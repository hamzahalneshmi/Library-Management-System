﻿using System;
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
    public partial class repCoustomers : Form
    {
        public repCoustomers()
        {
            InitializeComponent();
        }

        private void repCoustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Borrower' table. You can move, or remove it, as needed.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BorrowerTableAdapter.Fill(this.Database1DataSet.Borrower);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BorrowerTableAdapter.FillByName(this.Database1DataSet.Borrower,"%"+textBox1.Text+"%");

            this.reportViewer1.RefreshReport();
        }
    }
}
