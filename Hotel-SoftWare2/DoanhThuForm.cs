using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace Hotel_SoftWare2
{
    public partial class DoanhThuForm : Form
    {
        htEntities context = new htEntities();
        public DoanhThuForm()
        {
            InitializeComponent();
        }

        private void DoanhThuForm_Load(object sender, EventArgs e)
        {

        }

        private void showTienDvDetail(DataGridView dgv)
        {
            dgv.DataSource = context.getDoanhThuTienDV(dtpNgayVao.Value, dtpNgaydi.Value);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showTienPhongDetail(DataGridView dgv)
        {
            dgv.DataSource = context.getDoanhThuTienPhong(dtpNgayVao.Value, dtpNgaydi.Value);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpNgayVao.Value < dtpNgaydi.Value)
            {
                showTienPhongDetail(dgvTienPhongDetail);
                showTienDvDetail(dgvTienDvDetail);
                showTien();
            }
            else
            {
                MessageBox.Show("sai ngay!!!");
            }
        }

        private void showTien()
        {
            int sumtienDV = 0, sumtienPhong = 0, i;
            for (i = 0; i < dgvTienDvDetail.Rows.Count; i++)
            {
                sumtienDV += Convert.ToInt32(dgvTienDvDetail.Rows[i].Cells[4].Value);
            }

            for (i = 0; i < dgvTienPhongDetail.Rows.Count; i++)
            {
                sumtienPhong += Convert.ToInt32(dgvTienPhongDetail.Rows[i].Cells[4].Value);
            }

            labelTongTienDV.Text = sumtienDV.ToString();
            labelTongTienPhong.Text = sumtienPhong.ToString();
            labelTongDT.Text = (sumtienDV + sumtienPhong).ToString();
        }

        //public class DoanhThu
        //{
        //    public string Name { get; set; }
        //    public DateTime Birthday { get; set; }
        //}

        private void exportExcel()
        {
            //ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (Convert.ToBoolean(dialog.ShowDialog()) == true)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "MTA-HOTEL";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Thống kê doanh thu";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Thống kê doanh thu sheet");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    // đặt tên cho sheet
                    ws.Name = "MTA-HOTEL sheet";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Tổng tiền phòng",
                                                "Tổng tiền dịch vụ",
                                                "Tổng doanh thu",
                                                "Từ ngày",
                                                "Đến ngày"
                    };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "THỐNG KÊ DOANH THU CỦA KHÁCH SẠN HOÀNG GIA MTA";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // lấy ra danh sách UserInfo từ ItemSource của DataGrid
                    //List<DoanhThu> doanhthu = dtgExcel.ItemsSource.Cast<UserInfo>().ToList();

                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    /*foreach (var item in userList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.Name;

                        // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();

                    }*/
                    ws.Cells[3, 1].Value = labelTongTienPhong.Text;
                    ws.Cells[3, 2].Value = labelTongTienDV.Text;
                    ws.Cells[3, 3].Value = labelTongTien.Text;
                    ws.Cells[3, 4].Value = dtpNgayVao.Text;
                    ws.Cells[3, 5].Value = dtpNgaydi.Text;

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInFile_Click(object sender, EventArgs e)
        {
            exportExcel();
        }
    }
}
