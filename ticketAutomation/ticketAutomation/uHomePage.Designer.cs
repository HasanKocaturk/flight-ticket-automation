namespace ticketAutomation
{
    partial class uHomePage
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
            this.btnUHPExit = new System.Windows.Forms.Button();
            this.pnlLeftUHP = new System.Windows.Forms.Panel();
            this.lblUserReceive = new System.Windows.Forms.Label();
            this.dataGWFlights = new System.Windows.Forms.DataGridView();
            this.btnUHPBuy = new System.Windows.Forms.Button();
            this.cmbFClass = new System.Windows.Forms.ComboBox();
            this.pnlLeftUHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUHPExit
            // 
            this.btnUHPExit.FlatAppearance.BorderSize = 0;
            this.btnUHPExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUHPExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUHPExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnUHPExit.Location = new System.Drawing.Point(847, 0);
            this.btnUHPExit.Name = "btnUHPExit";
            this.btnUHPExit.Size = new System.Drawing.Size(40, 40);
            this.btnUHPExit.TabIndex = 0;
            this.btnUHPExit.Text = "X";
            this.btnUHPExit.UseVisualStyleBackColor = true;
            this.btnUHPExit.Click += new System.EventHandler(this.btnUHPExit_Click);
            // 
            // pnlLeftUHP
            // 
            this.pnlLeftUHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.pnlLeftUHP.Controls.Add(this.lblUserReceive);
            this.pnlLeftUHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftUHP.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftUHP.Name = "pnlLeftUHP";
            this.pnlLeftUHP.Size = new System.Drawing.Size(260, 506);
            this.pnlLeftUHP.TabIndex = 1;
            // 
            // lblUserReceive
            // 
            this.lblUserReceive.AutoSize = true;
            this.lblUserReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserReceive.ForeColor = System.Drawing.Color.White;
            this.lblUserReceive.Location = new System.Drawing.Point(12, 209);
            this.lblUserReceive.Name = "lblUserReceive";
            this.lblUserReceive.Size = new System.Drawing.Size(205, 32);
            this.lblUserReceive.TabIndex = 0;
            this.lblUserReceive.Text = "Aldığım Biletler";
            this.lblUserReceive.Click += new System.EventHandler(this.lblUserReceive_Click);
            // 
            // dataGWFlights
            // 
            this.dataGWFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGWFlights.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGWFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGWFlights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGWFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGWFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWFlights.Location = new System.Drawing.Point(266, 71);
            this.dataGWFlights.Name = "dataGWFlights";
            this.dataGWFlights.RowHeadersVisible = false;
            this.dataGWFlights.RowHeadersWidth = 51;
            this.dataGWFlights.RowTemplate.Height = 24;
            this.dataGWFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGWFlights.Size = new System.Drawing.Size(609, 316);
            this.dataGWFlights.TabIndex = 2;
            // 
            // btnUHPBuy
            // 
            this.btnUHPBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnUHPBuy.FlatAppearance.BorderSize = 0;
            this.btnUHPBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUHPBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUHPBuy.ForeColor = System.Drawing.Color.White;
            this.btnUHPBuy.Location = new System.Drawing.Point(266, 405);
            this.btnUHPBuy.Name = "btnUHPBuy";
            this.btnUHPBuy.Size = new System.Drawing.Size(120, 60);
            this.btnUHPBuy.TabIndex = 3;
            this.btnUHPBuy.Text = "Satın Al";
            this.btnUHPBuy.UseVisualStyleBackColor = false;
            this.btnUHPBuy.Click += new System.EventHandler(this.btnUHPBuy_Click);
            // 
            // cmbFClass
            // 
            this.cmbFClass.FormattingEnabled = true;
            this.cmbFClass.Location = new System.Drawing.Point(417, 405);
            this.cmbFClass.Name = "cmbFClass";
            this.cmbFClass.Size = new System.Drawing.Size(121, 24);
            this.cmbFClass.TabIndex = 4;
            // 
            // uHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 506);
            this.Controls.Add(this.cmbFClass);
            this.Controls.Add(this.btnUHPBuy);
            this.Controls.Add(this.dataGWFlights);
            this.Controls.Add(this.pnlLeftUHP);
            this.Controls.Add(this.btnUHPExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.uHomePage_Load);
            this.pnlLeftUHP.ResumeLayout(false);
            this.pnlLeftUHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUHPExit;
        private System.Windows.Forms.Panel pnlLeftUHP;
        private System.Windows.Forms.DataGridView dataGWFlights;
        private System.Windows.Forms.Button btnUHPBuy;
        private System.Windows.Forms.ComboBox cmbFClass;
        private System.Windows.Forms.Label lblUserReceive;
    }
}