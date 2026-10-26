using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05 // Hoặc tên namespace của project bạn
{
    public partial class frmXuat : Form
    {
        // Khai báo Property để nhận dữ liệu số dòng, số cột từ form ngoài truyền vào
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        // Khai báo các tham số kích thước, khoảng cách
        int h = 35, margin = 5;

        // Hàm khởi tạo nhận tham số dòng và cột
        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();

            // Gán giá trị số dòng, số cột
            this.SoDong = dong;
            this.SoCot = cot;

            // Dùng vòng lặp tạo các Button động bỏ lên Form
            Button btn = null;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    btn = new Button();
                    btn.Width = h;
                    btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;

                    // Gắn sự kiện cho từng Button được tạo ra
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenButton;
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);

                    this.Controls.Add(btn);
                }
            }

            // Tự động điều chỉnh kích thước Form vừa khít với lưới Button
            this.ClientSize = new Size(SoCot * (h + margin) + margin, SoDong * (h + margin) + margin);
        }

        // Sự kiện khi rê chuột vào Button thì đổi tiêu đề Form hiển thị vị trí
        private void HoChuotLenButton(object sender, EventArgs e)
        {
            this.Text = (sender as Button).Tag.ToString();
        }

        // Sự kiện khi click vào Button thì hiện MessageBox thông báo số trên nút
        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }
        private void frmXuat_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc viết logic khởi tạo nếu cần
        }
    }
}