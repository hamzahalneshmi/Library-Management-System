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
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            jobNoTextBox.Clear();
            jobNameTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Job_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.database1DataSet.Job);

        }

        private void butAddJob_Click(object sender, EventArgs e)
        {

            if (butAddJob.Text == "Add")
            {
                clearItems();
                jobNoTextBox.Focus();
                butAddJob.Text = "Save";
            }
            else
            {
                
                 if (jobNameTextBox.Text == "")
                {
                    errorProvider1.SetError(jobNameTextBox, "enter the job name!");
                    jobNameTextBox.Focus();
                }
                else if (cityTextBox.Text == "")
                {
                    errorProvider1.SetError(cityTextBox, "enter the city!");
                    cityTextBox.Focus();
                }
                else if (streetTextBox.Text == "")
                {
                    errorProvider1.SetError(streetTextBox, "enter the street!");
                    streetTextBox.Focus();
                }
                else
                {
                    this.jobTableAdapter.InsertQuery(jobNameTextBox.Text,cityTextBox.Text,streetTextBox.Text);
                    this.jobTableAdapter.Fill(this.database1DataSet.Job);
                    butAddJob.Text = "Add";
                    errorProvider1.Clear();
                }
            }
        }

        private void butDeleteJob_Click(object sender, EventArgs e)
        {
            if (jobNoTextBox.Text != "")
            {
                if (MessageBox.Show("Do you want to delete this Job?", "Delete Job", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    this.jobTableAdapter.DeleteQuery(Convert.ToInt32(jobNoTextBox.Text));
                    this.jobTableAdapter.Fill(this.database1DataSet.Job);
                }
            }
        }

        private void butEditJob_Click(object sender, EventArgs e)
        {
            if (butEditJob.Text == "Edit")
            {
               
                jobNameTextBox.Focus();
                butEditJob.Text = "Save";
            }
            else
            {
                
             
                 if (jobNameTextBox.Text == "")
                {
                    errorProvider1.SetError(jobNameTextBox, "enter the job name!");
                    jobNameTextBox.Focus();
                }
                else if (cityTextBox.Text == "")
                {
                    errorProvider1.SetError(cityTextBox, "enter the city!");
                    cityTextBox.Focus();
                }
                else if (streetTextBox.Text == "")
                {
                    errorProvider1.SetError(streetTextBox, "enter the street!");
                    streetTextBox.Focus();
                }
                else
                {
                    if (MessageBox.Show("Do you want to save changes?", "Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        this.jobTableAdapter.UpdateQuery(jobNameTextBox.Text, cityTextBox.Text, streetTextBox.Text, Convert.ToInt32(jobNoTextBox.Text));
                        this.jobTableAdapter.Fill(this.database1DataSet.Job);
                        butEditJob.Text = "Edit";
                        errorProvider1.Clear();
                    }
                    else
                    {
                        butEditJob.Text = "Edit";
                        errorProvider1.Clear();
                    }

                }
            }
        }

        private void butRefershJob_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Job().Show();
        }

        private void butSearchJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbJob.Text == "")
                {
                    searchTexbJob.Focus();
                    searchCombJob.Text = "ID";
                }
                else if (searchCombJob.Text == "ID")
                {
                   
                    this.jobTableAdapter.FillByjobNo(this.database1DataSet.Job,Convert.ToInt32(searchTexbJob.Text));
                }
                else if (searchCombJob.Text == "Name")
                {
                    this.jobTableAdapter.FillByjobName(this.database1DataSet.Job,"%"+ searchTexbJob.Text+"%");
                }
                searchTexbJob.Clear();
                searchTexbJob.Focus();
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(searchTexbJob, "entered error data type!!");
            }
        }
    }
}