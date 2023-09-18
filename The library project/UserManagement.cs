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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        void clearItems()
        {
            uNoTextBox.Clear();
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            uTypeComboBox.Text = "Normal";
            userImagePictureBox.Image = null;
        }
        //convert Image to Byte to save it in database
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void userBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.database1DataSet.User);

        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                butAddImagUser.Enabled = true;
                butDeleteImagUser.Enabled = true;
                if (butAddUser.Text == "Add")
                {
                    clearItems();
                    fNameTextBox.Focus();
                    butAddUser.Text = "Save";
                    
                }
                else
                {
                    if (fNameTextBox.Text == "")
                    {
                        errorProvider1.SetError(fNameTextBox, "enter the first name!");
                        fNameTextBox.Focus();
                    }
                    else if (usernameTextBox.Text == "" || usernameTextBox.Text.Length < 4)
                    {
                        errorProvider1.SetError(usernameTextBox, "enter the username and sure you dont enter smaller than three char!");
                        usernameTextBox.Focus();
                    }
                    else if (passwordTextBox.Text == "" || passwordTextBox.Text.Length < 4)
                    {
                        errorProvider1.SetError(passwordTextBox, "enter the username and sure you dont enter smaller than three char!");
                        passwordTextBox.Focus();
                    }
                    else
                    {
                        this.userTableAdapter.Insert(fNameTextBox.Text, lNameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, uTypeComboBox.Text, ImageToByte(userImagePictureBox.Image));
                        this.userTableAdapter.Fill(this.database1DataSet.User);

                        butAddUser.Text = "Add";
                        butAddImagUser.Enabled = false;
                        butDeleteImagUser.Enabled = false;
                        
                        errorProvider1.Clear();
                    }
                }
            }
            catch { }
        }

        private void butAddImagUser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Add an Image";
            openFileDialog1.InitialDirectory = @"C:\Users";
            openFileDialog1.FileName = "";

            openFileDialog1.Filter = "JPEG Images|*.jpg|All Files|*.*";
            string Chosen_File = "";
            Chosen_File = openFileDialog1.FileName;
            openFileDialog1.ShowDialog();
            Chosen_File = openFileDialog1.FileName;
            userImagePictureBox.Image = Image.FromFile(Chosen_File);
        }

        private void butDeleteImagUser_Click(object sender, EventArgs e)
        {
            userImagePictureBox.Image = null;
        }

        private void butDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (uNoTextBox.Text != "")
                {
                    if (MessageBox.Show("Do you want to delete this User?", "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        this.userTableAdapter.DeleteQuery(Convert.ToInt32(uNoTextBox.Text));
                        this.userTableAdapter.Fill(this.database1DataSet.User);
                    }
                }
            }
            catch { }
        }

        private void butEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (uNoTextBox.Text != null && uNoTextBox.Text !="")
                {
                    butAddImagUser.Enabled = true;
                    butDeleteImagUser.Enabled = true;
                    if (butEditUser.Text == "Edit")
                    {

                        fNameTextBox.Focus();
                        butEditUser.Text = "Save";
                    }
                    else
                    {
                        if (fNameTextBox.Text == "")
                        {
                            errorProvider1.SetError(fNameTextBox, "enter the first name!");
                            fNameTextBox.Focus();
                        }
                        else if (usernameTextBox.Text == "" || usernameTextBox.Text.Length < 4)
                        {
                            errorProvider1.SetError(usernameTextBox, "enter the username and sure you dont enter smaller than three char!");
                            usernameTextBox.Focus();
                        }
                        else if (passwordTextBox.Text == "" || passwordTextBox.Text.Length < 4)
                        {
                            errorProvider1.SetError(passwordTextBox, "enter the username and sure you dont enter smaller than three char!");
                            passwordTextBox.Focus();
                        }
                        else
                        {
                            if (MessageBox.Show("Do you want to save changes?", "Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                this.userTableAdapter.UpdateQuery(fNameTextBox.Text, lNameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, uTypeComboBox.Text, ImageToByte(userImagePictureBox.Image), Convert.ToInt32(uNoTextBox.Text));
                                this.userTableAdapter.Fill(this.database1DataSet.User);
                                butEditUser.Text = "Edit";
                                butAddImagUser.Enabled = false;
                                butDeleteImagUser.Enabled = false;
                                errorProvider1.Clear();
                            }
                            else
                            {
                                butEditUser.Text = "Edit";
                                butAddImagUser.Enabled = false;
                                butDeleteImagUser.Enabled = false;
                                errorProvider1.Clear();
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void butRefershUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement obj = new UserManagement();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void butSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTexbUser.Text == "")
                {
                    searchTexbUser.Focus();
                    searchCombUser.Text = "ID";
                }
                else if (searchCombUser.Text == "ID")
                {

                    this.userTableAdapter.FillByID(this.database1DataSet.User, Convert.ToInt32(searchTexbUser.Text));
                }
                else if (searchCombUser.Text == "Name")
                {
                    this.userTableAdapter.FillByName(this.database1DataSet.User, "%" + searchTexbUser.Text + "%");
                }
                else if (searchCombUser.Text == "Type")
                {
                    this.userTableAdapter.FillByType(this.database1DataSet.User, "%" + searchTexbUser.Text + "%");
                }
                searchTexbUser.Clear();
                searchTexbUser.Focus();
                errorProvider1.Clear();
            }
            catch { errorProvider1.SetError(searchTexbUser, "entered error data type!!");/*MessageBox.Show("error");*/ }
        }
    }
}
