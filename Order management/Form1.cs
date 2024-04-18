using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_management
{
    public partial class Form1 : Form
    {
        private List<DonHang> danhSachDonHang = new List<DonHang>
        {
           new DonHang("Bắt Đầu Từ Con Số 0", "Hồ Chí Minh", "đang giao"),
            new DonHang("Đắc Nhân Tâm", "Đà Nẵng", "đang chờ xử lý"),
            new DonHang("Lược Sử Vạn Vật", "Cần Thơ", "trên đường đi"),
            new DonHang("Nhà Giả Kim", "Hà Nội", "đã giao"),
            new DonHang(" Sapiens: Lược Sử Loài Người", "Hải Phòng", "đang chờ xử lý"),
            new DonHang("Tuổi Trẻ Đáng Giá Bao Nhiêu?", "Bình Dương", "đã giao"),
            new DonHang(" Muôn Kiếp Nhân Sinh", "Đồng Nai", "đang giao"),
            new DonHang("Lối Sống Tối Giản Của Người Nhật", "Khánh Hòa", "trên đường đi"),
            new DonHang("Cha Giàu Cha Nghèo", "Quảng Nam", "đang chờ xử lý"),
            new DonHang(" Tôi Tự Học", "Lâm Đồng", "đã giao"),


        };

        public Form1()
        {
            InitializeComponent();
            LoadDataToListBox();
        }

        private void LoadDataToListBox()
        {
            foreach (var donHang in danhSachDonHang)
            {
                listDonHang.Items.Add(donHang);
            }
        }


        private void btnXacNhanDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xác nhận đơn hàng này?", "Xác nhận đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Xác nhận đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            }
        }
        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            string[] trangThaiMoi = { "Đang giao", "Đang chờ xử lý", "Trên đường đi" };
            string trangThaiCu = ((DonHang)listDonHang.SelectedItem).TrangThai;

            DialogResult dialogResult = MessageBox.Show("Chọn trạng thái mới cho đơn hàng:", "Cập nhật trạng thái", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                
                
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy đơn hàng này?", "Xác nhận hủy đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                danhSachDonHang.Remove((DonHang)listDonHang.SelectedItem);
                RefreshListBox();
            }
        }
        private void RefreshListBox()
        {
            listDonHang.Items.Clear();
            foreach (var donHang in danhSachDonHang)
            {
                listDonHang.Items.Add(donHang);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class DonHang
    {
        public string TenSach { get; set; }
        public string DiaDiem { get; set; }
        public string TrangThai { get; set; }

        public DonHang(string tenSach, string diaDiem, string trangThai)
        {
            TenSach = tenSach;
            DiaDiem = diaDiem;
            TrangThai = trangThai;
        }

        public override string ToString()
        {
            return $"Tên sách: {TenSach} - Địa điểm: {DiaDiem} - Trạng thái: {TrangThai}";
        }
    }
}
