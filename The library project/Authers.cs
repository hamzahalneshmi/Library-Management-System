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
    public partial class Authers : Form
    {
        public Authers()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            aNoTextBox.Clear();
            fNameTextBox.Clear();
            lNameTextBox.Clear();
        }
        private void autherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Authers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Auther' table. You can move, or remove it, as needed.
            this.autherTableAdapter.Fill(this.database1DataSet.Auther);

        }

        private void butAddUser_Click(object sender, EventArgs e)
        {

        }

        private void butSearchUser_Click(object sender, EventArgs e)
        {

        }

        private void butAddAuther_Click(object sender, EventArgs e)
        {
            try
            {
                if (butAddAuther.Text == "Add")
                {
                    clearItems();
                    fNameTextBox.Focus();
                    butAddAuther.Text = "Save";
                }
                else
                {
                    if (fNameTextBox.Text == "")
                    {
                        errorProvider1.SetError(fNameTextBox, "enter the first name!");
                        fNameTextBox.Focus();
                    }
                    else
                    {
                        this.autherTableAdapter.Insert(fNameTextBox.Text, lNameTextBox.Text);
                        this.autherTableAdapter.Fill(this.database1DataSet.Auther);

                        butAddAuther.Text = "Add";
                        errorProvider1.Clear();
                    }
                }
            }
            catch { }
        }

        private void butDeleteAuther_Click(object sender, EventArgs e)
        {
            try
            {
                if (aNoTextBox.Text != "")
                {
                    if (MessageBox.Show("Do you want to delete this User?", "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        this.autherTableAdapter.DeleteQuery(Convert.ToInt32(aNoTextBox.Text));
                        this.autherTableAdapter.Fill(this.database1DataSet.Auther);
                    }
                }
            }
            catch { }
        }

        private void butRefershAuther_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authers obj = new Authers();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void butEditAuther_Click(object sender, EventArgs e)
        {
            try
            {
                if (aNoTextBox.Text != null && aNoTextBox.Text !="")
                {
                    if (butEditAuther.Text == "Edit")
                    {

                        fNameTextBox.Focus();
                        butEditAuther.Text = "Save";
                    }
                    else
                    {
                        if (fNameTextBox.Text == "")
                        {
                            errorProvider1.SetError(fNameTextBox, "enter the first name!");
                            fNameTextBox.Focus();
                        }
                        else
                        {
                            if (MessageBox.Show("Do you want to save changes?", "Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.autherTableAdapter.UpdateQuery(fNameTextBox.Text, lNameTextBox.Text, Convert.ToInt32(aNoTextBox.Text));
                                this.autherTableAdapter.Fill(this.database1DataSet.Auther);
                                butEditAuther.Text = "Edit";
                                errorProvider1.Clear();
                            }
                            else
                            {
                                butEditAuther.Text = "Edit";
                                errorProvider1.Clear();
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void butSearchAuther_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbAuther.Text == "")
                {
                    searchTexbAuther.Focus();
                    searchCombAuther.Text = "ID";
                }
                else if (searchCombAuther.Text == "ID")
                {

                    this.autherTableAdapter.FillByID(this.database1DataSet.Auther, Convert.ToInt32(searchTexbAuther.Text));
                }
                else if (searchCombAuther.Text == "Name")
                {
                    this.autherTableAdapter.FillByName(this.database1DataSet.Auther, "%" + searchTexbAuther.Text + "%");
                }
                searchTexbAuther.Clear();
                searchTexbAuther.Focus();
                errorProvider1.Clear();
            }
            catch { errorProvider1.SetError(searchTexbAuther, "entered error data type!!");/*MessageBox.Show("error");*/ }
        }
    }
}
