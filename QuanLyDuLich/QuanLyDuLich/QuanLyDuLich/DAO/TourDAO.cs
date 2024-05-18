using QuanLyDuLich.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;


namespace QuanLyDuLich.DAO
{
    public class TourDAO
    {
        private static TourDAO instance;

        public static TourDAO Instance
        {
            get { if (instance == null) instance = new TourDAO(); return instance; }
            private set { instance = value; }
        }

        public TourDAO() { }

        public DataTable HienThiDanhSachTour()
        {
            string query = "SELECT [TOUR_ID] AS N'Mã Tour',[TOUR_Ten] AS N'Tên Tour', FORMAT([TOUR_NgayKhoiHanh], 'dd-MM-yyyy') AS N'Ngày khởi hành',[TOUR_SoNgay] AS N'Số ngày',[TOUR_DonGia] AS N'Đơn giá',[TOUR_NoiKhoiHanh] AS N'Nơi khởi hành', [TOUR_TongSoVeTour] AS N'Tổng số vé' FROM dbo.tour ORDER BY CAST(SUBSTRING(TOUR_ID, 2, LEN(TOUR_ID) - 1) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable HienThiDanhSachTour(string timkiem)
        {
            string query = "SELECT [TOUR_ID] AS N'Mã Tour',[TOUR_Ten] AS N'Tên Tour', FORMAT([TOUR_NgayKhoiHanh], 'dd-MM-yyyy') AS N'Ngày khởi hành',[TOUR_SoNgay] AS N'Số ngày',[TOUR_DonGia] AS N'Đơn giá',[TOUR_NoiKhoiHanh] AS N'Nơi khởi hành', [TOUR_TongSoVeTour] AS N'Tổng số vé' FROM dbo.tour WHERE TOUR_Ten like N'%" + timkiem + "%'  ORDER BY CAST(SUBSTRING(TOUR_ID, 2, LEN(TOUR_ID) - 1) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public string MaTourMoiNhat()
        {
            string kq = "T1";
            string query = "SELECT TOP 1 TOUR_ID FROM [dbo].[TOUR] ORDER BY CAST(SUBSTRING(TOUR_ID, 2, LEN(TOUR_ID) - 1) AS INT) DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                // Lấy giá trị cột TOUR_ID từ dòng đầu tiên
                string tourIdString = data.Rows[0]["TOUR_ID"].ToString();

                kq = "T" + (Convert.ToInt32(tourIdString.Substring(1)) + 1).ToString();
            }
            return kq;
        }

        public void ThemTourMoi(Tour tour)
        {
            string query = "EXEC Proc_Tour_Them @id , @ten , @ngayKhoiHanh , @soNgay , @donGia , @noiKH , @tongSoVe";
            DataProvider.Instance.ExecuteQuery(query, new object[] {
                tour.IdTour, tour.TenTour, tour.NgayKhoiHanh, tour.SoNgay, tour.DonGia, tour.NoiKhoiHanh, tour.TongVe
            });
        }

        public void SuaTour(Tour tour)
        {
            string query = "EXEC Proc_Tour_Sua @id , @ten , @ngayKhoiHanh , @soNgay , @donGia , @noiKH , @tongSoVe";
            DataProvider.Instance.ExecuteQuery(query, new object[] {
                tour.IdTour, tour.TenTour, tour.NgayKhoiHanh, tour.SoNgay, tour.DonGia, tour.NoiKhoiHanh, tour.TongVe
            });
        }

        public void XoaTour(string id)
        {
            string query = "EXEC Proc_Tour_Xoa @id";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }



        public async void ThemHinhAnhTour(string idTour, int STT)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Get selected file path and filename
                string filePath = ofd.FileName;

                // Check if resource folder exists, create it if necessary
                string resourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HinhAnhTour");

                if (!Directory.Exists(resourcePath))
                {
                    Directory.CreateDirectory(resourcePath);
                }


                string ha_ten_morong = idTour + "_" + STT.ToString() + Path.GetExtension(filePath);

                // Copy file to resource folder
                string destinationPath = Path.Combine(resourcePath, ha_ten_morong);


                try
                {
                    if (File.Exists(Path.GetFileNameWithoutExtension(destinationPath)))
                    {
                        File.Delete(Path.GetFileNameWithoutExtension(destinationPath));
                    }

                    //nếu như tên của hình ảnh không tính đuôi
                    // thì xóa hình ảnh cũ và thêm hình ảnh mới vào
                    File.Copy(filePath, destinationPath, true); // Overwrite existing files


                    //Thêm hình ảnh vào CSDL

                    string query = "EXEC PROC_Tour_ThemHinhANH @HA_Ten , @HA_DuongDan , @HA_STT , @TOUR_ID";
                    DataProvider.Instance.ExecuteQuery(query, new object[] { ha_ten_morong, Path.Combine("HinhAnhTour", ha_ten_morong), STT.ToString(), idTour });

                    MessageBox.Show("Thêm hình ảnh thành công", "Thêm hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra " + ex.Message, "Thêm hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            } else { return; }
            return;
        }

        public string LoadHinhAnhByIDTour_STT(string idTour, int STT)
        {
            string query = "EXEC PROC_Tour_LoadHinhAnH @HA_STT , @TOUR_ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {STT.ToString(), idTour});

            string kq = "";
            // Kiểm tra xem có dữ liệu trả về không
            if (data != null && data.Rows.Count > 0)
            {
                // Trả về đường dẫn hình ảnh từ cột HA_DuongDan trong bảng dữ liệu
                kq = data.Rows[0]["HA_DuongDan"].ToString();
            }
            else
            {
                // Trường hợp không có dữ liệu trả về
                kq = null; // hoặc một giá trị khác để xác định không có hình ảnh được tìm thấy
            }
            return kq;
        }

        public void XoaTatCaHinhAnhTour(string idTour)
        {
            string query = "EXEC PROC_Tour_XoaHinhAnH @TOUR_ID ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { idTour });
        }


        public List<string> HienThiThongTinTourTheoID(string id)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();

            string query = "select tour_id, tour_ten, TOUR_TongSoVeTour, TOUR_DonGia from Tour where tour_id = @id";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (dt.Rows.Count > 0) // Kiểm tra xem DataTable có hàng không
            {
                DataRow row = dt.Rows[0]; // Lấy hàng đầu tiên

                // Chuyển đổi giá trị từ các cột sang chuỗi và thêm vào danh sách
                list.Add(row["tour_id"].ToString());
                list.Add(row["tour_ten"].ToString());
                list.Add(row["TOUR_TongSoVeTour"].ToString());
                list.Add(row["TOUR_DonGia"].ToString());
            }

            ///HINH ANH
            string query2 = "select HA_DuongDan from HINHANHTOUR where HA_STT = 1 AND tour_id = @id";
            DataTable dt2 = DataProvider.Instance.ExecuteQuery(query2, new object[] { id });

            list.Add(""); //hinh anh [4]

            if (dt2.Rows.Count > 0)
            {
                DataRow row2 = dt2.Rows[0];
                list[4] = row2["HA_DuongDan"].ToString();
            }

            return list;
        }
    }
}
