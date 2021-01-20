namespace TRACNGHIEM.Report
{
    partial class XemKetQuaThi
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtenlop = new System.Windows.Forms.Label();
            this.lbmalop = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMAMH = new System.Windows.Forms.ComboBox();
            this.bdSMH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.dateNgaythi = new DevExpress.XtraEditors.DateEdit();
            this.mONHOCTableAdapter = new TRACNGHIEM.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.dANGKYTableAdapter = new TRACNGHIEM.DSTableAdapters.DANGKYTableAdapter();
            this.sINHVIENTableAdapter = new TRACNGHIEM.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            tENMHLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaythi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaythi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(12, 245);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(61, 17);
            tENMHLabel.TabIndex = 68;
            tENMHLabel.Text = "TENMH:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(560, 252);
            nGAYTHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(73, 17);
            nGAYTHILabel.TabIndex = 65;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtenlop);
            this.groupBox1.Controls.Add(this.lbmalop);
            this.groupBox1.Controls.Add(this.lbhoten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 353);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lbtenlop
            // 
            this.lbtenlop.AutoSize = true;
            this.lbtenlop.Location = new System.Drawing.Point(257, 149);
            this.lbtenlop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtenlop.Name = "lbtenlop";
            this.lbtenlop.Size = new System.Drawing.Size(46, 17);
            this.lbtenlop.TabIndex = 17;
            this.lbtenlop.Text = "label6";
            // 
            // lbmalop
            // 
            this.lbmalop.AutoSize = true;
            this.lbmalop.Location = new System.Drawing.Point(257, 95);
            this.lbmalop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmalop.Name = "lbmalop";
            this.lbmalop.Size = new System.Drawing.Size(46, 17);
            this.lbmalop.TabIndex = 16;
            this.lbmalop.Text = "label5";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(257, 41);
            this.lbhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(46, 17);
            this.lbhoten.TabIndex = 15;
            this.lbhoten.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Họ và tên";
            // 
            // cbMAMH
            // 
            this.cbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSMH, "TENMH", true));
            this.cbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDangKy, "MAMH", true));
            this.cbMAMH.DataSource = this.bdSMH;
            this.cbMAMH.DisplayMember = "TENMH";
            this.cbMAMH.FormattingEnabled = true;
            this.cbMAMH.Location = new System.Drawing.Point(90, 245);
            this.cbMAMH.Margin = new System.Windows.Forms.Padding(4);
            this.cbMAMH.Name = "cbMAMH";
            this.cbMAMH.Size = new System.Drawing.Size(357, 24);
            this.cbMAMH.TabIndex = 70;
            this.cbMAMH.ValueMember = "MAMH";
            this.cbMAMH.SelectedIndexChanged += new System.EventHandler(this.cbMAMH_SelectedIndexChanged);
            // 
            // bdSMH
            // 
            this.bdSMH.DataMember = "MONHOC";
            this.bdSMH.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "DANGKY";
            this.bdsDangKy.DataSource = this.dS;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(633, 357);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 28);
            this.btnThoat.TabIndex = 69;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(180, 357);
            this.btnXemKQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(137, 28);
            this.btnXemKQ.TabIndex = 67;
            this.btnXemKQ.Text = "XEM KẾT QUẢ";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // dateNgaythi
            // 
            this.dateNgaythi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDangKy, "NGAYTHI", true));
            this.dateNgaythi.EditValue = null;
            this.dateNgaythi.Location = new System.Drawing.Point(661, 245);
            this.dateNgaythi.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgaythi.Name = "dateNgaythi";
            this.dateNgaythi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaythi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaythi.Size = new System.Drawing.Size(231, 22);
            this.dateNgaythi.TabIndex = 66;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LAYBAITHITableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.NHANVIENPGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS;
            // 
            // XemKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 489);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbMAMH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(nGAYTHILabel);
            this.Controls.Add(this.dateNgaythi);
            this.Controls.Add(this.groupBox1);
            this.Name = "XemKetQuaThi";
            this.Text = "XemKetQuaThi";
            this.Load += new System.EventHandler(this.XemKetQuaThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaythi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaythi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtenlop;
        private System.Windows.Forms.Label lbmalop;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMAMH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemKQ;
        private DevExpress.XtraEditors.DateEdit dateNgaythi;
        private DS dS;
        private System.Windows.Forms.BindingSource bdSMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
    }
}