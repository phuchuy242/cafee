using System;
using System.Windows.Forms;

namespace Quản_lý_cà_phê
{
    public partial class Xoatk : Form
    {
        private Giaodien giaodienForm; // Khai báo biến giaodienForm ở cấp độ lớp

        public Xoatk()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại khi nút được nhấn
            this.Close();
        }

        private void Xoatk_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hủy việc đóng cửa sổ hiện tại và mở cửa sổ mới
            e.Cancel = true; // Hủy sự kiện đóng

            // Kiểm tra xem cửa sổ Giaodien đã tồn tại và không bị đóng
            if (giaodienForm == null || giaodienForm.IsDisposed)
            {
                // Nếu không tồn tại hoặc đã bị đóng, tạo một cửa sổ mới
                giaodienForm = new Giaodien();
                giaodienForm.FormClosed += (s, args) => this.Close(); // Đóng cửa sổ hiện tại khi cửa sổ mới đóng
            }

            giaodienForm.Show(); // Hiển thị cửa sổ đã tồn tại hoặc mới được tạo
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
