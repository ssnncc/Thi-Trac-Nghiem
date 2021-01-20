using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace TRACNGHIEM
{
    public partial class SinhvienThi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SinhvienThi()
        {
            InitializeComponent();
        }
        Boolean Dangxuat = false;
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void btnLogout2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dangxuat = true;
            this.Close();
            Program.formDN.Visible = true;
        }

        private void btnThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(formDuThi));
        }

        private void btnChonMon_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btnSVTracuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(TracuuDiem));
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.XemKetQuaThi));
        }
    }
}