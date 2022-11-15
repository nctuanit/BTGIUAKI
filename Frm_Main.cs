using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTGIUAKI
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            new Frm_DangNhap().ShowDialog();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            new Frm_TaoSoNgauNhien().ShowDialog();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            new Frm_XuLyNgonNgu().ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Frm_DoiMatKhau().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            isLogin(false);
        }

        public void isLogin(bool flag)
        {
            if (flag)
            {
                label3.Text = "Đăng xuất";
            }
            else
            {
                label3.Text = "Đăng nhập";
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
