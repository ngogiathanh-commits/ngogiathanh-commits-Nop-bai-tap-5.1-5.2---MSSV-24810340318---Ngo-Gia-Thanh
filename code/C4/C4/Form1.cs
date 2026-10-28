using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C4
{
    public partial class Form1 : Form
    {
        
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ql_sinhvien;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                valid = false;
            }

            if (valid)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                       
                        string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username AND MatKhau = @Password";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                            conn.Open();
                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmMain mainForm = new frmMain();

                                // 2. Hiển thị Form chính lên màn hình
                                mainForm.Show();

                                // 3. Ẩn Form đăng nhập đi
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}