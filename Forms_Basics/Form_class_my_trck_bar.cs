using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Basics
{
    public partial class Form_class_my_trck_bar : Form
    {
        
        public Form_class_my_trck_bar()
        {
            InitializeComponent();
        }
        private void xzzz()
        {

            int R = Convert.ToInt32(textBox1.Text);             
            int G = Convert.ToInt32(textBox2.Text);           
            int B = Convert.ToInt32(textBox3.Text);
            if (R <= 255 && G <=255 && B<=255 ) 
            {              
                pictureBox1.BackColor = Color.FromArgb(R,G, B);

                numericUpDown1.Value = Convert.ToDecimal(textBox1.Text);
                numericUpDown2.Value = Convert.ToDecimal(textBox2.Text);
                numericUpDown3.Value = Convert.ToDecimal(textBox3.Text);

             
                
                string xs = Convert.ToString(R, 16);
                string xxs = Convert.ToString(G, 16);
                string xxxs = Convert.ToString(B, 16);

               
                label7.Text = xs+ xxs + xxxs;
                
            }
         

        }


        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            int my_value = trackBar1.Value;
            textBox1.Text = my_value.ToString("D2");
            
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            int my_value = trackBar2.Value;
            textBox2.Text = my_value.ToString();
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            int my_value = trackBar3.Value;
            textBox3.Text = my_value.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
                      
            if (textBox1.TextLength<=0)
            {
                textBox1.Text = "0";
                
            }
            xzzz();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength <= 0)
            {
                  textBox2.Text = "0";
            }
          

            xzzz();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength <= 0)
            {
                   textBox3.Text = "0";
            }
            
            xzzz();            
        }

      

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
