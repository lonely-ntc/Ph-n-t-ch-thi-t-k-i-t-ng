using System;
using System.Windows.Forms;

namespace user_management
{
    public partial class XemThemForm : Form
    {
        private NguoiDung nguoiDung;

        public XemThemForm(NguoiDung selectedUser)
        {
            InitializeComponent();
            nguoiDung = selectedUser;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            lblTenNguoiDung.Text = nguoiDung.HoTen;
            lblSoDienThoai.Text = nguoiDung.SoDienThoai;
            lblSoSachDaMua.Text = nguoiDung.SoSachDaMua.ToString();
        }

        private void buttonSuaThongTin_Click(object sender, EventArgs e)
        {
            string tenMoi = txtTenNguoiDung.Text;
            string soDienThoaiMoi = txtSoDienThoai.Text;
            int soSachDaMuaMoi;
            if (!int.TryParse(txtSoSachDaMua.Text, out soSachDaMuaMoi))
            {
                MessageBox.Show("Số sách đã mua phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nguoiDung.HoTen = tenMoi;
            nguoiDung.SoDienThoai = soDienThoaiMoi;
            nguoiDung.SoSachDaMua = soSachDaMuaMoi;

            MessageBox.Show("Thông tin đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayUserInfo(); // Cập nhật hiển thị thông tin mới
        }

        private void buttonXoaNguoiDung_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Người dùng đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
