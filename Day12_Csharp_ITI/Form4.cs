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
            G.AddEllipse(300, 100, 100, 100);
            G.AddEllipse(150, 150, 200, 200);


            G.FillMode = FillMode.Winding;
            G.AddLine(0, 0, 100, 100);
            
            G.CloseFigure();
            Gr.FillPath(new SolidBrush(Color.Black), G);

            Matrix translateMatrix = new Matrix();
            translateMatrix.Translate(600, 0);
            G.Transform(translateMatrix);
            Gr.FillPath(new SolidBrush(Color.Yellow), G);
            //////graphicspathiterator it = new graphicspathiterator(g);
            //////bool a;
            //////graphicspath n1 = it.next
           

            // Gr.DrawPath(new Pen(Color.Black),G);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    
        private void button2_Click(object sender, EventArgs e)
        {

        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        
    }
}
