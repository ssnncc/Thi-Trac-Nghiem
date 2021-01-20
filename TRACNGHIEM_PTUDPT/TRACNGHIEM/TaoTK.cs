using DevExpress.XtraEditors;
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

namespace TRACNGHIEM
{
    public partial class TaoTK : Form
    {
        public TaoTK()
        {
            InitializeComponent();
        }

        private void TaoTK_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

            // biding data từ data table vào combobox chi nhánh
            cmbCoso.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbCoso.DisplayMember = "TENCN";
            cmbCoso.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbCoso.SelectedIndex = 1;

            cmbCoso.SelectedIndex = Program.mCoso;
            // PGV chỉ được tạo login cho PGV
            if (Program.mNhom == Program.NhomQuyen[0])
            {
                rdoPGV.Checked = true;
                rdoKhoa.Enabled = rdoGV.Enabled = false;
            } // KHOA chỉ được tạo tài khoản cho KHOA hoặc GIẢNG VIÊN
            else if (Program.mNhom == Program.NhomQuyen[1])
            {
                rdoKhoa.Checked = false;
                rdoKhoa.Enabled = rdoGV.Enabled = true;
                rdoPGV.Enabled = false;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)


            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoso.SelectedValue != null)
            {
                if (cmbCoso.SelectedValue.ToString() == "System.Data.DataRowView") return; // Hệ thống chưa chọn đã chạy => Kết thúc
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
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                    cmbMaGV.DataSource = bdsGV;  // sao chép bds_dspm đã load ở form đăng nhập  qua
                    cmbMaGV.DisplayMember = "MAGV";
                    cmbMaGV.ValueMember = "MAGV";

                }
            }

        }
        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
        // true: ko empty, false : empty
        private Boolean KiemtraText()
        {
            Boolean check = true;


            //check từng textedit

            if (string.IsNullOrEmpty(this.txtLogin.Text))
            {
                error.SetError(this.txtLogin, "Trường dữ liệu không được để trống !");
                check = false;
            }
            if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                error.SetError(this.txtPass, "Trường dữ liệu không được để trống !");
                check = false;
            }

            if (string.IsNullOrEmpty(this.txtConfirm.Text))
            {
                error.SetError(this.txtConfirm, "Trường dữ liệu không được để trống !");
                check = false;
            }


            return check;
        }


        // true: ko empty, false : empty
        private Boolean KiemtraRadio()
        {
            //check từng radiobutton

            if (this.rdoKhoa.Checked || this.rdoPGV.Checked || this.rdoGV.Checked)
            {
                return true;
            }

            error.SetError(this.pnRole, "Bạn chưa chọn nhóm quyền !");

            return false;

        }


        private bool KiemtraValidate()
        {
            bool isValid = true;

            // xóa hết thông báo ở error
            error.Clear();


            // check khoảng trống ở textedit
            if (!KiemtraText())
            {
                isValid = false;
            }


            // check khớp mật khẩu
            if (txtConfirm.Text != txtPass.Text)
            {
                this.error.SetError(txtConfirm, "Mật khẩu không khớp");
                isValid = false;
            }

            // check khoảng trống ở radiobutton
            if (!KiemtraRadio())
            {
                isValid = false;
            }

            // login không được chứa khoảng trống
            if (txtLogin.Text.Contains(" "))
            {
                this.error.SetError(txtLogin, "Tên login không được chứa khoảng trăng !");
                isValid = false;
            }


            return isValid;
        }

        // 1: trùng, 0 : not trùng
        private void TaoTaiKhoan()
        {

            String login = txtLogin.Text;
            String pass = txtPass.Text;
            String user = (String)cmbMaGV.SelectedValue.ToString();
            String role = rdoKhoa.Checked ? Program.NhomQuyen[1] : (rdoPGV.Checked ? Program.NhomQuyen[0] : Program.NhomQuyen[2]);

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";


            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                error.SetError(this.txtLogin, "Login bị trùng . Mời bạn nhập login khác !");
            }
            else if (resultCheckLogin == 2)
            {
                error.SetError(this.cmbMaGV, "Giảng viên đã có tài khoản rồi !");

            }
            else if (resultCheckLogin == 3)
            {
                XtraMessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            return;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool check = this.KiemtraValidate();
            if (check)
            {
                TaoTaiKhoan();

            }
            else
            {
                return;
            }
        }
    }
}
