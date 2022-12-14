using BTGIUAKI.Entitys;
using BTGIUAKI.Services;
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
        private static Frm_Main _instance;
        public UserEntity user;
        public static Frm_Main gI()
        {
            if (_instance == null)
            {
                _instance = new Frm_Main();
            }
            return _instance;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                user = null;
                isLogin(false);
            }
            else
            {
                Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
                frm_DangNhap.ShowDialog();
                frm_DangNhap.IsLogout();
            }
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
    }
}
