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
            pictureBox1.BackColor = Color.FromArgb(R,G, B);



            decimal my_value1 = Convert.ToDecimal(textBox1.Text);
            numericUpDown1.Value = my_value1;           
            decimal my_value2 = Convert.ToDecimal(textBox2.Text);
            numericUpDown2.Value = my_value2;
            decimal my_value3 = Convert.ToDecimal(textBox3.Text);
            numericUpDown3.Value = my_value3;
            string all = my_value1.ToString() + my_value2 + my_value3;
           
            int x = int.Parse(my_value1.ToString());
            string xs = Convert.ToString(x, 16);
            int xx = int.Parse(my_value2.ToString());
            string xxs = Convert.ToString(xx, 16);
            int xxx = int.Parse(my_value3.ToString());
            string xxxs = Convert.ToString(xxx, 16);

            label7.Text = xs + xxs + xxxs;
        }


        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            int my_value = trackBar1.Value;
            textBox1.Text = my_value.ToString();
            
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
            
            xzzz();
           

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            xzzz();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

            xzzz();
            
            
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
