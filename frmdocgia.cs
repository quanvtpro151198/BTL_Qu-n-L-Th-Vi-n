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

namespace library
{
    public partial class frmdocgia : Form
    {
        SqlConnection conn;
        SqlCommand command;
        string str = "Data Source=DESKTOP-D3HOFOB\\SQLEXPRESS;Initial Catalog=LibraryMng;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = conn.CreateCommand();
            command.CommandText = "select * from Readers";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public frmdocgia()
        {
            InitializeComponent();
        }

        private void frmdocgia_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loadData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtMaDocGia.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTenDocGia.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbGioiTinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dtNgaySinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtNgheNghiep.Text = dgv.Rows[i].Cells[4].Value.ToString();
            dtNgayThamGia.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "insert into Readers values('"+txtMaDocGia.Text+"', '"+txtTenDocGia.Text+"', '"+cbGioiTinh.Text+"', '"+dtNgaySinh.Text+"', '"+txtNgheNghiep.Text+"', '"+dtNgayThamGia.Text+"')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnDienLai_Click(object sender, EventArgs e)
        {

        }
    }
}
