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
    public partial class frmQLSach : Form
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

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from TaiLieu ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {       
                sql = "Select * From TaiLieu" +
                      " where " + cmbField.Text + " = N'" + cmbGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdData.DataSource = dt;
                grdData.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();
            }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select Distinct " + cmbField.Text + " From TaiLieu";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            cmbGT.DataSource = comdt;
            cmbGT.DisplayMember = cmbField.Text;
        }

        public frmQLSach()
        {
            InitializeComponent();
        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql = "select * from TaiLieu ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0]; //cột mấy dòng mấy, cột trước dòng sau
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1]; //cột mấy dòng mấy, cột trước dòng sau
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if(i>0)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addnewFlag = true;
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
           if( MessageBox.Show("Hãy nhập nội dung của bản ghi mới, kết thúc với nút Cập nhật", "Xác nhận thêm bản ghi mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK);
            {
                txtMaS.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?(Y/N)", "Xác nhận yêu cầu", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql = "Delete from TaiLieu where MaTL = '" + txtMaS.Text + "'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                i = grdData.CurrentRow.Index; // vị trí bản ghi hiện thời 
                grdData.Rows.RemoveAt(1); // xóa bản ghi hiện thời
                NapCT();

            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmQLSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            sql = "Select * from TaiLieu " +
                       " where " + cmbField.Text + " = N'" + cmbGT.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dtBC.Clear();
            da.Fill(dtBC);
            rptQLSach bc = new rptQLSach();
            bc.SetDataSource(dtBC); // đưa dữ liệu vào trong báo cáo
            bc.DataDefinition.FormulaFields["TenTruong"].Text = "'" + cmbField.Text + "'";
            bc.DataDefinition.FormulaFields["GiaTri"].Text = "'" + cmbGT.Text + "'";

            frmrptQLSach f = new frmrptQLSach(bc);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa nội dung của bản ghi hiện thời, kết thúc bằng nút Cập nhật");
            txtTenS.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addnewFlag == true)
            {
                addnewFlag = false;
                sql = "insert into TaiLieu (MaTL,TenTL, LoaiSach, TheLoai, NhaXuatBan, NamXuatBan, KeSach)" +
                    " Values('" + txtMaS.Text + "', N'" + txtTenS.Text + "', N'" + txtLoaiS.Text + "', N'" + txtTL.Text + "', N'" + txtNXB.Text + "' ," + txtNamXB.Text + ", "+ txtKeSach.Text+")";
                // chữ N trước dấu nháy đơn để định dạng tiếng Việt
                // giá trị là số thì không cần đặt trong nháy đơn

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thêm mới thành công");

            }
            else
            {
                for (i = 0; i <= grdData.RowCount - 2; i++)
                {
                    txtMaS.Text = grdData.Rows[i].Cells["MaTL"].Value.ToString(); // cách để lấy giá trị ở dòng i và ở cột tên là cột mã nhóm
                    txtTenS.Text = grdData.Rows[i].Cells["TenTL"].Value.ToString();
                    txtLoaiS.Text = grdData.Rows[i].Cells["LoaiSach"].Value.ToString();
                    txtTL.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
                    txtNXB.Text = grdData.Rows[i].Cells["NhaXuatBan"].Value.ToString();
                    txtNamXB.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
                    txtKeSach.Text = grdData.Rows[i].Cells["KeSach"].Value.ToString();
                    sql = "update TaiLieu set TenTL = N'" + txtTenS.Text + "', LoaiSach = N'" + txtLoaiS.Text + "', TheLoai = N'" + txtTL.Text + "', NhaXuatBan = N'" + txtNXB.Text + "', NamXuatBan = " + txtNamXB.Text + ", KeSach = " + txtKeSach.Text + " Where MaTL = '" + txtMaS.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật sửa đổi thành công");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index; // i chứa số thứ tự của dòng hiện thời trong ô lưới
            txtMaS.Text = grdData.Rows[i].Cells["MaTL"].Value.ToString(); // cách để lấy giá trị ở dòng i và ở cột tên là cột mã nhóm
            txtTenS.Text = grdData.Rows[i].Cells["TenTL"].Value.ToString();
            txtLoaiS.Text = grdData.Rows[i].Cells["LoaiSach"].Value.ToString();
            txtTL.Text = grdData.Rows[i].Cells["TheLoai"].Value.ToString();
            txtNXB.Text = grdData.Rows[i].Cells["NhaXuatBan"].Value.ToString();
            txtNamXB.Text = grdData.Rows[i].Cells["NamXuatBan"].Value.ToString();
            txtKeSach.Text = grdData.Rows[i].Cells["KeSach"].Value.ToString();

        }
    }
}


//  lỗi btn cập nhật chưa sửa được
