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
    public partial class frmTKDG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter daTKMK = new SqlDataAdapter();
        SqlDataAdapter daTT = new SqlDataAdapter();
        SqlCommand cmdTKMK = new SqlCommand();
        SqlCommand cmdTT = new SqlCommand();
        SqlCommand cmd = new SqlCommand();

        string sqlTKMK, sqlTT, constr, sql;

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có muốn thay đổi thông tin cá nhân","xác nhận cập nhật",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string GioiTinh, GT;
                if(rbtnNam.Checked == true)
                {
                    GioiTinh = rbtnNam.Text;
                    sql = "update DocGia set TenDG = N'" + txtHoTen.Text + "',GioiTinh =  N'" + GioiTinh + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "' Where MaDG = '" + txtMaDG.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                } 
                else if(rbtnNu.Checked == true)
                {
                    GioiTinh = rbtnNu.Text;
                    sql = "update DocGia set TenDG = N'" + txtHoTen.Text + "',GioiTinh =  N'" + GioiTinh + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "' Where MaDG = '" + txtMaDG.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                else if(rbtnKhac.Checked == true)
                {
                    GioiTinh = rbtnKhac.Text;
                    sql = "update DocGia set TenDG = N'" + txtHoTen.Text + "',GioiTinh =  N'" + GioiTinh + "',SDT = '" + txtSDT.Text + "',Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "' Where MaDG = '" + txtMaDG.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
                sqlTT = "select * from QuanThu where MaQT= '" + txtMaDG.Text + "'";
                cmdTT.CommandText = sqlTT;
                cmdTT.Connection = conn;
                SqlDataReader TT = cmdTT.ExecuteReader();
                while (TT.Read())
                {
                    txtHoTen.Text = TT["TenDG"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn muốn đổi mật khẩu","dổi mật khẩu",MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                if(txtMKHT.Text == txtMK.Text && txtMKM.Text == txtXNMK.Text)
                {
                    sql = "update DocGiaTT set MK = '" + txtMKM.Text + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    sqlTKMK = "select MK from DocGiaTT where MaDG= '" + txtMaDG.Text + "'";
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
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                }    
                else if(txtMKHT.Text == txtMK.Text && txtMKM.Text != txtXNMK.Text)
                {
                    MessageBox.Show("mật khẩu mới hoặc cập nhật mật khẩu không đúng");
                }
                else if (txtMKHT.Text != txtMK.Text && txtMKM.Text != txtXNMK.Text)
                {
                    MessageBox.Show("mật khẩu hiện tại không đúng");
                }
            }    
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void frmTKDG_Load(object sender, EventArgs e)
        {
            string GT;
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sqlTKMK = "select MK from DocGiaTT where MaDG= '" + txtMaDG.Text + "'";
            sqlTT = "select * from DocGia where MaDG= '" + txtMaDG.Text + "'";
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
            while (TT.Read())
            {
                txtHoTen.Text = TT["TenDG"].ToString();
                txtSDT.Text = TT["SDT"].ToString();
                txtEmail.Text = TT["Email"].ToString();
                txtDiaChi.Text = TT["DiaChi"].ToString();
                txtNgayCap.Text = TT["NgayCap"].ToString();

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

        public frmTKDG(string MaDG)
        {
            InitializeComponent();
            txtMaDG.Text = MaDG;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienThi.Checked == true)
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
    }
}
