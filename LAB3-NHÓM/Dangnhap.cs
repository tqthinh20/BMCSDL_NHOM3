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

namespace LAB3_NHÓM
{
    public partial class Dangnhap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-TKQ5GJT;Initial Catalog=QLSVNhom;Integrated Security=True";
        SqlDataReader dr;

        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from nhanvien where tendn=@tendn and matkhau=@matkhau", con);
            
            cmd.Parameters.AddWithValue("@tendn", textBox1.Text);
            cmd.Parameters.AddWithValue("@matkhau", HASH.HashSHA1(textBox2.Text));

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Nhanvien_NV.MANV = dr["MANV"].ToString();
                    Nhanvien_NV.PUBLICKEY = dr["PUBKEY"].ToString();
                }
                MessageBox.Show("Đăng nhập thành công " + Nhanvien_NV.MANV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }
    }
}
