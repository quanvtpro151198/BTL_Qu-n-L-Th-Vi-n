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
    public partial class frmTKQT : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter daTKMK = new SqlDataAdapter();
        SqlDataAdapter daTT = new SqlDataAdapter();
        SqlCommand cmdTKMK = new SqlCommand();
        SqlCommand cmdTT = new SqlCommand();
        SqlCommand cmd = new SqlCommand();

        string sqlTKMK, sqlTT, constr,sql;

        public frmTKQT(string MaQT)
        {
            InitializeComponent();
            txtMaQT.Text = MaQT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn cập nhật dữ liệu cá nhân đã sửa ở trên","xác nhận cập nhật",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string GioiTinh,GT;
                if (rbtnNam.Checked == true)
                {
                    GioiTinh = rbtnNam.Text;
                    sql = "update QuanThu set TenQT = N'" + txtHoTen.Text + "',GioiTinh =  N'" + GioiTinh + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "' Where MaQT = '"+ txtMaQT.Text +"'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                else if (rbtnNu.Checked == true)
                {
                    GioiTinh = rbtnNu.Text;
                    sql = "update QuanThu set TenQT = N'" + txtHoTen.Text + "',GioiTinh =  N'" + GioiTinh + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "'Where MaQT = '" + txtMaQT.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                else if (rbtnKhac.Checked == true)
                {
                    GioiTinh = rbtnNam.Text;
                    sql = "update QuanThu set TenQT = N'" + txtHoTen.Text + "',GioiTinh =  N'" + GioiTinh + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "'Where MaQT = '" + txtMaQT.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                sqlTT = "select * from QuanThu where MaQT= '" + txtMaQT.Text + "'";
                cmdTT.CommandText = sqlTT;
                cmdTT.Connection = conn;
                SqlDataReader TT = cmdTT.ExecuteReader();
                while (TT.Read())
                {
                    txtHoTen.Text = TT["TenQT"].ToString();
                    txtSDT.Text = TT["SDT"].ToString();
                    txtEmail.Text = TT["Email"].ToString();
                    txtDiaChi.Text = TT["DiaChi"].ToString();
                    GT = TT["GioiTinh"].ToString();
                    if (GT == "Nam" || GT == "nam")
                    {
                        rbtnNam.Checked = true;
                    }
                    else if (GT == "Nữ" || GT == "nữ")
                    {
                        rbtnNu.Checked = true;
                    }
                    else
                    {
                        rbtnNam.Checked = true;
                    }
                }
                TT.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn cập nhật mật khẩu mới", "xác nhận cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(txtMKHT.Text == txtMK.Text && txtMKM.Text == txtXNMK.Text)
                {
                    sql = "update QuanThuTT set MK = '" + txtMKM.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    sqlTKMK = "select MK from QuanThuTT where MaQT= '" + txtMaQT.Text + "'";
                    cmdTKMK.CommandText = sqlTKMK;
                    cmdTKMK.Connection = conn;
                    SqlDataReader MK = cmdTKMK.ExecuteReader();
                    while (MK.Read())
                    {
                        txtMK.Text = MK["MK"].ToString();
                    }
                    MK.Close();
                    txtMKHT.Text = "";
                    txtMKM.Text = "";
                    txtXNMK.Text = "";
                }    
                else if(txtMKHT.Text != txtMK.Text && txtMKM.Text == txtXNMK.Text)
                {
                    MessageBox.Show("mật khẩu hiện tại không đúng");
                }    
                else if(txtMKHT.Text == txtMK.Text && txtMKM.Text != txtXNMK.Text)
                {
                    MessageBox.Show("mật khẩu mới hoặc cập nhật mật khẩu không đúng");
                }
                else if(txtMKHT.Text != txtMK.Text && txtMKM.Text != txtXNMK.Text)
                {
                    MessageBox.Show("mật khẩu hiện tại không đúng");
                }
            }    

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbTKQT.Checked == true)
            {
                txtMK.UseSystemPasswordChar = false;
                txtMKHT.UseSystemPasswordChar = false;
                txtMKM.UseSystemPasswordChar = false;
                txtXNMK.UseSystemPasswordChar = false;
            }    
            else
            {
                txtMK.UseSystemPasswordChar = true;
                txtMKHT.UseSystemPasswordChar = true;
                txtMKM.UseSystemPasswordChar = true;
                txtXNMK.UseSystemPasswordChar = true;
            }    
        }

        private void frmTKQT_Load(object sender, EventArgs e)
        {
            string GT;
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sqlTKMK = "select MK from QuanThuTT where MaQT= '" + txtMaQT.Text + "'";
            sqlTT = "select * from QuanThu where MaQT= '" + txtMaQT.Text + "'";
            cmdTKMK.CommandText = sqlTKMK;
            cmdTKMK.Connection = conn;
            SqlDataReader MK = cmdTKMK.ExecuteReader();
            while (MK.Read())
            {
                txtMK.Text = MK["MK"].ToString();
            }
            MK.Close();

            cmdTT.CommandText = sqlTT;
            cmdTT.Connection = conn;
            SqlDataReader TT = cmdTT.ExecuteReader();
            while(TT.Read())
            {
                txtHoTen.Text = TT["TenQT"].ToString();
                txtSDT.Text = TT["SDT"].ToString();
                txtEmail.Text = TT["Email"].ToString();
                txtDiaChi.Text = TT["DiaChi"].ToString();
                GT = TT["GioiTinh"].ToString();
                if(GT == "Nam" || GT == "nam")
                {
                    rbtnNam.Checked = true;
                }    
                else if(GT == "Nữ" || GT =="nữ")
                {
                    rbtnNu.Checked = true;
                }    
                else
                {
                    rbtnNam.Checked = true;
                }    
            }
            TT.Close();
        }
    }
}
