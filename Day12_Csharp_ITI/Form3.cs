using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day12_Csharp_ITI
{
    public partial class Form3 : Form
    {
        Graphics G;
        Brush brush;
        Pen pen;
        Point last;
        
        public Form3()
        {
            InitializeComponent();
            //brush = new SolidBrush(Color.Black); 
            pen = new Pen(Color.Black);
            colorDialog1.AllowFullOpen = true;
            G = this.CreateGraphics();
            last = new Point(-1, -1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pen = new Pen(colorDialog1.Color);
            //brush = new SolidBrush(colorDialog1.Color);
        }


        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && last.X != -1 && last.Y !=-1)
            {
                G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                G.DrawLine(pen, last, e.Location);
                last = e.Location;
                //G.FillEllipse(brush, e.X, e.Y, 10, 10);
            }
            else if (e.Button == MouseButtons.Right && last.X != -1 && last.Y != -1)
            {
                G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                G.DrawLine(new Pen(this.BackColor), last, e.Location);
                last = e.Location;
                
                //G.FillEllipse(new SolidBrush(this.BackColor), e.X, e.Y, 10, 10);

            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            last = new Point(-1, -1);
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            last = e.Location;
        }
    }
}
