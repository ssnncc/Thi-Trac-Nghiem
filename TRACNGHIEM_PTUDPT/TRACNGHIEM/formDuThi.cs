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
using TRACNGHIEM.Model;

namespace TRACNGHIEM
{
    public partial class formDuThi : Form
    {
        
        public formDuThi()
        {
            InitializeComponent();
        }
        

        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDangky.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formDuThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            lbhoten.Text =  Program.mHoTen;
            lbmalop.Text =  Program.mMalop;
            lbtenlop.Text =  Program.mTenLop;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        
        private void btnThi_Click(object sender, EventArgs e)
        {
            Program.mMalop = lbmalop.Text;
            Program.ngayThi = dateNgaythi.Text;

            string malop = Program.mMalop.Trim();
            Program.maMH = cbMAMH.SelectedValue.ToString();
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
                //Lấy ra các thông tin
                trinhdo = dkthi.GetString(4).Trim();
                socauthi = dkthi.GetInt32(6);
                thoigianthi = dkthi.GetInt32(5);
                manv = dkthi.GetString(3);
                Program.iddk= dkthi.GetInt32(7);
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
                DataTable db = Program.ExecSqlDataTable("EXEC SP_GET_DE_THI '" + Program.maMH + "','" + trinhdo + "',"+socauthi +"");
                int checkCount = db.Rows.Count;
                if (checkCount == 0)
                {
                    MessageBox.Show("Số câu hỏi thi trong hệ thống không đáp ứng đủ để thi!");
                }
                else
                {
                    Dangky.dangky = dk;
                    this.Close();//Đóng form dự thi lại
                    List<BoDe> list = convertToListBD(db);
                    BoDe.boDe = list; 

                    
                    ThiTN form = new ThiTN();//Mở form THI
                    form.ShowDialog();
                    //// Chỗ này để lưu những câu hỏi đã lấy vào bảng LAYDETHI
                    //string strLenh = "SELECT COUNT(IDDK)  FROM TRACNGHIEM.dbo.LAYBAITHI WHERE IDDK='" + Program.iddk + "'";

                    //Program.myReader = Program.ExecSqlDataReader(strLenh);
                    //Program.myReader.Read();
                    //int s = Program.myReader.GetInt32(0);
                    //if (s == 0)
                    //{
                    //    Program.myReader.Close();
                    //    if (Program.conn.State == ConnectionState.Closed)
                    //    {
                    //        Program.conn.Open();
                    //    }
                    //    for (int i = 0; i < list.Count; i++)
                    //    {

                    //        SqlCommand sqlcmd = Program.conn.CreateCommand();
                    //        sqlcmd.CommandType = CommandType.StoredProcedure;
                    //        sqlcmd.Parameters.Add(new SqlParameter("IDDK", Program.iddk));
                    //        sqlcmd.Parameters.Add(new SqlParameter("MACH", list[i].MaCH));
                    //        sqlcmd.CommandText = "SP_LAYBAITHI";

                    //        sqlcmd.ExecuteNonQuery();
                    //    }
                        
                    //    return;
                    //}
                    
                    //// MessageBox.Show("Đã tồn tại", "", MessageBoxButtons.OK);
                    
                    //Program.myReader.Close();
                    //// Chỗ này để lưu những câu hỏi đã lấy vào bảng LAYDETHI
                    
                }
            }
        }
        //Lưu bộ đề vào List từ datatable
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
        //Lưu Các lựa chọn vào List
        private List<LuaChon> convertToListLC(DataTable ds)
        {
            List<LuaChon> list = new List<LuaChon>();
            foreach (DataRow row in ds.Rows)
            {
                LuaChon lc = new LuaChon(

                    Convert.ToInt32(row["MALC"].ToString()),
                    row["TENLC"].ToString(),
                    row["MACH"].ToString(),
                    row["NOIDUNG"].ToString()
                    );
                list.Add(lc);
            }
            return list;
        }

        List<Dangky> list = new List<Dangky>();
    }
}
