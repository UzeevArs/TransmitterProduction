using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Wrox;
using WindowsFormsApplication3.Forms;
using WindowsFormsApplication3.DataModel;


namespace WindowsFormsApplication3
{
    public partial class MainForm : Form
    {

        public ChangeGrid ChangeGrid;
        //public ConnectToCrcx connectToCrcx = new ConnectToCrcx();
        InputOutputData inputOutputdata;
        public MainForm()
        {

            InitializeComponent();
            stopIo.Enabled = false;
            startIo.Enabled = false;
            
        }


        private string WayForConnect;
        private string Id { get; set; }
        private void edtIndexNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Id = edtIndexNo.Text;
                edtIndexNo.Text = "";
                var form = new AddRowForm(Id);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var WrapData = form.WrapData;
                    dataTableAdapter.InsertQuery(WrapData.MsCode, WrapData.Model, WrapData.ProdNo, WrapData.ProdNoSfix, WrapData.LineNoSfix,
                                                        WrapData.CrpGrNo, WrapData.ProdCareer, WrapData.IndexNo, WrapData.TestCertSighn, WrapData.DocLangType, WrapData.InstFinishD, WrapData.TestCertYn, WrapData.EndUserCust,
                                                        WrapData.OrderNo, WrapData.ItemNo, WrapData.ProdItemRevNo, WrapData.ProdInstRevNo, WrapData.CompNo,
                                                        WrapData.StartSch, WrapData.FinishSch, WrapData.StartNo, WrapData.SerialNo, WrapData.AllowanceSign,
                                                        WrapData.ProdNJ, WrapData.ProdNE, WrapData.TokuchuSpec, WrapData.SapLinkNo, WrapData.RangeInstSign500,
                                                        WrapData.OrdInstMax500, WrapData.OrdInstMin500, WrapData.Unit500, WrapData.Features500, WrapData.RangeInstSign502, WrapData.OrdInstMax502,
                                                        WrapData.OrdInstMin502, WrapData.Unit502, WrapData.OrdInstContectW69, WrapData.OrdInstContectX72,
                                                        WrapData.OrdInstContectX91, WrapData.OrdInstContectZ30, WrapData.TagNo525, WrapData.NifudaCode);

                }
                Id = "";

            }
        }


        public MessageBox EmptyMessage;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inputOutputdata?.StopReading();
        }
        
        private void ConnectFormClosing()
        {
            string path1 = WayForConnect + "Nifuda.txt";
            string path2 = WayForConnect + "IndexNO.txt";

            if (WayForConnect == null || File.Exists(path1)== false || File.Exists(path2) == false)
            {
                startIo.Enabled = false;
            }
            else
            {
                startIo.Enabled = true;
            }
        }

        private void startIo_Click(object sender, EventArgs e)
        {

            inputOutputdata = new InputOutputData(dataTableAdapter, WayForConnect);
            inputOutputdata.StartReading();
            startIo.Enabled = false;
            stopIo.Enabled = true;
            changeWayButton.Enabled = false;
            generateFileButton.Enabled = false;

        }

        private void stopIo_Click(object sender, EventArgs e)
        {
            inputOutputdata.StopReading();
            startIo.Enabled = true;
            stopIo.Enabled = false;
            changeWayButton.Enabled = true;
            generateFileButton.Enabled = true;
        }

        private void ChangeTableButton_Click(object sender, EventArgs e)
        {
            var changeGridForm = new ChangeGrid();
            changeGridForm.ShowDialog();
        }

            
        
        private void generateFileButton_Click_1(object sender, EventArgs e)
        {
            string path1 = WayForConnect + "Nifuda.txt";
            string path2 = WayForConnect + "IndexNO.txt";

            try
            {
                using (FileStream fs = File.Create(path1))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("NifudaTest");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                using (FileStream fs = File.Create(path2))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("IndexNOTest.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                ConnectFormClosing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void edtPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                edtPath.Enabled = false;
                WayForConnect = edtPath.Text;
                ConnectFormClosing();
            }
        }

        private void changeWayButton_Click_1(object sender, EventArgs e)
        {
            edtPath.Enabled = true;
            ConnectFormClosing();

        }
    }
}


