namespace TRACNGHIEM
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonhoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnBode = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangky = new DevExpress.XtraBars.BarButtonItem();
            this.btnThiThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKetqua = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangdiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLogin,
            this.btnLogout,
            this.btnLop,
            this.btnMonhoc,
            this.btnSV,
            this.btnGV,
            this.btnKhoa,
            this.btnBode,
            this.btnDangky,
            this.btnThiThu,
            this.btnKetqua,
            this.btnBangdiem,
            this.btnTaoTK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(978, 225);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "ĐĂNG NHẬP";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "ĐĂNG XUẤT";
            this.btnLogout.Id = 2;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "LỚP HỌC";
            this.btnLop.Id = 3;
            this.btnLop.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.home_16x16;
            this.btnLop.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.home_32x32;
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Caption = "MÔN HỌC";
            this.btnMonhoc.Id = 4;
            this.btnMonhoc.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.text_16x16;
            this.btnMonhoc.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.text_32x32;
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonhoc_ItemClick);
            // 
            // btnSV
            // 
            this.btnSV.Caption = "SINH VIÊN";
            this.btnSV.Id = 5;
            this.btnSV.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.bodetails_16x16;
            this.btnSV.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.bodetails_32x32;
            this.btnSV.Name = "btnSV";
            this.btnSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSV_ItemClick);
            // 
            // btnGV
            // 
            this.btnGV.Caption = "GIẢNG VIÊN";
            this.btnGV.Id = 6;
            this.btnGV.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.boposition2_16x161;
            this.btnGV.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.boposition2_32x321;
            this.btnGV.Name = "btnGV";
            this.btnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGV_ItemClick);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "KHOA";
            this.btnKhoa.Id = 7;
            this.btnKhoa.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.documentmap_16x16;
            this.btnKhoa.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.documentmap_32x32;
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnBode
            // 
            this.btnBode.Caption = "BỘ ĐỀ";
            this.btnBode.Id = 8;
            this.btnBode.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.notes_16x16;
            this.btnBode.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.notes_32x32;
            this.btnBode.Name = "btnBode";
            this.btnBode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBode_ItemClick);
            // 
            // btnDangky
            // 
            this.btnDangky.Caption = "ĐĂNG KÝ THI";
            this.btnDangky.Id = 9;
            this.btnDangky.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.editdatasource_16x16;
            this.btnDangky.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.editdatasource_32x32;
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangky_ItemClick);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Caption = "THI THỬ";
            this.btnThiThu.Id = 10;
            this.btnThiThu.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.btnThiThu.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThiThu_ItemClick);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Caption = "KẾT QUẢ THI";
            this.btnKetqua.Id = 11;
            this.btnKetqua.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.forcetesting_16x16;
            this.btnKetqua.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.forcetesting_32x32;
            this.btnKetqua.Name = "btnKetqua";
            // 
            // btnBangdiem
            // 
            this.btnBangdiem.Caption = "BẢNG ĐIỂM MÔN HỌC";
            this.btnBangdiem.Id = 12;
            this.btnBangdiem.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.spreadsheetinserttable_16x16;
            this.btnBangdiem.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.spreadsheetinserttable_32x32;
            this.btnBangdiem.Name = "btnBangdiem";
            this.btnBangdiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangdiem_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "TẠO TÀI KHOẢN";
            this.btnTaoTK.Id = 13;
            this.btnTaoTK.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.add_32x32;
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup12});
            this.ribbonPage1.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.technology_32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "QUẢN TRỊ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "NHẬP LIỆU";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnKhoa);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMonhoc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnGV);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSV);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnBode);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnDangky);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnBangdiem);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaGV,
            this.HoTen,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaGV
            // 
            this.MaGV.Name = "MaGV";
            this.MaGV.Size = new System.Drawing.Size(53, 20);
            this.MaGV.Text = "Mã GV";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(75, 20);
            this.HoTen.Text = "Họ và Tên";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        public DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        public DevExpress.XtraBars.BarButtonItem btnMonhoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        public DevExpress.XtraBars.BarButtonItem btnSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        public DevExpress.XtraBars.BarButtonItem btnGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        public DevExpress.XtraBars.BarButtonItem btnKhoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        public DevExpress.XtraBars.BarButtonItem btnBode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        public DevExpress.XtraBars.BarButtonItem btnDangky;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        public DevExpress.XtraBars.BarButtonItem btnThiThu;
        public DevExpress.XtraBars.BarButtonItem btnKetqua;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MaGV;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel Nhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public DevExpress.XtraBars.BarButtonItem btnBangdiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        public DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
    }
}

