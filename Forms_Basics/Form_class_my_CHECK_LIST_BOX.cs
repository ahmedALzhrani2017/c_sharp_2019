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
            for (int i = 0; i < checkedListBox3.CheckedItems.Count; i += 1)
            {

                MessageBox.Show(checkedListBox3.CheckedItems[i].ToString());
            }

        }

        private void But_add_item_Click(object sender, EventArgs e)
        {
            checkedListBox4.Items.Add(textBox1.Text);



        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            //// Display in a message box all the items that are checked.

            //// First show the index and check state of all selected items.
            //foreach (int indexChecked in checkedListBox1.CheckedIndices)
            //{
            //    // The indexChecked variable contains the index of the item.
            //    MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
            //                    checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            //

            //// Next show the object title and check state for each item selected.
            //foreach (object itemChecked in checkedListBox1.CheckedItems)
            //{

            //    // Use the IndexOf method to get the index of an item.
            //    MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
            //                    "\", is checked. Checked state is: " +
            //                    checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
        }
    }
}

