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
    public partial class frmQLTG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmdTKMK = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtBC = new DataTable();

        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public frmQLTG()
        {
            InitializeComponent();
        }

        private void frmQLTG_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select * from TacGia";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời ?(Y/N)", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = " delete from TacPham where MaTG = '" + txtMaTG.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "delete from TacGia where MaTG = '" + txtMaTG.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                i = grdData.CurrentRow.Index;
                grdData.Rows.RemoveAt(i);
                NapCT();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("hãy nhập nội dung của bản ghi mới, sau khi nhập xong nhấn cập nhật để xem kết quả");
            txtMaTG.Text = "";
            txtNamSinh.Text = "";
            txtTenTG.Text = "";
            txtMaTG.ReadOnly = false;
            txtMaTG.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(addnewflag == true)
            {
                sql = "insert into TacGia (MaTG, TenTG, NamSinh) values ('" + txtMaTG.Text + "',N'" + txtTenTG.Text + "','" + txtNamSinh.Text + "')";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            else if(addnewflag == false)
            {
                sql = "update TacGia set TenTG = N'" + txtTenTG.Text + "', NamSinh = '" + txtNamSinh.Text + "' where MaTG = '"+txtMaTG.Text+"'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }  
            
            txtMaTG.ReadOnly = true;
            sql = "select * from TacGia";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn muốn cập nhật dòng hiện thời", "cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtTenTG.Focus();
                addnewflag = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sql = "select * from TacGia";
            da = new SqlDataAdapter(sql, conn); 
            dtBC.Clear();
            da.Fill(dtBC);

            rptQLTG bc = new rptQLTG();
            bc.SetDataSource(dtBC);
            frmrptQLTG f = new frmrptQLTG(bc);
            f.Show();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaTG.Text = grdData.Rows[i].Cells["MaTG"].Value.ToString();
            txtTenTG.Text = grdData.Rows[i].Cells["TenTG"].Value.ToString();
            txtNamSinh.Text = grdData.Rows[i].Cells["NamSinh"].Value.ToString();
        }
    }
}
