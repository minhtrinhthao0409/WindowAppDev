namespace Module2BaiSo5_TrinhThaoMinh
{
    partial class frmFormater
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
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.chkUderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxColor.Controls.Add(this.radBlack);
            this.groupBoxColor.Controls.Add(this.radBlue);
            this.groupBoxColor.Controls.Add(this.radGreen);
            this.groupBoxColor.Controls.Add(this.radRed);
            this.groupBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.Location = new System.Drawing.Point(63, 98);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(200, 137);
            this.groupBoxColor.TabIndex = 0;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(6, 88);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(57, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(6, 65);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(50, 17);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(6, 42);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(59, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(6, 19);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(48, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.raddo_CheckedChanged);
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.BackColor = System.Drawing.Color.Bisque;
            this.groupBoxFont.Controls.Add(this.chkUderline);
            this.groupBoxFont.Controls.Add(this.chkItalic);
            this.groupBoxFont.Controls.Add(this.chkBold);
            this.groupBoxFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFont.Location = new System.Drawing.Point(337, 98);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(200, 137);
            this.groupBoxFont.TabIndex = 1;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Font";
            // 
            // chkUderline
            // 
            this.chkUderline.AutoSize = true;
            this.chkUderline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUderline.Location = new System.Drawing.Point(6, 66);
            this.chkUderline.Name = "chkUderline";
            this.chkUderline.Size = new System.Drawing.Size(117, 17);
            this.chkUderline.TabIndex = 2;
            this.chkUderline.Text = "Gạch dưới Uderline";
            this.chkUderline.UseVisualStyleBackColor = true;
            this.chkUderline.CheckedChanged += new System.EventHandler(this.chkUderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(6, 43);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(91, 17);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBold.Location = new System.Drawing.Point(6, 20);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(80, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblNhapTen.Location = new System.Drawing.Point(61, 34);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(121, 25);
            this.lblNhapTen.TabIndex = 2;
            this.lblNhapTen.Text = "Nhập Tên:";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapTen.Location = new System.Drawing.Point(214, 34);
            this.txtNhapTen.Multiline = true;
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(383, 25);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lập Trình bởi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLapTrinh.Location = new System.Drawing.Point(228, 276);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(378, 25);
            this.lblLapTrinh.TabIndex = 4;
            this.lblLapTrinh.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(645, 274);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 54);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmFormater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 356);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblNhapTen);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.groupBoxColor);
            this.Name = "frmFormater";
            this.Text = "ĐỊnh dạng (Formater)";
            this.Load += new System.EventHandler(this.frmFormater_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFormater_KeyDown);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkUderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

