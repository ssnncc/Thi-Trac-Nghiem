using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRACNGHIEM.Model;

namespace TRACNGHIEM
{
    public partial class TracuuDiem : Form
    {
        public TracuuDiem()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void TracuuDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            txtMaMH.Text = cmbMH.SelectedValue.ToString();
        }

        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMH.SelectedValue != null)
            {
                txtMaMH.Text = cmbMH.SelectedValue.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double Diem;
        private void btnIn_Click(object sender, EventArgs e)
        {
            string MaMH = cmbMH.SelectedValue.ToString();
            string MaSV = Program.username;
            DataTable db = Program.ExecSqlDataTable("EXEC SP_TIMBANGDIEM '" + MaSV + "','" + MaMH + "'");

            List<BangDiem> listBD = convertToListBD(db);
            BangDiem.bd = listBD;
            BangDiem[] arrBD= listBD.ToArray();
            Diem = Math.Round(arrBD[0].Diem, 2);
            DialogResult dialogResult = MessageBox.Show("BẠN THI ĐƯỢC : " + Diem);

        }
        private List<BangDiem> convertToListBD(DataTable ds)
        {
            List<BangDiem> list = new List<BangDiem>();
            foreach (DataRow row in ds.Rows)
            {
                BangDiem d = new BangDiem(

                    Convert.ToDouble(row["DIEM"].ToString())

                    );
                list.Add(d);
            }
            return list;
        }
    }
}
