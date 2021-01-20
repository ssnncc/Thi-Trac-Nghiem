using DevExpress.XtraReports.UI;
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

namespace TRACNGHIEM.Report
{
    public partial class XemKetQuaThi : Form
    {
        public XemKetQuaThi()
        {
            InitializeComponent();
        }

        private void XemKetQuaThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            lbhoten.Text = Program.mHoTen;
            lbmalop.Text = Program.mMalop;
            lbtenlop.Text = Program.mTenLop;
            Program.ngayThi = dateNgaythi.Text;
        }

        private void cbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.maMH = cbMAMH.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            //LẤY IDDK
       
            Program.KetNoi();
            string query = "EXEC SP_GET_DK_THI '" + Program.mMalop + "','" + Program.maMH + "','" + dateNgaythi.Text + "'";
            SqlDataReader dkthi = Program.ExecSqlDataReader(query);
            if (dkthi == null)
            {

                MessageBox.Show("Đợt thi này không tồn tại trong hệ thống");
            }
            else
            {
                bool c = dkthi.Read();
                if (c == false)
                {
                    MessageBox.Show("Đợt thi này đã không còn tồn tại trong hệ thống! ");
                    return;
                }
                Program.iddk = dkthi.GetInt32(7);
            }
            dkthi.Close();

            string strLenh = "SELECT IDTHI FROM THI WHERE MASV='" + Program.username + "'" + "AND IDDK=" + Program.iddk;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            Program.idThi = Program.myReader.GetInt32(0);
            Program.myReader.Close();

            //Xem report
            Report.Xrpt_ChiTietBaiThi rpt = new Report.Xrpt_ChiTietBaiThi(Program.idThi);
            rpt.xrLop.Text = Program.mTenLop;
            rpt.xrHoTen.Text = Program.mHoTen;
            rpt.xrMonHoc.Text = Program.maMH;
            rpt.xrNgayThi.Text = Program.ngayThi;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
