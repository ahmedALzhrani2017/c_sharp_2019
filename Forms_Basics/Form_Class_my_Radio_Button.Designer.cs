namespace Forms_Basics
{
    partial class Form_Class_my_Radio_Button
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
            this.radioButton1_male = new System.Windows.Forms.RadioButton();
            this.radioButton2_female = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_checked = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1_male
            // 
            this.radioButton1_male.AutoSize = true;
            this.radioButton1_male.Location = new System.Drawing.Point(0, 3);
            this.radioButton1_male.Name = "radioButton1_male";
            this.radioButton1_male.Size = new System.Drawing.Size(47, 17);
            this.radioButton1_male.TabIndex = 0;
            this.radioButton1_male.TabStop = true;
            this.radioButton1_male.Text = "male";
            this.radioButton1_male.UseVisualStyleBackColor = true;
            // 
            // radioButton2_female
            // 
            this.radioButton2_female.AutoSize = true;
            this.radioButton2_female.Location = new System.Drawing.Point(3, 39);
            this.radioButton2_female.Name = "radioButton2_female";
            this.radioButton2_female.Size = new System.Drawing.Size(56, 17);
            this.radioButton2_female.TabIndex = 1;
            this.radioButton2_female.TabStop = true;
            this.radioButton2_female.Text = "female";
            this.radioButton2_female.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton1_male);
            this.panel1.Controls.Add(this.radioButton2_female);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 62);
            this.panel1.TabIndex = 2;
            // 
            // button1_checked
            // 
            this.button1_checked.Location = new System.Drawing.Point(117, 32);
            this.button1_checked.Name = "button1_checked";
            this.button1_checked.Size = new System.Drawing.Size(75, 23);
            this.button1_checked.TabIndex = 3;
            this.button1_checked.Text = "checked";
            this.button1_checked.UseVisualStyleBackColor = true;
            this.button1_checked.Click += new System.EventHandler(this.button1_checked_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "radioButton1.Checked=tru";
            // 
            // Form_Class_my_Radio_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_checked);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Class_my_Radio_Button";
            this.Text = "Form_Class_my_Radio_Button";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1_male;
        private System.Windows.Forms.RadioButton radioButton2_female;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_checked;
        private System.Windows.Forms.Label label1;
    }
}