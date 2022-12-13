using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVL_Tree
{
    
    public partial class Form1 : Form
    {
        AVLTree tree;
        public Form1()
        {
            InitializeComponent();
            this.Text = "AVL Visualization";
            tree = new AVLTree(this);
            tree.preOrder(tree.root);
            foreach(var item in tree.lingkaran)
            {
                Console.WriteLine("X : " + item.Value.x + " Y: " + item.Value.y);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void mbox(String text)
        {
            MessageBox.Show(text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tree.root = tree.InsertHelper(tree.root, Convert.ToString(valueBox.Text));
            tree.inOrderHelper();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            foreach (var item in tree.garis.Values)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), item.x1, item.y1, item.x2, item.y2);
            }
            foreach (var item in tree.lingkaran.Values)
            {
                e.Graphics.FillEllipse(item.brush, item.x-300, item.y, 50, 50);
                e.Graphics.DrawString(item.value, new Font("Arial", 16), new SolidBrush(Color.White), new Point(item.x + 8, item.y + 10));
                //    e.Graphics.DrawString(item.balanceFactor.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), new Point(item.x + 38, item.y + 10));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tree.root = tree.deleteNode(tree.root, Convert.ToString(valueBox.Text));
            tree.inOrderHelper();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tree.inOrder(tree.root);
            MessageBox.Show("InOrder : " + tree.inOrderResult);
            tree.inOrderResult = "";
            tree.inOrderHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tree.find(Convert.ToString(valueBox.Text));
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }
    }
}
