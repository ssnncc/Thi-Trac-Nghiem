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
    public partial class Bode : Form
    {
        int vitri = 0;
        public Bode()
        {
            InitializeComponent();
        }

        private void cAUHOIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Bode_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
           
            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.dS.CAUHOI);
            this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
            if (Program.mNhom == Program.NhomQuyen[0] || Program.mNhom ==Program.NhomQuyen[1])
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
        
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsCH.Position;
            groupBox1.Enabled = true;
            bdsCH.AddNew();
            txtMaCH.Focus();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsCH.Position;
            txtMaCH.Enabled = false;
            groupBox1.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaCH.Text.Trim() == "")
            {
                MessageBox.Show("Mã câu hỏi không được để trống!", "", MessageBoxButtons.OK);
                txtMaCH.Focus();
                return;
            }
            if (txtNoidung.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung của câu hỏi không được để trống!", "", MessageBoxButtons.OK);
                txtNoidung.Focus();
                return;
            }
            if (txtLoaiCH.Text.Trim() == "")
            {
                MessageBox.Show("Loại câu hỏi không được để trống!", "", MessageBoxButtons.OK);
                txtLoaiCH.Focus();
                return;
            }
            if (txtDapAn.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án không được để trống!", "", MessageBoxButtons.OK);
                txtDapAn.Focus();
                return;
            }
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtMaTD.Text.Trim() == "")
            {
                MessageBox.Show("Mã trình độ không được để trống!", "", MessageBoxButtons.OK);
                txtMaTD.Focus();
                return;
            }
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtMaCH.Enabled == true)
            {
                string strLenh = "SELECT COUNT(MACH) FROM CAUHOI WHERE MACH='" + txtMaCH.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã câu hỏi đã có", "", MessageBoxButtons.OK);
                    txtMaCH.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            try
            {
                bdsCH.EndEdit();
                bdsCH.ResetCurrentItem();
                this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cAUHOITableAdapter.Update(this.dS.CAUHOI);
                this.cAUHOITableAdapter.Fill(this.dS.CAUHOI);

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI GHI CÂU HỎI.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mach = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mach = ((DataRowView)bdsCH[bdsCH.Position])["MACH"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsCH.Position = bdsCH.Find("MACH", mach);
                    bdsCH.RemoveCurrent(); // xóa tại chỗ 
                    this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cAUHOITableAdapter.Update(this.dS.CAUHOI); // ghi vào CSDL
                    //Đưa dữ liệu từ DataTable qLDSVDataSet.MONHOC  trong Project về table MONHOC
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.cAUHOITableAdapter.Fill(this.dS.CAUHOI);
                    bdsCH.Position = bdsCH.Find("MACH", mach);
                    return;
                }
            }

            if (bdsCH.Count == 0) btnXoa.Enabled = false;
        }
        //CHỈ CHO THÊM 4 LỰA CHỌN
        private void menuThemLC_Click(object sender, EventArgs e)
        {
            vitri = bdsLC.Position;
            //groupBox1.Enabled = true;
            bdsLC.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnPhuchoi.Enabled = btnSua.Enabled = btnGhi.Enabled = groupBox1.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCH.CancelEdit();
            if (btnThem.Enabled == false) bdsCH.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void menuXoaLC_Click(object sender, EventArgs e)
        {
            //int malc;
            if (MessageBox.Show("Bạn có thật sự muốn xóa lựa chọn này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /* malc = ((DataRowView)bdsLC[bdsLC.Position])["MALC"].GetType().;// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại*/
                    //  bdsLC.Position = bdsLC.Find("MALC", malc);
                    bdsLC.RemoveCurrent(); // xóa tại chỗ 
                    this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lUACHONTableAdapter.Update(this.dS.LUACHON); // ghi vào CSDL
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
                    //bdsLC.Position = bdsLC.Find("MALC", malc);
                    return;
                }
            }

            if (bdsLC.Count == 0) btnXoa.Enabled = false;
        }
        //Lưu lựa chọn vào database
        private void menuLuuLC_Click(object sender, EventArgs e)
        {
            int index = bdsLC.Count - 1;
            
           
                try
                {
                    bdsLC.EndEdit();
                bdsLC.ResetCurrentItem();
                this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cAUHOITableAdapter.Update(this.dS.CAUHOI);
                this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lUACHONTableAdapter.Update(this.dS.LUACHON);
                this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
                    
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu lựa chọn.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            

            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

        }

        
    }
}
