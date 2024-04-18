using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    namespace ViewStatisticsReport
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            rdbtnBaoCaoND.Checked = false;
            rdbtnBaoCaoSach.Checked = false;
            rdbtnBaoCaoDT.Checked = false;
        }

           

            private void DisplayReports(List<string> selectedReportTypes)
            {
                foreach (string reportType in selectedReportTypes)
                {
                    switch (reportType)
                    {
                        case "Báo cáo người dùng":
                            DisplayUserReport();
                            break;
                        case "Báo cáo sách":
                            DisplayBookReport();
                            break;
                        case "Báo cáo doanh thu":
                            DisplayRevenueReport();
                            break;
                        default:
                            break;
                    }
                }
            }

        private void DisplayUserReport()
        {
            txtKetQua.AppendText("Báo cáo người dùng: Tổng số người dùng: 1,5 triệu người dùng (Đã có hơn 1,5 triệu người dùng đăng ký app)\nSố lượng người dùng mới: 300.000 người dùng/năm (Đã có hơn 300.000 người dùng mới trong 1 năm)\n...\n\n");
        }

        private void DisplayBookReport()
        {
            txtKetQua.AppendText("Báo cáo sách:\nTổng số sách: 4tr+ ( Hơn 4tr sách có trong hệ thống của app)\\n\r\n\r\nSố lượng sách bán ra: 1tr+/1year ( Hơn 1tr cuốn sách được bán ra trong 1 năm)\\n\r\n\r\nDoanh thu bán sách: 20 tỷ VNĐ/1year (Doanh thu bán sách đạt 20 tỷ đồng trong 1 năm)\\n\r\n\r\nSách bán chạy nhất:\\n\r\n\r\nTop 1: \"Tên sách bán chạy nhất\" (Tác giả) - 100k bản\\n\r\n\r\nTop 2: \"Tên sách bán chạy thứ 2\" (Tác giả) - 80k bản\\n\r\n\r\nTop 3: \"Tên sách bán chạy thứ 3\" (Tác giả) - 70k bản\\n\r\n\r\nPhân tích theo thể loại:\\n\r\n\r\nVăn học: 40% (40% doanh thu bán sách thuộc về thể loại văn học)\\n\r\n\r\nKỹ năng sống: 30% (30% doanh thu bán sách thuộc về thể loại kỹ năng sống)\\n\r\n\r\nKinh doanh: 20% (20% doanh thu bán sách thuộc về thể loại kinh doanh)\\n\r\n\r\nKhác: 10% (10% doanh thu bán sách thuộc về các thể loại khác)\\n\r\n\r\nPhân tích theo tác giả:\\n\r\n\r\nTác giả 1: 200k bản (Tác giả 1 bán được 200k bản sách)\\n\r\n\r\nTác giả 2: 150k bản (Tác giả 2 bán được 150k bản sách)\\n\r\n\r\nTác giả 3: 100k bản (Tác giả 3 bán được 100k bản sách)\\n\r\n\r\nLợi nhuận gộp: 5 tỷ VNĐ/1year (Lợi nhuận gộp đạt 5 tỷ đồng trong 1 năm)\\n\r\n\r\nTỷ suất lợi nhuận: 25% (Tỷ suất lợi nhuận đạt 25%)\\n\r\n\r\nPhân tích theo chi phí:\\n\r\n\r\nChi phí nhân viên: 2 tỷ VNĐ/1year\\n\r\n\r\nChi phí marketing: 1 tỷ VNĐ/1year\\n\r\n\r\nChi phí vận chuyển: 500 triệu VNĐ/1year\\n\r\n\r\nChi phí khác: 500 triệu VNĐ/1year\\n");
        }

        private void DisplayRevenueReport()
        {
            txtKetQua.AppendText("Báo cáo doanh thu: Doanh thu theo kênh bán hàng:\nOnline: 15 tỷ VNĐ/1year (75% doanh thu bán sách đến từ kênh bán hàng online)\nOffline: 5 tỷ VNĐ/1year (25% doanh thu bán sách đến từ kênh bán hàng offline)\n...\n\n");
        }

        private void btnViewReport_Click_1(object sender, EventArgs e)
        {
            List<string> selectedReportTypes = GetSelectedReportTypes();

            if (selectedReportTypes.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một loại báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DisplayReports(selectedReportTypes);
        }


        private List<string> GetSelectedReportTypes()
        {
            List<string> selectedReportTypes = new List<string>();

            if (rdbtnBaoCaoND.Checked)
            {
                selectedReportTypes.Add("Báo cáo người dùng");
            }

            if (rdbtnBaoCaoSach.Checked)
            {
                selectedReportTypes.Add("Báo cáo sách");
            }

            if (rdbtnBaoCaoDT.Checked)
            {
                selectedReportTypes.Add("Báo cáo doanh thu");
            }

            return selectedReportTypes;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

