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
            e.Cancel = true; 
                                    if (giaodienForm == null || giaodienForm.IsDisposed)
            {

                giaodienForm = new Giaodien();
                giaodienForm.FormClosed += (s, args) => this.Close(); 
            }
                    giaodienForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Giaodien f = new Giaodien();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
