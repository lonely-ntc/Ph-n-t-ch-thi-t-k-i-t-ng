using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AreFieldsValid())
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn lưu thông tin này?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Xác nhận lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool AreFieldsValid()
        {
            // Kiểm tra xem tất cả các ô văn bản đã được điền đầy đủ
            if (string.IsNullOrWhiteSpace(textBox1.Text) || // Tên
                string.IsNullOrWhiteSpace(textBox2.Text) || // Số điện thoại
                string.IsNullOrWhiteSpace(textBox3.Text) || // Ngày tháng năm sinh
                string.IsNullOrWhiteSpace(textBox4.Text) || // Địa chỉ
                string.IsNullOrWhiteSpace(textBox5.Text) || // Lịch sử mua sách
                string.IsNullOrWhiteSpace(textBox6.Text) || // Giới tính
                string.IsNullOrWhiteSpace(textBox7.Text))   // Tên đăng nhập
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra các điều kiện khác nếu cần

            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
