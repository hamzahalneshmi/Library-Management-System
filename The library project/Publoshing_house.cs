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
    public partial class Publoshing_house : Form
    {
        public Publoshing_house()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            pubNoTextBox.Clear();
            pubNameTextBox.Clear();
            tellNo1TextBox.Clear();
            tellNo2TextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            eMailTextBox.Clear();
        }
        private void publoshing_houseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publoshing_houseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Publoshing_house_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet.Book);
            // TODO: This line of code loads data into the 'database1DataSet.Publoshing_house' table. You can move, or remove it, as needed.
            this.publoshing_houseTableAdapter.Fill(this.database1DataSet.Publoshing_house);

        }

        private void butAddpub_Click(object sender, EventArgs e)
        {
            if (butAddpub.Text == "Add")
            {
                clearItems();
                pubNameTextBox.Focus();
                butAddpub.Text = "Save";
            }
            else
            {

                if (pubNameTextBox.Text == "")
                {
                    errorProvider1.SetError(pubNameTextBox, "enter the publoshing house name!");
                    pubNameTextBox.Focus();
                }
                
                else if (tellNo1TextBox.Text == "")
                {
                    errorProvider1.SetError(tellNo1TextBox, "enter the tell!");
                    tellNo1TextBox.Focus();
                }
                else if (tellNo2TextBox.Text == "")
                {
                    errorProvider1.SetError(tellNo2TextBox, "enter the tell!");
                    tellNo2TextBox.Focus();
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
                
                else if (eMailTextBox.Text == "")
                {
                    errorProvider1.SetError(eMailTextBox, "enter the emai!");
                    eMailTextBox.Focus();
                }
                else
                {
                    this.publoshing_houseTableAdapter.InsertQuery(pubNameTextBox.Text,tellNo1TextBox.Text,tellNo2TextBox.Text,eMailTextBox.Text,cityTextBox.Text,streetTextBox.Text);
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                    // TODO: This line of code loads data into the 'database1DataSet.Publoshing_house' table. You can move, or remove it, as needed.
                    this.publoshing_houseTableAdapter.Fill(this.database1DataSet.Publoshing_house);
                    butAddpub.Text = "Add";
                    errorProvider1.Clear();
                }
            }
        }

        private void butDeletepub_Click(object sender, EventArgs e)
        {
            if (pubNoTextBox.Text != "")
            {
                if (MessageBox.Show("Do you want to delete this publish house?", "Delete publosing house", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.publoshing_houseTableAdapter.DeleteQuery(Convert.ToInt32(pubNoTextBox.Text));
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                    // TODO: This line of code loads data into the 'database1DataSet.Publoshing_house' table. You can move, or remove it, as needed.
                    this.publoshing_houseTableAdapter.Fill(this.database1DataSet.Publoshing_house);
                }
            }
        }

        private void butEditpub_Click(object sender, EventArgs e)
        {
            if (butEditpub.Text == "Edit")
            {
               
                pubNameTextBox.Focus();
                butEditpub.Text = "Save";
            }
            else
            {

                if (pubNameTextBox.Text == "")
                {
                    errorProvider1.SetError(pubNameTextBox, "enter the publoshing house name!");
                    pubNameTextBox.Focus();
                }

                else if (tellNo1TextBox.Text == "")
                {
                    errorProvider1.SetError(tellNo1TextBox, "enter the tell!");
                    tellNo1TextBox.Focus();
                }
                else if (tellNo2TextBox.Text == "")
                {
                    errorProvider1.SetError(tellNo2TextBox, "enter the tell!");
                    tellNo2TextBox.Focus();
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

                else if (eMailTextBox.Text == "")
                {
                    errorProvider1.SetError(eMailTextBox, "enter the emai!");
                    eMailTextBox.Focus();
                }
                else
                {
                    this.publoshing_houseTableAdapter.UpdateQuery(pubNameTextBox.Text, tellNo1TextBox.Text, tellNo2TextBox.Text, eMailTextBox.Text, cityTextBox.Text, streetTextBox.Text,Convert.ToInt32(pubNoTextBox.Text));
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                    // TODO: This line of code loads data into the 'database1DataSet.Publoshing_house' table. You can move, or remove it, as needed.
                    this.publoshing_houseTableAdapter.Fill(this.database1DataSet.Publoshing_house);
                    butEditpub.Text = "Edit";
                    errorProvider1.Clear();
                }
            }
        }

        private void butRefershpub_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Publoshing_house().Show();
        }

        private void butSearchpub_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbpub.Text == "")
                {
                    searchTexbpub.Focus();
                    searchCombpub.Text = "ID";
                }
                else if (searchCombpub.Text == "ID")
                {
                    this.publoshing_houseTableAdapter.FillByID(this.database1DataSet.Publoshing_house,Convert.ToInt32(searchTexbpub.Text));
                }
                else if (searchCombpub.Text == "Name")
                {
                    this.publoshing_houseTableAdapter.FillByName(this.database1DataSet.Publoshing_house, "%" + searchTexbpub.Text + "%" );
                }
                searchTexbpub.Clear();
                searchTexbpub.Focus();
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(searchTexbpub, "entered error data type!!");
            }
        }
    }
}
