namespace user_management
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonXemThem = new System.Windows.Forms.Button();
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonXuatDanhSach = new System.Windows.Forms.Button();
            this.listNguoiDung = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(492, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Quay lại trang chủ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonXemThem
            // 
            this.buttonXemThem.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemThem.Location = new System.Drawing.Point(492, 209);
            this.buttonXemThem.Name = "buttonXemThem";
            this.buttonXemThem.Size = new System.Drawing.Size(122, 43);
            this.buttonXemThem.TabIndex = 12;
            this.buttonXemThem.Text = "Sửa";
            this.buttonXemThem.UseVisualStyleBackColor = true;
            this.buttonXemThem.Click += new System.EventHandler(this.buttonXemThem_Click_1);
            // 
            // buttonChon
            // 
            this.buttonChon.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChon.Location = new System.Drawing.Point(494, 160);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(124, 43);
            this.buttonChon.TabIndex = 11;
            this.buttonChon.Text = "Chọn";
            this.buttonChon.UseVisualStyleBackColor = true;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click_1);
            // 
            // buttonXuatDanhSach
            // 
            this.buttonXuatDanhSach.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXuatDanhSach.Location = new System.Drawing.Point(494, 111);
            this.buttonXuatDanhSach.Name = "buttonXuatDanhSach";
            this.buttonXuatDanhSach.Size = new System.Drawing.Size(122, 43);
            this.buttonXuatDanhSach.TabIndex = 10;
            this.buttonXuatDanhSach.Text = "Xuất danh sách";
            this.buttonXuatDanhSach.UseVisualStyleBackColor = true;
            this.buttonXuatDanhSach.Click += new System.EventHandler(this.buttonXuatDanhSach_Click_1);
            // 
            // listNguoiDung
            // 
            this.listNguoiDung.FormattingEnabled = true;
            this.listNguoiDung.ItemHeight = 16;
            this.listNguoiDung.Location = new System.Drawing.Point(185, 111);
            this.listNguoiDung.Name = "listNguoiDung";
            this.listNguoiDung.Size = new System.Drawing.Size(255, 196);
            this.listNguoiDung.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::user.Properties.Resources.OIP__3_;
            this.pictureBox2.Location = new System.Drawing.Point(80, 354);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::user.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(329, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(155, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 241);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý người dùng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonXemThem);
            this.Controls.Add(this.buttonChon);
            this.Controls.Add(this.buttonXuatDanhSach);
            this.Controls.Add(this.listNguoiDung);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "User manegement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonXemThem;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonXuatDanhSach;
        private System.Windows.Forms.ListBox listNguoiDung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

