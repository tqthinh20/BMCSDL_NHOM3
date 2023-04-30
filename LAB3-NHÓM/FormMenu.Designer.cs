namespace LAB3_NHÓM
{
    partial class FormMenu
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
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.btnMenu3 = new System.Windows.Forms.Button();
            this.btnMenu_Thoat = new System.Windows.Forms.Button();
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu1
            // 
            this.btnMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu1.Location = new System.Drawing.Point(81, 42);
            this.btnMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(200, 86);
            this.btnMenu1.TabIndex = 0;
            this.btnMenu1.Text = "Quản lý lớp học";
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.Location = new System.Drawing.Point(81, 268);
            this.btnMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(200, 86);
            this.btnMenu2.TabIndex = 1;
            this.btnMenu2.Text = "Quản lý danh sách sinh viên theo lớp";
            this.btnMenu2.UseVisualStyleBackColor = true;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // btnMenu3
            // 
            this.btnMenu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu3.Location = new System.Drawing.Point(81, 378);
            this.btnMenu3.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(200, 86);
            this.btnMenu3.TabIndex = 2;
            this.btnMenu3.Text = "Nhập điểm";
            this.btnMenu3.UseVisualStyleBackColor = true;
            this.btnMenu3.Click += new System.EventHandler(this.btnMenu3_Click);
            // 
            // btnMenu_Thoat
            // 
            this.btnMenu_Thoat.Location = new System.Drawing.Point(224, 492);
            this.btnMenu_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu_Thoat.Name = "btnMenu_Thoat";
            this.btnMenu_Thoat.Size = new System.Drawing.Size(119, 36);
            this.btnMenu_Thoat.TabIndex = 3;
            this.btnMenu_Thoat.Text = "Thoát";
            this.btnMenu_Thoat.UseVisualStyleBackColor = true;
            this.btnMenu_Thoat.Click += new System.EventHandler(this.btnMenu_Thoat_Click);
            // 
            // btnMenu4
            // 
            this.btnMenu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu4.Location = new System.Drawing.Point(81, 157);
            this.btnMenu4.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(200, 86);
            this.btnMenu4.TabIndex = 4;
            this.btnMenu4.Text = "Quản lý nhân viên";
            this.btnMenu4.UseVisualStyleBackColor = true;
            this.btnMenu4.Click += new System.EventHandler(this.btnMenu4_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 533);
            this.Controls.Add(this.btnMenu4);
            this.Controls.Add(this.btnMenu_Thoat);
            this.Controls.Add(this.btnMenu3);
            this.Controls.Add(this.btnMenu2);
            this.Controls.Add(this.btnMenu1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(374, 580);
            this.MinimumSize = new System.Drawing.Size(374, 580);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu1;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.Button btnMenu3;
        private System.Windows.Forms.Button btnMenu_Thoat;
        private System.Windows.Forms.Button btnMenu4;
    }
}