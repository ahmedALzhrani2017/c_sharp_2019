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
    public partial class Form_Class_my_Radio_Button : Form
    {
        public Form_Class_my_Radio_Button()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1_male.Checked)
            {
                MessageBox.Show("it is male");
            }
            else
            {

                MessageBox.Show("it is famele");
            }
        }
    }
}
