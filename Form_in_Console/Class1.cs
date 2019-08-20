using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Form_in_Console
{
    class Class1
    {
        public static void InputBox(string titel, string text, bool pass=false)
        {
            Form f_1 = new Form();
            f_1.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f_1.ControlBox = false;
            f_1.Text = titel;
            f_1.Font = new Font("Arial", 10, FontStyle.Bold);
            f_1.MaximizeBox = false;
            f_1.MinimizeBox = false;
            f_1.Size = new Size(500, 500);
            f_1.StartPosition = FormStartPosition.Manual; /*FormStartPosition.CenterScreen;*/
            f_1.Location = new Point((Screen.PrimaryScreen.Bounds.Width - f_1.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - f_1.Height) / 2); /*new Point((Screen.PrimaryScreen.WorkingArea.Width - f_1.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - f_1.Height) / 2);*/

            Label b1 = new Label();
            b1.Text = "my name is";
            f_1.Controls.Add(b1);





            f_1.ShowDialog();

        }
        
    }
}
