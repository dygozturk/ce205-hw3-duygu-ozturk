using ProjectSDL2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ce205_hw4_form_app
{
    public partial class Form2 : Form
    {
        redblacktree avl;
        Brush temp;
        public Form2()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            avl.insertion(ref avl.root, Convert.ToString(valueBox.Text.ToString()), this.Width / 2, 50);
            valueBox.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void valueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            avl.delete(ref avl.root, Convert.ToString(valueBox.Text.ToString()));
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            avl.search(ref avl.root, Convert.ToString(valueBox.Text.ToString()));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (line x in avl.garis)
            {
                Pen p = new Pen(x.warna);
                e.Graphics.DrawLine(p, x.x1, x.y1, x.x2, x.y2);
            }
            foreach (var item in avl.lingkaran)
            {
                e.Graphics.FillEllipse(item.brush, item.x, item.y, 30, 30);
                e.Graphics.DrawString(item.value, new Font("Arial", 14), temp, new Point(item.x, item.y + 5));
            }
        }
    }
}
