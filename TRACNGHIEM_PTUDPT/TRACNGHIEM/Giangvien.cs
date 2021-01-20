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
    public partial class Giangvien : Form
    {
        int vitri = 0;
        public Giangvien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Giangvien_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            // TODO: This line of code loads data into the 'dS.CAUHOI' table. You can move, or remove it, as needed.
            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.dS.CAUHOI);
            // TODO: This line of code loads data into the 'dS.GV_DAY' table. You can move, or remove it, as needed.
            this.gV_DAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gV_DAYTableAdapter.Fill(this.dS.GV_DAY);

            if (Program.mNhom == Program.NhomQuyen[0])
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhuchoi.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
            }
            //if (Program.mNhom == Program.NhomQuyen[1])
            //{
            //    string strLenh = "SELECT MAKH FROM GIANGVIEN WHERE MAGV='" + Program.username + "'";
            //    Program.myReader = Program.ExecSqlDataReader(strLenh);
            //    Program.myReader.Read();
            //    Program.mKhoa = Program.myReader.GetString(0);
            //    Program.myReader.Close();
            //    bdsGV.Filter = "MAKH = '" + Program.mKhoa + "'";
            //}
            btnPhuchoi.Enabled = false;
            btnGhi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position; //lấy vị trí lớp  
            bdsGV.AddNew(); //thêm mới 1 hàng vào danh sách
            groupBox1.Enabled = true;
            txtMaGV.Focus();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String magv = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa giảng viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    magv = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsGV.Position = bdsGV.Find("MAGV", magv);
                    bdsGV.RemoveCurrent(); // xóa tại chỗ 
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN); // ghi vào CSDL
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                    bdsGV.Position = bdsGV.Find("MAGV", magv);
                    return;
                }
            }

            if (bdsGV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
            txtMaGV.Enabled = false;
            groupBox1.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHoGV.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                txtHoGV.Focus();
                return;
            }
            if (txtTenGV.Text.Trim() == "")
            {
                MessageBox.Show("Tên giảng viên không được để trống!", "", MessageBoxButtons.OK);
                txtTenGV.Focus();
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return;
            }
            if (txtMaGV.Enabled == true)
            {
                string strLenh = "SELECT COUNT(MAGV) FROM GIANGVIEN WHERE MAGV='" + txtMaGV.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã môn đã có", "", MessageBoxButtons.OK);
                    txtMaGV.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }


            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Update(this.dS.GIANGVIEN);
                this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giảng viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            if (btnThem.Enabled == false) bdsGV.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
