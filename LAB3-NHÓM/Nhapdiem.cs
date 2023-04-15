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
    public partial class Nhapdiem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TKQ5GJT;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Nhapdiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("exec sp_ins_bangdiem @manv, @masv, @mahp, @diem", con);

            cmd.Parameters.AddWithValue("@manv", textBox1.Text);
            cmd.Parameters.AddWithValue("@masv", textBox1.Text);
            cmd.Parameters.AddWithValue("@mahp", textBox2.Text);
            cmd.Parameters.AddWithValue("@diem", textBox3.Text);

            con.Open();
            da.InsertCommand = new SqlCommand("exec sp_ins_bandiem @manv, @masv, @mahp, @diem", con);

            da.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
