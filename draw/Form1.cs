using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(50, 50);
            this.CreateGraphics().DrawLine(Pens.Black, p1, p2);
        }

        private void Button5_Click(object sender, EventArgs e)

        {
            
           this.CreateGraphics().Clear(Color.White);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(50, 50);
            Point p3 = new Point(100, 0);
            Point p4 = new Point(150, 50);
            Point p5 = new Point(200, 0);
            Point p6 = new Point(250, 50);
            Point p7 = new Point(300, 0);
            Point p8 = new Point(350, 50);
            Point[] all_p={p1,p2,p3,p4,p5,p6,p7,p8 };
            this.CreateGraphics().DrawLines(Pens.Black,all_p);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawRectangle(Pens.Black, 1, 50, 350, 50);
        }
    }
}
