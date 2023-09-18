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
    public partial class repPubloshing : Form
    {
        public repPubloshing()
        {
            InitializeComponent();
        }

        private void repPubloshing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Publoshing_house' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Publoshing_houseTableAdapter.Fill(this.Database1DataSet.Publoshing_house);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Publoshing_houseTableAdapter.FillByName(this.Database1DataSet.Publoshing_house,"%"+textBox1.Text+"%");

            this.reportViewer1.RefreshReport();
        }
    }
}
