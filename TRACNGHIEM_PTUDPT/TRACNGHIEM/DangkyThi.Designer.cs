namespace TRACNGHIEM
{
    partial class DangkyThi
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
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangkyThi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnChinhsua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThiThu = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.pnChiNhanh = new System.Windows.Forms.Panel();
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsDangky = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new TRACNGHIEM.DSTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.kHOATableAdapter = new TRACNGHIEM.DSTableAdapters.KHOATableAdapter();
            this.dANGKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit_Thoigian = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_Cauhoi = new DevExpress.XtraEditors.SpinEdit();
            this.dtNgaythi = new DevExpress.XtraEditors.DateEdit();
            this.cmbTD = new System.Windows.Forms.ComboBox();
            tRINHDOLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Thoigian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Cauhoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            tRINHDOLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tRINHDOLabel.Location = new System.Drawing.Point(23, 211);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(81, 16);
            tRINHDOLabel.TabIndex = 45;
            tRINHDOLabel.Text = "TRÌNH ĐỘ :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            mALOPLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            mALOPLabel.Location = new System.Drawing.Point(23, 158);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(66, 16);
            mALOPLabel.TabIndex = 44;
            mALOPLabel.Text = "MÃ LỚP :";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            mAMHLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            mAMHLabel.Location = new System.Drawing.Point(23, 103);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(105, 16);
            mAMHLabel.TabIndex = 43;
            mAMHLabel.Text = "MÃ MÔN HỌC :";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            mAGVLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            mAGVLabel.Location = new System.Drawing.Point(23, 49);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(113, 16);
            mAGVLabel.TabIndex = 42;
            mAGVLabel.Text = "MÃ NHÂN VIÊN:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            tHOIGIANLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tHOIGIANLabel.Location = new System.Drawing.Point(615, 153);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(86, 16);
            tHOIGIANLabel.TabIndex = 54;
            tHOIGIANLabel.Text = "THỜI GIAN :";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            sOCAUTHILabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            sOCAUTHILabel.Location = new System.Drawing.Point(615, 99);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(93, 16);
            sOCAUTHILabel.TabIndex = 52;
            sOCAUTHILabel.Text = "SỐ CÂU HỎI :";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Times New Roman", 7.8F);
            nGAYTHILabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            nGAYTHILabel.Location = new System.Drawing.Point(615, 51);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(80, 16);
            nGAYTHILabel.TabIndex = 50;
            nGAYTHILabel.Text = "NGÀY THI :";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.barButtonItem3,
            this.btnPhuchoi,
            this.btnThoat,
            this.btnGhi,
            this.btnSua,
            this.btnChinhsua,
            this.barButtonItem1,
            this.btnThiThu});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChinhsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThiThu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "ĐĂNG KÝ MỚI";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA ĐĂNG KÝ";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnChinhsua
            // 
            this.btnChinhsua.Caption = "CHỈNH SỬA";
            this.btnChinhsua.Id = 7;
            this.btnChinhsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhsua.ImageOptions.Image")));
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChinhsua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "LƯU ĐĂNG KÝ";
            this.btnGhi.Id = 5;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "PHỤC HỒI";
            this.btnPhuchoi.Id = 3;
            this.btnPhuchoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.ImageOptions.Image")));
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThi_ItemClick);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Caption = "THI THỬ";
            this.btnThiThu.Id = 9;
            this.btnThiThu.ImageOptions.Image = global::TRACNGHIEM.Properties.Resources.editcontact_16x16;
            this.btnThiThu.ImageOptions.LargeImage = global::TRACNGHIEM.Properties.Resources.editcontact_32x32;
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThiThu_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1284, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 524);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1284, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1284, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 484);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "CHỈNH SỬA";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "CHỈNH SỬA";
            this.btnSua.Id = 6;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Name = "btnSua";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "THI THỬ";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.cmbCoso);
            this.pnChiNhanh.Controls.Add(this.label1);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 40);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1284, 70);
            this.pnChiNhanh.TabIndex = 7;
            // 
            // cmbCoso
            // 
            this.cmbCoso.DataSource = this.bdsKhoa;
            this.cmbCoso.DisplayMember = "TENKH";
            this.cmbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(380, 22);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(256, 24);
            this.cmbCoso.TabIndex = 2;
            this.cmbCoso.ValueMember = "MAKH";
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CƠ SỞ";
            // 
            // bdsDangky
            // 
            this.bdsDangky.DataMember = "DANGKY";
            this.bdsDangky.DataSource = this.dS;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = this.dANGKYTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GV_DAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LAYBAITHITableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHANVIENPGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // dANGKYGridControl
            // 
            this.dANGKYGridControl.DataSource = this.bdsDangky;
            this.dANGKYGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dANGKYGridControl.Location = new System.Drawing.Point(0, 110);
            this.dANGKYGridControl.MainView = this.gridView1;
            this.dANGKYGridControl.MenuManager = this.barManager1;
            this.dANGKYGridControl.Name = "dANGKYGridControl";
            this.dANGKYGridControl.Size = new System.Drawing.Size(1284, 414);
            this.dANGKYGridControl.TabIndex = 8;
            this.dANGKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colMALOP,
            this.colNGAYTHI,
            this.colMANV,
            this.colTRINHDO,
            this.colTHOIGIAN,
            this.colSOCAU,
            this.colIDDK});
            this.gridView1.GridControl = this.dANGKYGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 1;
            this.colMALOP.Width = 94;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 25;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 2;
            this.colNGAYTHI.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 4;
            this.colTRINHDO.Width = 94;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 25;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            this.colTHOIGIAN.Width = 94;
            // 
            // colSOCAU
            // 
            this.colSOCAU.FieldName = "SOCAU";
            this.colSOCAU.MinWidth = 25;
            this.colSOCAU.Name = "colSOCAU";
            this.colSOCAU.Visible = true;
            this.colSOCAU.VisibleIndex = 6;
            this.colSOCAU.Width = 94;
            // 
            // colIDDK
            // 
            this.colIDDK.FieldName = "IDDK";
            this.colIDDK.MinWidth = 25;
            this.colIDDK.Name = "colIDDK";
            this.colIDDK.Visible = true;
            this.colIDDK.VisibleIndex = 7;
            this.colIDDK.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(tHOIGIANLabel);
            this.groupBox1.Controls.Add(this.spinEdit_Thoigian);
            this.groupBox1.Controls.Add(sOCAUTHILabel);
            this.groupBox1.Controls.Add(this.spinEdit_Cauhoi);
            this.groupBox1.Controls.Add(nGAYTHILabel);
            this.groupBox1.Controls.Add(this.dtNgaythi);
            this.groupBox1.Controls.Add(this.cmbTD);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 246);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangky, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(173, 100);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(378, 22);
            this.txtMaMH.TabIndex = 60;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangky, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(173, 48);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(378, 22);
            this.txtMaNV.TabIndex = 59;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangky, "MALOP", true));
            this.txtMaLop.EditValue = "";
            this.txtMaLop.Location = new System.Drawing.Point(173, 150);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(378, 22);
            this.txtMaLop.TabIndex = 58;
            // 
            // spinEdit_Thoigian
            // 
            this.spinEdit_Thoigian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangky, "THOIGIAN", true));
            this.spinEdit_Thoigian.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinEdit_Thoigian.Location = new System.Drawing.Point(765, 148);
            this.spinEdit_Thoigian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinEdit_Thoigian.Name = "spinEdit_Thoigian";
            this.spinEdit_Thoigian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_Thoigian.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinEdit_Thoigian.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinEdit_Thoigian.Size = new System.Drawing.Size(378, 24);
            this.spinEdit_Thoigian.TabIndex = 55;
            // 
            // spinEdit_Cauhoi
            // 
            this.spinEdit_Cauhoi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangky, "SOCAU", true));
            this.spinEdit_Cauhoi.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_Cauhoi.Location = new System.Drawing.Point(765, 94);
            this.spinEdit_Cauhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinEdit_Cauhoi.Name = "spinEdit_Cauhoi";
            this.spinEdit_Cauhoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_Cauhoi.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_Cauhoi.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_Cauhoi.Size = new System.Drawing.Size(378, 24);
            this.spinEdit_Cauhoi.TabIndex = 53;
            // 
            // dtNgaythi
            // 
            this.dtNgaythi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangky, "NGAYTHI", true));
            this.dtNgaythi.EditValue = null;
            this.dtNgaythi.Location = new System.Drawing.Point(765, 46);
            this.dtNgaythi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaythi.Name = "dtNgaythi";
            this.dtNgaythi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaythi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaythi.Size = new System.Drawing.Size(378, 22);
            this.dtNgaythi.TabIndex = 51;
            // 
            // cmbTD
            // 
            this.cmbTD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bdsDangky, "TRINHDO", true));
            this.cmbTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTD.FormattingEnabled = true;
            this.cmbTD.Items.AddRange(new object[] {
            "CDCQ",
            "DHCQ",
            "VB2"});
            this.cmbTD.Location = new System.Drawing.Point(173, 203);
            this.cmbTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTD.Name = "cmbTD";
            this.cmbTD.Size = new System.Drawing.Size(378, 24);
            this.cmbTD.TabIndex = 47;
            // 
            // DangkyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dANGKYGridControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DangkyThi";
            this.Text = "DangkyThi";
            this.Load += new System.EventHandler(this.DSDangkyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Thoigian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Cauhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaythi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Panel pnChiNhanh;
        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsDangky;
        private DS dS;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dANGKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAU;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDK;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTD;
        private DevExpress.XtraEditors.SpinEdit spinEdit_Thoigian;
        private DevExpress.XtraEditors.SpinEdit spinEdit_Cauhoi;
        private DevExpress.XtraEditors.DateEdit dtNgaythi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnChinhsua;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThiThu;
    }
}