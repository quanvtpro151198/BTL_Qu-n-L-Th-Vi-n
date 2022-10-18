namespace BTL_quanlythuvien
{
    partial class frmDKMS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MQT = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpN = new System.Windows.Forms.DateTimePicker();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.cmbMaS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.MQT);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaDG);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 497);
            this.panel1.TabIndex = 0;
            // 
            // MQT
            // 
            this.MQT.AutoSize = true;
            this.MQT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.MQT.Location = new System.Drawing.Point(11, 473);
            this.MQT.Name = "MQT";
            this.MQT.Size = new System.Drawing.Size(46, 17);
            this.MQT.TabIndex = 6;
            this.MQT.Text = "label6";
            this.MQT.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(124, 336);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(51, 260);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mã độc giả";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(33, 214);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(157, 30);
            this.txtMaDG.TabIndex = 1;
            this.txtMaDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_quanlythuvien.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(33, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 50);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(265, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 51);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ĐĂNG KÍ MƯỢN SÁCH";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(259, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 29);
            this.label15.TabIndex = 70;
            this.label15.Text = "Họ và tên:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(259, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 29);
            this.label14.TabIndex = 72;
            this.label14.Text = "Giới tính:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 29);
            this.label13.TabIndex = 73;
            this.label13.Text = "Địa chỉ: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 29);
            this.label12.TabIndex = 75;
            this.label12.Text = "Số điện thoại:";
            // 
            // txtTenDG
            // 
            this.txtTenDG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenDG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(449, 82);
            this.txtTenDG.Multiline = true;
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(340, 35);
            this.txtTenDG.TabIndex = 71;
            this.txtTenDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDC
            // 
            this.txtDC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(449, 181);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.ReadOnly = true;
            this.txtDC.Size = new System.Drawing.Size(340, 35);
            this.txtDC.TabIndex = 74;
            this.txtDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(449, 230);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(340, 35);
            this.txtTel.TabIndex = 76;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 29);
            this.label16.TabIndex = 79;
            this.label16.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(449, 280);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(340, 35);
            this.txtEmail.TabIndex = 80;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGT
            // 
            this.txtGT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGT.Location = new System.Drawing.Point(449, 131);
            this.txtGT.Multiline = true;
            this.txtGT.Name = "txtGT";
            this.txtGT.ReadOnly = true;
            this.txtGT.Size = new System.Drawing.Size(340, 35);
            this.txtGT.TabIndex = 81;
            this.txtGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên tài liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 84;
            this.label3.Text = "Ngày mượn";
            // 
            // dtpN
            // 
            this.dtpN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpN.Location = new System.Drawing.Point(449, 426);
            this.dtpN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpN.Name = "dtpN";
            this.dtpN.Size = new System.Drawing.Size(340, 38);
            this.dtpN.TabIndex = 85;
            // 
            // cmbBook
            // 
            this.cmbBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbBook.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.ItemHeight = 24;
            this.cmbBook.Location = new System.Drawing.Point(449, 331);
            this.cmbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBook.MaxDropDownItems = 10;
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(340, 32);
            this.cmbBook.Sorted = true;
            this.cmbBook.TabIndex = 87;
            this.cmbBook.SelectedValueChanged += new System.EventHandler(this.cmbBook_SelectedValueChanged);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Location = new System.Drawing.Point(641, 466);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(147, 41);
            this.btnIssueBook.TabIndex = 88;
            this.btnIssueBook.Text = "Mượn Sách";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // cmbMaS
            // 
            this.cmbMaS.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbMaS.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaS.FormattingEnabled = true;
            this.cmbMaS.ItemHeight = 24;
            this.cmbMaS.Location = new System.Drawing.Point(449, 379);
            this.cmbMaS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaS.MaxDropDownItems = 10;
            this.cmbMaS.Name = "cmbMaS";
            this.cmbMaS.Size = new System.Drawing.Size(340, 32);
            this.cmbMaS.Sorted = true;
            this.cmbMaS.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 89;
            this.label5.Text = "Mã tài liệu";
            // 
            // frmDKMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(835, 541);
            this.Controls.Add(this.cmbMaS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.dtpN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtTenDG);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDKMS";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpN;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.ComboBox cmbMaS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MQT;
    }
}