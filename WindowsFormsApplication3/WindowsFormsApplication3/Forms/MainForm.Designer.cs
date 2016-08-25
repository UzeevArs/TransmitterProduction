using System;

namespace WindowsFormsApplication3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.edtIndexNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.startIo = new System.Windows.Forms.Button();
            this.stopIo = new System.Windows.Forms.Button();
            this.ChangeTableButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changeWayCallForm = new DevExpress.XtraEditors.SimpleButton();
            this.generateFileButton = new DevExpress.XtraEditors.SimpleButton();
            this.changeWayButton = new DevExpress.XtraEditors.SimpleButton();
            this.edtPath = new DevExpress.XtraEditors.TextEdit();
            this.dataBindingSource = new System.Windows.Forms.BindingSource();
            this.eJX_DATADataSet = new WindowsFormsApplication3.EJX_DATADataSet();
            this.dataTableAdapter = new WindowsFormsApplication3.EJX_DATADataSetTableAdapters.DataTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication3.EJX_DATADataSetTableAdapters.TableAdapterManager();
            this.dataTableAdapter1 = new WindowsFormsApplication3.EJX_DATADataSetTableAdapters.DataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.edtIndexNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJX_DATADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // edtIndexNo
            // 
            this.edtIndexNo.Location = new System.Drawing.Point(170, 75);
            this.edtIndexNo.Name = "edtIndexNo";
            this.edtIndexNo.Size = new System.Drawing.Size(136, 20);
            this.edtIndexNo.TabIndex = 22;
            this.edtIndexNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtIndexNo_KeyDown);
//            this.edtIndexNo.Leave += new System.EventHandler(this.edtIndexNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "INDEX_NO:";
            // 
            // startIo
            // 
            this.startIo.Location = new System.Drawing.Point(91, 194);
            this.startIo.Name = "startIo";
            this.startIo.Size = new System.Drawing.Size(173, 23);
            this.startIo.TabIndex = 24;
            this.startIo.Text = "Старт Синхронизации";
            this.startIo.UseVisualStyleBackColor = true;
            this.startIo.Click += new System.EventHandler(this.startIo_Click);
            // 
            // stopIo
            // 
            this.stopIo.Location = new System.Drawing.Point(91, 237);
            this.stopIo.Name = "stopIo";
            this.stopIo.Size = new System.Drawing.Size(173, 23);
            this.stopIo.TabIndex = 24;
            this.stopIo.Text = "Стоп Синхронизации";
            this.stopIo.UseVisualStyleBackColor = true;
            this.stopIo.Click += new System.EventHandler(this.stopIo_Click);
            // 
            // ChangeTableButton
            // 
            this.ChangeTableButton.Location = new System.Drawing.Point(91, 120);
            this.ChangeTableButton.Name = "ChangeTableButton";
            this.ChangeTableButton.Size = new System.Drawing.Size(173, 23);
            this.ChangeTableButton.TabIndex = 25;
            this.ChangeTableButton.Text = "Редактирование";
            this.ChangeTableButton.UseVisualStyleBackColor = true;
            this.ChangeTableButton.Click += new System.EventHandler(this.ChangeTableButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Производство EJX";
            // 
            // changeWayCallForm
            // 
            this.changeWayCallForm.Location = new System.Drawing.Point(91, 156);
            this.changeWayCallForm.Name = "changeWayCallForm";
            this.changeWayCallForm.Size = new System.Drawing.Size(173, 23);
            this.changeWayCallForm.TabIndex = 27;
            this.changeWayCallForm.Text = "Ввод пути до ПО";
            // 
            // generateFileButton
            // 
            this.generateFileButton.Location = new System.Drawing.Point(473, 162);
            this.generateFileButton.Name = "generateFileButton";
            this.generateFileButton.Size = new System.Drawing.Size(105, 23);
            this.generateFileButton.TabIndex = 30;
            this.generateFileButton.Text = "Сгенерировать";
            this.generateFileButton.Click += new System.EventHandler(this.generateFileButton_Click_1);
            // 
            // changeWayButton
            // 
            this.changeWayButton.Location = new System.Drawing.Point(473, 120);
            this.changeWayButton.Name = "changeWayButton";
            this.changeWayButton.Size = new System.Drawing.Size(105, 23);
            this.changeWayButton.TabIndex = 29;
            this.changeWayButton.Text = "Редактирование";
            this.changeWayButton.Click += new System.EventHandler(this.changeWayButton_Click_1);
            // 
            // edtPath
            // 
            this.edtPath.Location = new System.Drawing.Point(597, 122);
            this.edtPath.Name = "edtPath";
            this.edtPath.Size = new System.Drawing.Size(174, 20);
            this.edtPath.TabIndex = 28;
            this.edtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtPath_KeyDown);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.eJX_DATADataSet;
            // 
            // eJX_DATADataSet
            // 
            this.eJX_DATADataSet.DataSetName = "EJX_DATADataSet";
            this.eJX_DATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DataTableAdapter = this.dataTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication3.EJX_DATADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTableAdapter1
            // 
            this.dataTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 386);
            this.Controls.Add(this.generateFileButton);
            this.Controls.Add(this.changeWayButton);
            this.Controls.Add(this.edtPath);
            this.Controls.Add(this.changeWayCallForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeTableButton);
            this.Controls.Add(this.stopIo);
            this.Controls.Add(this.startIo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtIndexNo);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
//            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.edtIndexNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJX_DATADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private EJX_DATADataSet eJX_DATADataSet;
        private EJX_DATADataSetTableAdapters.DataTableAdapter dataTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.BindingSource dataBindingSource;
        private DevExpress.XtraEditors.TextEdit edtIndexNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startIo;
        private System.Windows.Forms.Button stopIo;
        private System.Windows.Forms.Button ChangeTableButton;
        private EJX_DATADataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label2;
        private EJX_DATADataSetTableAdapters.DataTableAdapter dataTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton changeWayCallForm;
        private DevExpress.XtraEditors.SimpleButton generateFileButton;
        private DevExpress.XtraEditors.SimpleButton changeWayButton;
        private DevExpress.XtraEditors.TextEdit edtPath;
    }
}

