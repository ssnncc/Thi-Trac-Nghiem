using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM.Report
{
    public partial class BangDiemMH : Form
    {
        String maCoso = "";
        public BangDiemMH()
        {
            InitializeComponent();
        }
        private void kHOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void BangDiemMH_Load(object sender, EventArgs e)
        {
           
            
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
            maCoso = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cmbCoso.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbCoso.DisplayMember = "TENCN";
            cmbCoso.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbCoso.SelectedIndex = -1;

            // nếu login vào là cs1, thì combox sẽ hiện CS1
            // nếu login vào là cs2, thì combox sẽ hiện CS2
            cmbCoso.SelectedIndex = Program.mCoso;
            txtMaMH.Text = cmbMH.SelectedValue.ToString();
            txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoso.SelectedValue != null)
            {
                if (cmbCoso.SelectedValue.ToString() == "System.Data.DataRowView")
                    return; // Hệ thống chưa chọn đã chạy => Kết thúc
                Program.servername = cmbCoso.SelectedValue.ToString();
                if (cmbCoso.SelectedIndex != Program.mCoso)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
                }
            }
        }

        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMH.SelectedValue != null)
            {
                txtMaMH.Text = cmbMH.SelectedValue.ToString();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String malop = cmbMaLop.SelectedValue.ToString();
            String mamonhoc = cmbMH.SelectedValue.ToString();
            

            Xrpt_BangDiemMH rpt = new Xrpt_BangDiemMH(malop, mamonhoc);
            rpt.lblLop.Text = cmbMaLop.Text;
            rpt.lblMonHoc.Text = cmbMH.Text;
           
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
