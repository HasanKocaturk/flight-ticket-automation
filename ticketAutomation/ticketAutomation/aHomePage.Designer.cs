namespace ticketAutomation
{
    partial class aHomePage
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
            this.dataGWFlights = new System.Windows.Forms.DataGridView();
            this.pnlLeftUHP = new System.Windows.Forms.Panel();
            this.lblCFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCFrom = new System.Windows.Forms.ComboBox();
            this.cmbCTo = new System.Windows.Forms.ComboBox();
            this.dtpFDate = new System.Windows.Forms.DateTimePicker();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbFlightNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUHPExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGWFlights
            // 
            this.dataGWFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGWFlights.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGWFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGWFlights.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGWFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGWFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWFlights.GridColor = System.Drawing.SystemColors.Control;
            this.dataGWFlights.Location = new System.Drawing.Point(266, 39);
            this.dataGWFlights.Name = "dataGWFlights";
            this.dataGWFlights.RowHeadersVisible = false;
            this.dataGWFlights.RowHeadersWidth = 51;
            this.dataGWFlights.RowTemplate.Height = 24;
            this.dataGWFlights.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGWFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGWFlights.Size = new System.Drawing.Size(597, 255);
            this.dataGWFlights.TabIndex = 4;
            // 
            // pnlLeftUHP
            // 
            this.pnlLeftUHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.pnlLeftUHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftUHP.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftUHP.Name = "pnlLeftUHP";
            this.pnlLeftUHP.Size = new System.Drawing.Size(260, 459);
            this.pnlLeftUHP.TabIndex = 3;
            // 
            // lblCFrom
            // 
            this.lblCFrom.AutoSize = true;
            this.lblCFrom.Location = new System.Drawing.Point(267, 311);
            this.lblCFrom.Name = "lblCFrom";
            this.lblCFrom.Size = new System.Drawing.Size(137, 16);
            this.lblCFrom.TabIndex = 5;
            this.lblCFrom.Text = "Kalış Yapılacak Şehir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "İniş Yapılacak Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kalkış Yapılacak Zaman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fiyatı:";
            // 
            // cmbCFrom
            // 
            this.cmbCFrom.FormattingEnabled = true;
            this.cmbCFrom.Location = new System.Drawing.Point(270, 340);
            this.cmbCFrom.Name = "cmbCFrom";
            this.cmbCFrom.Size = new System.Drawing.Size(134, 24);
            this.cmbCFrom.TabIndex = 9;
            // 
            // cmbCTo
            // 
            this.cmbCTo.FormattingEnabled = true;
            this.cmbCTo.Location = new System.Drawing.Point(444, 340);
            this.cmbCTo.Name = "cmbCTo";
            this.cmbCTo.Size = new System.Drawing.Size(125, 24);
            this.cmbCTo.TabIndex = 10;
            // 
            // dtpFDate
            // 
            this.dtpFDate.Location = new System.Drawing.Point(618, 340);
            this.dtpFDate.Name = "dtpFDate";
            this.dtpFDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFDate.TabIndex = 11;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(270, 405);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(134, 22);
            this.txtbPrice.TabIndex = 12;
            // 
            // txtbFlightNo
            // 
            this.txtbFlightNo.Location = new System.Drawing.Point(444, 405);
            this.txtbFlightNo.Name = "txtbFlightNo";
            this.txtbFlightNo.Size = new System.Drawing.Size(125, 22);
            this.txtbFlightNo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "FilghtCode";
            // 
            // btnFAdd
            // 
            this.btnFAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnFAdd.FlatAppearance.BorderSize = 0;
            this.btnFAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFAdd.ForeColor = System.Drawing.Color.White;
            this.btnFAdd.Location = new System.Drawing.Point(610, 376);
            this.btnFAdd.Name = "btnFAdd";
            this.btnFAdd.Size = new System.Drawing.Size(111, 60);
            this.btnFAdd.TabIndex = 15;
            this.btnFAdd.Text = "Kayıt Yap";
            this.btnFAdd.UseVisualStyleBackColor = false;
            this.btnFAdd.Click += new System.EventHandler(this.btnFAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(727, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 60);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "İptal Et/Etme";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUHPExit
            // 
            this.btnUHPExit.FlatAppearance.BorderSize = 0;
            this.btnUHPExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUHPExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUHPExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.btnUHPExit.Location = new System.Drawing.Point(827, 0);
            this.btnUHPExit.Name = "btnUHPExit";
            this.btnUHPExit.Size = new System.Drawing.Size(40, 40);
            this.btnUHPExit.TabIndex = 18;
            this.btnUHPExit.Text = "X";
            this.btnUHPExit.UseVisualStyleBackColor = true;
            this.btnUHPExit.Click += new System.EventHandler(this.btnUHPExit_Click);
            // 
            // aHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 459);
            this.Controls.Add(this.btnUHPExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFAdd);
            this.Controls.Add(this.txtbFlightNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.dtpFDate);
            this.Controls.Add(this.cmbCTo);
            this.Controls.Add(this.cmbCFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCFrom);
            this.Controls.Add(this.dataGWFlights);
            this.Controls.Add(this.pnlLeftUHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aHomePage";
            this.Load += new System.EventHandler(this.aHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGWFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGWFlights;
        private System.Windows.Forms.Panel pnlLeftUHP;
        private System.Windows.Forms.Label lblCFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCFrom;
        private System.Windows.Forms.ComboBox cmbCTo;
        private System.Windows.Forms.DateTimePicker dtpFDate;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbFlightNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUHPExit;
    }
}