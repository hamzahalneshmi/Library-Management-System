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
    public partial class EditCoustomer : Form
    {
        public EditCoustomer()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            brNoTextBox.Clear();
            //birthDateDateTimePicker.Text = "01/12/2016 03:04 م";
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            tellNo1TextBox.Clear();
            tellNo2TextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            jobNoComboBox.Text="";
            idNoComboBox.Text = "";
        }
        private void borrowerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void EditCoustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ID' table. You can move, or remove it, as needed.
            this.iDTableAdapter.Fill(this.database1DataSet.ID);
            // TODO: This line of code loads data into the 'database1DataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.database1DataSet.Job);
            // TODO: This line of code loads data into the 'database1DataSet.Borrower' table. You can move, or remove it, as needed.
            this.borrowerTableAdapter.Fill(this.database1DataSet.Borrower);

        }

        private void butAddBor_Click(object sender, EventArgs e)
        {
            if (butAddBor.Text == "Add")
            {
                clearItems();
                fNameTextBox.Focus();
                butAddBor.Text = "Save";
            }
            else
            {

                if (fNameTextBox.Text == "")
                {
                    errorProvider1.SetError(fNameTextBox, "enter the Borrowe name!");
                    fNameTextBox.Focus();
                }
                else if (lNameTextBox.Text == "")
                {
                    errorProvider1.SetError(lNameTextBox, "enter the Last name!");
                    lNameTextBox.Focus();
                }
                else if (tellNo1TextBox.Text == "")
                {
                    errorProvider1.SetError(tellNo1TextBox, "enter the tell!");
                    tellNo1TextBox.Focus();
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
                else if (idNoComboBox.Text == "")
                {
                    errorProvider1.SetError(idNoComboBox, "enter the ID number!");
                    idNoComboBox.Focus();
                }
                else if (jobNoComboBox.Text == "")
                {
                    errorProvider1.SetError(jobNoComboBox, "enter the Job number!");
                    jobNoComboBox.Focus();
                }
                else
                {
                   // this.jobTableAdapter.InsertQuery(jobNameTextBox.Text, cityTextBox.Text, streetTextBox.Text);
                    this.borrowerTableAdapter.InsertQuery(fNameTextBox.Text,lNameTextBox.Text,tellNo1TextBox.Text,tellNo2TextBox.Text,birthDateDateTimePicker.Text,cityTextBox.Text,streetTextBox.Text,Convert.ToInt32(jobNoComboBox.Text),Convert.ToInt32(idNoComboBox.Text));
                    this.borrowerTableAdapter.Fill(this.database1DataSet.Borrower);
                    butAddBor.Text = "Add";
                    errorProvider1.Clear();
                }
            }
        }

        private void butDeleteBor_Click(object sender, EventArgs e)
        {

            if (brNoTextBox.Text != "")
            {
                if (MessageBox.Show("Do you want to delete this Customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                   // this.iDTableAdapter.DeleteQuery(Convert.ToInt32(idNoTextBox.Text));
                    this.borrowerTableAdapter.DeleteQuery(Convert.ToInt32(brNoTextBox.Text));
                    this.borrowerTableAdapter.Fill(this.database1DataSet.Borrower);
                }
            }
        }

        private void butSearchBor_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbBor.Text == "")
                {
                    searchTexbBor.Focus();
                    searchCombBor.Text = "ID";
                }
                else if (searchCombBor.Text == "ID")
                {
                  //  this.iDTableAdapter.FillByidNo(this.database1DataSet.ID, Convert.ToInt32(searchTexbID.Text));
                    this.borrowerTableAdapter.FillByID(this.database1DataSet.Borrower,Convert.ToInt32(searchTexbBor.Text));
                }
                else if (searchCombBor.Text == "Name")
                {
                   // this.iDTableAdapter.FillByPlace(this.database1DataSet.ID, "%" + searchTexbBor.Text + "%");
                    this.borrowerTableAdapter.FillByName(this.database1DataSet.Borrower,"%"+ searchTexbBor.Text +"%");
                }
                searchTexbBor.Clear();
                searchTexbBor.Focus();
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(searchTexbBor, "entered error data type!!");
            }
        }

        private void butRefershBor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditCoustomer().Show();
        }

        private void butEditBor_Click(object sender, EventArgs e)
        {
            if (butEditBor.Text == "Edit")
            {
               // clearItems();
                brNoTextBox.Focus();
                butEditBor.Text = "Save";
            }
            else
            {

                if (fNameTextBox.Text == "")
                {
                    errorProvider1.SetError(fNameTextBox, "enter the Borrowe name!");
                    fNameTextBox.Focus();
                }
                else if (lNameTextBox.Text == "")
                {
                    errorProvider1.SetError(lNameTextBox, "enter the Last name!");
                    lNameTextBox.Focus();
                }
                else if (tellNo1TextBox.Text == "")
                {
                    errorProvider1.SetError(tellNo1TextBox, "enter the tell!");
                    tellNo1TextBox.Focus();
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
                else if (idNoComboBox.Text == "")
                {
                    errorProvider1.SetError(idNoComboBox, "enter the ID number!");
                    idNoComboBox.Focus();
                }
                else if (jobNoComboBox.Text == "")
                {
                    errorProvider1.SetError(jobNoComboBox, "enter the Job number!");
                    jobNoComboBox.Focus();
                }
                else
                {
                    this.borrowerTableAdapter.UpdateQuery(fNameTextBox.Text,lNameTextBox.Text,tellNo1TextBox.Text,tellNo2TextBox.Text,birthDateDateTimePicker.Text,cityTextBox.Text,streetTextBox.Text,Convert.ToInt32(jobNoComboBox.Text),Convert.ToInt32(idNoComboBox.Text),Convert.ToInt32(brNoTextBox.Text));
                    this.borrowerTableAdapter.Fill(this.database1DataSet.Borrower);
                    butEditBor.Text = "Edit";
                    errorProvider1.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Job obj = new Job();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID obj = new ID();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }
    }
}
