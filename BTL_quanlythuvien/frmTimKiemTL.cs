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
    public partial class frmTimKiemTL: Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();

        string sql, constr;

        public frmTimKiemTL()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void btnTaiLieu_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.ReadOnly = false;
            comTK.Visible = false;
        }

        private void btnTacGia_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.ReadOnly = false;
            comTK.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != " " && comTK.Text == "")
            {
                if(btnTaiLieu.Checked == true)
                {
                    txtTimKiem.Text = txtTimKiem.Text.Trim();
                    txtTimKiem.Text = txtTimKiem.Text.ToLower();

                    string text = txtTimKiem.Text.Substring(0, 1).ToUpper() + txtTimKiem.Text.Substring(1);
                    txtTimKiem.Text = text;

                    sql = "select TenTL, LoaiSach, TheLoai, NhaXuatBan, NamXuatBan, KeSach from TaiLieu where TenTL Like N'%" + txtTimKiem.Text + "%'";
                    da = new SqlDataAdapter(sql, conn);
                    dt.Clear();
                    da.Fill(dt);
                    grdData.DataSource = dt;
                    grdData.Refresh();
                }      
            }    
            else if(txtTimKiem.Text == " " && comTK.Text !=" ")
            {
                if(btnLoaiTL.Checked == true)
                {
                    sql = "select TenTL, LoaiSach, TheLoai, NhaXuatBan, NamXuatBan, KeSach from TaiLieu where LoaiSach = '" + comTK.Text + "'";
                    da = new SqlDataAdapter(sql, conn);
                    dt.Clear();
                    da.Fill(dt);
                    grdData.DataSource = dt;
                    grdData.Refresh();
                }   
                else if(btnTheLoai.Checked == true)
                {
                    sql = "select TenTL, LoaiSach, TheLoai, NhaXuatBan, NamXuatBan, KeSach from TaiLieu where TheLoai = N'" + comTK.Text + "'";
                    da = new SqlDataAdapter(sql, conn);
                    dt.Clear();
                    da.Fill(dt);
                    grdData.DataSource = dt;
                    grdData.Refresh();
                }    
            }   
            else if(txtTimKiem.Text == " " && comTK.Text ==" ")
            {
                MessageBox.Show("bạn cần nhập thông tin tìm kiếm");
            }    
            
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "select TenTL, LoaiSach, TheLoai, NhaXuatBan, NamXuatBan, KeSach from TaiLieu";
            da = new SqlDataAdapter(sql, conn);

            dt = new DataTable();
            da.Fill(dt);
            grdData.DataSource = dt;
        }

        private void btnTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            comTK.Visible = true;
            txtTimKiem.ReadOnly = true;
            comTK.Items.Clear();
            comTK.Text = " ";
            txtTimKiem.Text = " ";
            if(btnTheLoai.Checked == true)
            {
                sql = "select distinct TheLoai from TaiLieu";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                SqlDataReader TheLoai = cmd.ExecuteReader();
                while (TheLoai.Read())
                {
                    comTK.Items.Add(TheLoai[0]).ToString();
                }
                TheLoai.Close();
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sql = "select TenTL, LoaiSach, TheLoai, NhaXuatBan, NamXuatBan, KeSach from TaiLieu";
            da = new SqlDataAdapter(sql, conn);

            dt = new DataTable();
            da.Fill(dt);
            grdData.DataSource = dt;

            txtTimKiem.Text = "";
            comTK.Text = "";
        }

        private void btnLoaiTL_CheckedChanged(object sender, EventArgs e)
        {
            comTK.Visible = true;
            txtTimKiem.ReadOnly = true;
            comTK.Items.Clear();
            comTK.Text = " ";
            txtTimKiem.Text = " ";
            if (btnLoaiTL.Checked == true)
            {
                sql = "select distinct LoaiSach from TaiLieu";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                SqlDataReader LoaiTL = cmd.ExecuteReader();
                while(LoaiTL.Read())
                {
                    comTK.Items.Add(LoaiTL[0]).ToString();
                }
                LoaiTL.Close();
            }    
        }
    }
}
