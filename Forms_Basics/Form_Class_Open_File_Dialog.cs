using System;
using System.IO;
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
    public partial class Form_Class_Open_File_Dialog : Form
    {
        public Form_Class_Open_File_Dialog()
        {
            InitializeComponent();
        }

        private void Button_Choes_file_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            textBox_Path.Text = openFileDialog1.FileName;
            textBox_File_Name.Text = Path.GetFileName(openFileDialog1.FileName);
            textBox_extension.Text = Path.GetExtension(openFileDialog1.FileName);
        }

        
    }
}
