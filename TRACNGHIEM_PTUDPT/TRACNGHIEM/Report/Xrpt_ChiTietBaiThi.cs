using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM.Report
{
    public partial class Xrpt_ChiTietBaiThi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_ChiTietBaiThi(int IDTHI)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_GET_CHI_TIET_BAI_THITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_GET_CHI_TIET_BAI_THITableAdapter.Fill(ds1.SP_GET_CHI_TIET_BAI_THI,IDTHI);
        }

    }
}
