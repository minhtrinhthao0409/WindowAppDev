namespace Module2BaiSo6_TrinhThaoMinh
{
    partial class MessageFormater
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblMess);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(52, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(764, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Name && Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.PeachPuff;
            this.txtMessage.Location = new System.Drawing.Point(175, 80);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(519, 31);
            this.txtMessage.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PeachPuff;
            this.txtName.Location = new System.Drawing.Point(175, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(519, 31);
            this.txtName.TabIndex = 0;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Location = new System.Drawing.Point(44, 83);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(114, 25);
            this.lblMess.TabIndex = 1;
            this.lblMess.Text = "Message:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // grbColor
            // 
            this.grbColor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbColor.Controls.Add(this.radBlack);
            this.grbColor.Controls.Add(this.radBlue);
            this.grbColor.Controls.Add(this.radGreen);
            this.grbColor.Controls.Add(this.radRed);
            this.grbColor.Location = new System.Drawing.Point(58, 232);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(194, 191);
            this.grbColor.TabIndex = 1;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(15, 140);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(88, 29);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radBlue.Location = new System.Drawing.Point(15, 105);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(77, 29);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radGreen.Location = new System.Drawing.Point(15, 70);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(94, 29);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(15, 35);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(72, 29);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // grbAction
            // 
            this.grbAction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbAction.Controls.Add(this.btnExit);
            this.grbAction.Controls.Add(this.btnClear);
            this.grbAction.Controls.Add(this.btnDisplay);
            this.grbAction.Location = new System.Drawing.Point(622, 232);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(194, 191);
            this.grbAction.TabIndex = 2;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 81);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(27, 35);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(141, 40);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.MistyRose;
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(1, 496);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(926, 101);
            this.lblMessage.TabIndex = 3;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(322, 223);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(204, 29);
            this.chkVisible.TabIndex = 4;
            this.chkVisible.Text = "Message Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // MessageFormater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 598);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MessageFormater";
            this.Text = "Message Formater";
            this.Load += new System.EventHandler(this.MessageFormater_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageFormater_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.CheckBox chkVisible;
    }
}

