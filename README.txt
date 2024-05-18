Thông tin tập tin

- Folder QuanLyDuLich
- csdl.bak là file backup
- Data.sql đầy là dữ liệu của CSDL được generate từ SQL Server
- BaoCao_CT291.pdf 



Trước khi sử dụng 

1. Mở file QuanLyDuLich.sln

2. Ở trên thanh bar --> chọn debug

3. Mở Solution Explorer 
	Nếu chưa có tab  Solution Explorer nằm bên phải:
	Cách 1: View --> Solution Explorer
	Cách 2: Ctrl + Alt + L

4. Mở cây thư mục QuanLyDuLich 

5. Tìm kiếm Folder DAO --> Chọn DataProvider.cs

6. Ở dòng số 15 chỉnh sửa chuỗi kết nối chỗ Data Source theo SQL Server máy cá nhân

Mẫu đúng:
private string connectionString = "Data Source=THANHPHAT\\THANHPHAT;Initial Catalog=QUANLYDULICH;Integrated Security=True";

Mẫu thay đổi chuỗi kết nối:
private string connectionString = "Data Source=<Thay đổi ở đây>;Initial Catalog=QUANLYDULICH;Integrated Security=True";

7. Chạy chương trình 



Enjoy it. Have fun

