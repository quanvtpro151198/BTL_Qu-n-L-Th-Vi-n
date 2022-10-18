
namespace BTL_quanlythuvien
{
    partial class frmmainQT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmainQT));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnQuảnThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýQuảnThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTàiLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripTenQT = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripMaQT = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.dữLiệuToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnQuảnThưToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.kếtThúcChươngTrìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống ";
            // 
            // tàiKhoảnQuảnThưToolStripMenuItem
            // 
            this.tàiKhoảnQuảnThưToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnQuảnThưToolStripMenuItem.Image = global::BTL_quanlythuvien.Properties.Resources.account;
            this.tàiKhoảnQuảnThưToolStripMenuItem.Name = "tàiKhoảnQuảnThưToolStripMenuItem";
            this.tàiKhoảnQuảnThưToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.tàiKhoảnQuảnThưToolStripMenuItem.Text = "1.Tài khoản quản thư";
            this.tàiKhoảnQuảnThưToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnQuảnThưToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Image = global::BTL_quanlythuvien.Properties.Resources.logout;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.đăngXuấtToolStripMenuItem.Text = "2.Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // kếtThúcChươngTrìnhToolStripMenuItem
            // 
            this.kếtThúcChươngTrìnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kếtThúcChươngTrìnhToolStripMenuItem.Image = global::BTL_quanlythuvien.Properties.Resources.power_off;
            this.kếtThúcChươngTrìnhToolStripMenuItem.Name = "kếtThúcChươngTrìnhToolStripMenuItem";
            this.kếtThúcChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.kếtThúcChươngTrìnhToolStripMenuItem.Text = "3.Kết thúc chương trình";
            this.kếtThúcChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcChươngTrìnhToolStripMenuItem_Click);
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.dữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quảnLýTácGiảToolStripMenuItem,
            this.quảnLýQuảnThưToolStripMenuItem});
            this.dữLiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.dữLiệuToolStripMenuItem.Text = "Dữ liệu ";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýSáchToolStripMenuItem.Image = global::BTL_quanlythuvien.Properties.Resources.open_book;
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.quảnLýSáchToolStripMenuItem.Text = "1.Quản lý sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = global::BTL_quanlythuvien.Properties.Resources.reader;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 32);
            this.toolStripMenuItem2.Text = "2.Quản lý độc giả";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTácGiảToolStripMenuItem.Image = global::BTL_quanlythuvien.Properties.Resources.author;
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.quảnLýTácGiảToolStripMenuItem.Text = "3.Quản lý tác giả";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // quảnLýQuảnThưToolStripMenuItem
            // 
            this.quảnLýQuảnThưToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýQuảnThưToolStripMenuItem.Image = global::BTL_quanlythuvien.Properties.Resources.librarian;
            this.quảnLýQuảnThưToolStripMenuItem.Name = "quảnLýQuảnThưToolStripMenuItem";
            this.quảnLýQuảnThưToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.quảnLýQuảnThưToolStripMenuItem.Text = "4.Quản lý quản thư ";
            this.quảnLýQuảnThưToolStripMenuItem.Click += new System.EventHandler(this.quảnLýQuảnThưToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mượnTrảSáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn trả sách";
            this.mượnTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnTrảSáchToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmTàiLiệuToolStripMenuItem,
            this.tìmKiếmĐộcGiảToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm ";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // tìmKiếmTàiLiệuToolStripMenuItem
            // 
            this.tìmKiếmTàiLiệuToolStripMenuItem.Name = "tìmKiếmTàiLiệuToolStripMenuItem";
            this.tìmKiếmTàiLiệuToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.tìmKiếmTàiLiệuToolStripMenuItem.Text = "1. Tìm kiếm tài liệu";
            this.tìmKiếmTàiLiệuToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTàiLiệuToolStripMenuItem_Click);
            // 
            // tìmKiếmĐộcGiảToolStripMenuItem
            // 
            this.tìmKiếmĐộcGiảToolStripMenuItem.Name = "tìmKiếmĐộcGiảToolStripMenuItem";
            this.tìmKiếmĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.tìmKiếmĐộcGiảToolStripMenuItem.Text = "2. Tìm kiếm độc giả";
            this.tìmKiếmĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmĐộcGiảToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.gIớiThiệuToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(293, 32);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "1.Hướng dẫn sử dụng ";
            // 
            // gIớiThiệuToolStripMenuItem
            // 
            this.gIớiThiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gIớiThiệuToolStripMenuItem.Name = "gIớiThiệuToolStripMenuItem";
            this.gIớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(293, 32);
            this.gIớiThiệuToolStripMenuItem.Text = "2.GIới thiệu ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripTenQT,
            this.stripMaQT,
            this.stripTime,
            this.stripDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripTenQT
            // 
            this.stripTenQT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stripTenQT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripTenQT.Name = "stripTenQT";
            this.stripTenQT.Size = new System.Drawing.Size(111, 23);
            this.stripTenQT.Text = "Tên quản thư";
            this.stripTenQT.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // stripMaQT
            // 
            this.stripMaQT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripMaQT.Name = "stripMaQT";
            this.stripMaQT.Size = new System.Drawing.Size(109, 23);
            this.stripMaQT.Text = "Mã quản thư";
            // 
            // stripTime
            // 
            this.stripTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripTime.Name = "stripTime";
            this.stripTime.Size = new System.Drawing.Size(769, 23);
            this.stripTime.Spring = true;
            this.stripTime.Text = "00:00";
            this.stripTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stripDate
            // 
            this.stripDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripDate.Name = "stripDate";
            this.stripDate.Size = new System.Drawing.Size(106, 23);
            this.stripDate.Text = "dd/mm/yyyy";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmmainQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 601);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmainQT";
            this.Text = "mainQT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmainQT_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnQuảnThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýQuảnThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIớiThiệuToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripTenQT;
        private System.Windows.Forms.ToolStripStatusLabel stripMaQT;
        private System.Windows.Forms.ToolStripStatusLabel stripTime;
        private System.Windows.Forms.ToolStripStatusLabel stripDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTàiLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmĐộcGiảToolStripMenuItem;
    }
}