
namespace BTL_quanlythuvien
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNQT = new System.Windows.Forms.TextBox();
            this.txtMKQT = new System.Windows.Forms.TextBox();
            this.chkMKQT = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDNQT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDNND = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDNND = new System.Windows.Forms.TextBox();
            this.chkMKND = new System.Windows.Forms.CheckBox();
            this.txtMKND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã quản thư ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtDNQT
            // 
            this.txtDNQT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNQT.Location = new System.Drawing.Point(6, 131);
            this.txtDNQT.Name = "txtDNQT";
            this.txtDNQT.Size = new System.Drawing.Size(358, 34);
            this.txtDNQT.TabIndex = 3;
            // 
            // txtMKQT
            // 
            this.txtMKQT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKQT.Location = new System.Drawing.Point(6, 213);
            this.txtMKQT.Name = "txtMKQT";
            this.txtMKQT.Size = new System.Drawing.Size(358, 34);
            this.txtMKQT.TabIndex = 4;
            this.txtMKQT.UseSystemPasswordChar = true;
            // 
            // chkMKQT
            // 
            this.chkMKQT.AutoSize = true;
            this.chkMKQT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMKQT.Location = new System.Drawing.Point(6, 253);
            this.chkMKQT.Name = "chkMKQT";
            this.chkMKQT.Size = new System.Drawing.Size(134, 21);
            this.chkMKQT.TabIndex = 5;
            this.chkMKQT.Text = "Hiển thị mật khẩu";
            this.chkMKQT.UseVisualStyleBackColor = true;
            this.chkMKQT.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(687, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 539);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDNQT);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkMKQT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMKQT);
            this.tabPage1.Controls.Add(this.txtDNQT);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản thư";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDNQT
            // 
            this.btnDNQT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNQT.Location = new System.Drawing.Point(110, 363);
            this.btnDNQT.Name = "btnDNQT";
            this.btnDNQT.Size = new System.Drawing.Size(180, 54);
            this.btnDNQT.TabIndex = 9;
            this.btnDNQT.Text = "Đăng nhập";
            this.btnDNQT.UseVisualStyleBackColor = true;
            this.btnDNQT.Click += new System.EventHandler(this.btnDNQT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "quản thư";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnDNND);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDNND);
            this.tabPage2.Controls.Add(this.chkMKND);
            this.tabPage2.Controls.Add(this.txtMKND);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Người đọc ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(6, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(358, 61);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nếu bạn chưa có tài khoản vui lòng liên hệ với quản thư để đăng ký.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "người đọc ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đăng nhập";
            // 
            // btnDNND
            // 
            this.btnDNND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNND.Location = new System.Drawing.Point(96, 327);
            this.btnDNND.Name = "btnDNND";
            this.btnDNND.Size = new System.Drawing.Size(180, 54);
            this.btnDNND.TabIndex = 16;
            this.btnDNND.Text = "Đăng nhập ";
            this.btnDNND.UseVisualStyleBackColor = true;
            this.btnDNND.Click += new System.EventHandler(this.btnDNND_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mật khẩu";
            // 
            // txtDNND
            // 
            this.txtDNND.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNND.Location = new System.Drawing.Point(6, 131);
            this.txtDNND.Name = "txtDNND";
            this.txtDNND.Size = new System.Drawing.Size(358, 34);
            this.txtDNND.TabIndex = 13;
            this.txtDNND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNND_KeyPress);
            // 
            // chkMKND
            // 
            this.chkMKND.AutoSize = true;
            this.chkMKND.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMKND.Location = new System.Drawing.Point(6, 253);
            this.chkMKND.Name = "chkMKND";
            this.chkMKND.Size = new System.Drawing.Size(134, 21);
            this.chkMKND.TabIndex = 15;
            this.chkMKND.Text = "Hiển thị mật khẩu";
            this.chkMKND.UseVisualStyleBackColor = true;
            this.chkMKND.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // txtMKND
            // 
            this.txtMKND.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKND.Location = new System.Drawing.Point(6, 213);
            this.txtMKND.Name = "txtMKND";
            this.txtMKND.Size = new System.Drawing.Size(358, 34);
            this.txtMKND.TabIndex = 14;
            this.txtMKND.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã độc giả";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::BTL_quanlythuvien.Properties.Resources.tv;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNQT;
        private System.Windows.Forms.TextBox txtMKQT;
        private System.Windows.Forms.CheckBox chkMKQT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDNND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDNND;
        private System.Windows.Forms.CheckBox chkMKND;
        private System.Windows.Forms.TextBox txtMKND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDNQT;
    }
}

