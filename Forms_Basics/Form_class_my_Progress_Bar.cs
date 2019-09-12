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
    public partial class Form_class_my_Progress_Bar : Form
    {
        public Form_class_my_Progress_Bar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=100; i++)
            {
                if (progressBar1.Value<100)
                         {
                    progressBar1.Value = i;
                    MessageBox.Show(i.ToString());
                                
                }
                
            }
           
            
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
