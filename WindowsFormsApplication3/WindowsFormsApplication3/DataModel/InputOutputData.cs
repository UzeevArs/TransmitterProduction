using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Forms;
using Wrox;

namespace WindowsFormsApplication3.DataModel
{
   public class InputOutputData : IDisposable
    {
        private EJX_DATADataSetTableAdapters.DataTableAdapter dataTableAdapter;


        private string FilePath { get; set; }
        private Thread Worker{ get; set; }
        private bool Cancel { get; set; }
        public InputOutputData(EJX_DATADataSetTableAdapters.DataTableAdapter adapter,
            string filePath)
        {
            dataTableAdapter = adapter;
            FilePath = filePath;
            Cancel = false;
        }

        //public InputOutputData(object dataTableAdapter1, string wayForConnect)
        //{
        //    this.dataTableAdapter1 = dataTableAdapter1;
        //    this.wayForConnect = wayForConnect;
        //}

        ~InputOutputData()
        {
            StopReading();
        }
        public void StartReading()
        {
            Worker = new Thread(DataIo);
            Worker.Start();
        }
        public void StopReading()
        {
            Cancel = true;
            if (Worker.IsAlive && !Worker.IsBackground)
            {
                Worker.Join();
            }
        }

        //public bool IsWorkerAlive()
        //{
        //    return (bool)Worker?.IsAlive;
        //}
        private void DataIo()
        {
            while (!Cancel)
            {
                string ReadFilePath = FilePath + "IndexNO.txt";
                while (new FileInfo(ReadFilePath).Length == 0 && !Cancel)
                {
                    Thread.Sleep(50);
                }
                if (Cancel) break;
                try
                {
                    string WriteFilePath = FilePath + "Nifuda.txt";
                    var id = "";
                    using (var streamRead = new StreamReader(ReadFilePath))
                    {
                          id = streamRead.ReadLine();
                    }

                    var f = new FileStream(ReadFilePath, FileMode.Truncate);
                    f.Close();

                    using (StreamWriter write = new StreamWriter(WriteFilePath))
                    {
                        var testingg = dataTableAdapter.ScalarQuery(id);

                        write.Write(testingg);
                        
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public void Dispose()
        {
           StopReading();
        }
    }
}
    

