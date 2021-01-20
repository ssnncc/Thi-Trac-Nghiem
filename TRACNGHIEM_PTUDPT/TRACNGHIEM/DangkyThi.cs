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
using TRACNGHIEM.Model;

namespace TRACNGHIEM
{
    public partial class DangkyThi : Form
    {
        String maCoso = "";
        int vitri = 0;
        
        public DangkyThi()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDangky.Position; //lấy vị trí lớp  
            bdsDangky.AddNew(); //thêm mới 1 hàng vào danh sách
            groupBox1.Enabled = true;

            txtMaNV.Focus();
            
            cmbCoso.Enabled = false;
            btnThem.Enabled = btnChinhsua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDangky.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void DSDangkyThi_Load(object sender, EventArgs e)
        {
            
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            maCoso = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cmbCoso.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbCoso.DisplayMember = "TENCN";
            cmbCoso.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbCoso.SelectedIndex = -1;

            // nếu login vào là cs1, thì combox sẽ hiện CS1
            // nếu login vào là cs2, thì combox sẽ hiện CS2
            cmbCoso.SelectedIndex = Program.mCoso;
            if (Program.mNhom == Program.NhomQuyen[1] || Program.mNhom == Program.NhomQuyen[2])
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhuchoi.Enabled = false;
                btnChinhsua.Enabled = false;
                btnGhi.Enabled = false;
               
            }
            btnPhuchoi.Enabled = false;
            btnGhi.Enabled = false;
            groupBox1.Enabled = false;
            Program.maMH = txtMaMH.Text;
            Program.mMalop = txtMaLop.Text;
            Program.ngayThi = dtNgaythi.Text;
         


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
                    this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                }
            }
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn không được để trống!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã NV không được để trống!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (dtNgaythi.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi không được để trống!", "", MessageBoxButtons.OK);
                dtNgaythi.Focus();
                return;
            }
            if (spinEdit_Cauhoi.Text.Trim() == "")
            {
                MessageBox.Show("Số câu  hỏi không được để trống!", "", MessageBoxButtons.OK);
                spinEdit_Cauhoi.Focus();
                return;
            }
            if (spinEdit_Thoigian.Text.Trim() == "")
            {
                MessageBox.Show("Thời gian thi không được để trống!", "", MessageBoxButtons.OK);
                spinEdit_Thoigian.Focus();
                return;
            }
            bool check = KiemTraDangKy(txtMaMH.Text,txtMaLop.Text, dtNgaythi.Text.ToString());
            if (check == true)
            {
                MessageBox.Show("ĐĂNG KÝ ĐÃ TỒN TẠI", "", MessageBoxButtons.OK);
                return ;
            }
            int soCauHoiHeThong = getSoCauHoiCuaHeThong(txtMaMH.Text, cmbTD.SelectedItem.ToString());
            if (Int32.Parse(spinEdit_Cauhoi.Text) > soCauHoiHeThong)
            {
                MessageBox.Show("SỐ CÂU TRONG HỆ THỐNG KHÔNG ĐỦ", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsDangky.EndEdit();
                bdsDangky.ResetCurrentItem();
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Update(this.dS.DANGKY);
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnChinhsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDangky.Position;
            txtMaMH.Enabled = false;
            txtMaLop.Enabled = false;
            groupBox1.Enabled = true;
            cmbCoso.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa???", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsDangky.RemoveCurrent();
                    this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dANGKYTableAdapter.Update(this.dS.DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa", string.Empty, MessageBoxButtons.OK);
                }
            }
        }

        //PHẦN NÀY ĐỂ TỐI LÀM TIẾP 


        ////KIỂM TRA XEM ĐĂNG KỸ ĐÃ TỒN TẠI HAY CHƯA.
        private bool KiemTraDangKy(string maMH, string maLop, string ngayThi)
        {
            int kn = Program.KetNoi();
            if (kn == 0)
            {
                MessageBox.Show("Lỗi kết nối! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand sqlCommand = new SqlCommand("SP_KIEM_TRA_DANG_KY", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MAMH", maMH);
            sqlCommand.Parameters.AddWithValue("@MALOP", maLop);
            sqlCommand.Parameters.AddWithValue("@NGAYTHI", ngayThi);
            try
            {
                int kq = executeSP(sqlCommand);
                if (kq == 1)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kiểm tra được \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                return false;
            }
        }
        //Kiểm tra số câu hỏi có trong hệ thống
        private int getSoCauHoiCuaHeThong(string maMH, string trinhdo)
        {
            int kn = Program.KetNoi();
            if (kn == 0)
            {
                MessageBox.Show("Lỗi kết nối! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand sqlCommand = new SqlCommand("SP_DEM_CAU_HOI", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MAMH", maMH);
            sqlCommand.Parameters.AddWithValue("@TRINHDO", trinhdo);
            try
            {
                int kq = executeSP(sqlCommand);
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kiểm tra được số câu hỏi có trong hệ thống " + ex, "Lỗi Phần Mềm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public static int executeSP(SqlCommand sqlcmd)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlParameter retval = sqlcmd.Parameters.Add("@return_value", SqlDbType.Int);
            retval.Direction = ParameterDirection.ReturnValue;
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            string tmp = sqlcmd.Parameters["@return_value"].Value.ToString();
            if (tmp == null)
            {
                MessageBox.Show("Lỗi lập trình! Sp hoặc đối số của sp có vấn đề!");
            }
            return int.Parse(tmp);

        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDangky.CancelEdit();
            if (btnThem.Enabled == false) bdsDangky.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThiThu thithu = new ThiThu();
            thithu.Show();
        }

        private void btnThiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mMalop = txtMaLop.Text;
            Program.ngayThi = dtNgaythi.Text;

            string malop = Program.mMalop.Trim();
            Program.maMH = txtMaMH.Text;
            string mamh = Program.maMH;
            string trinhdo = "";
            int socauthi = -1;
            int thoigianthi = -1;
            string manv = "";
            Program.KetNoi();
            string query = "EXEC SP_GET_DK_THI '" + malop + "','" + Program.maMH + "','" + Program.ngayThi + "'";
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
                trinhdo = dkthi.GetString(4).Trim();
                socauthi = dkthi.GetInt32(6);
                thoigianthi = dkthi.GetInt32(5);
                manv = dkthi.GetString(3);
                Program.iddk = dkthi.GetInt32(7);
                Dangky dk = new Dangky(
                mamh,//mamon
                malop,//malop
                DateTime.Parse(Program.ngayThi),//ngaythi
                manv,//manv
                 trinhdo,
                thoigianthi,
                 socauthi
                );
                dkthi.Close();
                DataTable db = Program.ExecSqlDataTable("EXEC SP_GET_DE_THI '" + Program.maMH + "','" + trinhdo + "'," + socauthi + "");
                int checkCount = db.Rows.Count;
                if (checkCount == 0)
                {
                    MessageBox.Show("Số câu hỏi thi trong hệ thống không đáp ứng đủ để thi!");
                }
                else
                {
                    Dangky.dangky = dk;
                    this.Close();
                    List<BoDe> list = convertToListBD(db);
                    BoDe.boDe = list;
                    ThiThu form = new ThiThu();
                    form.ShowDialog();
                }
            }
        }
        //Lấy bộ đề lưu vào List
        private List<BoDe> convertToListBD(DataTable ds)
        {
            List<BoDe> list = new List<BoDe>();
            foreach (DataRow row in ds.Rows)
            {
                BoDe bd = new BoDe(

                    row["MACH"].ToString(),
                    row["NOIDUNG"].ToString(),
                    row["LOAICH"].ToString(),
                    row["DAPAN"].ToString(),
                    row["MAMH"].ToString(),
                    row["MATD"].ToString(),
                    row["MAGV"].ToString()
                    );
                list.Add(bd);
            }
            return list;
        }
    }
}
