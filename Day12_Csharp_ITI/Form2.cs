using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day12_Csharp_ITI
{
    public partial class Form2 : Form
    {
        Graphics G;

        public Form2()
        {
            InitializeComponent();
            G = this.CreateGraphics();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            G.DrawEllipse(Pens.Blue, 100 , 100, 50, 50);
            G.DrawLine(Pens.Blue, 125, 150, 125, 300);
            G.DrawLine(Pens.Blue, 75, 300, 125, 200);
            G.DrawLine(Pens.Blue, 175, 300, 125, 200);
            G.DrawLine(Pens.Blue, 75,400 , 125, 300);
            G.DrawLine(Pens.Blue, 175, 400, 125, 300);

           
            G.DrawEllipse( Pens.DeepPink , 600, 100, 50, 50);
            G.DrawLine( Pens.DeepPink , 625, 150, 625, 300);
            G.DrawLine( Pens.DeepPink , 575, 300, 625, 200);
            G.DrawLine( Pens.DeepPink , 675, 300, 625, 200);
            G.DrawLine( Pens.DeepPink , 575, 400, 625, 300);
            G.DrawLine(Pens.DeepPink, 675, 400, 625, 300);
            G.DrawLine(Pens.DeepPink, 600, 350, 650, 350);



        }
    }
}
