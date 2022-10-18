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
    public partial class frmTimKiemDG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;

        public frmTimKiemDG()
        {
            InitializeComponent();
        }

        private void frmTimKiemDG_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select * from DocGia";
            da = new SqlDataAdapter(sql, conn);

            dt = new DataTable();
            da.Fill(dt);
            grdData.DataSource = dt;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = "select * from DocGia";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdData.DataSource = dt;

            txtTK.Text = "";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(txtTK.Text != "")
            {
                string text = txtTK.Text;
                text = text.Trim();
                string firstletter = string.Join(" ", text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));

                txtTK.Text = firstletter;
                sql = "select * from DocGia where TenDG = N'" + txtTK.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grdData.DataSource = dt;
                grdData.Refresh();
            }    
            else if(txtTK.Text == "")
            {
                MessageBox.Show("bạn cần nhập tên độc giả cần tìm");
            }    
        }
    }
}
