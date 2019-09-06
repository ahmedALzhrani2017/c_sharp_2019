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
    public partial class Form_class_my_textBox : Form
    {
        public Form_class_my_textBox()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it is password\t" + textBox2.Text);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.CharacterCasing = CharacterCasing.Upper;

        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.TextAlign = HorizontalAlignment.Center;
        }
        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
        }
        private bool flag;
        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            long val;
            // Check the flag to prevent code re-entry. 
            if (flag == false)
            {
                // Set the flag to True to prevent re-entry of the code below.
                flag = true;
                // Determine if the text of the control is a number.
                try
                {
                    // Attempt to convert to long
                    val = System.Convert.ToInt64(textBox12.Text);
                }
                catch
                {
                    
                    // Display a message box and clear the contents if not a number.
                    MessageBox.Show("The text is not a valid number. Please re-enter");
                    // Clear the contents of the text box to allow re-entry.
                    textBox12.Clear();
                }
                // Reset the flag so other TextChanged events are processed correctly.
                flag = false;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Method.Cut_Copy_Paste_Undo show_cut_Copy_Paste_Undo =new Method.Cut_Copy_Paste_Undo();
            show_cut_Copy_Paste_Undo.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Method.Cut_Copy_Paste_Undo show_cut_Copy_Paste_Undo = new Method.Cut_Copy_Paste_Undo();
            show_cut_Copy_Paste_Undo.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Method.Cut_Copy_Paste_Undo show_cut_Copy_Paste_Undo = new Method.Cut_Copy_Paste_Undo();
            show_cut_Copy_Paste_Undo.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Method.Cut_Copy_Paste_Undo show_cut_Copy_Paste_Undo = new Method.Cut_Copy_Paste_Undo();
            show_cut_Copy_Paste_Undo.ShowDialog();
        }
    }
}
