using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ahmed hassan in c sharp form");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter sw1 = new StreamWriter("a1.txt"))
            {
                sw1.WriteLine(richTextBox1.Text);
            }
        }
    }
}
