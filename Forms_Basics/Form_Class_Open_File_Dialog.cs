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
        //openFileDialog1.Filter = "PNG Image|*.png";
        //openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        //openFileDialog1.Filter = "Office Files|*.doc;*.xls;*.ppt";
        
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox_Path.Text = openFileDialog1.FileName;
                textBox_File_Name.Text = Path.GetFileName(openFileDialog1.FileName);
                textBox_extension.Text = Path.GetExtension(openFileDialog1.FileName);
            }
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {


        }


        private void File_Create_Click(object sender, EventArgs e)
        {

            if (!File.Exists("we.txt")) /*غير موجود الملف*/
            {
                  File.Create("we.txt").Close(); /*انشاء الملف*/
                
            }
            else
            {
                MessageBox.Show("الملف موجود");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (File.Exists("we.txt")) /* موجود الملف*/
            {
                File.Delete("we.txt"); /*حذف الملف */

            }
            else
            {
                MessageBox.Show("الملف  غير موجود");
            }
        }

        private void COPY_Click(object sender, EventArgs e)
        {
            string path_open = "";
            string path_save = "";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    path_open = openFileDialog1.FileName;
                }
                saveFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    path_save = saveFileDialog1.FileName;
                    File.Copy(path_open, path_save);
                    MessageBox.Show("تم نسخ " + Path.GetFileName(saveFileDialog1.FileName));
                }
                
            }
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            var fileStream = openFileDialog2.OpenFile();

            using (StreamReader reader = new StreamReader(fileStream))
            {
               MessageBox.Show(reader.ReadToEnd());
            }
        }

        private void Button_Move_Click(object sender, EventArgs e)
        {
            string path_open = "";
            string path_save = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    path_open = openFileDialog1.FileName;
                }
                saveFileDialog1.FileName = Path.GetFileName(openFileDialog1.FileName);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(saveFileDialog1.FileName)) /*غير موجود الملف*/
                    {
                       
                    path_save = saveFileDialog1.FileName;
                    File.Move(path_open, path_save);
                    MessageBox.Show("تم نقل " + Path.GetFileName(saveFileDialog1.FileName));
                    }
                    else
                    {
                        MessageBox.Show("الملف موجود");
                    }
                    
                }

            }
        }
    }

   
 }

