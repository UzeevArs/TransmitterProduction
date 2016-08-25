using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrox
{
    public class WrapperData
    {
        public string MsCode { get; set; }
        public string Model { get; set; }
        public string ProdNo { get; set; }
        public string ProdNoSfix { get; set; }
        public string LineNoSfix { get; set; }
        public string CrpGrNo { get; set; }
        public string ProdCareer { get; set; }
        public int    IndexNo { get; set; }
        public string TestCertSighn { get; set; }
        public string DocLangType { get; set; }
        public string InstFinishD { get; set; }
        public string TestCertYn { get; set; }
        public string EndUserCust { get; set; }
        public string OrderNo { get; set; }
        public string ItemNo { get; set; }
        public string ProdItemRevNo { get; set; }
        public string ProdInstRevNo { get; set; }
        public string CompNo { get; set; }
        public string StartSch { get; set; }
        public string FinishSch { get; set; }
        public string StartNo { get; set; }
        public string SerialNo { get; set; }
        public string AllowanceSign { get; set; }
        public string ProdNJ { get; set; }
        public string ProdNE { get; set; }
        public string TokuchuSpec { get; set; }
        public string SapLinkNo { get; set; }
        public string RangeInstSign500 { get; set; }
        public string OrdInstMax500 { get; set; }
        public string OrdInstMin500 { get; set; }
        public string Unit500 { get; set; }
        public string Features500 { get; set; }
        public string RangeInstSign502 { get; set; }
        public string OrdInstMax502 { get; set; }
        public string OrdInstMin502 { get; set; }
        public string Unit502 { get; set; }
        public string OrdInstContectW69 { get; set; }
        public string OrdInstContectX72 { get; set; }
        public string OrdInstContectX91 { get; set; }
        public string OrdInstContectZ30 { get; set; }
        public string TagNo525 { get; set; }
        public string NifudaCode { get; set; }
        public WrapperData(Dictionary<string, string> dict)
        {
                     
            MsCode = dict["MsCode"];
            Model = dict["Model"];
            ProdNo = dict["ProdNo"];
            ProdNoSfix = dict["ProdNoSfix"];
            LineNoSfix = dict["LineNoSfix"];
            CrpGrNo = dict["CrpGrNo"];
            ProdCareer = dict["ProdCareer"];
            IndexNo = Convert.ToInt32(dict["IndexNo"]);
            TestCertSighn = dict["TestCertSighn"];
            DocLangType = dict["DocLangType"];
            InstFinishD = dict["InstFinishD"];
            TestCertYn = dict["TestCertYn"];
            EndUserCust = dict["EndUserCust"];
            OrderNo = dict["OrderNo"];
            ItemNo = dict["ItemNo"];
            ProdItemRevNo = dict["ProdItemRevNo"];
            ProdInstRevNo = dict["ProdInstRevNo"];
            CompNo = dict["CompNo"];
            StartSch = dict["StartSch"];
            FinishSch = dict["FinishSch"];
            StartNo = dict["StartNo"];
            SerialNo = dict["SerialNo"];
            AllowanceSign = dict["AllowanceSign"];
            ProdNJ = dict["ProdNJ"];
            ProdNE = dict["ProdNE"];
            TokuchuSpec = dict["TokuchuSpec"];
            SapLinkNo = dict["SapLinkNo"];
            RangeInstSign500 = dict["RangeInstSign500"];
            OrdInstMax500 = dict["OrdInstMax500"];
            OrdInstMin500 = dict["OrdInstMin500"];
            Unit500 = dict["Unit500"];
            Features500 = dict["Features500"];
            RangeInstSign502 = dict["RangeInstSign502"];
            OrdInstMax502 = dict["OrdInstMax502"];
            OrdInstMin502 = dict["OrdInstMin502"];
            Unit502 = dict["Unit502"];
            OrdInstContectW69 = dict["OrdInstContectW69"];
            OrdInstContectX72 = dict["OrdInstContectX72"];
            OrdInstContectX91 = dict["OrdInstContectX91"];
            OrdInstContectZ30 = dict["OrdInstContectZ30"];
            TagNo525 = dict["TagNo525"];
            NifudaCode = dict["NifudaCode"];
        }
    }
}
