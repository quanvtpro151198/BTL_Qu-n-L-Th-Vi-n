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
    public partial class frmmainND : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql, constr;

        public frmmainND(string MaND)
        {
            InitializeComponent();
            stripMaND.Text = MaND;
        }

        private void tàiKhoảnQuảnThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKDG f = new frmTKDG(stripMaND.Text.ToString());
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stripTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Close();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemTL f = new frmTimKiemTL();
            f.Show();
        }

        private void stripTenND_Click(object sender, EventArgs e)
        {

        }

        private void frmmainND_Load(object sender, EventArgs e)
        {
            timer1.Start();
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select TenDG from DocGia where MaDG = '" + stripMaND.Text + "'";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader TenND = cmd.ExecuteReader();//đọc dữ liệu 
            while (TenND.Read())
            {
                stripTenND.Text= TenND["TenDG"].ToString() + "  - ";
            }
        }
    }
}
