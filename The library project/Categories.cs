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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            sNameTextBox.Clear();
            sNameTextBox.Clear();
            sDescriptionTextBox.Clear();
            numRangeTextBox.Clear();
            }

          

        private void bookSortBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookSortBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.BookSort' table. You can move, or remove it, as needed.
            this.bookSortTableAdapter.Fill(this.database1DataSet.BookSort);

        }

        private void butAddBookSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (butAddBookSort.Text == "Add")
                {
                    clearItems();
                    sNameTextBox.Focus();
                    butAddBookSort.Text = "Save";
                }
                else
                {
                    if (sNameTextBox.Text == "")
                    {
                        errorProvider1.SetError(sNameTextBox, "enter the first name!");
                        sNameTextBox.Focus();
                    }
                    else if (numRangeTextBox.Text == "")
                    {
                        errorProvider1.SetError(numRangeTextBox, "enter the number range!");
                        numRangeTextBox.Focus();
                    }
                    else
                    {
                        this.bookSortTableAdapter.Insert(sNameTextBox.Text, sDescriptionTextBox.Text, numRangeTextBox.Text);
                        this.bookSortTableAdapter.Fill(this.database1DataSet.BookSort);

                        butAddBookSort.Text = "Add";
                        errorProvider1.Clear();
                    }
                }
            }
            catch { }
        }

        private void butDeleteBookSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (sNoTextBox.Text != "")
                {
                    if (MessageBox.Show("Do you want to delete this User?", "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        this.bookSortTableAdapter.DeleteQuery(Convert.ToInt32(sNoTextBox.Text));
                        this.bookSortTableAdapter.Fill(this.database1DataSet.BookSort);
                    }
                }
            }
            catch { }
        }

        private void butEditBookSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (sNoTextBox.Text != null && sNoTextBox.Text!="")
                {
                    if (butEditBookSort.Text == "Edit")
                    {

                        sNameTextBox.Focus();
                        butEditBookSort.Text = "Save";
                    }
                    else
                    {
                        if (sNameTextBox.Text == "")
                        {
                            errorProvider1.SetError(sNameTextBox, "enter the first name!");
                            sNameTextBox.Focus();
                        }
                        else if (numRangeTextBox.Text == "")
                        {
                            errorProvider1.SetError(numRangeTextBox, "enter the Number Range!");
                            numRangeTextBox.Focus();
                        }
                        else
                        {
                            if (MessageBox.Show("Do you want to save changes?", "Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.bookSortTableAdapter.UpdateQueryB(sNameTextBox.Text, sDescriptionTextBox.Text, numRangeTextBox.Text, Convert.ToInt32(sNoTextBox.Text));
                                this.bookSortTableAdapter.Fill(this.database1DataSet.BookSort);
                                butEditBookSort.Text = "Edit";
                                errorProvider1.Clear();
                            }
                            else
                            {
                                butEditBookSort.Text = "Edit";
                                errorProvider1.Clear();
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void butRefershBookSort_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories obj = new Categories();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void butSearchBookSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbBookSort.Text == "")
                {
                    searchTexbBookSort.Focus();
                    searchCombBookSort.Text = "ID";
                }
                else if (searchCombBookSort.Text == "ID")
                {

                    this.bookSortTableAdapter.FillByID(this.database1DataSet.BookSort, Convert.ToInt32(searchTexbBookSort.Text));
                }
                else if (searchCombBookSort.Text == "Name")
                {
                    this.bookSortTableAdapter.FillByName(this.database1DataSet.BookSort, "%" + searchTexbBookSort.Text + "%");
                }
                searchTexbBookSort.Clear();
                searchTexbBookSort.Focus();
                errorProvider1.Clear();
            }
            catch { errorProvider1.SetError(searchTexbBookSort, "entered error data type!!");/*MessageBox.Show("error");*/ }
        }
    }
}
