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

        private void Form_Class_my_Timer_Load(object sender, EventArgs e)
        {

        }

        
    }
}
