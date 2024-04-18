namespace ViewStatisticsReport
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
            this.components = new System.ComponentModel.Container();
            this.rdbtnBaoCaoND = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.rdbtnBaoCaoSach = new System.Windows.Forms.RadioButton();
            this.rdbtnBaoCaoDT = new System.Windows.Forms.RadioButton();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnBaoCaoND
            // 
            this.rdbtnBaoCaoND.AutoSize = true;
            this.rdbtnBaoCaoND.Checked = true;
            this.rdbtnBaoCaoND.Location = new System.Drawing.Point(114, 232);
            this.rdbtnBaoCaoND.Name = "rdbtnBaoCaoND";
            this.rdbtnBaoCaoND.Size = new System.Drawing.Size(148, 20);
            this.rdbtnBaoCaoND.TabIndex = 0;
            this.rdbtnBaoCaoND.TabStop = true;
            this.rdbtnBaoCaoND.Text = "Báo cáo người dùng";
            this.rdbtnBaoCaoND.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(272, 50);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(337, 307);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.Text = "";
            // 
            // rdbtnBaoCaoSach
            // 
            this.rdbtnBaoCaoSach.AutoSize = true;
            this.rdbtnBaoCaoSach.Location = new System.Drawing.Point(114, 258);
            this.rdbtnBaoCaoSach.Name = "rdbtnBaoCaoSach";
            this.rdbtnBaoCaoSach.Size = new System.Drawing.Size(111, 20);
            this.rdbtnBaoCaoSach.TabIndex = 0;
            this.rdbtnBaoCaoSach.TabStop = true;
            this.rdbtnBaoCaoSach.Text = "Báo cáo sách";
            this.rdbtnBaoCaoSach.UseVisualStyleBackColor = true;
            // 
            // rdbtnBaoCaoDT
            // 
            this.rdbtnBaoCaoDT.AutoSize = true;
            this.rdbtnBaoCaoDT.Location = new System.Drawing.Point(114, 284);
            this.rdbtnBaoCaoDT.Name = "rdbtnBaoCaoDT";
            this.rdbtnBaoCaoDT.Size = new System.Drawing.Size(140, 20);
            this.rdbtnBaoCaoDT.TabIndex = 0;
            this.rdbtnBaoCaoDT.TabStop = true;
            this.rdbtnBaoCaoDT.Text = "Báo cáo doanh thu";
            this.rdbtnBaoCaoDT.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(114, 322);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(152, 35);
            this.btnViewReport.TabIndex = 3;
            this.btnViewReport.Text = "Xem báo cáo";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nội dung báo cáo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(80, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 376);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xem báo cáo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quay lại trang chủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View_statistics_report.Properties.Resources.OIP__3_;
            this.pictureBox1.Location = new System.Drawing.Point(50, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.rdbtnBaoCaoDT);
            this.Controls.Add(this.rdbtnBaoCaoSach);
            this.Controls.Add(this.rdbtnBaoCaoND);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnBaoCaoND;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtKetQua;
        private System.Windows.Forms.RadioButton rdbtnBaoCaoSach;
        private System.Windows.Forms.RadioButton rdbtnBaoCaoDT;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

