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
    public partial class Form_class_my_toolTip : Form
    {
        public Form_class_my_toolTip()
        {
            InitializeComponent();
        }
        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            //Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            string x = "احمد الزهراني \n حسن";
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(label1, x);
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
