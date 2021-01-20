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
    public partial class Khoa : Form
    {
        int vitri = 0;
        String maCoso = "";
        public Khoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOPHOC' table. You can move, or remove it, as needed.
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
            if (Program.mNhom == Program.NhomQuyen[0])
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhuchoi.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
            }
            btnPhuchoi.Enabled = false;
            btnGhi.Enabled = false;
            groupBox1.Enabled = false;
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
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                    this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position; //lấy vị trí khoa 
            bdsKhoa.AddNew(); //thêm mới 1 hàng vào danh sách
            groupBox1.Enabled = true;
            txtMakhoa.Focus();
            cmbCoso.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makhoa = "";
         
            if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makhoa = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsKhoa.Position = bdsKhoa.Find("MAKH", makhoa);
                    MessageBox.Show(bdsKhoa.Position + " ");
                    bdsKhoa.RemoveCurrent(); //xóa đi hàng hiện tại ra khỏi dataSet
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khoa đã có dữ liệu không thể xóa \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    bdsKhoa.Position = bdsKhoa.Find("MAKH", makhoa);
                    return;
                }
            }

            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            txtMakhoa.Enabled = false;
            groupBox1.Enabled = true;
            cmbCoso.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMakhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "", MessageBoxButtons.OK);
                txtMakhoa.Focus();
                return;
            }
            if (txtTenkhoa.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được để trống!", "", MessageBoxButtons.OK);
                txtTenkhoa.Focus();
                return;
            }
            if (txtMakhoa.Enabled == true)
            {
                string strLenh = "SELECT COUNT(MAKH)  FROM LINK0.TRACNGHIEM.dbo.KHOA WHERE MAKH='" + txtMakhoa.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã khoa đã có", "", MessageBoxButtons.OK);
                    txtMakhoa.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Update(this.dS.KHOA);
                this.kHOATableAdapter.Fill(this.dS.KHOA);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =  true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            if (btnThem.Enabled == false) bdsKhoa.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =  btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
