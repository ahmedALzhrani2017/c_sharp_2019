namespace Forms_Basics.Method
{
    partial class Cut_Copy_Paste_Undo
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.text_copy = new System.Windows.Forms.Button();
            this.text_past = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.copy_img = new System.Windows.Forms.Button();
            this.past_img = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_copy_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(3, 228);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(97, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.copyToolStripMenuItem.Text = "copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBox2.Location = new System.Drawing.Point(119, 228);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(97, 96);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pastToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(97, 26);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.pastToolStripMenuItem.Text = "past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.PastToolStripMenuItem_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(3, 52);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 96);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(116, 52);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(100, 96);
            this.richTextBox4.TabIndex = 5;
            this.richTextBox4.Text = "";
            // 
            // text_copy
            // 
            this.text_copy.Location = new System.Drawing.Point(3, 154);
            this.text_copy.Name = "text_copy";
            this.text_copy.Size = new System.Drawing.Size(75, 23);
            this.text_copy.TabIndex = 6;
            this.text_copy.Text = "copy";
            this.text_copy.UseVisualStyleBackColor = true;
            this.text_copy.Click += new System.EventHandler(this.text_copy_Click);
            // 
            // text_past
            // 
            this.text_past.Location = new System.Drawing.Point(116, 154);
            this.text_past.Name = "text_past";
            this.text_past.Size = new System.Drawing.Size(75, 23);
            this.text_past.TabIndex = 7;
            this.text_past.Text = "past";
            this.text_past.UseVisualStyleBackColor = true;
            this.text_past.Click += new System.EventHandler(this.text_past_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Forms_Basics.Properties.Resources.c_sharp;
            this.pictureBox1.Location = new System.Drawing.Point(232, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(356, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // copy_img
            // 
            this.copy_img.Location = new System.Drawing.Point(232, 154);
            this.copy_img.Name = "copy_img";
            this.copy_img.Size = new System.Drawing.Size(75, 23);
            this.copy_img.TabIndex = 10;
            this.copy_img.Text = "copy";
            this.copy_img.UseVisualStyleBackColor = true;
            this.copy_img.Click += new System.EventHandler(this.Copy_img_Click);
            // 
            // past_img
            // 
            this.past_img.Location = new System.Drawing.Point(356, 154);
            this.past_img.Name = "past_img";
            this.past_img.Size = new System.Drawing.Size(75, 23);
            this.past_img.TabIndex = 11;
            this.past_img.Text = "past";
            this.past_img.UseVisualStyleBackColor = true;
            this.past_img.Click += new System.EventHandler(this.Past_img_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.past_img);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.copy_img);
            this.panel1.Controls.Add(this.richTextBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.text_copy);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.text_past);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 366);
            this.panel1.TabIndex = 12;
            // 
            // button_copy_file
            // 
            this.button_copy_file.Location = new System.Drawing.Point(682, 62);
            this.button_copy_file.Name = "button_copy_file";
            this.button_copy_file.Size = new System.Drawing.Size(103, 23);
            this.button_copy_file.TabIndex = 13;
            this.button_copy_file.Text = "copy-file";
            this.button_copy_file.UseVisualStyleBackColor = true;
            this.button_copy_file.Click += new System.EventHandler(this.Button_copy_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cut_Copy_Paste_Undo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_copy_file);
            this.Controls.Add(this.panel1);
            this.Name = "Cut_Copy_Paste_Undo";
            this.Text = "Cut_Copy_Paste_Undo";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button text_copy;
        private System.Windows.Forms.Button text_past;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button copy_img;
        private System.Windows.Forms.Button past_img;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_copy_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}