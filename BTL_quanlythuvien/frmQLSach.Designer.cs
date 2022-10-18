namespace BTL_quanlythuvien
{
    partial class frmQLSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSach));
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtKeSach = new System.Windows.Forms.TextBox();
            this.lblKS = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTL,
            this.TenTL,
            this.LoaiSach,
            this.TheLoai,
            this.NhaXuatBan,
            this.NamXuatBan,
            this.KeSach});
            this.grdData.Location = new System.Drawing.Point(1, 80);
            this.grdData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(987, 477);
            this.grdData.TabIndex = 7;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Mã Tài Liệu";
            this.MaTL.MinimumWidth = 6;
            this.MaTL.Name = "MaTL";
            // 
            // TenTL
            // 
            this.TenTL.DataPropertyName = "TenTL";
            this.TenTL.HeaderText = "Tên Tài Liệu";
            this.TenTL.MinimumWidth = 6;
            this.TenTL.Name = "TenTL";
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "LoaiSach";
            this.LoaiSach.HeaderText = "Loại Sách";
            this.LoaiSach.MinimumWidth = 6;
            this.LoaiSach.Name = "LoaiSach";
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.MinimumWidth = 6;
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm Xuất Bản";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            // 
            // KeSach
            // 
            this.KeSach.DataPropertyName = "KeSach";
            this.KeSach.HeaderText = "Kệ Sách";
            this.KeSach.MinimumWidth = 6;
            this.KeSach.Name = "KeSach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1002, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Sách";
            // 
            // txtMaS
            // 
            this.txtMaS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtMaS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaS.ForeColor = System.Drawing.Color.White;
            this.txtMaS.Location = new System.Drawing.Point(1161, 122);
            this.txtMaS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(249, 25);
            this.txtMaS.TabIndex = 9;
            // 
            // txtTenS
            // 
            this.txtTenS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtTenS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenS.ForeColor = System.Drawing.Color.White;
            this.txtTenS.Location = new System.Drawing.Point(1161, 175);
            this.txtTenS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(249, 25);
            this.txtTenS.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1002, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Tài Liệu";
            // 
            // txtNamXB
            // 
            this.txtNamXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtNamXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamXB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.ForeColor = System.Drawing.Color.White;
            this.txtNamXB.Location = new System.Drawing.Point(1161, 386);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(249, 25);
            this.txtNamXB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1002, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Năm Xuất Bản";
            // 
            // txtNXB
            // 
            this.txtNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNXB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.ForeColor = System.Drawing.Color.White;
            this.txtNXB.Location = new System.Drawing.Point(1161, 333);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(249, 25);
            this.txtNXB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1002, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nhà Xuất Bản";
            // 
            // txtTL
            // 
            this.txtTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtTL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.ForeColor = System.Drawing.Color.White;
            this.txtTL.Location = new System.Drawing.Point(1161, 280);
            this.txtTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(249, 25);
            this.txtTL.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1002, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Thể Loại";
            // 
            // txtLoaiS
            // 
            this.txtLoaiS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtLoaiS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoaiS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiS.ForeColor = System.Drawing.Color.White;
            this.txtLoaiS.Location = new System.Drawing.Point(1161, 227);
            this.txtLoaiS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiS.Name = "txtLoaiS";
            this.txtLoaiS.Size = new System.Drawing.Size(249, 25);
            this.txtLoaiS.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1002, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Loại Sách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1161, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 2);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1161, 204);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(249, 2);
            this.textBox2.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1161, 256);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(249, 2);
            this.textBox4.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1161, 414);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(249, 2);
            this.textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1161, 362);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(249, 2);
            this.textBox7.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1161, 309);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(249, 2);
            this.textBox8.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 41);
            this.label4.TabIndex = 33;
            this.label4.Text = "QUẢN LÝ TÀI LIỆU";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(4, 51);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 2);
            this.textBox5.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1001, 502);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 37);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoEllipsis = true;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1221, 502);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 37);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoEllipsis = true;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1111, 502);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 37);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1332, 502);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 37);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Cập nhật";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbField
            // 
            this.cmbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Items.AddRange(new object[] {
            "MaTL",
            "TenTL",
            "LoaiSach",
            "TheLoai",
            "NhaXuatBan",
            "NamXuatBan",
            "KeSach"});
            this.cmbField.Location = new System.Drawing.Point(1001, 80);
            this.cmbField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(110, 30);
            this.cmbField.TabIndex = 42;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // cmbGT
            // 
            this.cmbGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Location = new System.Drawing.Point(1116, 80);
            this.cmbGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(282, 30);
            this.cmbGT.TabIndex = 43;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.Location = new System.Drawing.Point(923, 576);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(49, 44);
            this.btnLast.TabIndex = 48;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(860, 576);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 44);
            this.btnNext.TabIndex = 47;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPrv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrv.BackgroundImage")));
            this.btnPrv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrv.Location = new System.Drawing.Point(796, 576);
            this.btnPrv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(49, 44);
            this.btnPrv.TabIndex = 46;
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.Location = new System.Drawing.Point(733, 576);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(49, 44);
            this.btnFirst.TabIndex = 45;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1161, 468);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(249, 2);
            this.textBox3.TabIndex = 52;
            // 
            // txtKeSach
            // 
            this.txtKeSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.txtKeSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeSach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeSach.ForeColor = System.Drawing.Color.White;
            this.txtKeSach.Location = new System.Drawing.Point(1161, 439);
            this.txtKeSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeSach.Name = "txtKeSach";
            this.txtKeSach.Size = new System.Drawing.Size(249, 25);
            this.txtKeSach.TabIndex = 16;
            // 
            // lblKS
            // 
            this.lblKS.AutoSize = true;
            this.lblKS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKS.ForeColor = System.Drawing.Color.White;
            this.lblKS.Location = new System.Drawing.Point(1002, 447);
            this.lblKS.Name = "lblKS";
            this.lblKS.Size = new System.Drawing.Size(77, 23);
            this.lblKS.TabIndex = 51;
            this.lblKS.Text = "Kệ Sách";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Yellow;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(10, 562);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(360, 58);
            this.btnReport.TabIndex = 53;
            this.btnReport.Text = "Xuất báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(1446, 78);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 31);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSort.BackgroundImage")));
            this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Location = new System.Drawing.Point(1406, 78);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(35, 31);
            this.btnSort.TabIndex = 41;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1332, 583);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 37);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(136)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1495, 762);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtKeSach);
            this.Controls.Add(this.lblKS);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbGT);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLoaiS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdData);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1513, 809);
            this.MinimumSize = new System.Drawing.Size(1513, 809);
            this.Name = "frmQLSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSach";
            this.Load += new System.EventHandler(this.frmQLSach_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQLSach_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeSach;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtKeSach;
        private System.Windows.Forms.Label lblKS;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
    }
}