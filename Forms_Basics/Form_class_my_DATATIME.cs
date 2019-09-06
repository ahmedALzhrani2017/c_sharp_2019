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
    public partial class Form_class_my_DATATIME : Form
    {
        public Form_class_my_DATATIME()
        {
            InitializeComponent();
        }

        private void Form_class_my_DATATIME_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the control's font.
                dateTimePicker1.Font = fontDialog1.Font;
            }
        }
    }
}
