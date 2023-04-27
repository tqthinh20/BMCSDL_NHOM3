using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_NHÓM
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLop formLop = new FormLop();
            formLop.ShowDialog();
            this.Close();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSSV formDSSV = new FormDSSV();
            formDSSV.ShowDialog();
            this.Close();
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhapdiem formNhapDiem = new Nhapdiem();
            formNhapDiem.ShowDialog();
            this.Close();
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSNV formDSNV = new DSNV();
            formDSNV.ShowDialog();
            this.Close();
        }

        private void btnMenu_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
