using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buy_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSoluong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add selected item and quantity to cart (replace with your actual logic)
            int selectedQuantity = int.Parse(cbSoluong.SelectedItem.ToString());
            // Add selectedQuantity to cart

            MessageBox.Show("Đã thêm " + selectedQuantity + " sản phẩm vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e) // Assuming button3 is for adding to cart
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            giohang f1 = new giohang();
            f1.Show();
        }
    }
}
