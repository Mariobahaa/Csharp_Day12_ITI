using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Day12_Csharp_ITI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics Gr = this.CreateGraphics();
            GraphicsPath G = new GraphicsPath();
            G.StartFigure();
            G.AddEllipse(100, 100, 100, 100);
            G.FillMode = FillMode.Alternate;
            G.AddLine(0, 0, 100, 100);
            G.CloseFigure();
            Gr.FillPath(new SolidBrush(Color.Black),G);
        }
    }
}
