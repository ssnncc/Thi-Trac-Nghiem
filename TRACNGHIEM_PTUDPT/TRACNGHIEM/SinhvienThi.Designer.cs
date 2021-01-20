namespace TRACNGHIEM
{
    partial class SinhvienThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSVTracuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonMon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTracuu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLogout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Malop = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tenlop = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnThi,
            this.btnSVTracuu,
            this.btnLogout2,
            this.barButtonItem3,
            this.btnChonMon,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(875, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnThi
            // 
            this.btnThi.Caption = "THI";
            this.btnThi.Id = 1;
            this.btnThi.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.showtestreport_16x161;
            this.btnThi.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.showtestreport_32x321;
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // btnSVTracuu
            // 
            this.btnSVTracuu.Caption = "TRA CỨU ĐIỂM THI";
            this.btnSVTracuu.Id = 2;
            this.btnSVTracuu.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.functionslookupandreference_16x161;
            this.btnSVTracuu.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.functionslookupandreference_32x321;
            this.btnSVTracuu.Name = "btnSVTracuu";
            this.btnSVTracuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSVTracuu_ItemClick);
            // 
            // btnLogout2
            // 
            this.btnLogout2.Caption = "ĐĂNG XUẤT";
            this.btnLogout2.Id = 3;
            this.btnLogout2.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.right_16x16;
            this.btnLogout2.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.right_32x32;
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "TRA CỨU ";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnChonMon
            // 
            this.btnChonMon.Caption = "CHỌN MÔN THI";
            this.btnChonMon.Id = 5;
            this.btnChonMon.Name = "btnChonMon";
            this.btnChonMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChonMon_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "KẾT QUẢ THI";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.forcetesting_16x161;
            this.barButtonItem1.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.forcetesting_32x321;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.btnTracuu,
            this.btnLogout,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CHỨC NĂNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnTracuu
            // 
            this.btnTracuu.ItemLinks.Add(this.btnSVTracuu);
            this.btnTracuu.Name = "btnTracuu";
            // 
            // btnLogout
            // 
            this.btnLogout.ItemLinks.Add(this.btnLogout2);
            this.btnLogout.Name = "btnLogout";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 471);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(875, 30);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HoTen,
            this.Malop,
            this.Tenlop,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(73, 20);
            this.HoTen.Text = "Họ và tên";
            // 
            // Malop
            // 
            this.Malop.Name = "Malop";
            this.Malop.Size = new System.Drawing.Size(56, 20);
            this.Malop.Text = "Mã lớp";
            // 
            // Tenlop
            // 
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Size = new System.Drawing.Size(58, 20);
            this.Tenlop.Text = "Tên lớp";
            // 
            // Nhom
            // 
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(50, 20);
            this.Nhom.Text = "Nhóm";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // SinhvienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "SinhvienThi";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "GIAO DIỆN SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.BarButtonItem btnSVTracuu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnTracuu;
        private DevExpress.XtraBars.BarButtonItem btnLogout2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnLogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel Malop;
        public System.Windows.Forms.ToolStripStatusLabel Tenlop;
        public System.Windows.Forms.ToolStripStatusLabel Nhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnChonMon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}