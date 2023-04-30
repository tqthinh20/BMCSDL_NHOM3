namespace LAB3_NHÓM
{
    partial class FormDSSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTendn = new System.Windows.Forms.TextBox();
            this.tbMatkhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbMalop = new System.Windows.Forms.TextBox();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSV_Back = new System.Windows.Forms.Button();
            this.btnSV_Select = new System.Windows.Forms.Button();
            this.btnSV_Insert = new System.Windows.Forms.Button();
            this.btnSV_Delete = new System.Windows.Forms.Button();
            this.btnSV_Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1019, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // dgv_SV
            // 
            this.dgv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV.Location = new System.Drawing.Point(8, 27);
            this.dgv_SV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SV.Name = "dgv_SV";
            this.dgv_SV.RowHeadersWidth = 51;
            this.dgv_SV.Size = new System.Drawing.Size(1004, 166);
            this.dgv_SV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTendn);
            this.groupBox2.Controls.Add(this.tbMatkhau);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbNgaysinh);
            this.groupBox2.Controls.Add(this.tbDiachi);
            this.groupBox2.Controls.Add(this.tbHoten);
            this.groupBox2.Controls.Add(this.tbMalop);
            this.groupBox2.Controls.Add(this.tbMaSV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(32, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(445, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý sinh viên";
            // 
            // tbTendn
            // 
            this.tbTendn.Location = new System.Drawing.Point(155, 231);
            this.tbTendn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTendn.Name = "tbTendn";
            this.tbTendn.Size = new System.Drawing.Size(263, 26);
            this.tbTendn.TabIndex = 7;
            // 
            // tbMatkhau
            // 
            this.tbMatkhau.Location = new System.Drawing.Point(155, 268);
            this.tbMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMatkhau.Name = "tbMatkhau";
            this.tbMatkhau.Size = new System.Drawing.Size(263, 26);
            this.tbMatkhau.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(15, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(15, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên đăng nhập";
            // 
            // tbNgaysinh
            // 
            this.tbNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbNgaysinh.Location = new System.Drawing.Point(155, 106);
            this.tbNgaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNgaysinh.Name = "tbNgaysinh";
            this.tbNgaysinh.Size = new System.Drawing.Size(263, 26);
            this.tbNgaysinh.TabIndex = 2;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(155, 153);
            this.tbDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(263, 26);
            this.tbDiachi.TabIndex = 3;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(155, 66);
            this.tbHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(263, 26);
            this.tbHoten.TabIndex = 1;
            // 
            // tbMalop
            // 
            this.tbMalop.Location = new System.Drawing.Point(155, 190);
            this.tbMalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMalop.Name = "tbMalop";
            this.tbMalop.Size = new System.Drawing.Size(263, 26);
            this.tbMalop.TabIndex = 4;
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(155, 32);
            this.tbMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(263, 26);
            this.tbMaSV.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(15, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // btnSV_Back
            // 
            this.btnSV_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSV_Back.Location = new System.Drawing.Point(991, 508);
            this.btnSV_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSV_Back.Name = "btnSV_Back";
            this.btnSV_Back.Size = new System.Drawing.Size(79, 34);
            this.btnSV_Back.TabIndex = 10;
            this.btnSV_Back.Text = "Back";
            this.btnSV_Back.UseVisualStyleBackColor = true;
            this.btnSV_Back.Click += new System.EventHandler(this.btnSV_Back_Click);
            // 
            // btnSV_Select
            // 
            this.btnSV_Select.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV_Select.Location = new System.Drawing.Point(577, 291);
            this.btnSV_Select.Margin = new System.Windows.Forms.Padding(4);
            this.btnSV_Select.Name = "btnSV_Select";
            this.btnSV_Select.Size = new System.Drawing.Size(143, 66);
            this.btnSV_Select.TabIndex = 11;
            this.btnSV_Select.Text = "SELECT";
            this.btnSV_Select.UseVisualStyleBackColor = true;
            this.btnSV_Select.Click += new System.EventHandler(this.btnSV_Select_Click);
            // 
            // btnSV_Insert
            // 
            this.btnSV_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV_Insert.Location = new System.Drawing.Point(808, 291);
            this.btnSV_Insert.Margin = new System.Windows.Forms.Padding(4);
            this.btnSV_Insert.Name = "btnSV_Insert";
            this.btnSV_Insert.Size = new System.Drawing.Size(143, 66);
            this.btnSV_Insert.TabIndex = 12;
            this.btnSV_Insert.Text = "INSERT";
            this.btnSV_Insert.UseVisualStyleBackColor = true;
            this.btnSV_Insert.Click += new System.EventHandler(this.btnSV_Insert_Click);
            // 
            // btnSV_Delete
            // 
            this.btnSV_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV_Delete.Location = new System.Drawing.Point(577, 375);
            this.btnSV_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSV_Delete.Name = "btnSV_Delete";
            this.btnSV_Delete.Size = new System.Drawing.Size(143, 66);
            this.btnSV_Delete.TabIndex = 12;
            this.btnSV_Delete.Text = "DELETE";
            this.btnSV_Delete.UseVisualStyleBackColor = true;
            this.btnSV_Delete.Click += new System.EventHandler(this.btnSV_Delete_Click);
            // 
            // btnSV_Update
            // 
            this.btnSV_Update.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV_Update.Location = new System.Drawing.Point(808, 375);
            this.btnSV_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btnSV_Update.Name = "btnSV_Update";
            this.btnSV_Update.Size = new System.Drawing.Size(143, 66);
            this.btnSV_Update.TabIndex = 12;
            this.btnSV_Update.Text = "UPDATE";
            this.btnSV_Update.UseVisualStyleBackColor = true;
            this.btnSV_Update.Click += new System.EventHandler(this.btnSV_Update_Click);
            // 
            // FormDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.btnSV_Update);
            this.Controls.Add(this.btnSV_Delete);
            this.Controls.Add(this.btnSV_Insert);
            this.Controls.Add(this.btnSV_Select);
            this.Controls.Add(this.btnSV_Back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "FormDSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình quản lý sinh viên";
            this.Load += new System.EventHandler(this.FormDSSV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tbNgaysinh;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbMalop;
        private System.Windows.Forms.Button btnSV_Back;
        private System.Windows.Forms.DataGridView dgv_SV;
        private System.Windows.Forms.Button btnSV_Select;
        private System.Windows.Forms.Button btnSV_Insert;
        private System.Windows.Forms.Button btnSV_Delete;
        private System.Windows.Forms.Button btnSV_Update;
        private System.Windows.Forms.TextBox tbTendn;
        private System.Windows.Forms.TextBox tbMatkhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}