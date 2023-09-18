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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            repAuther obj = new repAuther();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repBook obj = new repBook();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            repCatagourise obj = new repCatagourise();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            repCoustomers obj = new repCoustomers();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            repPubloshing obj = new repPubloshing();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }
    }
}
