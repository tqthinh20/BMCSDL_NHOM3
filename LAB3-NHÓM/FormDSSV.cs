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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3_NHÓM
{
    public partial class FormDSSV : Form
    {
        SqlConnection connection;
        SqlCommand comm;
        string str = @"Data Source=" + System.Windows.Forms.SystemInformation.ComputerName + ";Initial Catalog=QLSVNhom;Integrated Security=True";
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable DSSV = new DataTable();

        void loadDatafromSV()
        {
            comm = connection.CreateCommand();
            comm.CommandText = "SELECT LOP.MALOP, LOP.TENLOP, SV.MASV, SV.HOTEN, SV.NGAYSINH, SV.DIACHI FROM SINHVIEN SV JOIN LOP ON LOP.MALOP = SV.MALOP";
            adpt.SelectCommand = comm;
            DSSV.Clear();
            adpt.Fill(DSSV);
            dgv_SV.DataSource = DSSV;
        }

        public FormDSSV()
        {
            InitializeComponent();
        }

        private void btnSV_Select_Click(object sender, EventArgs e)
        {
            comm = connection.CreateCommand();
            comm.CommandText = "SELECT LOP.MALOP, LOP.TENLOP, SV.MASV, SV.HOTEN, SV.NGAYSINH, SV.DIACHI FROM SINHVIEN SV JOIN LOP ON LOP.MALOP = SV.MALOP WHERE LOP.MALOP = '" + tbMalop.Text + "'";
            comm.ExecuteNonQuery();
            loadDatafromSV();
        }

        private void btnSV_Insert_Click(object sender, EventArgs e)
        {
            comm = connection.CreateCommand();
            comm.CommandText = "IF '" + tbMalop.Text + "' in (SELECT MALOP FROM LOP WHERE MANV = '" + Nhanvien_NV.MANV + "') INSERT INTO SINHVIEN VALUES('" + tbMaSV.Text + "', N'" + tbHoten.Text + "', '" + tbNgaysinh.Text + "', N'" + tbDiachi.Text + "', '" + tbMalop.Text + "', N'" + tbTendn.Text + "', @matkhau)";
            
            comm.Parameters.AddWithValue("@matkhau", HASH.HashMD5(tbMatkhau.Text));
            comm.ExecuteNonQuery();
            loadDatafromSV();
        }

        private void btnSV_Delete_Click(object sender, EventArgs e)
        {
            comm = connection.CreateCommand();
            comm.CommandText = "DELETE SINHVIEN FROM SINHVIEN SV JOIN LOP ON LOP.MALOP = SV.MALOP WHERE LOP.MANV = '" + Nhanvien_NV.MANV + "' AND MASV = '" + tbMaSV.Text + "'";
            comm.ExecuteNonQuery();
            loadDatafromSV();
        }

        private void btnSV_Update_Click(object sender, EventArgs e)
        {
            comm = connection.CreateCommand();
            comm.CommandText = "UPDATE SINHVIEN SET SINHVIEN.HOTEN = N'" + tbHoten.Text + "', SINHVIEN.NGAYSINH = '" + tbNgaysinh.Text + "', SINHVIEN.DIACHI = N'" + tbDiachi.Text + "' FROM SINHVIEN SV JOIN LOP ON SV.MALOP = LOP.MALOP WHERE LOP.MANV = '" + Nhanvien_NV.MANV + "' AND SV.MASV = '" + tbMaSV.Text + "' ";
            comm.ExecuteNonQuery();
            loadDatafromSV();
        }

        private void btnSV_Back_Click(object sender, EventArgs e)
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

        private void dgv_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_SV.CurrentRow.Index;
            tbMaSV.Text = dgv_SV.Rows[i].Cells[0].Value.ToString();
            tbHoten.Text = dgv_SV.Rows[i].Cells[1].Value.ToString();
            tbNgaysinh.Text = dgv_SV.Rows[i].Cells[2].Value.ToString();
            tbDiachi.Text = dgv_SV.Rows[i].Cells[3].Value.ToString();
            tbMalop.Text = dgv_SV.Rows[i].Cells[4].Value.ToString();
        }

        private void FormDSSV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDatafromSV();
        }
    }
}
