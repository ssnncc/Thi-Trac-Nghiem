namespace TRACNGHIEM
{
    partial class ThiTN
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
            this.lblTHONGBAO = new System.Windows.Forms.Label();
            this.lblTHOIGIANTHI = new System.Windows.Forms.Label();
            this.btnNOPBAI = new System.Windows.Forms.Button();
            this.summarylistview = new System.Windows.Forms.ListView();
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNOIDUNG = new System.Windows.Forms.RichTextBox();
            this.lblCHUYENDENCAU = new System.Windows.Forms.Label();
            this.numericUpDownCAUINDEX = new System.Windows.Forms.NumericUpDown();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.btnCAUSAU = new System.Windows.Forms.Button();
            this.btnCAUTRUOC = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNGAYTHI = new System.Windows.Forms.Label();
            this.lblTRINHDO = new System.Windows.Forms.Label();
            this.lblLOP = new System.Windows.Forms.Label();
            this.dS = new TRACNGHIEM.DS();
            this.bdsCTBT = new System.Windows.Forms.BindingSource(this.components);
            this.cTBAITHITableAdapter = new TRACNGHIEM.DSTableAdapters.CTBAITHITableAdapter();
            this.tableAdapterManager = new TRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCAUINDEX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTHONGBAO
            // 
            this.lblTHONGBAO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTHONGBAO.AutoSize = true;
            this.lblTHONGBAO.Location = new System.Drawing.Point(1165, 48);
            this.lblTHONGBAO.Name = "lblTHONGBAO";
            this.lblTHONGBAO.Size = new System.Drawing.Size(77, 17);
            this.lblTHONGBAO.TabIndex = 9;
            this.lblTHONGBAO.Text = "Thông báo";
            // 
            // lblTHOIGIANTHI
            // 
            this.lblTHOIGIANTHI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTHOIGIANTHI.AutoSize = true;
            this.lblTHOIGIANTHI.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHOIGIANTHI.ForeColor = System.Drawing.Color.Red;
            this.lblTHOIGIANTHI.Location = new System.Drawing.Point(1164, 9);
            this.lblTHOIGIANTHI.Name = "lblTHOIGIANTHI";
            this.lblTHOIGIANTHI.Size = new System.Drawing.Size(85, 24);
            this.lblTHOIGIANTHI.TabIndex = 8;
            this.lblTHOIGIANTHI.Text = "Còn lại:";
            // 
            // btnNOPBAI
            // 
            this.btnNOPBAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNOPBAI.Location = new System.Drawing.Point(1341, 9);
            this.btnNOPBAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNOPBAI.Name = "btnNOPBAI";
            this.btnNOPBAI.Size = new System.Drawing.Size(124, 57);
            this.btnNOPBAI.TabIndex = 10;
            this.btnNOPBAI.Text = "NỘP BÀI";
            this.btnNOPBAI.UseVisualStyleBackColor = true;
            this.btnNOPBAI.Click += new System.EventHandler(this.btnNOPBAI_Click);
            // 
            // summarylistview
            // 
            this.summarylistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summarylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.question,
            this.answer});
            this.summarylistview.GridLines = true;
            this.summarylistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.summarylistview.HideSelection = false;
            this.summarylistview.Location = new System.Drawing.Point(1187, 72);
            this.summarylistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summarylistview.MultiSelect = false;
            this.summarylistview.Name = "summarylistview";
            this.summarylistview.Size = new System.Drawing.Size(267, 484);
            this.summarylistview.TabIndex = 11;
            this.summarylistview.UseCompatibleStateImageBehavior = false;
            this.summarylistview.View = System.Windows.Forms.View.Details;
            this.summarylistview.SelectedIndexChanged += new System.EventHandler(this.summarylistview_SelectedIndexChanged);
            // 
            // question
            // 
            this.question.Text = "Question";
            this.question.Width = 120;
            // 
            // answer
            // 
            this.answer.Text = "Answer";
            this.answer.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblNOIDUNG);
            this.groupBox1.Controls.Add(this.lblCHUYENDENCAU);
            this.groupBox1.Controls.Add(this.numericUpDownCAUINDEX);
            this.groupBox1.Controls.Add(this.rdoD);
            this.groupBox1.Controls.Add(this.rdoC);
            this.groupBox1.Controls.Add(this.rdoB);
            this.groupBox1.Controls.Add(this.rdoA);
            this.groupBox1.Controls.Add(this.btnCAUSAU);
            this.groupBox1.Controls.Add(this.btnCAUTRUOC);
            this.groupBox1.Location = new System.Drawing.Point(28, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1153, 502);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // lblNOIDUNG
            // 
            this.lblNOIDUNG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNOIDUNG.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOIDUNG.Location = new System.Drawing.Point(6, 20);
            this.lblNOIDUNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNOIDUNG.Name = "lblNOIDUNG";
            this.lblNOIDUNG.ReadOnly = true;
            this.lblNOIDUNG.Size = new System.Drawing.Size(1122, 153);
            this.lblNOIDUNG.TabIndex = 10;
            this.lblNOIDUNG.Text = "";
            // 
            // lblCHUYENDENCAU
            // 
            this.lblCHUYENDENCAU.AutoSize = true;
            this.lblCHUYENDENCAU.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHUYENDENCAU.Location = new System.Drawing.Point(390, 397);
            this.lblCHUYENDENCAU.Name = "lblCHUYENDENCAU";
            this.lblCHUYENDENCAU.Size = new System.Drawing.Size(134, 21);
            this.lblCHUYENDENCAU.TabIndex = 9;
            this.lblCHUYENDENCAU.Text = "Chuyển đến câu:";
            // 
            // numericUpDownCAUINDEX
            // 
            this.numericUpDownCAUINDEX.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCAUINDEX.Location = new System.Drawing.Point(556, 395);
            this.numericUpDownCAUINDEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCAUINDEX.Name = "numericUpDownCAUINDEX";
            this.numericUpDownCAUINDEX.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownCAUINDEX.TabIndex = 8;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoD.Location = new System.Drawing.Point(898, 271);
            this.rdoD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(43, 25);
            this.rdoD.TabIndex = 6;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D";
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.rdoD_CheckedChanged);
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoC.Location = new System.Drawing.Point(144, 271);
            this.rdoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(41, 25);
            this.rdoC.TabIndex = 5;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.rdoC_CheckedChanged);
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoB.Location = new System.Drawing.Point(900, 221);
            this.rdoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(41, 25);
            this.rdoB.TabIndex = 4;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B";
            this.rdoB.UseVisualStyleBackColor = true;
            this.rdoB.CheckedChanged += new System.EventHandler(this.rdoB_CheckedChanged);
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoA.Location = new System.Drawing.Point(143, 221);
            this.rdoA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(42, 25);
            this.rdoA.TabIndex = 3;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A";
            this.rdoA.UseVisualStyleBackColor = true;
            this.rdoA.CheckedChanged += new System.EventHandler(this.rdoA_CheckedChanged);
            // 
            // btnCAUSAU
            // 
            this.btnCAUSAU.Location = new System.Drawing.Point(731, 380);
            this.btnCAUSAU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAUSAU.Name = "btnCAUSAU";
            this.btnCAUSAU.Size = new System.Drawing.Size(128, 57);
            this.btnCAUSAU.TabIndex = 1;
            this.btnCAUSAU.Text = "Câu Sau";
            this.btnCAUSAU.UseVisualStyleBackColor = true;
            this.btnCAUSAU.Click += new System.EventHandler(this.btnCAUSAU_Click);
            // 
            // btnCAUTRUOC
            // 
            this.btnCAUTRUOC.Location = new System.Drawing.Point(214, 380);
            this.btnCAUTRUOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAUTRUOC.Name = "btnCAUTRUOC";
            this.btnCAUTRUOC.Size = new System.Drawing.Size(142, 57);
            this.btnCAUTRUOC.TabIndex = 0;
            this.btnCAUTRUOC.Text = "Câu trước";
            this.btnCAUTRUOC.UseVisualStyleBackColor = true;
            this.btnCAUTRUOC.Click += new System.EventHandler(this.btnCAUTRUOC_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.AutoSize = true;
            this.txtDiem.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.ForeColor = System.Drawing.Color.Red;
            this.txtDiem.Location = new System.Drawing.Point(1061, 22);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(61, 25);
            this.txtDiem.TabIndex = 11;
            this.txtDiem.Text = "ĐIỂM";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDiem);
            this.groupBox2.Controls.Add(this.lblNGAYTHI);
            this.groupBox2.Controls.Add(this.lblTRINHDO);
            this.groupBox2.Controls.Add(this.lblLOP);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1144, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lblNGAYTHI
            // 
            this.lblNGAYTHI.AutoSize = true;
            this.lblNGAYTHI.Location = new System.Drawing.Point(760, 29);
            this.lblNGAYTHI.Name = "lblNGAYTHI";
            this.lblNGAYTHI.Size = new System.Drawing.Size(58, 17);
            this.lblNGAYTHI.TabIndex = 3;
            this.lblNGAYTHI.Text = "ngày thi";
            // 
            // lblTRINHDO
            // 
            this.lblTRINHDO.AutoSize = true;
            this.lblTRINHDO.Location = new System.Drawing.Point(557, 29);
            this.lblTRINHDO.Name = "lblTRINHDO";
            this.lblTRINHDO.Size = new System.Drawing.Size(61, 17);
            this.lblTRINHDO.TabIndex = 2;
            this.lblTRINHDO.Text = "Trình độ";
            // 
            // lblLOP
            // 
            this.lblLOP.AutoSize = true;
            this.lblLOP.Location = new System.Drawing.Point(41, 30);
            this.lblLOP.Name = "lblLOP";
            this.lblLOP.Size = new System.Drawing.Size(36, 17);
            this.lblLOP.TabIndex = 1;
            this.lblLOP.Text = "LỚP";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCTBT
            // 
            this.bdsCTBT.DataMember = "CTBAITHI";
            this.bdsCTBT.DataSource = this.dS;
            // 
            // cTBAITHITableAdapter
            // 
            this.cTBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBAITHITableAdapter = this.cTBAITHITableAdapter;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
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
            // ThiTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.summarylistview);
            this.Controls.Add(this.lblTHONGBAO);
            this.Controls.Add(this.lblTHOIGIANTHI);
            this.Controls.Add(this.btnNOPBAI);
            this.Name = "ThiTN";
            this.Text = "ThiTN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThiTN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCAUINDEX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTHONGBAO;
        private System.Windows.Forms.Label lblTHOIGIANTHI;
        private System.Windows.Forms.Button btnNOPBAI;
        private System.Windows.Forms.ListView summarylistview;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ColumnHeader answer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox lblNOIDUNG;
        private System.Windows.Forms.Label lblCHUYENDENCAU;
        private System.Windows.Forms.NumericUpDown numericUpDownCAUINDEX;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.Button btnCAUSAU;
        private System.Windows.Forms.Button btnCAUTRUOC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNGAYTHI;
        private System.Windows.Forms.Label lblTRINHDO;
        private System.Windows.Forms.Label lblLOP;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsCTBT;
        private DSTableAdapters.CTBAITHITableAdapter cTBAITHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label txtDiem;
    }
}