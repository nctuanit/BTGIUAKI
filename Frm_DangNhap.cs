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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var taikhoan = textBoxX1.Text;
            var matkhau = textBoxX2.Text;

            if(taikhoan.Length < 3 || matkhau.Length < 3)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            else
            {
               var user =  UserService.gI().login(taikhoan, matkhau);
                if (user != null)
                {
                    var config = FileService.ReadConfig();
                    config.password = matkhau;
                    FileService.WriteConfig(config);
                    MessageBox.Show("Đăng nhập thành công");
                    Frm_Main.gI().user = user;
                    Frm_Main.gI().isLogin(true);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    return;
                }
            }

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var config = FileService.ReadConfig();
            config.isSavePass = checkBox1.Checked;
            config.password = textBoxX2.Text;
            FileService.WriteConfig(config);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var config = FileService.ReadConfig();
            if (config.isSavePass)
            {
                textBoxX2.Text = config.password;
            }
            checkBox1.Checked = config.isSavePass;
        }
        public void IsLogout()
        {
            {
                textBoxX1.Text = "";
                textBoxX2.Text = "";
            }
        }
    }
}
