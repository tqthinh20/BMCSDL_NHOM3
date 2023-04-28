﻿using System;
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
        string str = @"Data Source=DESKTOP-TKQ5GJT;Initial Catalog=QLSVNhom;Integrated Security=True";
        string pk;

        void loadDatafromNV()       
        {
            comm = connection.CreateCommand();
            comm.CommandText = "SELECT MANV, HOTEN, EMAIL, LUONG, PUBKEY FROM NHANVIEN";

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
                
                pk = sqlDataReader["PUBKEY"].ToString();
                RSA.RSAPersistKeyInCSP(pk);
                
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTextBox(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setTextBox(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == false || textBox1.Text == null || textBox3.Text == null || textBox4.Text == null || textBox6.Text == null || textBox7.Text == null)
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            else
            {
                comm = connection.CreateCommand();
                comm.CommandText = "EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @manv, @hoten, @email, @luong, @tendn, @matkhau, @pubkey";

                RSA.RSAPersistKeyInCSP(textBox7.Text);

                comm.Parameters.AddWithValue("@manv", textBox1.Text);
                comm.Parameters.AddWithValue("@email", textBox2.Text);
                comm.Parameters.AddWithValue("@tendn", textBox3.Text);
                comm.Parameters.AddWithValue("@hoten", textBox4.Text);
                comm.Parameters.AddWithValue("@luong", RSA.Encrypt(Encoding.UTF8.GetBytes(textBox5.Text), textBox7.Text, true));
                comm.Parameters.AddWithValue("@matkhau", HASH.HashSHA1(textBox6.Text));
                comm.Parameters.AddWithValue("@pubkey", textBox7.Text);

                comm.ExecuteNonQuery();
                setTextBox(false);
                loadDatafromNV();
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
            Application.Exit();
        }

        
    }
}
