using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_quanlythuvien
{
    public partial class frmTKND : Form
    {
        public frmTKND()
        {
            InitializeComponent();
        }

         private void btnProfile_Click(object sender, EventArgs e)
        {
            lblTT.Visible = true;
            lblTT.Text = btnProfile.Text;
            pnlTTCN.Visible = true;
            pnlTTTK.Visible = false;
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {

            lblTT.Visible = true;
            lblTT.Text = btnAcc.Text;
            pnlTTTK.Visible = true;
            pnlTTCN.Visible = false;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlChangePW.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu ?", "Xác nhận yêu cầu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.OK)
            if(txtPW.Text != txtCurPW.Text || txtNewPW.Text != txtCfPW.Text )
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại");
            }
        }

    }
}
