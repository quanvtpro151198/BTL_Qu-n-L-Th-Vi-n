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
    public partial class frmQLMS : Form
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

        private void frmQLMS_Load(object sender, EventArgs e)
        {

            constr = "Data Source=DESKTOP-QVQHN10\\SQLEXPRESS;Initial Catalog=btlQLTV;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from PhieuMuon ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdDataPM.DataSource = dt;


            string sql1 = "select * from ChiTietPhieuMuon";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdDataCTPM.DataSource = dt1;
        }
        public frmQLMS()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaP.Focus();
            grdDataPM.CurrentCell = grdDataPM[0, grdDataPM.RowCount - 1];
            sql = "insert into PhieuMuon(MaP, MaDG, NgayMuon) " +
                "VALUES ( '" + txtMaP.Text + "', '" + txtMaDG.Text + "', '" + dtpNgayMuon.Value.ToString("MM-dd-yyyy") + "')";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        private void grdDataPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = grdDataPM.CurrentRow.Index;
            string sql = "select PhieuMuon.MaP, ChiTietPhieuMuon.MaTL, TaiLieu.TenTL, PhieuMuon.NgayMuon, PhieuMuon.NgayTra from ChiTietPhieuMuon, PhieuMuon, TaiLieu where ChiTietPhieuMuon.MaP = PhieuMuon.MaP and PhieuMuon.MaDG = '" + txtMaDG.Text + "' and ChiTietPhieuMuon.MaTL = TaiLieu.MaTL and PhieuMuon.MaP = '" + grdDataPM.Rows[i].Cells["MaP"].Value.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdDataCTPM.DataSource = dt;
            grdDataCTPM.Refresh();
            NapCT();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sql = "select * from PhieuMuon where MaDG = '" + txtMaDG.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt); //dữ liệu từ da từ máy chủ csdl đc đổ vào data tbl đc gọi là dt
            grdDataPM.DataSource = dt;
            grdDataPM.Refresh();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (grdDataCTPM.RowCount > 1)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sql = "DELETE FROM ChiTietPhieuMuon " +
                        " WHERE ChiTietPhieuMuon.MaTL IN" +
                        " (select CT.MaTL from ChiTietPhieuMuon as CT, TaiLieu" +
                        " where CT.MaTL = TaiLieu.MaTL AND TaiLieu.TenTL = N'" + txtMaTL.Text + "')";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sql = "Delete from PhieuMuon where MaP = '" + grdDataPM.CurrentRow.Cells["MaP"].Value.ToString() + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    i = grdDataPM.CurrentRow.Index; // vị trí bản ghi hiện thời 
                    grdDataPM.Rows.RemoveAt(1); // xóa bản ghi hiện thời
                    grdDataPM.Refresh();
                }
            }
        }

        private void grdDataCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = grdDataCTPM.CurrentRow.Index;
            txtTenTL.Text = grdDataCTPM.Rows[j].Cells["TenTL"].Value.ToString();
            txtMaTL.Text = grdDataCTPM.Rows[j].Cells["MaTL"].Value.ToString();
            dtpNgayMuon.Text = grdDataCTPM.Rows[j].Cells["NgayMuon"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdDataCTPM.CurrentCell = grdDataCTPM[0, grdDataCTPM.RowCount - 1];
            sql = "insert into ChiTietPhieuMuon(MaP, MaTL) " +
               "VALUES ( '" + txtMaP.Text + "', '" + txtMaTL.Text + "')";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã cập nhật thêm mới thành công");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void NapCT()
        {
            i = grdDataPM.CurrentRow.Index;
            txtMaDG.Text = grdDataPM.Rows[i].Cells["MaDG"].Value.ToString();
            txtMaP.Text = grdDataPM.Rows[i].Cells["MaP"].Value.ToString();
        }
    }
}
