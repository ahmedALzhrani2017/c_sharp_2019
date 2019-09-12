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
    public partial class Form_Class_my_Timer : Form
    {
        public Form_Class_my_Timer()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = DateTime.Now.ToString("HH: mm:ss");


        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
