using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bai4._2
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
            var courses = new[]
            {
                new { Id = 1, Name = "Lập trình C#" },
                new { Id = 2, Name = "Lập trình Java" },
                new { Id = 3, Name = "Lập trình Python" },
                new { Id = 4, Name = "Cơ sở dữ liệu" }
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!chkAgree.Checked)
            {
                MessageBox.Show("Bạn phải tích chọn đồng ý trước khi đăng ký!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string hoTen = txtName.Text.Trim();
            string soDienThoai = mtxtPhone.Text.Trim();
            DateTime ngaySinh = dtpBirthDate.Value.Date;
            string gioiTinh = rdoMale.Checked ? "Nam" : (rdoFemale.Checked ? "Nữ" : "Khác");
            string khoaHoc = cboCourse.Text;

            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO DangKyHocVien (HoTen, SoDienThoai, NgaySinh, GioiTinh, KhoaHoc) 
                                     VALUES (@HoTen, @SoDienThoai, @NgaySinh, @GioiTinh, @KhoaHoc)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@KhoaHoc", khoaHoc);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Đăng ký thành công và đã lưu vào CSDL SQL Server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
