using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_library_project
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/HamzaMuradAlneshmi");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("  https://www.facebook.com/omar.altbiani");
        }
    }
}
