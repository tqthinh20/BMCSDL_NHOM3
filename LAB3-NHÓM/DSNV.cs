using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_NHÓM
{
    public partial class DSNV : Form
    {
        SqlConnection connection;
        SqlCommand comm;
        string str = @"Data Source=" + System.Windows.Forms.SystemInformation.ComputerName + ";Initial Catalog=QLSVNhom;Integrated Security=True";
        string pk;
        int mode = 0;

        void loadDatafromNV()       
        {
            comm = connection.CreateCommand();
            comm.CommandText = "SELECT MANV, HOTEN, EMAIL, LUONG FROM NHANVIEN";

            SqlDataReader reader = comm.ExecuteReader();
            SqlDataReader sqlDataReader = reader;
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("MÃ NHÂN VIÊN");
            dataTable.Columns.Add("HỌ TÊN");
            dataTable.Columns.Add("EMAIL");
            dataTable.Columns.Add("LƯƠNG");

            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["MÃ NHÂN VIÊN"].Width = 170;
            dataGridView1.Columns["HỌ TÊN"].Width = 170;
            dataGridView1.Columns["EMAIL"].Width = 250;
            dataGridView1.Columns["LƯƠNG"].Width = 193;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);

            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["MÃ NHÂN VIÊN"] = sqlDataReader["MANV"];
                row["HỌ TÊN"] = sqlDataReader["HOTEN"];
                row["EMAIL"] = sqlDataReader["EMAIL"];
                
                pk = sqlDataReader["MANV"].ToString();
                
                if (sqlDataReader["LUONG"] == null)
                    row["LƯƠNG"] = sqlDataReader["LUONG"];
                
                else
                    row["LƯƠNG"] = Encoding.UTF8.GetString(RSA.Decrypt((byte[])sqlDataReader["LUONG"], pk, true));

                dataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = dataTable;

            reader.Close();
        }

        void setTextBox(bool status)
        {
            textBox1.Enabled = status;
            textBox2.Enabled = status;
            textBox3.Enabled = status;
            textBox4.Enabled = status;
            textBox5.Enabled = status;
            textBox6.Enabled = status;
            textBox7.Enabled = status;
        }

        public DSNV()
        {
            InitializeComponent();
        }

        private void DSNV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();            
            setTextBox(false);
            loadDatafromNV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setTextBox(true);
            mode = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTextBox(true);
            mode = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setTextBox(true);
            mode = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox6.Text.Length == 0 || textBox7.Text.Length == 0)
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else if (textBox1.Text == Nhanvien_NV.MANV)
                {
                    MessageBox.Show("Không thể thêm nhân viên có cùng mã nhân viên của nhân viên đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                
                else
                {
                    if (textBox5.Text != null)
                        comm.Parameters.AddWithValue("@luong", RSA.Encrypt(Encoding.UTF8.GetBytes(textBox5.Text), textBox1.Text, true));
                    else
                        comm.Parameters.AddWithValue("@luong", textBox5.Text);

                    comm.CommandText = "EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @manv, @hoten, @email, @luong, @tendn, @matkhau, @pubkey";

                    comm.Parameters.AddWithValue("@manv", textBox1.Text);
                    comm.Parameters.AddWithValue("@email", textBox2.Text);
                    comm.Parameters.AddWithValue("@tendn", textBox3.Text);
                    comm.Parameters.AddWithValue("@hoten", textBox4.Text);
                    comm.Parameters.AddWithValue("@matkhau", HASH.HashSHA1(textBox6.Text));
                    comm.Parameters.AddWithValue("@pubkey", textBox7.Text);

                    comm.ExecuteNonQuery();
                    setTextBox(false);
                    loadDatafromNV();

                    mode = 0;
                }
                    
            }

            else if (mode == 2)
            {
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                    
                
                else if (textBox1.Text == Nhanvien_NV.MANV)
                {
                    MessageBox.Show("Không thể xóa thông tin nhân viên đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                    
                
                else
                {
                    comm.CommandText = "delete from NHANVIEN where MANV = '" + textBox1.Text + "'";
                    comm.Parameters.AddWithValue("@manv", textBox1.Text);

                    comm.ExecuteNonQuery();
                    setTextBox(false);
                    loadDatafromNV();

                    mode = 0;
                }
            }

            else if (mode == 3)
            {
                if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox6.Text.Length == 0 || textBox7.Text.Length == 0)
                {
                    MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                
                else if (textBox1.Text == Nhanvien_NV.MANV)
                {
                    MessageBox.Show("Không thể sửa thông tin nhân viên đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                    
                
                else
                {
                    if (textBox5.Text != null)
                        comm.Parameters.AddWithValue("@luong", RSA.Encrypt(Encoding.UTF8.GetBytes(textBox5.Text), textBox1.Text, true));
                    else
                        comm.Parameters.AddWithValue("@luong", textBox5.Text);                    

                    comm.CommandText = "UPDATE NHANVIEN SET HOTEN = N'" + textBox4.Text + "', EMAIL = '" + textBox2.Text + "', LUONG = @luong, TENDN = N'" + textBox3.Text + "', MATKHAU = @matkhau, PUBKEY = N'" + textBox7.Text + "' WHERE MANV = '" + textBox1.Text + "'";

                    comm.Parameters.AddWithValue("@matkhau", HASH.HashSHA1(textBox6.Text));

                    comm.ExecuteNonQuery();
                    setTextBox(false);
                    loadDatafromNV();

                    mode = 0;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            setTextBox(false);
        }

        private void button6_Click(object sender, EventArgs e)
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
