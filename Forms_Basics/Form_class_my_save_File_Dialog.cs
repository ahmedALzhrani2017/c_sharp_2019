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

namespace Forms_Basics
{
    public partial class Form_class_my_save_File_Dialog : Form
    {
        public Form_class_my_save_File_Dialog()
        {
            InitializeComponent();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "my save";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
