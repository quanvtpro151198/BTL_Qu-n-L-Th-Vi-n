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
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql, constr;

    public frmDangNhap()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMKQT.Checked == true)
            {
                txtMKQT.UseSystemPasswordChar = false;
            }  
            else
            {
                txtMKQT.UseSystemPasswordChar = true;
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkMKND.Checked == true)
            {
                txtMKND.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKND.UseSystemPasswordChar = true;
            }
        }
        private void btnDNND_Click(object sender, EventArgs e)
        {
            string MaND = txtDNND.Text;
            sql = "select * from DocGiaTT where MaDG = '" + txtDNND.Text + "' AND MK = '" + txtMKND.Text + "'";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công :))");
                this.Hide();
                frmmainND f = new frmmainND(MaND);
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng :((");
                dta.Close();
            }
        }

        private void btnDNQT_Click(object sender, EventArgs e)
        {
            string MaQT = txtDNQT.Text;
            sql = "select * from QuanThuTT where MaQT = '" + txtDNQT.Text + "' AND MK = '" + txtMKQT.Text + "'";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công ");
                this.Hide();
                frmmainQT f = new frmmainQT(MaQT);
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng ");
                dta.Close();
            }
        }

        private void txtDNND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
       
    }
}
