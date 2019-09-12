using System;
using System.IO;
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

            openFileDialog1.Title = "افتح";
            //openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        check:
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            
                textBox_Path.Text = openFileDialog1.FileName;
                textBox_File_Name.Text = Path.GetFileName(openFileDialog1.FileName);
                textBox_extension.Text = Path.GetExtension(openFileDialog1.FileName);
            }
            else
            {

                DialogResult dt;
                dt = MessageBox.Show("هلا تريد الخروج ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dt == DialogResult.No)
                {
                    goto check;
                }
                else
                {
                    MessageBox.Show("شكر");
                }

            }
        }
           
     }

       
 }

