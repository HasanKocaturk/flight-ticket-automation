namespace ticketAutomation
{
    partial class frmLog
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
            this.txtbUName = new System.Windows.Forms.TextBox();
            this.txtbUPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlLeftLogin = new System.Windows.Forms.Panel();
            this.picboxLeftIconPlane = new System.Windows.Forms.PictureBox();
            this.lblWSentenceUnder = new System.Windows.Forms.Label();
            this.lblWSentence = new System.Windows.Forms.Label();
            this.btnAppExit = new System.Windows.Forms.Button();
            this.pnlUName = new System.Windows.Forms.Panel();
            this.picbUName = new System.Windows.Forms.PictureBox();
            this.pnlUPassword = new System.Windows.Forms.Panel();
            this.picbUPassword = new System.Windows.Forms.PictureBox();
            this.lblOnUserName = new System.Windows.Forms.Label();
            this.pnlLeftLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLeftIconPlane)).BeginInit();
            this.pnlUName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUName)).BeginInit();
            this.pnlUPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbUName
            // 
            this.txtbUName.BackColor = System.Drawing.SystemColors.Control;
            this.txtbUName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbUName.Location = new System.Drawing.Point(68, 4);
            this.txtbUName.Multiline = true;
            this.txtbUName.Name = "txtbUName";
            this.txtbUName.Size = new System.Drawing.Size(483, 33);
            this.txtbUName.TabIndex = 0;
            // 
            // txtbUPassword
            // 
            this.txtbUPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtbUPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbUPassword.Location = new System.Drawing.Point(68, 3);
            this.txtbUPassword.Multiline = true;
            this.txtbUPassword.Name = "txtbUPassword";
            this.txtbUPassword.PasswordChar = '*';
            this.txtbUPassword.Size = new System.Drawing.Size(483, 33);
            this.txtbUPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(369, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 60);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(535, 355);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 60);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlLeftLogin
            // 
            this.pnlLeftLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.pnlLeftLogin.Controls.Add(this.picboxLeftIconPlane);
            this.pnlLeftLogin.Controls.Add(this.lblWSentenceUnder);
            this.pnlLeftLogin.Controls.Add(this.lblWSentence);
            this.pnlLeftLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftLogin.Name = "pnlLeftLogin";
            this.pnlLeftLogin.Size = new System.Drawing.Size(300, 553);
            this.pnlLeftLogin.TabIndex = 6;
            // 
            // picboxLeftIconPlane
            // 
            this.picboxLeftIconPlane.Image = global::ticketAutomation.Properties.Resources.airplaneAroundEarth;
            this.picboxLeftIconPlane.Location = new System.Drawing.Point(85, 77);
            this.picboxLeftIconPlane.Name = "picboxLeftIconPlane";
            this.picboxLeftIconPlane.Size = new System.Drawing.Size(148, 138);
            this.picboxLeftIconPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLeftIconPlane.TabIndex = 2;
            this.picboxLeftIconPlane.TabStop = false;
            // 
            // lblWSentenceUnder
            // 
            this.lblWSentenceUnder.AutoSize = true;
            this.lblWSentenceUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWSentenceUnder.ForeColor = System.Drawing.Color.White;
            this.lblWSentenceUnder.Location = new System.Drawing.Point(79, 270);
            this.lblWSentenceUnder.Name = "lblWSentenceUnder";
            this.lblWSentenceUnder.Size = new System.Drawing.Size(176, 32);
            this.lblWSentenceUnder.TabIndex = 1;
            this.lblWSentenceUnder.Text = "Hoş Geldiniz";
            // 
            // lblWSentence
            // 
            this.lblWSentence.AutoSize = true;
            this.lblWSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWSentence.ForeColor = System.Drawing.Color.White;
            this.lblWSentence.Location = new System.Drawing.Point(79, 220);
            this.lblWSentence.Name = "lblWSentence";
            this.lblWSentence.Size = new System.Drawing.Size(117, 32);
            this.lblWSentence.TabIndex = 0;
            this.lblWSentence.Text = "Sisteme";
            // 
            // btnAppExit
            // 
            this.btnAppExit.FlatAppearance.BorderSize = 0;
            this.btnAppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppExit.ForeColor = System.Drawing.Color.Red;
            this.btnAppExit.Location = new System.Drawing.Point(843, 0);
            this.btnAppExit.Name = "btnAppExit";
            this.btnAppExit.Size = new System.Drawing.Size(40, 40);
            this.btnAppExit.TabIndex = 7;
            this.btnAppExit.Text = "X";
            this.btnAppExit.UseVisualStyleBackColor = true;
            this.btnAppExit.Click += new System.EventHandler(this.btnAppExit_Click);
            // 
            // pnlUName
            // 
            this.pnlUName.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUName.Controls.Add(this.picbUName);
            this.pnlUName.Controls.Add(this.txtbUName);
            this.pnlUName.Location = new System.Drawing.Point(301, 216);
            this.pnlUName.Name = "pnlUName";
            this.pnlUName.Size = new System.Drawing.Size(583, 40);
            this.pnlUName.TabIndex = 8;
            // 
            // picbUName
            // 
            this.picbUName.Image = global::ticketAutomation.Properties.Resources.personIcon;
            this.picbUName.Location = new System.Drawing.Point(0, 0);
            this.picbUName.Name = "picbUName";
            this.picbUName.Size = new System.Drawing.Size(41, 40);
            this.picbUName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbUName.TabIndex = 1;
            this.picbUName.TabStop = false;
            // 
            // pnlUPassword
            // 
            this.pnlUPassword.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUPassword.Controls.Add(this.picbUPassword);
            this.pnlUPassword.Controls.Add(this.txtbUPassword);
            this.pnlUPassword.Location = new System.Drawing.Point(301, 289);
            this.pnlUPassword.Name = "pnlUPassword";
            this.pnlUPassword.Size = new System.Drawing.Size(581, 40);
            this.pnlUPassword.TabIndex = 9;
            // 
            // picbUPassword
            // 
            this.picbUPassword.Image = global::ticketAutomation.Properties.Resources.passwordIcon;
            this.picbUPassword.Location = new System.Drawing.Point(0, 0);
            this.picbUPassword.Name = "picbUPassword";
            this.picbUPassword.Size = new System.Drawing.Size(41, 40);
            this.picbUPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbUPassword.TabIndex = 2;
            this.picbUPassword.TabStop = false;
            // 
            // lblOnUserName
            // 
            this.lblOnUserName.AutoSize = true;
            this.lblOnUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.lblOnUserName.Location = new System.Drawing.Point(363, 141);
            this.lblOnUserName.Name = "lblOnUserName";
            this.lblOnUserName.Size = new System.Drawing.Size(285, 32);
            this.lblOnUserName.TabIndex = 3;
            this.lblOnUserName.Text = "Sisteme Giriş Yapınız";
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblOnUserName);
            this.Controls.Add(this.pnlUPassword);
            this.Controls.Add(this.pnlUName);
            this.Controls.Add(this.btnAppExit);
            this.Controls.Add(this.pnlLeftLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.pnlLeftLogin.ResumeLayout(false);
            this.pnlLeftLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLeftIconPlane)).EndInit();
            this.pnlUName.ResumeLayout(false);
            this.pnlUName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUName)).EndInit();
            this.pnlUPassword.ResumeLayout(false);
            this.pnlUPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbUPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbUName;
        private System.Windows.Forms.TextBox txtbUPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlLeftLogin;
        private System.Windows.Forms.Button btnAppExit;
        private System.Windows.Forms.PictureBox picboxLeftIconPlane;
        private System.Windows.Forms.Label lblWSentenceUnder;
        private System.Windows.Forms.Label lblWSentence;
        private System.Windows.Forms.Panel pnlUName;
        private System.Windows.Forms.Panel pnlUPassword;
        private System.Windows.Forms.PictureBox picbUName;
        private System.Windows.Forms.PictureBox picbUPassword;
        private System.Windows.Forms.Label lblOnUserName;
    }
}

