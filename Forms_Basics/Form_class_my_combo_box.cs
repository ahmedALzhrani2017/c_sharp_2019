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
    public partial class Form_class_my_combo_box : Form
    {
        public Form_class_my_combo_box()
        {
            InitializeComponent();
        }

        private void But_add_item_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("aa");
        }
        

        private void But_add_items_Click(object sender, EventArgs e)
        {
            string[] add_items = { "ahmed", "hassan" };
            comboBox2.Items.AddRange(add_items);
        }
    }
}
