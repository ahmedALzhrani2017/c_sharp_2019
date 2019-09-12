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
    public partial class Form_class_my_dialogresult_message_show : Form
    {
        public Form_class_my_dialogresult_message_show()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xxxxxxx", "AAA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dt;
            dt=MessageBox.Show("xxxxxxx", "AAA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt==DialogResult.Yes)
            {
                MessageBox.Show("احسنت");
            }
            else
            {
                MessageBox.Show("لا");
            }
        }
    }
}
