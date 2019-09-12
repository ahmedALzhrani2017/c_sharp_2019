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
            this.CreateGraphics().DrawRectangle(Pens.Black, 1, 50, 350, 100);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawEllipse(Pens.Red, 350 ,50, 100, 100);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawPie(Pens.Red, 450, 50, 100, 100, 90, 180);
        }

       

        private void Button7_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(550, 50);
            Point p2 = new Point(600, 25);
            Point p3 = new Point(700, 60);
            Point p4 = new Point(800, 70);
            Point p5 = new Point(750, 40);
            Point p6 = new Point(600, 20);
            Point p7 = new Point(550, 50);
            Point[] all_p = { p1, p2, p3, p4, p5, p6, p7 };

            this.CreateGraphics().DrawPolygon(Pens.Black, all_p);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string my_text = textBox1.Text;
            Font my_font = new Font("tahoma", 14, FontStyle.Bold);
            Point p1 = new Point(800, 50);
            this.CreateGraphics().DrawString(my_text ,my_font, Brushes.Red, p1);

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
            
            timer1.Start();
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           

        }
        
        private void Timer1_Tick(object sender, EventArgs e)

        {
            
            if (numericUpDown1.Value < 100)
            {
                this.CreateGraphics().FillRectangle(Brushes.LightBlue, 1, 160, 500, 40);
                decimal x = numericUpDown1.Value += 1;
                this.CreateGraphics().FillRectangle(Brushes.Blue, 1, 160, (float)x*5, 40);
                string my_text = numericUpDown1.Value.ToString();               
                Font my_font = new Font("tahoma", 14, FontStyle.Bold);
                Point p1 = new Point(240, 170);
                if (numericUpDown1.Value <=50)
                {
                    this.CreateGraphics().DrawString(my_text, my_font, Brushes.Black, p1);
                }
                else
                {
                    this.CreateGraphics().DrawString(my_text, my_font, Brushes.White, p1);
                }
            }
            else
            {
               
                timer1.Stop();
                numericUpDown1.Value = 0;
                MessageBox.Show("complet");
            }
                         
           
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawImage(Properties.Resources.c_, 700,250);
           
        }

        private void Button11_Click(object sender, EventArgs e)
        {

            Point p1 = new Point(550, 50);
            Point p2 = new Point(600, 25);
            Point p3 = new Point(700, 60);
            Point p4 = new Point(800, 70);
            Point p5 = new Point(750, 40);
            Point p6 = new Point(600, 20);
            Point p7 = new Point(550, 50);
            Point[] all_p = { p1, p2, p3, p4, p5, p6, p7 };

            this.CreateGraphics().DrawCurve(Pens.Red, all_p);
            this.CreateGraphics().FillClosedCurve(Brushes.LightBlue, all_p);
        }
    }
}
