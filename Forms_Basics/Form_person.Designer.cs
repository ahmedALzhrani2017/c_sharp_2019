namespace Forms_Basics
{
    partial class Form_person
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_NumericUpDown = new System.Windows.Forms.Button();
            this.but_my_PictureBox = new System.Windows.Forms.Button();
            this.but_Timer = new System.Windows.Forms.Button();
            this.but_Open_File = new System.Windows.Forms.Button();
            this.but_CHECK_LIST_BOX = new System.Windows.Forms.Button();
            this.butt_combo_box = new System.Windows.Forms.Button();
            this.but_save_File = new System.Windows.Forms.Button();
            this.but_Radio = new System.Windows.Forms.Button();
            this.but_track_bar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_NumericUpDown
            // 
            this.but_NumericUpDown.Location = new System.Drawing.Point(12, 24);
            this.but_NumericUpDown.Name = "but_NumericUpDown";
            this.but_NumericUpDown.Size = new System.Drawing.Size(140, 23);
            this.but_NumericUpDown.TabIndex = 0;
            this.but_NumericUpDown.Text = "NumericUpDown";
            this.but_NumericUpDown.UseVisualStyleBackColor = true;
            this.but_NumericUpDown.Click += new System.EventHandler(this.But_NumericUpDown_Click);
            // 
            // but_my_PictureBox
            // 
            this.but_my_PictureBox.Location = new System.Drawing.Point(158, 24);
            this.but_my_PictureBox.Name = "but_my_PictureBox";
            this.but_my_PictureBox.Size = new System.Drawing.Size(169, 23);
            this.but_my_PictureBox.TabIndex = 1;
            this.but_my_PictureBox.Text = "my_PictureBox";
            this.but_my_PictureBox.UseVisualStyleBackColor = true;
            this.but_my_PictureBox.Click += new System.EventHandler(this.But_my_PictureBox_Click);
            // 
            // but_Timer
            // 
            this.but_Timer.Location = new System.Drawing.Point(333, 24);
            this.but_Timer.Name = "but_Timer";
            this.but_Timer.Size = new System.Drawing.Size(95, 23);
            this.but_Timer.TabIndex = 2;
            this.but_Timer.Text = "Timer";
            this.but_Timer.UseVisualStyleBackColor = true;
            this.but_Timer.Click += new System.EventHandler(this.But_Timer_Click);
            // 
            // but_Open_File
            // 
            this.but_Open_File.Location = new System.Drawing.Point(448, 24);
            this.but_Open_File.Name = "but_Open_File";
            this.but_Open_File.Size = new System.Drawing.Size(132, 23);
            this.but_Open_File.TabIndex = 3;
            this.but_Open_File.Text = "Open File Dialog ";
            this.but_Open_File.UseVisualStyleBackColor = true;
            this.but_Open_File.Click += new System.EventHandler(this.But_Open_File_Click);
            // 
            // but_CHECK_LIST_BOX
            // 
            this.but_CHECK_LIST_BOX.Location = new System.Drawing.Point(12, 65);
            this.but_CHECK_LIST_BOX.Name = "but_CHECK_LIST_BOX";
            this.but_CHECK_LIST_BOX.Size = new System.Drawing.Size(140, 23);
            this.but_CHECK_LIST_BOX.TabIndex = 4;
            this.but_CHECK_LIST_BOX.Text = "CHECK LIST BOX";
            this.but_CHECK_LIST_BOX.UseVisualStyleBackColor = true;
            this.but_CHECK_LIST_BOX.Click += new System.EventHandler(this.But_CHECK_LIST_BOX_Click);
            // 
            // butt_combo_box
            // 
            this.butt_combo_box.Location = new System.Drawing.Point(158, 65);
            this.butt_combo_box.Name = "butt_combo_box";
            this.butt_combo_box.Size = new System.Drawing.Size(169, 23);
            this.butt_combo_box.TabIndex = 5;
            this.butt_combo_box.Text = "Combo BOX ";
            this.butt_combo_box.UseVisualStyleBackColor = true;
            this.butt_combo_box.Click += new System.EventHandler(this.Butt_combo_box_Click);
            // 
            // but_save_File
            // 
            this.but_save_File.Location = new System.Drawing.Point(448, 64);
            this.but_save_File.Name = "but_save_File";
            this.but_save_File.Size = new System.Drawing.Size(132, 23);
            this.but_save_File.TabIndex = 6;
            this.but_save_File.Text = "save file";
            this.but_save_File.UseVisualStyleBackColor = true;
            this.but_save_File.Click += new System.EventHandler(this.But_save_File_Click);
            // 
            // but_Radio
            // 
            this.but_Radio.Location = new System.Drawing.Point(333, 65);
            this.but_Radio.Name = "but_Radio";
            this.but_Radio.Size = new System.Drawing.Size(109, 23);
            this.but_Radio.TabIndex = 7;
            this.but_Radio.Text = "Radio Button ";
            this.but_Radio.UseVisualStyleBackColor = true;
            this.but_Radio.Click += new System.EventHandler(this.But_Radio_Click);
            // 
            // but_track_bar
            // 
            this.but_track_bar.Location = new System.Drawing.Point(12, 109);
            this.but_track_bar.Name = "but_track_bar";
            this.but_track_bar.Size = new System.Drawing.Size(140, 23);
            this.but_track_bar.TabIndex = 8;
            this.but_track_bar.Text = "Track Bar ";
            this.but_track_bar.UseVisualStyleBackColor = true;
            this.but_track_bar.Click += new System.EventHandler(this.But_track_bar_Click);
            // 
            // Form_person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 588);
            this.Controls.Add(this.but_track_bar);
            this.Controls.Add(this.but_Radio);
            this.Controls.Add(this.but_save_File);
            this.Controls.Add(this.butt_combo_box);
            this.Controls.Add(this.but_CHECK_LIST_BOX);
            this.Controls.Add(this.but_Open_File);
            this.Controls.Add(this.but_Timer);
            this.Controls.Add(this.but_my_PictureBox);
            this.Controls.Add(this.but_NumericUpDown);
            this.Name = "Form_person";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_NumericUpDown;
        private System.Windows.Forms.Button but_my_PictureBox;
        private System.Windows.Forms.Button but_Timer;
        private System.Windows.Forms.Button but_Open_File;
        private System.Windows.Forms.Button but_CHECK_LIST_BOX;
        private System.Windows.Forms.Button butt_combo_box;
        private System.Windows.Forms.Button but_save_File;
        private System.Windows.Forms.Button but_Radio;
        private System.Windows.Forms.Button but_track_bar;
    }
}

