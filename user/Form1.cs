using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using user;

namespace user_management
{

    public partial class Form1 : Form
    {
        private List<NguoiDung> danhSachNguoiDung = new List<NguoiDung>
        {
            new NguoiDung("Nguyễn Thị Anh", "123456789", 5),
            new NguoiDung("Trần Văn Bình", "987654321", 10),
            new NguoiDung("Phạm Thị Cẩm", "111222333", 7),
            new NguoiDung("Lê Minh Đức", "444555666", 3),
            new NguoiDung("Hồ Văn Dương", "777888999", 8),
            new NguoiDung("Lưu Thị Hoa", "101010101", 12),
            new NguoiDung("Hoàng Văn Hùng", "121212121", 6),
            new NguoiDung("Đỗ Thị Lan", "131313131", 15),
            new NguoiDung("Nguyễn Xuân Mai", "141414141", 9),
            new NguoiDung("Vũ Hoàng Nam", "151515151", 11),
            new NguoiDung("Lương Trung Hoàng", "161616161", 4),
            new NguoiDung("Nguyễn Chung Hiếu", "171717171", 2),
            new NguoiDung("Sơn Tùng MTP", "181818181", 20)
        };

        public Form1()
        {
            InitializeComponent();
            LoadDataToListBox();
        }

        private void LoadDataToListBox()
        {
            foreach (var user in danhSachNguoiDung)
            {
                listNguoiDung.Items.Add(user);
            }
        }


       
        private void buttonXuatDanhSach_Click_1(object sender, EventArgs e)
        {
            string danhSach = string.Join("\n", danhSachNguoiDung.Select(user => $"{user.HoTen} - Số điện thoại: {user.SoDienThoai} - Số sách đã mua: {user.SoSachDaMua}"));
            MessageBox.Show(danhSach, "Danh sách người dùng");
        }

        
        private void buttonXemThem_Click_1(object sender, EventArgs e)
        {
            
                if (listNguoiDung.SelectedIndex != -1)
                {
                    NguoiDung selectedUser = danhSachNguoiDung[listNguoiDung.SelectedIndex];
                    Form2 form2 = new Form2(selectedUser, this);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một người dùng từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listNguoiDung.SelectedIndex != -1)
            {
                NguoiDung selectedUser = (NguoiDung)listNguoiDung.SelectedItem;
                DialogResult result = MessageBox.Show($"Bạn có muốn xóa người dùng {selectedUser.HoTen} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    danhSachNguoiDung.Remove(selectedUser);
                    listNguoiDung.Items.Remove(selectedUser);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người dùng từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonChon_Click_1(object sender, EventArgs e)
        {
            if (listNguoiDung.SelectedIndex != -1)
            {
                NguoiDung selectedUser = (NguoiDung)listNguoiDung.SelectedItem;
                MessageBox.Show($"Thông tin chi tiết:\nTên: {selectedUser.HoTen}\nSố điện thoại: {selectedUser.SoDienThoai}\nSố sách đã mua: {selectedUser.SoSachDaMua}", "Thông tin chi tiết", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người dùng từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


    public class NguoiDung
    {
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public int SoSachDaMua { get; set; }

        public NguoiDung(string hoTen, string soDienThoai, int soSachDaMua)
        {
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            SoSachDaMua = soSachDaMua;
        }

        public override string ToString()
        {
            return HoTen;
        }
    }
}

