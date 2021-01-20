using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TRACNGHIEM
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_PM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_PM.V_DS_PHANMANH);
          
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtMK.Focus();
                return;
            }
            Program.servername = cmbCN.SelectedValue.ToString();
            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return;
            Program.mCoso = cmbCN.SelectedIndex;
            Program.bds_dspm = bds_PM;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            
            String strlenh = "EXEC dbo.SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.mCoso = cmbCN.SelectedIndex;
            if (Program.myReader.Read())//Đọc 1 dòng
            {
                Program.username = Program.myReader.GetString(0);     // Đọc dữ liệu cột đầu tiên (user)
                //Kiểm tra xem có username này tồn tại hay không?
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoTen = Program.myReader.GetString(1); //Đọc dữ liệu cột thứ 2
                Program.mNhom = Program.myReader.GetString(2);
                Program.mLoai = Program.myReader.GetString(3);
                if (Program.mNhom == "SINHVIEN")
                {
                    Program.mMalop = Program.myReader.GetString(4);
                    Program.mTenLop = Program.myReader.GetString(5);
                }
                Program.myReader.Close();
                Program.conn.Close();
            }
            Program.myReader.Close();
            //this.Hide();
            switch (Program.mLoai)
            {
                case "giangvien":
                    {
                        Program.frmChinh = new FormMain();
                        Program.frmChinh.MaGV.Text = " Mã giảng viên : " + Program.username;
                        Program.frmChinh.HoTen.Text = " Họ tên : " + Program.mHoTen;
                        Program.frmChinh.Nhom.Text = " Nhóm : " + Program.mNhom;
                        MessageBox.Show("Đăng nhập thành công.", " ", MessageBoxButtons.OK);
                        Program.frmChinh.Activate();
                        Program.frmChinh.Show();
                        // frmDN ẩn
                        Program.formDN.Visible = false;
                        
                        if (Program.mNhom == Program.NhomQuyen[2])
                        {
                            Program.frmChinh.btnTaoTK.Enabled = false;
                            Program.frmChinh.btnKhoa.Enabled = false;
                            Program.frmChinh.btnLop.Enabled = false;
                            Program.frmChinh.btnMonhoc.Enabled = false;
                            Program.frmChinh.btnGV.Enabled = false;
                            Program.frmChinh.btnSV.Enabled = false;
                            Program.frmChinh.btnBangdiem.Enabled = false;


                        }
                       
                        break;
                    }
                case "sinhvien":
                    {
                       
                        SinhvienThi form = new SinhvienThi();
                        form.HoTen.Text = " Họ tên : " + Program.mHoTen;
                        form.Nhom.Text = " Nhóm : " + Program.mNhom;
                        form.Malop.Text = " Mã lớp : " + Program.mMalop;
                        form.Tenlop.Text = " Tên lớp : " + Program.mTenLop;
                        MessageBox.Show("Đăng nhập thành công.", " ", MessageBoxButtons.OK);
                        form.Activate();
                        form.Show();
                        Program.formDN.Visible = false;
                        break;
                    }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue != null)
            {
                Program.servername = cmbCN.SelectedValue.ToString();//Lấy giá trị từ cmb
            }
        }
    }
}
