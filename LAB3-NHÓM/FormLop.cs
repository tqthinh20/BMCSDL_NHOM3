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

namespace LAB3_NHÓM
{
    public partial class FormLop : Form
    {
        SqlConnection conn_Lop;
        SqlCommand cmd;
        string str = @"Data Source=QUOCANH;Initial Catalog=QLSVNhom;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable lop = new DataTable();

        void loadDataFromLop()
        {
            cmd = conn_Lop.CreateCommand();
            cmd.CommandText = "select * from LOP";
            adapter.SelectCommand = cmd;
            lop.Clear();
            adapter.Fill(lop);
            dataGridViewLop.DataSource = lop;
        }

        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            conn_Lop = new SqlConnection(str);
            conn_Lop.Open();
            loadDataFromLop();
        }

        private void txtBoxLop_MaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLop_TenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLop_MaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLop_Select_Click(object sender, EventArgs e)
        {
            loadDataFromLop();
        }

        private void btnLop_Insert_Click(object sender, EventArgs e)
        {
            cmd = conn_Lop.CreateCommand();
            cmd.CommandText = "insert into LOP values('" + txtBoxLop_MaLop.Text + "', N'" + txtBoxLop_TenLop.Text + "', '" + txtBoxLop_MaNV.Text + "')";
            cmd.ExecuteNonQuery();
            loadDataFromLop();
        }

        private void btnLop_Delete_Click(object sender, EventArgs e)
        {
            cmd = conn_Lop.CreateCommand();
            cmd.CommandText = "delete from LOP where MALOP = '" + txtBoxLop_MaLop.Text + "'";
            cmd.ExecuteNonQuery();
            loadDataFromLop();
        }

        private void btnLop_Update_Click(object sender, EventArgs e)
        {
            cmd = conn_Lop.CreateCommand();
            cmd.CommandText = "update LOP set TENLOP = N'" + txtBoxLop_TenLop.Text + "', MANV = '" + txtBoxLop_MaNV.Text + "' where MALOP = '" + txtBoxLop_MaLop.Text + "'";
            cmd.ExecuteNonQuery();
            loadDataFromLop();
        }

        private void dataGridViewLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewLop.CurrentRow.Index;
            txtBoxLop_MaLop.Text = dataGridViewLop.Rows[i].Cells[0].Value.ToString();
            txtBoxLop_TenLop.Text = dataGridViewLop.Rows[i].Cells[1].Value.ToString();
            txtBoxLop_MaNV.Text = dataGridViewLop.Rows[i].Cells[2].Value.ToString();
        }

        private void btnLop_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Về màn hình Menu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
                this.Close();
            }
        }
    }
}
