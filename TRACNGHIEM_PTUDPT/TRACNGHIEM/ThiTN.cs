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
using TRACNGHIEM.Model;

namespace TRACNGHIEM
{
    public partial class ThiTN : Form
    {
        int index = 0;
        int soCauThi = 0;
        Timer t = new Timer();
        int mm = 1;//Phút
        int ss = 0;//Giây
        float tongDiem = 0;
        int soCauDung = 0;
        List<BoDe> boDe;
        
        public ThiTN()
        {
            InitializeComponent();
        }

        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void ThiTN_Load(object sender, EventArgs e)
        {
            boDe = BoDe.boDe;
            soCauThi = boDe.Count;
            dS.EnforceConstraints = false;
            this.cTBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + index + 1 + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            Dangky g = Dangky.dangky;
            soCauThi = g.SoCauThi;
           
            lblLOP.Text = "Lớp: " + Program.mTenLop;
            lblNGAYTHI.Text = "Ngày thi: " + g.NgayThi.ToString("dd/MM/yyyy");
            lblTRINHDO.Text = "Trình độ: " + g.TrinhDo;
            btnCAUTRUOC.Enabled = false;
            mm = g.ThoiGian;
            t.Interval = 1000;//Bộ tính 1s

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();
            //Copy dữ liệu từ bộ đề sang chi tiết bài thi
            int i = 1;
            foreach (BoDe b2 in BoDe.boDe)
            {
                String maCH = b2.MaCH;
                String noiDung = b2.NoiDung;
                String loaiCH = b2.LoaiCH;
                String dapAn = b2.DapAn;
                String maMH = b2.MaMH;
                String maTD = b2.MaTD;
                String maGV = b2.MaGV;
                //Lấy ra các lựa chọn trong từng câu hỏi
                DataTable lc = Program.ExecSqlDataTable("EXEC SP_GET_LUA_CHON '" + maCH + "'");
                List<LuaChon> listLC = convertToListLC(lc);
                LuaChon.lc = listLC;
                LuaChon[] arrluachon = listLC.ToArray();
                
                String A = arrluachon[0].TenLC;
                String B = arrluachon[1].TenLC;
                String C = arrluachon[2].TenLC;
                String D = arrluachon[3].TenLC;
                String dapAnDaChon = "";
                CT_BaiThi ct = new CT_BaiThi(maCH, i, noiDung, A, B, C, D, dapAn, dapAnDaChon);
                CT_BaiThi.ct_baiThi.Add(ct);//Lưu vào mảng  ct_baiThi
                
                i++;
                
            }
            /*cập nhật thông báo đáp án đã chọn*/
            //     capNhatThongBaoDapAnDaChon();
            numericUpDownCAUINDEX.Maximum = 100;
            numericUpDownCAUINDEX.Minimum = 1;

            summarylistview.View = View.Details;
            summarylistview.GridLines = true;//Tạo đường viền lưới
            summarylistview.FullRowSelect = true;//Click vào được từng dòng dữ liệu
            foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
            {
                String[] arr = new string[2];
                arr[0] = ct.getThuTu().ToString();
                arr[1] = ct.getDapAnDaChon().ToString();
                ListViewItem baiThi = new ListViewItem(arr);
                this.summarylistview.Items.Add(baiThi);//Thêm lựa chọn vào phiếu làm bài listview
            }
        }
        private List<LuaChon> convertToListLC(DataTable ds)
        {
            List<LuaChon> list = new List<LuaChon>();
            foreach (DataRow row in ds.Rows)
            {
                LuaChon lc = new LuaChon(
                
                    row["NOIDUNG"].ToString()

                    );
                list.Add(lc);
            }
            return list;
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //get time;
            string time = "";
            string timess = "";
            string timemm = "";
            if (mm == 0 && ss == 0)
            {
                t.Stop();
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                lblTHONGBAO.Text = "Hết giờ làm bài!";
                chamDiem();
                ghiBangDiemVaBaiThi();
                this.Close();
            }
            if (ss != 0)
            {
                ss--;
            }
            else
            {
                mm--;
                ss = 59;
            }
            if (mm < 10)
            {
                timemm = "0" + mm;
            }
            else timemm = mm.ToString();
            if (ss < 10)
            {
                timess = "0" + ss;
            }
            else timess = ss.ToString();
            time = "Còn lại: " + timemm + ":" + timess;
            lblTHOIGIANTHI.Text = time;
        }
        private void chamDiem()
        {
            float diemMoiCau = (float)10 / soCauThi;
            foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
            {
                if (ct.getDapAnDaChon().Equals(ct.getDapAnDung()))
                {
                    tongDiem += diemMoiCau;
                    soCauDung++;
                }
            }
            tongDiem = (float)Math.Round(tongDiem, 2);
           
        }
        private void cTBAITHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTBT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void capNhatThongBaoDapAnDaChon(int cau)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[cau];
            String[] arr = new string[2];
            arr[0] = ct.getThuTu().ToString();
            arr[1] = ct.getDapAnDaChon().ToString();
            ListViewItem baiThi = new ListViewItem(arr);
            this.summarylistview.Items[cau] = baiThi;
        }

        private void btnCAUTRUOC_Click(object sender, EventArgs e)
        {
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            index--;
            numericUpDownCAUINDEX.Value = index + 1;

            btnCAUSAU.Enabled = true;
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == 0)
            {
                btnCAUTRUOC.Enabled = false;
            }
            this.checkDapAnDaChon();
        }
        private void checkDapAnDaChon()
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            //Nếu câu hỏi này chưa chọn đáp án
            if (ct.getDapAnDaChon().Equals(""))
            {
                rdoA.Checked = false;
                rdoB.Checked = false;
                rdoC.Checked = false;
                rdoD.Checked = false;
            }
            else
            {
                switch (ct.getDapAnDaChon())
                {
                    case "A":
                        {
                            rdoA.Checked = true;
                            rdoB.Checked = false;
                            rdoC.Checked = false;
                            rdoD.Checked = false;
                            break;
                        }
                    case "B":
                        {
                            rdoA.Checked = false;
                            rdoB.Checked = true;
                            rdoC.Checked = false;
                            rdoD.Checked = false;
                            break;
                        }
                    case "C":
                        {
                            rdoA.Checked = false;
                            rdoB.Checked = false;
                            rdoC.Checked = true;
                            rdoD.Checked = false;
                            break;
                        }
                    case "D":
                        {
                            rdoA.Checked = false;
                            rdoB.Checked = false;
                            rdoC.Checked = false;
                            rdoD.Checked = true;
                            break;
                        }
                }
            }
        }
        private void summarylistview_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            int i = 0;
            try
            {
                i = index;
                index = summarylistview.FocusedItem.Index;
                //FocusedItem trả về 1 item trong listview
            }
            catch (Exception)
            {
                index = i;
            }
            if (index <= 0)
            {
                btnCAUTRUOC.Enabled = false;
                btnCAUSAU.Enabled = true;
                index = 0;
                numericUpDownCAUINDEX.Value = index + 1;
            }
            else if (index >= soCauThi - 1)
            {
                btnCAUSAU.Enabled = false;
                btnCAUTRUOC.Enabled = true;
                index = soCauThi - 1;
                numericUpDownCAUINDEX.Value = index + 1;
            }
            else
            {
                btnCAUTRUOC.Enabled = true;
                btnCAUSAU.Enabled = true;
            }
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == 0)
            {
                btnCAUTRUOC.Enabled = false;
            }
            this.checkDapAnDaChon();
        }

        private void rdoA_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("A");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void rdoB_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("B");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("C");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
            ct.setDapDaChon("D");
            CT_BaiThi.ct_baiThi[index] = ct;
            capNhatThongBaoDapAnDaChon(index);
        }

        private void btnCAUSAU_Click(object sender, EventArgs e)
        {
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;
            index++;
            numericUpDownCAUINDEX.Value = index + 1;
            btnCAUTRUOC.Enabled = true;
            BoDe b = (BoDe)boDe[index];
            lblNOIDUNG.Text = "Câu " + (index + 1) + ": " + b.NoiDung;
            rdoA.Text = b.DapAnA;
            rdoB.Text = b.DapAnB;
            rdoC.Text = b.DapAnC;
            rdoD.Text = b.DapAnD;
            if (index == soCauThi - 1)
            {
                btnCAUSAU.Enabled = false;
            }
            this.checkDapAnDaChon();
        }

        private void btnNOPBAI_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn nộp bài thi?", "CẢNH BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                t.Stop();
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                chamDiem();
                txtDiem.Text= tongDiem.ToString();
                ghiBangDiemVaBaiThi();
               
               this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void ghiBangDiemVaBaiThi()
        {
            //GHI ĐIỂM SAU KHI THI
            Dangky dk = Dangky.dangky;
            int iddk = Program.iddk;

            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();

            }

            SqlCommand sqlcmd = Program.conn.CreateCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.Add(new SqlParameter("MASV", Program.username));
            sqlcmd.Parameters.Add(new SqlParameter("IDDK", iddk));
            sqlcmd.Parameters.Add(new SqlParameter("DIEM", tongDiem));
         

            sqlcmd.CommandText = "SP_GHIDIEM";

            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            //Lấy IDTHI TỪ BẢNG THI
           
            string strLenh = "SELECT IDTHI FROM THI WHERE MASV='" +Program.username + "'"+ "AND IDDK='" + iddk + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            Program.idThi = Program.myReader.GetInt32(0);
            Program.myReader.Close();
            //Lưu Các câu hỏi đã lấy vào bảng LAYBAITHI
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }
                foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
                {
                    //Program.myReader.Close();
                    SqlCommand sqlcmdLBT = Program.conn.CreateCommand();
                    sqlcmdLBT.CommandType = CommandType.StoredProcedure;
                    sqlcmdLBT.Parameters.Add(new SqlParameter("IDDK", Program.iddk));
                    sqlcmdLBT.Parameters.Add(new SqlParameter("MACH", ct.getCauHoi()));
                    sqlcmdLBT.CommandText = "SP_LAYBAITHI";
                    sqlcmdLBT.ExecuteNonQuery();

                }

            foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
            {
                string strLenh2 = "SELECT IDLBT FROM LAYBAITHI WHERE MACH='" + ct.getCauHoi() + "'" + "AND IDDK=" + Program.iddk ;
                Program.myReader = Program.ExecSqlDataReader(strLenh2);
                Program.myReader.Read();
                Program.IDLBTHI.Add(Program.myReader.GetInt32(0));
                Program.myReader.Close();
            }
            Program.myReader.Close();
            //int count = Program.IDLBTHI.Count();

            //Ghi thông tin chi tiết bài thi
            for (int i = 0; i < Program.IDLBTHI.Count; i++)
            {
                //Lấy thông tin câu hỏi để kiểm tra
                CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[i];
                //KIỂM TRA MÃ CÂU HỎI CẦN LƯU
                string strCauHoi= "SELECT MACH FROM LAYBAITHI WHERE IDLBT=" + Program.IDLBTHI[i];

                Program.myReader = Program.ExecSqlDataReader(strCauHoi);
                Program.myReader.Read();
                string cauHoi = Program.myReader.GetString(0);
                Program.myReader.Close();
                if (cauHoi.Equals(ct.getCauHoi()))
                {
                    
                    SqlCommand sqlcmdCTBT = Program.conn.CreateCommand();
                    sqlcmdCTBT.CommandType = CommandType.StoredProcedure;
                    sqlcmdCTBT.Parameters.Add(new SqlParameter("IDTHI", Program.idThi));
                    sqlcmdCTBT.Parameters.Add(new SqlParameter("IDLBT", Program.IDLBTHI[i]));
                    sqlcmdCTBT.Parameters.Add(new SqlParameter("DACHON", ct.getDapAnDaChon()));
                    sqlcmdCTBT.CommandText = "SP_GHI_CHI_TIET_BAI_THI";

                    sqlcmdCTBT.ExecuteNonQuery();
                }
            }
            //Xem chi tiết bài thi
            DialogResult dialogResult = MessageBox.Show("Số câu đúng: " + soCauDung + "/" + soCauThi + "\nTổng điểm: " + tongDiem + "\nBạn có muốn xem lại bài thi?", "KẾT QUẢ", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                Report.Xrpt_ChiTietBaiThi rpt = new Report.Xrpt_ChiTietBaiThi(Program.idThi);
                
                rpt.xrLop.Text = Program.mTenLop;
                rpt.xrHoTen.Text = Program.username;
                rpt.xrMonHoc.Text = Program.maMH;
                rpt.xrNgayThi.Text = Program.ngayThi;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
            Dangky.dangky = null;
            CT_BaiThi.ct_baiThi.Clear();
            BoDe.boDe.Clear();
            summarylistview.Clear();
        }
    }
    

}
