using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Basics.Method
{
    public partial class Cut_Copy_Paste_Undo : Form
    {
        public Cut_Copy_Paste_Undo()
        {
            InitializeComponent();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure that text is selected in the text box.   
            if (richTextBox1.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                richTextBox1.Copy();
        }

        private void PastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (richTextBox2.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        richTextBox2.SelectionStart = richTextBox2.SelectionStart + richTextBox2.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                richTextBox2.Paste();
            }
        }

        private void text_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox3.Text);
        }

        private void text_past_Click(object sender, EventArgs e)
        {
            richTextBox4.Text=Clipboard.GetText();
        }

        private void Copy_img_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
        }

        private void Past_img_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Clipboard.GetImage();
        }
    }
}
