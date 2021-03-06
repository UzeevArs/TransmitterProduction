﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrox;
using System.Windows.Forms;
using WindowsFormsApplication3.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication3.Forms
{
    
    public partial class AddRowForm : Form
    {
        public WrapperData WrapData { get; set; }

        public AddRowForm(string Id)
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            edtINDEX_NO.Text = Id;
            edtINDEX_NO.Enabled = false;
            foreach (Control control in Controls)
            {
                if (control is TextEdit)
                {
                    (control as TextEdit).EditValueChanged += createNifuda;
                }
            }
        }
        
        public void createNifuda(object sender, EventArgs e)
        {
           var Nifuda = String.Format("$MS_CODE{0}$MODEL{1}$PROD_NO{2}$PROD_NO_SFIX{3}$LINE_NO{4}$CRP_GR_NO{5}$PROD_CAREER{6}$INDEX_NO{7}$TEST_CERT_SIGN{8}$DOC_LANG_TYPE{9}$INST_FINISH_D{10}$TEST_CERT_YN{11}$END_USER_CUST_N_J{12}$ORDER_NO{13}$ITEM_NO{14}$PROD_ITEM_REV_NO{15}$PROD_INST_REV_NO{16}$COMP_NO{17}$START_SCHDULE_D{18}$FINISH_SCHDULE_D{19}$START_NO{20}$SERIAL_NO{21}$ALLOWANCE_SIGN{22}$PROD_N_J{23}$PROD_N_E{24}$TOKUCHU_SPEC_SIGN{25}$SAP_LINKAGE_NO{26}$RANGE_INST_SIGN_500{27}$ORD_INST_MAX_500{28}$UNIT_500{29}$FEATURES_500{30}$RANGE_INST_SIGN_502{31}$ORD_INST_MAX_502{32}$ORD_INST_MIN_502{33}$UNIT_502{34}$ORD_INST_CONTECT1_W69{35}$ORD_INST_CONTECT1_X72{36}$ORD_INST_CONTECT1_X91{37}$ORD_INST_CONTECT1_Z30{38}$TAG_NO_525{39}", edtMS_CODE.Text, edtMODEL.Text,edtPROD_NO.Text, edtPROD_NO_SFIXName.Text, edtLINE_NOName.Text, edtCRP_GR_NO.Text, edtPROD_CAREER.Text, edtINDEX_NO.Text, edtTEST_CERT_SIGN.Text, edtDOC_LANG_TYPE.Text, edtINST_FINISH_D.Text, edtTEST_CERT_YN.Text, edtEND_USER_CUST_N_J.Text, edtORDER_NO.Text, edtITEM_NO.Text, edtPROD_ITEM_REV_NO.Text, edtPROD_INST_REV_NO.Text, edtCOMP_NO.Text, edtSTART_SCHDULE_D.Text, edtFINISH_SCHDULE_D.Text, edtSTART_NO.Text, edtSERIAL_NO.Text, edtALLOWANCE_SIGN.Text, edtPROD_N_J.Text, edtPROD_N_E.Text, edtTOKUCHU_SPEC_SIGN.Text, edtSAP_LINKAGE_NO.Text, edtRANGE_INST_SIGN_500.Text, edtORD_INST_MAX_500.Text, edtUNIT_500.Text, edtFEATURES_500.Text, edtRANGE_INST_SIGN_502.Text, edtRANGE_INST_SIGN_502.Text, edtORD_INST_MIN_502.Text,edtUNIT_502.Text,edtORD_INST_CONTECT1_W69Text.Text,edtORD_INST_CONTECT1_X72.Text,edtORD_INST_CONTECT1_X91.Text,edtORD_INST_CONTECT1_Z30.Text,edtTAG_NO_525.Text);
            editNIFUDA.Text = Nifuda;
        }

        private void vGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }

        private void AddRowForm_Load(object sender, EventArgs e)
        {

        }

        private void labelControl24_Click(object sender, EventArgs e)
        {

        }

        private void edtMS_CODE_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void edtMS_CODE_EditValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict["MsCode"] = edtMS_CODE.Text;
            dict["Model"] = edtMODEL.Text;
            dict["ProdNo"] = edtPROD_NO.Text;
            dict["ProdNoSfix"] = edtPROD_NO_SFX.Text;
            dict["LineNoSfix"] = edtLN_NO.Text;
            dict["CrpGrNo"] = edtCRP_GR_NO.Text;
            dict["ProdCareer"] = edtPROD_CAREER.Text;
            dict["IndexNo"] = edtINDEX_NO.Text;
            dict["TestCertSighn"] = edtTEST_CERT_SIGN.Text;
            dict["DocLangType"] = edtDOC_LANG_TYPE.Text;
            dict["InstFinishD"] = edtINST_FINISH_D.Text;
            dict["TestCertYn"] = edtTEST_CERT_YN.Text;
            dict["EndUserCust"] = edtEND_USER_CUST_N_J.Text;
            dict["OrderNo"] = edtORDER_NO.Text;
            dict["ItemNo"] = edtITEM_NO.Text;
            dict["ProdItemRevNo"] = edtPROD_ITEM_REV_NO.Text;
            dict["ProdInstRevNo"] = edtPROD_INST_REV_NO.Text;
            dict["CompNo"] = edtCOMP_NO.Text;
            dict["StartSch"] = edtSTART_SCHDULE_D.Text;
            dict["FinishSch"] = edtFINISH_SCHDULE_D.Text;
            dict["StartNo"] = edtSTART_NO.Text;
            dict["SerialNo"] = edtSERIAL_NO.Text;
            dict["AllowanceSign"] = edtALLOWANCE_SIGN.Text;
            dict["ProdNJ"] = edtPROD_N_J.Text;
            dict["ProdNE"] = edtPROD_N_E.Text;
            dict["TokuchuSpec"] = edtTOKUCHU_SPEC_SIGN.Text;
            dict["SapLinkNo"] = edtSAP_LINKAGE_NO.Text;
            dict["RangeInstSign500"] = edtRANGE_INST_SIGN_500.Text;
            dict["OrdInstMax500"] = edtORD_INST_MAX_500.Text;
            dict["OrdInstMin500"] = edtORD_INST_MIN_500.Text;
            dict["Unit500"] = edtUNIT_500.Text;
            dict["Features500"] = edtFEATURES_500.Text;
            dict["RangeInstSign502"] = edtRANGE_INST_SIGN_502.Text;
            dict["OrdInstMax502"] = edtRANGE_INST_SIGN_502.Text;
            dict["OrdInstMin502"] = edtORD_INST_MIN_502.Text;
            dict["Unit502"] = edtUNIT_502.Text;
            dict["OrdInstContectW69"] = edtORD_INST_CONT_W69.Text;
            dict["OrdInstContectX72"] = edtORD_INST_CONTECT1_X72.Text;
            dict["OrdInstContectX91"] = edtORD_INST_CONTECT1_X91.Text;
            dict["OrdInstContectZ30"] = edtORD_INST_CONTECT1_Z30.Text;
            dict["TagNo525"] = edtTAG_NO_525.Text;
            dict["NifudaCode"] = editNIFUDA.Text;

            WrapData = new WrapperData(dict);
            DialogResult = DialogResult.OK;
            Close();

        }



        private void labelControl1_Click(object sender, EventArgs e)
        {

        }


    }
}
