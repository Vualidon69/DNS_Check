using System;
using System.Windows.Forms;

namespace DNS_DoAn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (UserSession.Login(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                new MainForm().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
            }
        }

        // SỰ KIỆN NÚT ĐĂNG KÝ MỚI
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text.Trim();
            string p = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu để đăng ký.");
                return;
            }

            if (UserSession.Register(u, p))
            {
                MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay bây giờ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            MessageBox.Show("Chế độ khách (Không lưu lịch sử).");
            this.Hide();
            new MainForm().ShowDialog();
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}