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
    public partial class Frm_TaoSoNgauNhien : Form
    {
        private void TaoSoNgauNhien(object o, EventArgs e)
        {
            Button button = (Button)o;
            MessageBox.Show(button.Text);
        }
        private int _leng = 50;
        public Frm_TaoSoNgauNhien()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            containerMainMatrix.Controls.Clear();
            int y = 0;
            int x = 0;
            for(int i = 0; i < (8 * 8); i++)
            {
                if (i % 8 == 0 && i!=0)
                {
                    y += _leng;
                    x = 0;
                }
                x += _leng;
                Button button = createBtn(x, y, (i + 1).ToString());
                containerMainMatrix.Controls.Add(button);
                
            }
        }

        public Button createBtn(int x, int y,string str)
        {
            
            Button btn = new Button();
            btn.Text = str;
            btn.Size = new Size(_leng, _leng);
            btn.Location = new Point(x, y);
            btn.Click += new EventHandler(TaoSoNgauNhien);
            return btn;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_TaoSoNgauNhien_Load(object sender, EventArgs e)
        {

        }

        private void containerMainMatrix_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
