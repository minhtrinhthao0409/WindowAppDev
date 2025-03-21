namespace Module2BaiSo2_TrinhThaoMinh
{
    partial class frmBaiTap1
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblYourName = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.lblYoB = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShow.Location = new System.Drawing.Point(62, 249);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(169, 76);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 73);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(73, 82);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(88, 18);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Your Name:";
            // 
            // txtYourName
            // 
            this.txtYourName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYourName.Location = new System.Drawing.Point(268, 80);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(436, 25);
            this.txtYourName.TabIndex = 1;
            this.txtYourName.TextChanged += new System.EventHandler(this.txtYourName_TextChanged);
            this.txtYourName.Leave += new System.EventHandler(this.txtYourName_Leave);
            // 
            // lblYoB
            // 
            this.lblYoB.AutoSize = true;
            this.lblYoB.Location = new System.Drawing.Point(73, 157);
            this.lblYoB.Name = "lblYoB";
            this.lblYoB.Size = new System.Drawing.Size(95, 18);
            this.lblYoB.TabIndex = 2;
            this.lblYoB.Text = "Date of birth:";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Location = new System.Drawing.Point(268, 157);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(436, 25);
            this.txtYear.TabIndex = 3;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(522, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 73);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBaiTap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 398);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYoB);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.lblYourName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Font = new System.Drawing.Font("Tahoma", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmBaiTap1";
            this.Text = "My Name Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaiTap1_FormClosing);
            this.Load += new System.EventHandler(this.frmBaiTap1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.Label lblYoB;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

