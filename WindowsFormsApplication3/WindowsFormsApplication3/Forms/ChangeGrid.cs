using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wrox;
using WindowsFormsApplication3.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using System.Data.Common;


namespace WindowsFormsApplication3.Forms
{
    public partial class ChangeGrid : Form
    {
        
        public ChangeGrid()
        {
            
            InitializeComponent();
            dataBindingSource.DataSource = dataTableAdapter.GetData();

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ColumnView view = gridControl1.FocusedView as ColumnView;
 //           if (view.UpdateCurrentRow())
            {
                dataTableAdapter.Update(eJX_DATADataSet.Data);
            }
        }

        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            dataBindingSource.DataSource = dataTableAdapter.GetData();
        }

        private void ChangeGrid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJX_DATADataSet.Data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.eJX_DATADataSet.Data);


        }

        private void EjxGrid_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Delete && gridControl1.FocusedView != null)
                {
                    dataTableAdapter.DeleteQuery(((gridControl1.FocusedView.DataSource as BindingSource).Current as DataRowView)["INDEX_NO"].ToString());
                    dataBindingSource.DataSource = dataTableAdapter.GetData();
                }
            }

        }

        private void ChangeData_Click(object sender, EventArgs e)
        {
            dataTableAdapter.Update(eJX_DATADataSet);
        }
    }
}
