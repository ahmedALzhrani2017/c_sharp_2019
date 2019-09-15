namespace Forms_Basics
{
    partial class Form_Class_Open_File_Dialog
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
            this.label_Path = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label_File_Name = new System.Windows.Forms.Label();
            this.textBox_File_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_extension = new System.Windows.Forms.TextBox();
            this.button_Choes_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_File_Create = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button_Move = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Path.Location = new System.Drawing.Point(3, 6);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(56, 25);
            this.label_Path.TabIndex = 0;
            this.label_Path.Text = "Path";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(153, 11);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(334, 20);
            this.textBox_Path.TabIndex = 1;
            // 
            // label_File_Name
            // 
            this.label_File_Name.AutoSize = true;
            this.label_File_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_File_Name.Location = new System.Drawing.Point(3, 56);
            this.label_File_Name.Name = "label_File_Name";
            this.label_File_Name.Size = new System.Drawing.Size(109, 25);
            this.label_File_Name.TabIndex = 2;
            this.label_File_Name.Text = "File Name";
            // 
            // textBox_File_Name
            // 
            this.textBox_File_Name.Location = new System.Drawing.Point(153, 56);
            this.textBox_File_Name.Name = "textBox_File_Name";
            this.textBox_File_Name.Size = new System.Drawing.Size(334, 20);
            this.textBox_File_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "extension";
            // 
            // textBox_extension
            // 
            this.textBox_extension.Location = new System.Drawing.Point(153, 105);
            this.textBox_extension.Name = "textBox_extension";
            this.textBox_extension.Size = new System.Drawing.Size(334, 20);
            this.textBox_extension.TabIndex = 5;
            // 
            // button_Choes_file
            // 
            this.button_Choes_file.Location = new System.Drawing.Point(24, 165);
            this.button_Choes_file.Name = "button_Choes_file";
            this.button_Choes_file.Size = new System.Drawing.Size(125, 23);
            this.button_Choes_file.TabIndex = 6;
            this.button_Choes_file.Text = "openFileDialog";
            this.button_Choes_file.UseVisualStyleBackColor = true;
            this.button_Choes_file.Click += new System.EventHandler(this.Button_Choes_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Move);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_File_Create);
            this.panel1.Controls.Add(this.label_File_Name);
            this.panel1.Controls.Add(this.button_Choes_file);
            this.panel1.Controls.Add(this.label_Path);
            this.panel1.Controls.Add(this.textBox_extension);
            this.panel1.Controls.Add(this.textBox_Path);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_File_Name);
            this.panel1.Location = new System.Drawing.Point(896, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 213);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.COPY_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(236, 165);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button_File_Create
            // 
            this.button_File_Create.Location = new System.Drawing.Point(155, 164);
            this.button_File_Create.Name = "button_File_Create";
            this.button_File_Create.Size = new System.Drawing.Size(75, 24);
            this.button_File_Create.TabIndex = 7;
            this.button_File_Create.Text = "File_Create";
            this.button_File_Create.UseVisualStyleBackColor = true;
            this.button_File_Create.Click += new System.EventHandler(this.File_Create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1149, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "if (System.IO.File.Exists(string path))";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(982, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "File.Exists(String path)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(982, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "File.Delete(String path)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button_Move
            // 
            this.button_Move.Location = new System.Drawing.Point(480, 164);
            this.button_Move.Name = "button_Move";
            this.button_Move.Size = new System.Drawing.Size(75, 23);
            this.button_Move.TabIndex = 11;
            this.button_Move.Text = " Move";
            this.button_Move.UseVisualStyleBackColor = true;
            this.button_Move.Click += new System.EventHandler(this.Button_Move_Click);
            // 
            // Form_Class_Open_File_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 704);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Class_Open_File_Dialog";
            this.Text = "Form_Class_Open_File_Dialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label_File_Name;
        private System.Windows.Forms.TextBox textBox_File_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_extension;
        private System.Windows.Forms.Button button_Choes_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_File_Create;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button_Move;
    }
}