using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_MULTI__INTERFACE
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            header h = new header();
            h.MdiParent = this;
            h.Show();

            nav v = new nav();
            v.MdiParent = this;
            v.Show();
        }
    }
}
