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
    public partial class Form_class_my_CHECK_LIST_BOX : Form
    {
        public Form_class_my_CHECK_LIST_BOX()
        {
            InitializeComponent();
        }

        private void But_CHECK_item_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox3.CheckedItems.Count; i+=1)
            {

                      MessageBox.Show(checkedListBox3.CheckedItems[i].ToString());
            } 
           
        }

        private void But_add_item_Click(object sender, EventArgs e)
        {
            checkedListBox4.Items.Add(textBox1.Text);
        }

       
    }
}
