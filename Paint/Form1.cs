using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int x, y, h, w;
        Pen p = new Pen(Color.Black, 3);
        SolidBrush br = new SolidBrush(Color.Black);
        ColorDialog colorChoose = new ColorDialog();
        OpenFileDialog fileDialog = new OpenFileDialog();

        private void btnPenColor_Click(object sender, EventArgs e)
        {
            float width = Convert.ToSingle(numPenWidth.Value);
            if (colorChoose.ShowDialog() == DialogResult.OK)
            {
                p = new Pen(colorChoose.Color, width);
                br = new SolidBrush(colorChoose.Color);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            String path = "";
            //pictureBox1.Visible = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Graphics g;
                path = fileDialog.FileName;
                Image img = Image.FromFile(path);
                //Graphics g = Graphics.FromImage("ava.jpg");
                g.DrawImage(img, 10, 10);
                
                //pictureBox1.ImageLocation = path;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            float width = Convert.ToSingle(numPenWidth.Value);
            p = new Pen(colorChoose.Color, width);
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;
            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if (rbtnLine.Checked)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
            }
            else if (rbtnEllipse.Checked)
            {
                g.DrawEllipse(p, shape);
            }
            else if (rbtnRectangle.Checked)
            {
                g.DrawRectangle(p, shape);
            }
            else if (rbtnFillEllipse.Checked)
            {
                g.FillEllipse(br, shape);
            }
            else if (rbtnFillRectangle.Checked)
            {
                g.FillRectangle(br, shape);
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            this.Refresh();
            pictureBox1.Visible = false;
        }
    }
}
