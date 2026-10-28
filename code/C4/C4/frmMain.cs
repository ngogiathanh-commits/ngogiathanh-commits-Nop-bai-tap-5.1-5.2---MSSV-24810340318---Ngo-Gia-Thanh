using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C4
{
    public partial class frmMain : Form
    {
        // Chuỗi kết nối SQL Server
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ql_sinhvien;Integrated Security=True";

        public frmMain()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form chính vừa hiện lên
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTableFromSQL();
        }

        // Hàm truy vấn và nạp Bảng dữ liệu lên DataGridView
        private void LoadTableFromSQL()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Thay 'SinhVien' bằng tên Bảng bạn muốn hiển thị trong CSDL ql_sinhvien
                    string query = "SELECT * FROM SinhVien";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt); // Nạp dữ liệu từ SQL vào DataTable

                    dgvData.DataSource = dt; // Hiển thị bảng dữ liệu lên DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ SQL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi đóng Form chính thì đóng hẳn toàn bộ ứng dụng
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}