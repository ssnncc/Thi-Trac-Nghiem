namespace TRACNGHIEM
{
    partial class Dangnhap
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
            System.Windows.Forms.Label KhoaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.bds_PM = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PM = new TRACNGHIEM.DS_PM();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelMK = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHTableAdapter = new TRACNGHIEM.DS_PMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DS_PMTableAdapters.TableAdapterManager();
            KhoaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM)).BeginInit();
            this.SuspendLayout();
            // 
            // KhoaLabel
            // 
            KhoaLabel.AutoSize = true;
            KhoaLabel.Location = new System.Drawing.Point(87, 68);
            KhoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            KhoaLabel.Name = "KhoaLabel";
            KhoaLabel.Size = new System.Drawing.Size(56, 17);
            KhoaLabel.TabIndex = 7;
            KhoaLabel.Text = "CƠ SỞ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHƯƠNG TRÌNH THI TRẮC NGHIỆM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(KhoaLabel);
            this.groupBox1.Controls.Add(this.cmbCN);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.labelMK);
            this.groupBox1.Controls.Add(this.labelTK);
            this.groupBox1.Location = new System.Drawing.Point(113, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(711, 318);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbCN
            // 
            this.cmbCN.DataSource = this.bds_PM;
            this.cmbCN.DisplayMember = "TENCN";
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(199, 64);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(397, 24);
            this.cmbCN.TabIndex = 8;
            this.cmbCN.ValueMember = "TENSERVER";
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // bds_PM
            // 
            this.bds_PM.DataMember = "V_DS_PHANMANH";
            this.bds_PM.DataSource = this.dS_PM;
            // 
            // dS_PM
            // 
            this.dS_PM.DataSetName = "DS_PM";
            this.dS_PM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(199, 156);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(397, 22);
            this.txtMK.TabIndex = 7;
            this.txtMK.Text = "123";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(199, 110);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(397, 22);
            this.txtTK.TabIndex = 6;
            this.txtTK.Text = "TDH";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Location = new System.Drawing.Point(508, 221);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.btnLogin.Location = new System.Drawing.Point(199, 221);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Location = new System.Drawing.Point(87, 159);
            this.labelMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(79, 17);
            this.labelMK.TabIndex = 2;
            this.labelMK.Text = "MẬT KHẨU";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(87, 113);
            this.labelTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(82, 17);
            this.labelTK.TabIndex = 1;
            this.labelTK.Text = "TÀI KHOẢN";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TRACNGHIEM.DS_PMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dangnhap";
            this.Text = "Dangnhap";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Label labelTK;
        private DS_PM dS_PM;
        private System.Windows.Forms.BindingSource bds_PM;
        private DS_PMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_PMTableAdapters.TableAdapterManager tableAdapterManager;
    }
}