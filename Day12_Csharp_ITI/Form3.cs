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
        
        public Form3()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Black);
            colorDialog1.AllowFullOpen = true;
            G = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            
            brush = new SolidBrush(colorDialog1.Color);
        }


        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                G.FillEllipse(brush, e.X, e.Y, 10, 10);
            }
            else if (e.Button == MouseButtons.Right)
            {
                G.FillEllipse(new SolidBrush(this.BackColor), e.X, e.Y, 10, 10);

            }
        }

    }
}
