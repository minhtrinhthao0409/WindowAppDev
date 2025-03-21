namespace Module2BaiSo3_TrinhThaoMinh
{
    partial class frmFullName
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(240, 22);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(134, 25);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "HỌ VÀ TÊN";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoLot.Location = new System.Drawing.Point(53, 78);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(83, 24);
            this.lblHoLot.TabIndex = 1;
            this.lblHoLot.Text = "Họ Lót:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(53, 134);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(48, 24);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(166, 78);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(376, 20);
            this.txtHoLot.TabIndex = 3;
            this.txtHoLot.TextChanged += new System.EventHandler(this.txtHoLot_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(166, 134);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(376, 20);
            this.txtTen.TabIndex = 4;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnHoLot
            // 
            this.btnHoLot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoLot.Location = new System.Drawing.Point(53, 206);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(122, 39);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "&Họ Lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.Location = new System.Drawing.Point(235, 206);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(122, 39);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "&Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoTen.Location = new System.Drawing.Point(420, 206);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(122, 39);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(187, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát Chương Trình";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFullName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmFullName";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnExit;
    }
}

