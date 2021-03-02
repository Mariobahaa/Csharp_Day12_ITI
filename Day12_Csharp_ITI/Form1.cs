using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day12_Csharp_ITI
{
    public partial class Form1 : Form
    {
        Point RectLoc;
        Point PntInside; 
        bool mouseDown;
        Graphics G;
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();

       
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            RectLoc = new Point(350, 175);
            mouseDown = false;
            G = this.CreateGraphics();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        
                G.FillRectangle(Brushes.DarkViolet, RectLoc.X, RectLoc.Y, 100, 100);

  
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            var curs = e.Location;

            if (curs.X >= RectLoc.X && curs.X <= RectLoc.X + 100 && curs.Y >= RectLoc.Y && curs.Y <= RectLoc.Y + 100)
            {
                PntInside = curs;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) 
        {
            if (mouseDown)
            {

                Invalidate();
                var curs = e.Location;
                //G.FillRectangle(Brushes.DarkViolet, curs.X, curs.Y, 100, 100);
                RectLoc =new Point(PntInside.X+( curs.X -PntInside.X) ,PntInside.Y+(curs.Y-PntInside.Y));
                    cnt++;
                label1.Text = $"X:{curs.X}, Y:{curs.Y}\n" +
                $"Pin: X:{PntInside.X} Y: {PntInside.Y}\n" +
                $"RL: X:{RectLoc.X}, Y:{RectLoc.Y}";
                    

               

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

       
    }
}
