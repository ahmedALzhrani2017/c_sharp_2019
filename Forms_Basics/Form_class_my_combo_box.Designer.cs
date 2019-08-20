namespace Forms_Basics
{
    partial class Form_class_my_combo_box
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.but_add_item = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.but_add_items = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // but_add_item
            // 
            this.but_add_item.Location = new System.Drawing.Point(152, 12);
            this.but_add_item.Name = "but_add_item";
            this.but_add_item.Size = new System.Drawing.Size(75, 23);
            this.but_add_item.TabIndex = 1;
            this.but_add_item.Text = "add item";
            this.but_add_item.UseVisualStyleBackColor = true;
            this.but_add_item.Click += new System.EventHandler(this.But_add_item_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.comboBox2.Location = new System.Drawing.Point(12, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // but_add_items
            // 
            this.but_add_items.Location = new System.Drawing.Point(152, 59);
            this.but_add_items.Name = "but_add_items";
            this.but_add_items.Size = new System.Drawing.Size(75, 23);
            this.but_add_items.TabIndex = 2;
            this.but_add_items.Text = "add_items";
            this.but_add_items.UseVisualStyleBackColor = true;
            this.but_add_items.Click += new System.EventHandler(this.But_add_items_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ahmed",
            "hassan",
            "alzhrani"});
            this.comboBox3.Location = new System.Drawing.Point(12, 115);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = " this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;" +
    "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListI" +
    "tems;";
            // 
            // Form_class_my_combo_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.but_add_items);
            this.Controls.Add(this.but_add_item);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form_class_my_combo_box";
            this.Text = "Form_class_my_combo_box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button but_add_item;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button but_add_items;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}