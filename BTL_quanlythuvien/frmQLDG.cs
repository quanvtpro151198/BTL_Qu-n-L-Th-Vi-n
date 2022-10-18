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
    public partial class frmQLDG : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtBC = new DataTable();

        string sql, constr; //connection string
        int i;
        Boolean addnewFlag = false;
        public frmQLDG()
        {
            InitializeComponent();
        }

        private void frmQLDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.qLTVDataSet.DocGia);
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from DocGia ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdData.DataSource = dt;
            NapCT();
        }
        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbField.Text == "")
            {
                MessageBox.Show("Bạn phải nhập dữ liệu lọc");

            }
            else
            {
                sql = "select Distinct " + cmbField.Text + " from DocGia ";
                da = new SqlDataAdapter(sql, conn);
                comdt.Clear();
                da.Fill(comdt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
                cmbGT.DataSource = comdt;
                cmbGT.DisplayMember = cmbField.Text;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sql = "Select * From DocGia" +
                      " where " + cmbField.Text + " = N'" + cmbGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdData.DataSource = dt;
            grdData.Refresh();
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            NapCT();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "select * from DocGia ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addnewFlag = true;
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            if (MessageBox.Show("Hãy nhập nội dung của bản ghi mới, kết thúc với nút Cập nhật", "Xác nhận thêm bản ghi mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) ;
            {
                txtMaDG.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy đảm bảo các phát sinh liên quan đã được xóa", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "Delete from DocGia where MaDG = '" + txtMaDG.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                i = grdData.CurrentRow.Index; // vị trí bản ghi hiện thời 
                grdData.Rows.RemoveAt(1); // xóa bản ghi hiện thời
                NapCT();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa nội dung của bản ghi hiện thời, kết thúc bằng nút Cập nhật");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addnewFlag == true)
            {
                addnewFlag = false;
                sql = "insert into DocGia (MaDG,TenDG, GioiTinh, NgayCap, SDT, Email, DiaChi)" +
                    " Values('" + txtMaDG.Text + "', N'" + txtTenDG.Text + "', N'" + txtSex.Text + "', '" + txtDate.Value.ToString("MM-dd-yyyy") + "', '" + txtTel.Text + "' , '" + txtMail.Text + "', '" + txtAddress.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thêm mới thành công");

            }
            else
            {
                for (i = 0; i <= grdData.RowCount - 2; i++)
                {
                    txtMaDG.Text = grdData.Rows[i].Cells["MaDG"].Value.ToString(); // cách để lấy giá trị ở dòng i và ở cột tên là cột mã nhóm
                    txtTenDG.Text = grdData.Rows[i].Cells["TenDG"].Value.ToString();
                    txtDate.Text = grdData.Rows[i].Cells["NgayCap"].Value.ToString();
                    txtTel.Text = grdData.Rows[i].Cells["SDT"].Value.ToString();
                    txtMail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();
                    txtAddress.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
                    txtSex.Text = grdData.Rows[i].Cells["GioiTinh"].Value.ToString();
                    sql = "update DocGia set TenDG = N'"
                        + txtTenDG.Text + "', GioiTinh = N'" + txtSex.Text + "', NgayCap = '"
                        + txtDate.Value.ToString("MM-dd-yyyy") + "', SDT = '" + txtTel.Text + "', Email = '" 
                        + txtMail.Text + "', DiaChi = N'" + txtAddress.Text + "' where MaDG = '"+txtMaDG.Text+"'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật sửa đổi thành công");
            }
            }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0]; //cột mấy dòng mấy, cột trước dòng sau
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
                NapCT();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1]; //cột mấy dòng mấy, cột trước dòng sau
            NapCT();
        }

        //private void btnReport_Click(object sender, EventArgs e)
        //{
        //    sql = "Select * from DocGia " +
        //               " where " + cmbField.Text + " = N'" + cmbGT.Text + "'";
        //    da = new SqlDataAdapter(sql, conn);
        //    DataTable dtBC = new DataTable();
        //    dtBC.Clear();
        //    da.Fill(dtBC);
        //    rptQLDG bc = new rptQLDG();
        //    bc.SetDataSource(dtBC); // đưa dữ liệu vào trong báo cáo
        //    bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cmbField.Text + "'";
        //    bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cmbGT.Text + "'";
        //    frmrptQLDG f = new frmrptQLDG(bc);
        //    f.Show();
        //}

        private void btnReport_Click(object sender, EventArgs e)
        {
            sql = "Select * From DocGia"+
            " where " + cmbField.Text + " = N'" + cmbGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dtBC.Clear();
            da.Fill(dtBC);

            rptQLDG bc = new rptQLDG();
            bc.SetDataSource(dtBC); 

            bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cmbField.Text + "'";
            bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cmbGT.Text + "'";

            frmrptQLDG f = new frmrptQLDG(bc);
            f.Show();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index; // i chứa số thứ tự của dòng hiện thời trong ô lưới
            txtMaDG.Text = grdData.Rows[i].Cells["MaDG"].Value.ToString(); // cách để lấy giá trị ở dòng i và ở cột tên là cột mã nhóm
            txtTenDG.Text = grdData.Rows[i].Cells["TenDG"].Value.ToString();
            txtDate.Text = grdData.Rows[i].Cells["NgayCap"].Value.ToString();
            txtTel.Text = grdData.Rows[i].Cells["SDT"].Value.ToString();
            txtMail.Text = grdData.Rows[i].Cells["Email"].Value.ToString();
            txtAddress.Text = grdData.Rows[i].Cells["DiaChi"].Value.ToString();
            txtSex.Text = grdData.Rows[i].Cells["GioiTinh"].Value.ToString();

        }
    }
}

// vấn đề gặp phải ở form này:
//1. không truyền được date vào grdData
//2. nút cập nhật
//3. report chưa làm