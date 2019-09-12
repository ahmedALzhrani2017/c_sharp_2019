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

      

        private void TrackBar5_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = (System.Math.Round(trackBar5.Value / 10.0)).ToString();
        }
    }
}
