using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3_NHÓM
{
    public partial class Nhapdiem : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=" + System.Windows.Forms.SystemInformation.ComputerName + ";Initial Catalog=QLSVNhom;Integrated Security=True";

        public Nhapdiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into BANGDIEM values(@masv, @mahp, @diem)";

            cmd.Parameters.AddWithValue("@masv", textBox1.Text);
            cmd.Parameters.AddWithValue("@mahp", textBox2.Text);
            cmd.Parameters.AddWithValue("@diem", RSA.Encrypt(Encoding.UTF8.GetBytes(textBox3.Text), Nhanvien_NV.PUBLICKEY, false));

            cmd.ExecuteNonQuery();

            MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Nhapdiem_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }
    }
}