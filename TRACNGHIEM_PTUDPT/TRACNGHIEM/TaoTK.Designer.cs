namespace TRACNGHIEM
{
    partial class TaoTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TRACNGHIEM.DS();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pnRole = new DevExpress.XtraEditors.PanelControl();
            this.rdoPGV = new System.Windows.Forms.RadioButton();
            this.rdoKhoa = new System.Windows.Forms.RadioButton();
            this.rdoGV = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.gIANGVIENTableAdapter = new TRACNGHIEM.DSTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnRole)).BeginInit();
            this.pnRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cmbCoso);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbMaGV);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.pnRole);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblConfirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Location = new System.Drawing.Point(110, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 427);
            this.panel1.TabIndex = 38;
            // 
            // cmbCoso
            // 
            this.cmbCoso.DropDownHeight = 123;
            this.cmbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoso.DropDownWidth = 123;
            this.cmbCoso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.IntegralHeight = false;
            this.cmbCoso.Location = new System.Drawing.Point(276, 19);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(353, 30);
            this.cmbCoso.TabIndex = 49;
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "Cơ sở";
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataSource = this.bdsGV;
            this.cmbMaGV.DisplayMember = "HO";
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(276, 178);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(351, 24);
            this.cmbMaGV.TabIndex = 48;
            this.cmbMaGV.ValueMember = "MAGV";
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHuy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(483, 333);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 53);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDangKy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangKy.Location = new System.Drawing.Point(276, 333);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(153, 53);
            this.btnDangKy.TabIndex = 46;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // pnRole
            // 
            this.pnRole.Controls.Add(this.rdoPGV);
            this.pnRole.Controls.Add(this.rdoKhoa);
            this.pnRole.Controls.Add(this.rdoGV);
            this.pnRole.Location = new System.Drawing.Point(276, 231);
            this.pnRole.Margin = new System.Windows.Forms.Padding(4);
            this.pnRole.Name = "pnRole";
            this.pnRole.Size = new System.Drawing.Size(353, 78);
            this.pnRole.TabIndex = 45;
            // 
            // rdoPGV
            // 
            this.rdoPGV.AutoSize = true;
            this.rdoPGV.Location = new System.Drawing.Point(22, 27);
            this.rdoPGV.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPGV.Name = "rdoPGV";
            this.rdoPGV.Size = new System.Drawing.Size(54, 21);
            this.rdoPGV.TabIndex = 4;
            this.rdoPGV.TabStop = true;
            this.rdoPGV.Text = "PGV";
            this.rdoPGV.UseVisualStyleBackColor = true;
            // 
            // rdoKhoa
            // 
            this.rdoKhoa.AutoSize = true;
            this.rdoKhoa.Location = new System.Drawing.Point(119, 27);
            this.rdoKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdoKhoa.Name = "rdoKhoa";
            this.rdoKhoa.Size = new System.Drawing.Size(64, 21);
            this.rdoKhoa.TabIndex = 5;
            this.rdoKhoa.TabStop = true;
            this.rdoKhoa.Text = "KHOA";
            this.rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoGV
            // 
            this.rdoGV.AutoSize = true;
            this.rdoGV.Location = new System.Drawing.Point(217, 28);
            this.rdoGV.Margin = new System.Windows.Forms.Padding(4);
            this.rdoGV.Name = "rdoGV";
            this.rdoGV.Size = new System.Drawing.Size(97, 21);
            this.rdoGV.TabIndex = 6;
            this.rdoGV.TabStop = true;
            this.rdoGV.Text = "GIANGVIEN";
            this.rdoGV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(276, 141);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirm.Properties.Appearance.Options.UseBackColor = true;
            this.txtConfirm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtConfirm.Properties.MaxLength = 25;
            this.txtConfirm.Properties.UseSystemPasswordChar = true;
            this.txtConfirm.Size = new System.Drawing.Size(351, 24);
            this.txtConfirm.TabIndex = 37;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(276, 61);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.Properties.Appearance.Options.UseBackColor = true;
            this.txtLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtLogin.Properties.MaxLength = 25;
            this.txtLogin.Size = new System.Drawing.Size(351, 24);
            this.txtLogin.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Giảng Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nhóm quyền ";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(87, 146);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(157, 22);
            this.lblConfirm.TabIndex = 44;
            this.lblConfirm.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(276, 103);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Properties.Appearance.Options.UseBackColor = true;
            this.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPass.Properties.MaxLength = 25;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(351, 24);
            this.txtPass.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 31);
            this.label5.TabIndex = 37;
            this.label5.Text = "TẠO TÀI KHOẢN";
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.GV_DAYTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
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
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "TaoTK";
            this.Text = "Dangky";
            this.Load += new System.EventHandler(this.TaoTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnRole)).EndInit();
            this.pnRole.ResumeLayout(false);
            this.pnRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKy;
        private DevExpress.XtraEditors.PanelControl pnRole;
        private System.Windows.Forms.RadioButton rdoPGV;
        private System.Windows.Forms.RadioButton rdoKhoa;
        private System.Windows.Forms.RadioButton rdoGV;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtConfirm;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.Windows.Forms.Label label5;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsGV;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider error;
    }
}