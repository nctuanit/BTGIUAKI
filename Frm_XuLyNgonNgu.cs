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
    public partial class Frm_XuLyNgonNgu : Form
    {
        public Frm_XuLyNgonNgu()
        {
            InitializeComponent();
        }
        public Dictionary<string, int> keys = new Dictionary<string, int>();
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            keys.Clear();
            richTextBox2.Clear();
            var list = richTextBox1.Text.Trim().Split(' ');
            foreach (var item in list)
            {
                if (keys.ContainsKey(item))
                {
                    keys[item]++;
                }
                else
                {
                    keys.Add(item, 1);
                }
            }
            var list2 = keys.OrderByDescending(x => x.Value).ToList();
            foreach (var item in list2)
            {
                richTextBox2.Text += item.Key + " xuất hiện  " + item.Value + " lần "+ "\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = Services.RegexService.CoverString(richTextBox1.Text);
            richTextBox1.Select(richTextBox1.Text.Length, 0);
        }
    }
}
