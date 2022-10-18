
namespace BTL_quanlythuvien
{
    partial class frmTimKiemTL
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
            this.btnTaiLieu = new System.Windows.Forms.RadioButton();
            this.btnLoaiTL = new System.Windows.Forms.RadioButton();
            this.btnTheLoai = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comTK = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm tài liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn muốn tìm kiếm theo:";
            // 
            // btnTaiLieu
            // 
            this.btnTaiLieu.AutoSize = true;
            this.btnTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLieu.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLieu.Location = new System.Drawing.Point(251, 7);
            this.btnTaiLieu.Name = "btnTaiLieu";
            this.btnTaiLieu.Size = new System.Drawing.Size(128, 28);
            this.btnTaiLieu.TabIndex = 2;
            this.btnTaiLieu.TabStop = true;
            this.btnTaiLieu.Text = "Tên tài liệu ";
            this.btnTaiLieu.UseVisualStyleBackColor = true;
            this.btnTaiLieu.CheckedChanged += new System.EventHandler(this.btnTaiLieu_CheckedChanged);
            // 
            // btnLoaiTL
            // 
            this.btnLoaiTL.AutoSize = true;
            this.btnLoaiTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiTL.ForeColor = System.Drawing.Color.Black;
            this.btnLoaiTL.Location = new System.Drawing.Point(458, 6);
            this.btnLoaiTL.Name = "btnLoaiTL";
            this.btnLoaiTL.Size = new System.Drawing.Size(129, 28);
            this.btnLoaiTL.TabIndex = 3;
            this.btnLoaiTL.TabStop = true;
            this.btnLoaiTL.Text = "Loại tài liệu ";
            this.btnLoaiTL.UseVisualStyleBackColor = true;
            this.btnLoaiTL.CheckedChanged += new System.EventHandler(this.btnLoaiTL_CheckedChanged);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.AutoSize = true;
            this.btnTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.ForeColor = System.Drawing.Color.Black;
            this.btnTheLoai.Location = new System.Drawing.Point(671, 6);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(157, 28);
            this.btnTheLoai.TabIndex = 4;
            this.btnTheLoai.TabStop = true;
            this.btnTheLoai.Text = "Thể loại tài liệu";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.CheckedChanged += new System.EventHandler(this.btnTheLoai_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTaiLieu);
            this.panel1.Controls.Add(this.btnTheLoai);
            this.panel1.Controls.Add(this.btnLoaiTL);
            this.panel1.Location = new System.Drawing.Point(238, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 39);
            this.panel1.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(238, 108);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(616, 39);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtTimKiem.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(870, 108);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(97, 38);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "search";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTL,
            this.LoaiSach,
            this.TheLoai,
            this.NhaXuatBan,
            this.NamXuatBan,
            this.KeSach});
            this.grdData.Location = new System.Drawing.Point(124, 197);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(1074, 477);
            this.grdData.TabIndex = 9;
            // 
            // TenTL
            // 
            this.TenTL.DataPropertyName = "TenTL";
            this.TenTL.HeaderText = "Tên tài liệu";
            this.TenTL.MinimumWidth = 6;
            this.TenTL.Name = "TenTL";
            this.TenTL.ReadOnly = true;
            this.TenTL.Width = 125;
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "LoaiSach";
            this.LoaiSach.HeaderText = "Loại tài liệu";
            this.LoaiSach.MinimumWidth = 6;
            this.LoaiSach.Name = "LoaiSach";
            this.LoaiSach.ReadOnly = true;
            this.LoaiSach.Width = 125;
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            this.TheLoai.Width = 125;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            this.NhaXuatBan.Width = 125;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm xuất bản";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            this.NamXuatBan.Width = 125;
            // 
            // KeSach
            // 
            this.KeSach.DataPropertyName = "KeSach";
            this.KeSach.HeaderText = "Kệ sách";
            this.KeSach.MinimumWidth = 6;
            this.KeSach.Name = "KeSach";
            this.KeSach.ReadOnly = true;
            this.KeSach.Width = 125;
            // 
            // comTK
            // 
            this.comTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTK.FormattingEnabled = true;
            this.comTK.Location = new System.Drawing.Point(982, 109);
            this.comTK.Name = "comTK";
            this.comTK.Size = new System.Drawing.Size(132, 34);
            this.comTK.TabIndex = 10;
            this.comTK.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(846, 153);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(149, 38);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy tìm kiếm";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmTimKiemTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1292, 730);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.comTK);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiemTL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton btnTaiLieu;
        private System.Windows.Forms.RadioButton btnLoaiTL;
        private System.Windows.Forms.RadioButton btnTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.ComboBox comTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeSach;
        private System.Windows.Forms.Button btnHuy;
    }
}