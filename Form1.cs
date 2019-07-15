using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox0x.TextChanged += button3_Click;
            textBox0y.TextChanged += button3_Click;
            textBox1x.TextChanged += button3_Click;
            textBox1y.TextChanged += button3_Click;
            textBox2x.TextChanged += button3_Click;
            textBox2y.TextChanged += button3_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(textBox0x.Text);
            int x1 = Convert.ToInt32(textBox1x.Text);
            int x2 = Convert.ToInt32(textBox2x.Text);
            int y0 = Convert.ToInt32(textBox0y.Text);
            int y1 = Convert.ToInt32(textBox1y.Text);
            int y2 = Convert.ToInt32(textBox2y.Text);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.FillRectangle(new SolidBrush(Color.Green), new Rectangle(x0, y0, 10, 10));
            }
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(textBox0x.Text);
            int x1 = Convert.ToInt32(textBox1x.Text);
            int x2 = Convert.ToInt32(textBox2x.Text);
            int y0 = Convert.ToInt32(textBox0y.Text);
            int y1 = Convert.ToInt32(textBox1y.Text);
            int y2 = Convert.ToInt32(textBox2y.Text);
            // Массив точек треугольника.
            Point[] points = new Point[3];
            points[0].X = x0; points[0].Y = y0;
            points[1].X = x1; points[1].Y = y1;
            points[2].X = x2; points[2].Y = y2;

            // Изображение, которое будем вставлять в PictureBox.
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                // Рисуем.
                grfx.DrawPolygon(Pens.Black, points);
            }

            // Устанавливаем изображение.
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x0 = Convert.ToInt32(textBox0x.Text);
            int x1 = Convert.ToInt32(textBox1x.Text);
            int x2 = Convert.ToInt32(textBox2x.Text);
            int y0 = Convert.ToInt32(textBox0y.Text);
            int y1 = Convert.ToInt32(textBox1y.Text);
            int y2 = Convert.ToInt32(textBox2y.Text);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(new Pen(Brushes.Red, 4), new Point(x0, y0), new Point(x1, y1));
            }
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new PictureBox().Image;
        }
    }
}
