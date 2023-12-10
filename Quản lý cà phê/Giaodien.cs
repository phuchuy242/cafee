using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_cà_phê
{
    public partial class Giaodien : Form
    {
        public Giaodien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage17_Click(object sender, EventArgs e)
        {

        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xoatk f = new Xoatk();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            DialogResult dialogResult = f.ShowDialog();
        }
    }
}
