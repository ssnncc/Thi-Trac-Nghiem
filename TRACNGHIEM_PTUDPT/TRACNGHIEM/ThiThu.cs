using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using TRACNGHIEM.Model;
using TRACNGHIEM.Report;

namespace TRACNGHIEM
{
    public partial class ThiThu : Form
    {
        int index = 0;
        int soCauThi = 0;
        Timer t = new Timer();
        int mm = 1;//phút
        int ss = 0;//giây
        float tongDiem = 0;
        int soCauDung = 0;
        List<BoDe> boDe;

        public ThiThu()
        {
            InitializeComponent();
        }

        private void cTBAITHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void ThiThu_Load(object sender, EventArgs e)
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
            lblMONHOC.Text = "Môn: " + Program.maMH;
            lblLOP.Text = "Lớp: " + Program.mMalop;
            lblNGAYTHI.Text = "Ngày thi: " + g.NgayThi.ToString("dd/MM/yyyy");
            lblTRINHDO.Text = "Trình độ: " + g.TrinhDo;
            btnCAUTRUOC.Enabled = false;
            mm = g.ThoiGian;
            t.Interval = 1000;// bộ tính là 1s

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
                CT_BaiThi.ct_baiThi.Add(ct);
                i++;
                
            }
            /*cập nhật thông báo đáp án đã chọn*/
            //     capNhatThongBaoDapAnDaChon();
            numericUpDownCAUINDEX.Maximum = 100;
            numericUpDownCAUINDEX.Minimum = 1;

            summarylistview.View = View.Details;
            summarylistview.GridLines = true;
            summarylistview.FullRowSelect = true;
            foreach (CT_BaiThi ct in CT_BaiThi.ct_baiThi)
            {
                String[] arr = new string[2];
                arr[0] = ct.getThuTu().ToString();
                arr[1] = ct.getDapAnDaChon().ToString();
                ListViewItem baiThi = new ListViewItem(arr);
                this.summarylistview.Items.Add(baiThi);
            }
        }

        private void cTBAITHIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTBT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
            string timess = "";//giây
            string timemm = "";//phút
            if (mm == 0 && ss == 0)
            {
                t.Stop();
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                lblTHONGBAO.Text = "Hết giờ làm bài!";
                chamDiem();
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
            diemMoiCau = (float)Math.Round(diemMoiCau, 2);
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
        private void checkDapAnDaChon()
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[index];
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

        private void btnNOPBAI_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn nộp bài thi?", "CẢNH BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                t.Stop();
                lblTHOIGIANTHI.Text = "Còn lại: 0 : 0";
                chamDiem();
                dialogResult = MessageBox.Show("Số câu đúng: " + soCauDung + "/" + soCauThi + "\nTổng điểm: " + tongDiem );
                
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
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
        private void capNhatThongBaoDapAnDaChon(int cau)
        {
            CT_BaiThi ct = (CT_BaiThi)CT_BaiThi.ct_baiThi[cau];
            String[] arr = new string[2];
            arr[0] = ct.getThuTu().ToString();
            arr[1] = ct.getDapAnDaChon().ToString();
            ListViewItem baiThi = new ListViewItem(arr);
            this.summarylistview.Items[cau] = baiThi;
        }
    }
}
