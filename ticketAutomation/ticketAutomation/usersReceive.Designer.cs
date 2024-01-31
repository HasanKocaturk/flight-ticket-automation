namespace ticketAutomation
{
    partial class usersReceive
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataUsersReceive = new System.Windows.Forms.DataGridView();
            this.btnURCancel = new System.Windows.Forms.Button();
            this.picBBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsersReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUsersReceive
            // 
            this.dataUsersReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUsersReceive.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataUsersReceive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUsersReceive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataUsersReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataUsersReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsersReceive.Location = new System.Drawing.Point(28, 59);
            this.dataUsersReceive.Name = "dataUsersReceive";
            this.dataUsersReceive.RowHeadersVisible = false;
            this.dataUsersReceive.RowHeadersWidth = 51;
            this.dataUsersReceive.RowTemplate.Height = 24;
            this.dataUsersReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUsersReceive.Size = new System.Drawing.Size(829, 362);
            this.dataUsersReceive.TabIndex = 5;
            // 
            // btnURCancel
            // 
            this.btnURCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnURCancel.FlatAppearance.BorderSize = 0;
            this.btnURCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnURCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnURCancel.ForeColor = System.Drawing.Color.White;
            this.btnURCancel.Location = new System.Drawing.Point(28, 456);
            this.btnURCancel.Name = "btnURCancel";
            this.btnURCancel.Size = new System.Drawing.Size(111, 60);
            this.btnURCancel.TabIndex = 19;
            this.btnURCancel.Text = "İptal Et";
            this.btnURCancel.UseVisualStyleBackColor = false;
            this.btnURCancel.Click += new System.EventHandler(this.btnURCancel_Click);
            // 
            // picBBack
            // 
            this.picBBack.Image = global::ticketAutomation.Properties.Resources.back;
            this.picBBack.Location = new System.Drawing.Point(839, 3);
            this.picBBack.Name = "picBBack";
            this.picBBack.Size = new System.Drawing.Size(40, 40);
            this.picBBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBBack.TabIndex = 20;
            this.picBBack.TabStop = false;
            this.picBBack.Click += new System.EventHandler(this.picBBack_Click);
            // 
            // usersReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.picBBack);
            this.Controls.Add(this.btnURCancel);
            this.Controls.Add(this.dataUsersReceive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usersReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usersReceive";
            this.Load += new System.EventHandler(this.usersReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsersReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataUsersReceive;
        private System.Windows.Forms.Button btnURCancel;
        private System.Windows.Forms.PictureBox picBBack;
    }
}