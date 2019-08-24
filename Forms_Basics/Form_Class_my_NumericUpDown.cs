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
    public partial class Form_Class_my_NumericUpDown : Form
    {
        public Form_Class_my_NumericUpDown()
        {
            InitializeComponent();
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown3.Value.ToString());
        }
    }
}
