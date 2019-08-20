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
    public partial class Form_Class_my_PictureBox : Form
    {
        public Form_Class_my_PictureBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.c_sharp;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile("c#.png");
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bitmap opj = new Bitmap("c#.png");
            pictureBox8.Image = opj;
        }

        private void My_PictureBox_Load(object sender, EventArgs e)
        {

        }
    }
    
}
