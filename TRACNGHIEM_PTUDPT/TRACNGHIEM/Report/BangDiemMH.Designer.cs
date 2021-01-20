namespace TRACNGHIEM.Report
{
    partial class BangDiemMH
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.pnChiNhanh = new System.Windows.Forms.Panel();
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.cmbMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.kHOATableAdapter = new TRACNGHIEM.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.lOPHOCTableAdapter = new TRACNGHIEM.DSTableAdapters.LOPHOCTableAdapter();
            this.mONHOCTableAdapter = new TRACNGHIEM.DSTableAdapters.MONHOCTableAdapter();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            mALOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(118, 139);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(36, 17);
            mALOPLabel.TabIndex = 9;
            mALOPLabel.Text = "LỚP";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(80, 193);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(74, 17);
            mAMHLabel.TabIndex = 11;
            mAMHLabel.Text = "MÔN HỌC";
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.cmbCoso);
            this.pnChiNhanh.Controls.Add(this.label2);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1129, 79);
            this.pnChiNhanh.TabIndex = 8;
            // 
            // cmbCoso
            // 
            this.cmbCoso.DataSource = this.bdsKhoa;
            this.cmbCoso.DisplayMember = "TENKH";
            this.cmbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(384, 29);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(463, 24);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CƠ SỞ";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(410, 311);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 41);
            this.btnIn.TabIndex = 15;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbMH
            // 
            this.cmbMH.DataSource = this.bdsMH;
            this.cmbMH.DisplayMember = "TENMH";
            this.cmbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMH.FormattingEnabled = true;
            this.cmbMH.Location = new System.Drawing.Point(184, 186);
            this.cmbMH.Name = "cmbMH";
            this.cmbMH.Size = new System.Drawing.Size(358, 24);
            this.cmbMH.TabIndex = 12;
            this.cmbMH.ValueMember = "MAMH";
            this.cmbMH.SelectedIndexChanged += new System.EventHandler(this.cmbMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataSource = this.bdsLop;
            this.cmbMaLop.DisplayMember = "TENLOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(184, 136);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(358, 24);
            this.cmbMaLop.TabIndex = 10;
            this.cmbMaLop.ValueMember = "MALOP";
            this.cmbMaLop.SelectedIndexChanged += new System.EventHandler(this.cmbMaLop_SelectedIndexChanged);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOPHOC";
            this.bdsLop.DataSource = this.dS;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(656, 311);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GV_DAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LAYBAITHITableAdapter = null;
            this.tableAdapterManager.LOPHOCTableAdapter = this.lOPHOCTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.NHANVIENPGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPHOCTableAdapter
            // 
            this.lOPHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(742, 188);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(151, 27);
            this.txtMaMH.TabIndex = 56;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(742, 139);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(151, 27);
            this.txtMaLop.TabIndex = 57;
            // 
            // BangDiemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cmbMH);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.pnChiNhanh);
            this.Name = "BangDiemMH";
            this.Text = "BangDiemMH";
            this.Load += new System.EventHandler(this.BangDiemMH_Load);
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnChiNhanh;
        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbMH;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Button btnThoat;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPHOCTableAdapter lOPHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtMaLop;
    }
}