using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM.Report
{
    public partial class Xrpt_BangDiemMH : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMH(String MaLop, String MaMH)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_GET_BANG_DIEM_THEO_LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_GET_BANG_DIEM_THEO_LOPTableAdapter.Fill(ds1.SP_GET_BANG_DIEM_THEO_LOP, MaLop, MaMH);
        }

    }
}
