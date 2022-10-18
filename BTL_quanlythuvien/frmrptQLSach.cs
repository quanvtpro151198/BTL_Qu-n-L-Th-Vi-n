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
    public partial class frmrptQLSach : Form
    {
        public frmrptQLSach(rptQLSach rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmrptQLSach_Load(object sender, EventArgs e)
        {

        }
    }
}
