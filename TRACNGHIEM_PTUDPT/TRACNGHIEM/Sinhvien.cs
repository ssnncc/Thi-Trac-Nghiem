﻿using System;
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
    public partial class Sinhvien : Form
    {
        int vitri = 0;
        String maCoso = "";
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void lOPHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            //this.gV_DAYTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.gV_DAYTableAdapter.Fill(this.dS.GV_DAY);
           
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
            //if (Program.mNhom == Program.NhomQuyen[1])
            //{
            //    string strLenh = "SELECT MAKH FROM GIANGVIEN WHERE MAGV='" + Program.username + "'";
            //    Program.myReader = Program.ExecSqlDataReader(strLenh);
            //    Program.myReader.Read();
            //    Program.mKhoa = Program.myReader.GetString(0);
            //    Program.myReader.Close();
            //    bdsLop.Filter = "MAKH = '" + Program.mKhoa + "'";
            //}
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
                    this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    //this.gV_DAYTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.gV_DAYTableAdapter.Fill(this.dS.GV_DAY);
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position; //lấy vị trí lớp  
            bdsLop.AddNew(); //thêm mới 1 hàng vào danh sách
            groupBox1.Enabled = true;
            txtMaLop.Focus();
            txtMaKhoa.Enabled = true;

            cmbCoso.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maLop = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    MessageBox.Show(bdsLop.Position + " ");
                    bdsLop.RemoveCurrent(); //xóa đi hàng hiện tại ra khỏi dataSet
                    this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPHOCTableAdapter.Update(this.dS.LOPHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khoa đã có dữ liệu không thể xóa \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
                    bdsLop.Position = bdsKhoa.Find("MAKH", maLop);
                    return;
                }
            }

            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            txtMaLop.Enabled = false;
            groupBox1.Enabled = true;
            cmbCoso.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtMaLop.Enabled == true)
            {
                string strLenh = "SELECT COUNT(MALOP)  FROM LINK0.TRACNGHIEM.dbo.LOPHOC WHERE MALOP='" + txtMaLop.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã lớp đã có", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPHOCTableAdapter.Update(this.dS.LOPHOC);
                this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp học học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void menuThem_Click(object sender, EventArgs e)
        {
            vitri = bdsSV.Position;
            //groupBox1.Enabled = true;
            bdsSV.AddNew();
            cmbCoso.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnPhuchoi.Enabled = btnSua.Enabled = btnGhi.Enabled = groupBox1.Enabled = false;
        }

        private void menuXoa_Click(object sender, EventArgs e)
        {
            //if (bdsDiem.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa sinh viên đã có điểm? ", "Xác nhận",
            //           MessageBoxButtons.OKCancel);
            //    return;
            //}
            String masv = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                     MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                                                                                   // bdsSV.Position = bdsSV.Find("MASV", masv);
                    bdsSV.RemoveCurrent();
                    this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPHOCTableAdapter.Update(this.dS.LOPHOC);
      
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPHOCTableAdapter.Fill(this.dS.LOPHOC);
                    //bdsSV.Position = bdsSV.Find("MASV", bdsSV);
                    return;
                }
                cmbCoso.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnPhuchoi.Enabled = btnSua.Enabled = btnGhi.Enabled = groupBox1.Enabled = false;
            }

            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }

        private void menuGhi_Click(object sender, EventArgs e)
        {
            int index = bdsSV.Count - 1;
            string maSV = this.gridView2.GetRowCellValue(index, "MASV").ToString();
            //Kiểm tra mã sinh viên đã tồn tại hay chưa.
            if (colMASV.ReadOnly == false)
            {
                string strLenh = "SELECT COUNT(MASV)  FROM LINK0.TRACNGHIEM.dbo.SINHVIEN WHERE MASV= '" + maSV + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s2 = Program.myReader.GetInt32(0);
                if (s2 == 1)
                {
                    MessageBox.Show("Mã sinh viên này đã có", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();

                
            }
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.lOPHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPHOCTableAdapter.Update(this.dS.LOPHOC);
                cmbCoso.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void menuPhuchoi_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThem.Enabled == false) bdsSV.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            menuThem.Enabled = menuXoa.Enabled =  true;
            menuGhi.Enabled = menuPhuchoi.Enabled = false;
        }

        private void menuSua_Click(object sender, EventArgs e)
        {
            vitri = bdsSV.Position;
            colMASV.OptionsColumn.ReadOnly = true;
        }
    }
}
