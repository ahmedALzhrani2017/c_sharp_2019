

namespace Z_my_test
{
    partial class my_form_design 
    {
      
        


            public static void InputBox()
            {

                Form f_1 = new Form();
                f_1.components = new System.ComponentModel.Container();
                f_1.label1 = new System.Windows.Forms.Label();
                f_1.timer1 = new System.Windows.Forms.Timer(f_1.components);
                f_1.label2 = new System.Windows.Forms.Label();
                f_1.label3 = new System.Windows.Forms.Label();
                f_1.SuspendLayout();
                // 
                // label1
                // 
                f_1.label1.AutoSize = true;
                f_1.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                f_1.label1.Location = new System.Drawing.Point(12, 58);
                f_1.label1.MinimumSize = new System.Drawing.Size(100, 20);
                f_1.label1.Name = "label1";
                f_1.label1.Size = new System.Drawing.Size(100, 20);
                f_1.label1.TabIndex = 0;
                f_1.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // timer1
                // 
                f_1.timer1.Enabled = true;
                f_1.timer1.Tick += new System.EventHandler(f_1.Timer1_Tick);
                // 
                // label2
                // 
                f_1.label2.AutoSize = true;
                f_1.label2.Location = new System.Drawing.Point(155, 65);
                f_1.label2.Name = "label2";
                f_1.label2.Size = new System.Drawing.Size(255, 13);
                f_1.label2.TabIndex = 1;
                f_1.label2.Text = "label1.Text = DateTime.Now.ToString(\"HH: mm:ss\");";
                // 
                // label3
                // 
                f_1.label3.AutoSize = true;
                f_1.label3.Location = new System.Drawing.Point(302, 9);
                f_1.label3.Name = "label3";
                f_1.label3.Size = new System.Drawing.Size(129, 13);
                f_1.label3.TabIndex = 2;
                f_1.label3.Text = "f_1.timer1.Enabled = true;";
                // 
                // Form_Class_my_Timer
                // 
                f_1.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                f_1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                f_1.ClientSize = new System.Drawing.Size(800, 450);
                f_1.Controls.Add(f_1.label3);
                f_1.Controls.Add(f_1.label2);
                f_1.Controls.Add(f_1.label1);
                f_1.Name = "Form_Class_my_Timer";
                f_1.Text = "my_Timer";
                f_1.Load += new System.EventHandler(f_1.Form_Class_my_Timer_Load);
                f_1.ResumeLayout(false);
                f_1.PerformLayout();

                f_1.ShowDialog();

            }

            

        


                   
        
    }

}
