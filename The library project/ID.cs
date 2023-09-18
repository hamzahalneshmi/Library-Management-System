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
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            idNoTextBox.Clear();
          //  issueDateDateTimePicker.Text = "01/12/2016 03:04 م";
            issuePlaceTextBox.Clear();
            borImagePictureBox.Image =null;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void iDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void ID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ID' table. You can move, or remove it, as needed.
            this.iDTableAdapter.Fill(this.database1DataSet.ID);

        }

        private void butSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbID.Text == "")
                {
                    searchTexbID.Focus();
                    searchCombID.Text = "ID";
                }
                else if (searchCombID.Text == "ID")
                {
                    this.iDTableAdapter.FillByidNo(this.database1DataSet.ID, Convert.ToInt32(searchTexbID.Text));
                }
                else if (searchCombID.Text == "Place")
                {
                    this.iDTableAdapter.FillByPlace(this.database1DataSet.ID, "%" + searchTexbID.Text + "%");
                }
                searchTexbID.Clear();
                searchTexbID.Focus();
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(searchTexbID, "entered error data type!!");
            }
        }

        private void butAddImagUser_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Add an Image";
                openFileDialog1.InitialDirectory = @"C:\Users";
                openFileDialog1.FileName = "";

                openFileDialog1.Filter = "JPEG Images|*.jpg|All Files|*.*";
                string Chosen_File = "";
                Chosen_File = openFileDialog1.FileName;
                openFileDialog1.ShowDialog();
                Chosen_File = openFileDialog1.FileName;
                borImagePictureBox.Image = Image.FromFile(Chosen_File);
            }
            catch
            {
                MessageBox.Show("Opraton canseled");
            }

        }

        private void butDeleteImagUser_Click(object sender, EventArgs e)
        {
            borImagePictureBox.Image = null;
        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                butAddImagID.Enabled = true;
                butDeleteImagID.Enabled = true;
                if (butAddID.Text == "Add")
                {
                    clearItems();
                    idNoTextBox.Text = "0";
                    idNoTextBox.Focus();
                    butAddID.Text = "Save";
                }
                else
                {
                    if (idNoTextBox.Text == "")
                    {
                        errorProvider1.SetError(idNoTextBox, "enter the first name!");
                        idNoTextBox.Focus();
                    }
                    else if (issuePlaceTextBox.Text == "")
                    {
                        errorProvider1.SetError(issuePlaceTextBox, "enter the issue place !");
                        issuePlaceTextBox.Focus();
                    }
                    else
                    {
                        this.iDTableAdapter.InsertQuery(Convert.ToInt32(idNoTextBox.Text), issueDateDateTimePicker.Text, issuePlaceTextBox.Text, ImageToByte(borImagePictureBox.Image));
                        this.iDTableAdapter.Fill(this.database1DataSet.ID);

                        butAddID.Text = "Add";
                        butAddImagID.Enabled = false;
                        butDeleteImagID.Enabled = false;
                        errorProvider1.Clear();
                    }
                }
            }
            catch{
              //  errorProvider1.SetError(idNoTextBox, "you enter an ID that wse entered");
            }
        }

        private void butDeleteUser_Click(object sender, EventArgs e)
        {
            
                if (idNoTextBox.Text != "")
                {
                    if (MessageBox.Show("Do you want to delete this ID?", "Delete ID", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        this.iDTableAdapter.DeleteQuery(Convert.ToInt32(idNoTextBox.Text));
                        this.iDTableAdapter.Fill(this.database1DataSet.ID);
                    }
                }
         }
        


        private void butEditUser_Click(object sender, EventArgs e)
        {
            butAddImagID.Enabled = true;
            butDeleteImagID.Enabled = true;
            if (butEditID.Text == "Edit")
            {

                idNoTextBox.Focus();
                butEditID.Text = "Save";
            }
            else
            {
                if (idNoTextBox.Text == "")
                {
                    errorProvider1.SetError(idNoTextBox, "enter the first name!");
                    idNoTextBox.Focus();
                }
                else if (issuePlaceTextBox.Text == "")
                {
                    errorProvider1.SetError(issuePlaceTextBox, "enter the issue place !");
                    issuePlaceTextBox.Focus();
                }
                else
                    {
                        if (MessageBox.Show("Do you want to save changes?", "Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            this.iDTableAdapter.UpdateQuery( issueDateDateTimePicker.Text, issuePlaceTextBox.Text, ImageToByte(borImagePictureBox.Image),Convert.ToInt32(idNoTextBox.Text));
                            this.iDTableAdapter.Fill(this.database1DataSet.ID);
                            butEditID.Text = "Edit";
                            butAddImagID.Enabled = false;
                            butDeleteImagID.Enabled = false;
                            errorProvider1.Clear();
                        }
                        else
                        {
                            butEditID.Text = "Edit";
                            butAddImagID.Enabled = false;
                            butDeleteImagID.Enabled = false;
                            errorProvider1.Clear();
                        }
                    }
                }
            }

        private void butRefershUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ID().Show();
        }
        }

    }
