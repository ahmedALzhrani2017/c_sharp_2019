namespace Forms_Basics
{
    partial class Form_class_my_CHECK_LIST_BOX
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.but_CHECK_item = new System.Windows.Forms.Button();
            this.but_ = new System.Windows.Forms.Button();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab_add_item = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 82);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "this.checkedListBox1.CheckOnClick = true;";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.checkedListBox3.Location = new System.Drawing.Point(12, 152);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox3.TabIndex = 0;
            // 
            // but_CHECK_item
            // 
            this.but_CHECK_item.Location = new System.Drawing.Point(141, 193);
            this.but_CHECK_item.Name = "but_CHECK_item";
            this.but_CHECK_item.Size = new System.Drawing.Size(127, 23);
            this.but_CHECK_item.TabIndex = 2;
            this.but_CHECK_item.Text = "CHECK item";
            this.but_CHECK_item.UseVisualStyleBackColor = true;
            this.but_CHECK_item.Click += new System.EventHandler(this.But_CHECK_item_Click);
            // 
            // but_
            // 
            this.but_.Location = new System.Drawing.Point(141, 260);
            this.but_.Name = "but_";
            this.but_.Size = new System.Drawing.Size(127, 23);
            this.but_.TabIndex = 3;
            this.but_.Text = "add item";
            this.but_.UseVisualStyleBackColor = true;
            this.but_.Click += new System.EventHandler(this.But_add_item_Click);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.CheckOnClick = true;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "a",
            "b"});
            this.checkedListBox4.Location = new System.Drawing.Point(12, 237);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lab_add_item
            // 
            this.lab_add_item.AutoSize = true;
            this.lab_add_item.Location = new System.Drawing.Point(423, 260);
            this.lab_add_item.Name = "lab_add_item";
            this.lab_add_item.Size = new System.Drawing.Size(213, 13);
            this.lab_add_item.TabIndex = 5;
            this.lab_add_item.Text = "checkedListBox4.Items.Add(textBox1.Text);";
            // 
            // Form_class_my_CHECK_LIST_BOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 634);
            this.Controls.Add(this.lab_add_item);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_);
            this.Controls.Add(this.but_CHECK_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form_class_my_CHECK_LIST_BOX";
            this.Text = "Form_class_my_CHECK_LIST_BOX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Button but_CHECK_item;
        private System.Windows.Forms.Button but_;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab_add_item;
    }
}