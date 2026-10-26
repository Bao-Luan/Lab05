namespace Lab05
{
    public partial class frmNhapLieu : Form
    {
        public frmNhapLieu()
        {
            InitializeComponent();
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {

        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            int sodong, socot;

            // Đọc dữ liệu người dùng nhập, nếu lỗi thì mặc định là 1
            if (!int.TryParse(txtSoDong.Text, out sodong))
                sodong = 1;
            if (!int.TryParse(txtSoCot.Text, out socot))
                socot = 1;

            // Khởi tạo frmXuat và truyền số dòng, số cột qua constructor
            frmXuat frmX = new frmXuat(sodong, socot);

            // Canh giữa màn hình và hiển thị Form xuất bảng lên
            frmX.StartPosition = FormStartPosition.CenterScreen;
            frmX.ShowDialog();
        }
    }
}
