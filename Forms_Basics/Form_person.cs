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
    public partial class Form_person : Form
    {
        public Form_person()
        {
            InitializeComponent();
        }

        private void But_NumericUpDown_Click(object sender, EventArgs e)
        {
            Form_Class_my_NumericUpDown show_my_NumericUpDown = new Form_Class_my_NumericUpDown();
            show_my_NumericUpDown.ShowDialog();
        }

        private void But_my_PictureBox_Click(object sender, EventArgs e)
        {
            Form_Class_my_PictureBox show_my_PictureBox = new Form_Class_my_PictureBox();
            show_my_PictureBox.ShowDialog();
        }

        private void But_Timer_Click(object sender, EventArgs e)
        {
            Form_Class_my_Timer show_my_Timer = new Form_Class_my_Timer();
            show_my_Timer.ShowDialog();

        }

        private void But_Open_File_Click(object sender, EventArgs e)
        {
            Form_Class_Open_File_Dialog show_Open_File_Dialog = new Form_Class_Open_File_Dialog();
            show_Open_File_Dialog.ShowDialog();
        }

        private void But_CHECK_LIST_BOX_Click(object sender, EventArgs e)
        {
            Form_class_my_CHECK_LIST_BOX show_my_CHECK_LIST_BOX = new Form_class_my_CHECK_LIST_BOX();
            show_my_CHECK_LIST_BOX.ShowDialog();
        }

        private void Butt_combo_box_Click(object sender, EventArgs e)
        {
            Form_class_my_combo_box show_my_Combo_Box = new Form_class_my_combo_box();
            show_my_Combo_Box.ShowDialog();
        }

        private void But_save_File_Click(object sender, EventArgs e)
        {
            Form_class_my_save_File_Dialog my_Save_File_Dialog = new Form_class_my_save_File_Dialog();
            my_Save_File_Dialog.ShowDialog();
        }

        private void But_Radio_Click(object sender, EventArgs e)
        {
            Form_Class_my_Radio_Button show_My_Radio_Button = new Form_Class_my_Radio_Button();
            show_My_Radio_Button.ShowDialog();
        }

        private void But_track_bar_Click(object sender, EventArgs e)
        {
            Form_class_my_trck_bar show_my_Trck_Bar = new Form_class_my_trck_bar();
            show_my_Trck_Bar.ShowDialog();
        }

        private void But_textbox_Click(object sender, EventArgs e)
        {
            Form_class_my_textBox show_my_TextBox = new Form_class_my_textBox();
            show_my_TextBox.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_class_my_label shpw_my_Label = new Form_class_my_label();
            shpw_my_Label.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form_class_my_DATATIME show_my_DATATIME = new Form_class_my_DATATIME();
            show_my_DATATIME.ShowDialog();
        }
    }
}
