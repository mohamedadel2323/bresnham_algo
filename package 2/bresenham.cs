using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace package_2
{
    public partial class bresenham : Form
    {
        public bresenham()
        {
            InitializeComponent();
        }

        private void Bresenham_Line(Point p1, Point p2)
        {
            double x, y, x1, y1, x2, y2;
            Bitmap pic = new Bitmap(this.Width, this.Height);
            double dx = p2.X - p2.X;
            double dy = p2.Y - p2.Y;
            double p = 2 * (dy - dx);
            double c1 = 2 * dy;
            double c2 = 2 * (dy - dx);

            x = x1 = p1.X;
            y = y1 = p1.Y;

            pic.SetPixel((int)x, (int)y, Color.Black);

            x2 = p2.X;
            y2 = p2.Y;

            while (x < x2)
            {
                if (p < 0)
                {
                    p += c1;
                }
                else
                {
                    p += c2;
                    y += 1;
                }
                x++;
                pic.SetPixel((int)x, (int)y, Color.Black);
            }
            pictureBox1.Image = pic;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Bresenham_Line(p1, p2);
        }
    }
}
