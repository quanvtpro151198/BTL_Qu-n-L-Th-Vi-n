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
    public partial class frmQLQT : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmdTKMK = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();

        string sql,sqlMK, constr; 
        int i;
        Boolean addnewflag = false; 
        public frmQLQT()
        {
            InitializeComponent();
        }

        private void frmQLQT_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select * from QuanThu";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdData.DataSource = dt;

            NapCT();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("hãy nhập nội dung của bản ghi mới, sau khi nhập xong nhấn cập nhật để xem kết quả");
            txtMaQT.Text = "";
            txtTenQT.Text = "";
            txtGT.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMK.Text = "";
            txtMaQT.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(addnewflag == true)
            {
                sql = "Insert into QuanThu (MaQT, TenQT, GioiTinh, SDT, Email, DiaChi) values ('" + txtMaQT.Text + "',N'" + txtTenQT.Text + "',N'" + txtGT.Text + "','" + txtSDT + "','" + txtEmail.Text + "',N'" + txtDiaChi.Text + "')";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "insert into QuanThuTT (MaQT,MK) values ('" + txtMaQT.Text + "','" + txtMK.Text + "')";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                addnewflag = false;
            }
            else if(addnewflag == false)
            {
                sql = "update QuanThuTT set MK = '" + txtMK.Text + "' where MaQT = '" + txtMaQT.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "update QuanThu set TenQT = N'" + txtTenQT.Text + "',GioiTinh = N'" + txtGT.Text + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "',DiaChi = N'" + txtDiaChi.Text + "' where MaQT = '" + txtMaQT.Text+"'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }    
            sql = "select * from QuanThu";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời ?(Y/N)", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = "delete from QuanThuTT where MaQT = '" + txtMaQT.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                sql = "delete from QuanThu where MaQT = '" + txtMaQT.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                i = grdData.CurrentRow.Index;//xác định dòng hiện thời
                grdData.Rows.RemoveAt(i);//xóa dòng i
                NapCT();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn muốn cập nhật dòng hiện thời", "cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtMaQT.Focus();
                addnewflag = false;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            sql = "Select * From QuanThu";
            da = new SqlDataAdapter(sql, conn);
            DataTable dtBC = new DataTable();
            dtBC.Clear();
            da.Fill(dtBC);

            rptQLQT bc = new rptQLQT();
            bc.SetDataSource(dtBC);

            frmrptQLQT f = new frmrptQLQT(bc);
            f.Show();
           
        }

        private void ckbHien_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHien.Checked == true)
            {
                txtMK.UseSystemPasswordChar = false;
            }    
            else if(ckbHien.Checked == false)
            {
                txtMK.UseSystemPasswordChar = true;
            }    
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index; //i chính là số thứ tự của dòng hiện thời đang ở trạng thái xanh dương - chọn 
            txtMaQT.Text = grdData.Rows[i].Cells["MaQT"].Value.ToString();
            txtTenQT.Text = grdData.Rows[i].Cells["TenQT"].Value.ToString();
            txtGT.Text = grdData.Rows[i].Cells["GioiTinh"].Value.ToString();
            txtSDT.Text = grdData.Rows[i].Cells["SDT"].Value.ToString();
            txtEmail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();
            txtDiaChi.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
            sqlMK = "select MK from QuanThuTT where MaQT = '" + txtMaQT.Text + "'";
            cmdTKMK.CommandText = sqlMK;
            cmdTKMK.Connection = conn;
            SqlDataReader MK = cmdTKMK.ExecuteReader();
            while (MK.Read())
            {
                txtMK.Text = MK["MK"].ToString();
            }
            MK.Close();
        }
    }
}
