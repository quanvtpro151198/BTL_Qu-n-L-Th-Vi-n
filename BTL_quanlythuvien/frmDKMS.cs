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
    public partial class frmDKMS : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, constr,sql1,MaTL; //connection string

        int i;
        public frmDKMS(string MaQT)
        {
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            cmd.Connection = conn;
            conn.Open();
            InitializeComponent();
            MQT.Text = MaQT;           
        }
        private void btnIssueBook_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Xác nhận yêu cầu mượn sách", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                sql = "insert into PhieuMuon(MaDG, MaQT, NgayMuon) " +
                    "VALUES ( '" + txtMaDG.Text + "', '" + MQT.Text + "', '"+ dtpN.Value.ToString("dd/MM/yyyy")+"')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thêm mới thành công");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = "select * from DocGia where MaDG = '" +txtMaDG.Text+ "'";
            cmd.CommandText = sql;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count !=0)
            {
                txtTenDG.Text = ds.Tables[0].Rows[0][1].ToString();
                txtGT.Text = ds.Tables[0].Rows[0][2].ToString();
                txtDC.Text = ds.Tables[0].Rows[0][6].ToString();
                txtTel.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            }

           
        }

        private void cmbBook_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql1 = "select MaTL From TaiLieu where TenTL = N'" + cmbBook.Text + "'";
            da = new SqlDataAdapter(sql1, conn);
            comdt.Clear();
            da.Fill(comdt);
            cmbMaS.DataSource = comdt;
            cmbMaS.DisplayMember = "MaTL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaDG.Clear();
            txtTenDG.Clear();
            txtGT.Clear();
            txtDC.Clear();
            txtTel.Clear();
            txtEmail.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sql = "select Distinct TenTL from TaiLieu";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            cmbBook.DataSource = dt;
            cmbBook.DisplayMember = "TenTL";
        }
    }
}
