using BTGIUAKI.Entitys;
using BTGIUAKI.Enums;
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
    public partial class Frm_QuanLyTaiKhoan : Form
    {
        public Frm_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.Rows.Clear();
            loadUser();
        }
        private void loadUser()
        {
            dataGridView1.Rows.Clear();
            List<UserEntity> users = UserService.gI().read();
            int i = 1;
            foreach (UserEntity user in users)
            {
                dataGridView1.Rows.Add(i, user.userId, user.fullName, user.userName, user.role == Role.ADMIN ? "Admin" : "User");
                i++;
            }
        }
        
    }
}
