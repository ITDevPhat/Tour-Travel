using QuanLyDuLich.DAO;

namespace QuanLyDuLich
{
    public partial class f_Login : Form
    {
        public f_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool isLogin(string userName, string passWord)
        {
            return DangNhapDAO.Instance.Login(userName, passWord);
        }
        private void btn_Login_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtBox_TenDangNhap.Text;
            string passWord = txtBox_MatKhau.Text;

            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng điền thông tin đăng nhập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //đăng nhập đúng không
            if (isLogin(userName, passWord))
            {
                //kiểm tra có phải là admin không?
                if (DangNhapDAO.Instance.isAdmin(userName))
                {
                    f_admin_Homepage f = new f_admin_Homepage(userName);
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    f_NhanVien_Homepage f = new f_NhanVien_Homepage(userName);
                    this.Hide();
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mặt khẩu. Vui lòng nhập lại!", "Lỗi đăng nhập");
            }
        }

        private void txtBox_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userName = txtBox_TenDangNhap.Text;
                string passWord = txtBox_MatKhau.Text;

                //đăng nhập đúng không
                if (isLogin(userName, passWord))
                {
                    //kiểm tra có phải là admin không?
                    if (DangNhapDAO.Instance.isAdmin(userName))
                    {
                        f_admin_Homepage f = new f_admin_Homepage(userName);
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        f_NhanVien_Homepage f = new f_NhanVien_Homepage(userName);
                        this.Hide();
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mặt khẩu. Vui lòng nhập lại!", "Lỗi đăng nhập");
                }
            }
        }

        private void f_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
