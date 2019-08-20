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
            this.SuspendLayout();
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Path.Location = new System.Drawing.Point(12, 25);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(56, 25);
            this.label_Path.TabIndex = 0;
            this.label_Path.Text = "Path";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(162, 30);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(334, 20);
            this.textBox_Path.TabIndex = 1;
            // 
            // label_File_Name
            // 
            this.label_File_Name.AutoSize = true;
            this.label_File_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_File_Name.Location = new System.Drawing.Point(12, 75);
            this.label_File_Name.Name = "label_File_Name";
            this.label_File_Name.Size = new System.Drawing.Size(109, 25);
            this.label_File_Name.TabIndex = 2;
            this.label_File_Name.Text = "File Name";
            // 
            // textBox_File_Name
            // 
            this.textBox_File_Name.Location = new System.Drawing.Point(162, 75);
            this.textBox_File_Name.Name = "textBox_File_Name";
            this.textBox_File_Name.Size = new System.Drawing.Size(334, 20);
            this.textBox_File_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "extension";
            // 
            // textBox_extension
            // 
            this.textBox_extension.Location = new System.Drawing.Point(162, 124);
            this.textBox_extension.Name = "textBox_extension";
            this.textBox_extension.Size = new System.Drawing.Size(334, 20);
            this.textBox_extension.TabIndex = 5;
            // 
            // button_Choes_file
            // 
            this.button_Choes_file.Location = new System.Drawing.Point(162, 184);
            this.button_Choes_file.Name = "button_Choes_file";
            this.button_Choes_file.Size = new System.Drawing.Size(125, 23);
            this.button_Choes_file.TabIndex = 6;
            this.button_Choes_file.Text = "Choes file";
            this.button_Choes_file.UseVisualStyleBackColor = true;
            this.button_Choes_file.Click += new System.EventHandler(this.Button_Choes_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            
            // 
            // Form_Class_Open_File_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 704);
            this.Controls.Add(this.button_Choes_file);
            this.Controls.Add(this.textBox_extension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_File_Name);
            this.Controls.Add(this.label_File_Name);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.label_Path);
            this.Name = "Form_Class_Open_File_Dialog";
            this.Text = "Form_Class_Open_File_Dialog";
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
    }
}