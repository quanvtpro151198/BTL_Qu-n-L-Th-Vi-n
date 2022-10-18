using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BTL_quanlythuvien
{
    public partial class frmmainQT : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql, constr;

        public frmmainQT(string MaQT)
        {
            InitializeComponent();
            stripMaQT.Text = MaQT;
        }

        private void tàiKhoảnQuảnThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKQT f = new frmTKQT(stripMaQT.Text.ToString());
            f.Show();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Close();
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stripTime.Text = DateTime.Now.ToString("HH:mm");
            stripDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemTL f = new frmTimKiemTL();
            f.Show();
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemDG f = new frmTimKiemDG();
            f.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach f = new frmQLSach();
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmQLDG f = new frmQLDG();
            f.Show();
        }

        private void mượnTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTG f = new frmQLTG();
            f.Show();
        }

        private void quảnLýQuảnThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLQT f = new frmQLQT();
            f.Show();
        }

        private void trảTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLMS f = new frmQLMS();
            f.Show();
        }

        private void frmmainQT_Load(object sender, EventArgs e)
        {
            timer1.Start();
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select TenQT from QuanThu where MaQT = '" + stripMaQT.Text + "'";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader TenQT = cmd.ExecuteReader();//đọc dữ liệu 
            while(TenQT.Read())
            {
                stripTenQT.Text = TenQT["TenQT"].ToString() + "  - ";
            }
        }
    }
}
