namespace LAB3_NHÓM
{
    partial class FormLop
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
            this.dataGridViewLop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxLop_MaNV = new System.Windows.Forms.TextBox();
            this.txtBoxLop_TenLop = new System.Windows.Forms.TextBox();
            this.txtBoxLop_MaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLop_Select = new System.Windows.Forms.Button();
            this.btnLop_Insert = new System.Windows.Forms.Button();
            this.btnLop_Delete = new System.Windows.Forms.Button();
            this.btnLop_Update = new System.Windows.Forms.Button();
            this.btnLop_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dataGridViewLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // dataGridViewLop
            // 
            this.dataGridViewLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLop.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewLop.Name = "dataGridViewLop";
            this.dataGridViewLop.Size = new System.Drawing.Size(358, 150);
            this.dataGridViewLop.TabIndex = 0;
            this.dataGridViewLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLop_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtBoxLop_MaNV);
            this.groupBox2.Controls.Add(this.txtBoxLop_TenLop);
            this.groupBox2.Controls.Add(this.txtBoxLop_MaLop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý lớp học";
            // 
            // txtBoxLop_MaNV
            // 
            this.txtBoxLop_MaNV.Location = new System.Drawing.Point(76, 178);
            this.txtBoxLop_MaNV.Name = "txtBoxLop_MaNV";
            this.txtBoxLop_MaNV.Size = new System.Drawing.Size(175, 23);
            this.txtBoxLop_MaNV.TabIndex = 2;
            // 
            // txtBoxLop_TenLop
            // 
            this.txtBoxLop_TenLop.Location = new System.Drawing.Point(76, 120);
            this.txtBoxLop_TenLop.Name = "txtBoxLop_TenLop";
            this.txtBoxLop_TenLop.Size = new System.Drawing.Size(175, 23);
            this.txtBoxLop_TenLop.TabIndex = 1;
            // 
            // txtBoxLop_MaLop
            // 
            this.txtBoxLop_MaLop.Location = new System.Drawing.Point(76, 51);
            this.txtBoxLop_MaLop.Name = "txtBoxLop_MaLop";
            this.txtBoxLop_MaLop.Size = new System.Drawing.Size(175, 23);
            this.txtBoxLop_MaLop.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // btnLop_Select
            // 
            this.btnLop_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLop_Select.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop_Select.Location = new System.Drawing.Point(275, 217);
            this.btnLop_Select.Name = "btnLop_Select";
            this.btnLop_Select.Size = new System.Drawing.Size(107, 54);
            this.btnLop_Select.TabIndex = 2;
            this.btnLop_Select.Text = "SELECT";
            this.btnLop_Select.UseVisualStyleBackColor = true;
            this.btnLop_Select.Click += new System.EventHandler(this.btnLop_Select_Click);
            // 
            // btnLop_Insert
            // 
            this.btnLop_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLop_Insert.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop_Insert.Location = new System.Drawing.Point(275, 277);
            this.btnLop_Insert.Name = "btnLop_Insert";
            this.btnLop_Insert.Size = new System.Drawing.Size(107, 54);
            this.btnLop_Insert.TabIndex = 3;
            this.btnLop_Insert.Text = "INSERT";
            this.btnLop_Insert.UseVisualStyleBackColor = true;
            this.btnLop_Insert.Click += new System.EventHandler(this.btnLop_Insert_Click);
            // 
            // btnLop_Delete
            // 
            this.btnLop_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLop_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop_Delete.Location = new System.Drawing.Point(275, 337);
            this.btnLop_Delete.Name = "btnLop_Delete";
            this.btnLop_Delete.Size = new System.Drawing.Size(107, 54);
            this.btnLop_Delete.TabIndex = 4;
            this.btnLop_Delete.Text = "DELETE";
            this.btnLop_Delete.UseVisualStyleBackColor = true;
            this.btnLop_Delete.Click += new System.EventHandler(this.btnLop_Delete_Click);
            // 
            // btnLop_Update
            // 
            this.btnLop_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLop_Update.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop_Update.Location = new System.Drawing.Point(275, 397);
            this.btnLop_Update.Name = "btnLop_Update";
            this.btnLop_Update.Size = new System.Drawing.Size(107, 54);
            this.btnLop_Update.TabIndex = 5;
            this.btnLop_Update.Text = "UPDATE";
            this.btnLop_Update.UseVisualStyleBackColor = true;
            this.btnLop_Update.Click += new System.EventHandler(this.btnLop_Update_Click);
            // 
            // btnLop_Thoat
            // 
            this.btnLop_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLop_Thoat.Location = new System.Drawing.Point(403, 422);
            this.btnLop_Thoat.Name = "btnLop_Thoat";
            this.btnLop_Thoat.Size = new System.Drawing.Size(89, 29);
            this.btnLop_Thoat.TabIndex = 6;
            this.btnLop_Thoat.Text = "Back";
            this.btnLop_Thoat.UseVisualStyleBackColor = true;
            this.btnLop_Thoat.Click += new System.EventHandler(this.btnLop_Thoat_Click);
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 463);
            this.Controls.Add(this.btnLop_Thoat);
            this.Controls.Add(this.btnLop_Update);
            this.Controls.Add(this.btnLop_Delete);
            this.Controls.Add(this.btnLop_Insert);
            this.Controls.Add(this.btnLop_Select);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(520, 502);
            this.MinimumSize = new System.Drawing.Size(520, 502);
            this.Name = "FormLop";
            this.Text = "Màn hình quản lý lớp học";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxLop_MaNV;
        private System.Windows.Forms.TextBox txtBoxLop_TenLop;
        private System.Windows.Forms.TextBox txtBoxLop_MaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLop_Select;
        private System.Windows.Forms.Button btnLop_Insert;
        private System.Windows.Forms.Button btnLop_Delete;
        private System.Windows.Forms.Button btnLop_Update;
        private System.Windows.Forms.Button btnLop_Thoat;
    }
}