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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        void clearItems()
        {
           // bNoTextBox.Clear();
           // edDateDateTimePicker.Text = "01/12/2016 03:04 م";
            bNameTextBox.Clear();
            iSBNTextBox.Clear();
            edNoTextBox.Clear();
            paNumTextBox.Clear();
            coNumTextBox.Clear();
            bSizeTextBox.Clear();
            bStateTextBox.Clear();
            sNoComboBox.Text = "";
            aNoComboBox.Text = "";
            pubNoComboBox.Text = "";
        }
        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Auther' table. You can move, or remove it, as needed.
            this.autherTableAdapter.Fill(this.database1DataSet.Auther);
            // TODO: This line of code loads data into the 'database1DataSet.Publoshing_house' table. You can move, or remove it, as needed.
            this.publoshing_houseTableAdapter.Fill(this.database1DataSet.Publoshing_house);
            // TODO: This line of code loads data into the 'database1DataSet.BookSort' table. You can move, or remove it, as needed.
            this.bookSortTableAdapter.Fill(this.database1DataSet.BookSort);
           
            // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database1DataSet.Book);
            //this.bookTableAdapter.UpdateQuery1State(bStateTextBox.Text, Convert.ToInt32(bNoTextBox.Text));
          

        }

        private void butAddBook_Click(object sender, EventArgs e)
        {
            if (butAddBook.Text == "Add")
            {
                clearItems();
                bNameTextBox.Focus();
                butAddBook.Text = "Save";
            }
            else
            {

                if (bNameTextBox.Text == "")
                {
                    errorProvider1.SetError(bNameTextBox, "enter the Book name!");
                    bNameTextBox.Focus();
                }
                else if (iSBNTextBox.Text == "")
                {
                    errorProvider1.SetError(iSBNTextBox, "enter the ISBN!");
                    iSBNTextBox.Focus();
                }
                else if (edNoTextBox.Text == "")
                {
                    errorProvider1.SetError(edNoTextBox, "enter the Edation number!");
                    edNoTextBox.Focus();
                }
                else if (edDateDateTimePicker.Text == "")
                {
                    errorProvider1.SetError(edDateDateTimePicker, "enter the Date!");
                    edDateDateTimePicker.Focus();
                }
                else if (paNumTextBox.Text == "")
                {
                    errorProvider1.SetError(paNumTextBox, "enter the page number!");
                    paNumTextBox.Focus();
                }
                else if (coNumTextBox.Text == "")
                {
                    errorProvider1.SetError(coNumTextBox, "enter the copy number!");
                    coNumTextBox.Focus();
                }
                else if (bSizeTextBox.Text == "")
                {
                    errorProvider1.SetError(bSizeTextBox, "enter the Book size!");
                    bSizeTextBox.Focus();
                }
                else if (bStateTextBox.Text == "")
                {
                    errorProvider1.SetError(bStateTextBox, "enter the Book State!");
                    bStateTextBox.Focus();
                }
                else if (sNoComboBox.Text == "")
                {
                    errorProvider1.SetError(sNoComboBox, "enter the Sort number!");
                    sNoComboBox.Focus();
                }
                else if (pubNoComboBox.Text == "")
                {
                    errorProvider1.SetError(pubNoComboBox, "enter the publoshing number!");
                    pubNoComboBox.Focus();
                }
                else if (aNoComboBox.Text == "")
                {
                    errorProvider1.SetError(aNoComboBox, "enter the Auther number!");
                    aNoComboBox.Focus();
                }
                else
                {
                    this.bookTableAdapter.InsertQuery(bNameTextBox.Text, iSBNTextBox.Text, Convert.ToInt32(edNoTextBox.Text), edDateDateTimePicker.Text, Convert.ToInt32(paNumTextBox.Text), Convert.ToInt32(coNumTextBox.Text), bSizeTextBox.Text, bStateTextBox.Text, Convert.ToInt32(sNoComboBox.Text), Convert.ToInt32(pubNoComboBox.Text), Convert.ToInt32(aNoComboBox.Text));
              
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                    butAddBook.Text = "Add";
                    errorProvider1.Clear();
                }
            }
        }

        private void butDeleteBook_Click(object sender, EventArgs e)
        {
            if (bNoTextBox.Text != "")
            {
                if (MessageBox.Show("متاكد انك تشتي تحذف هذا الكتاب ,,, مافيش صفاط ولا رح تقدر تتراجع ,,, اخر تحذير?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.bookTableAdapter.DeleteQuery(Convert.ToInt32(bNoTextBox.Text));
                   
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                }
            }
            
        }

        private void butEditBook_Click(object sender, EventArgs e)
        {
             if (butEditBook.Text == "Edit")
            {
               // clearItems();
                bNameTextBox.Focus();
                butEditBook.Text = "Save";
            }
            else
            {


                if (bNameTextBox.Text == "")
                {
                    errorProvider1.SetError(bNameTextBox, "enter the Book name!");
                    bNameTextBox.Focus();
                }
                else if (iSBNTextBox.Text == "")
                {
                    errorProvider1.SetError(iSBNTextBox, "enter the ISBN!");
                    iSBNTextBox.Focus();
                }
                else if (edNoTextBox.Text == "")
                {
                    errorProvider1.SetError(edNoTextBox, "enter the Edation number!");
                    edNoTextBox.Focus();
                }
                else if (edDateDateTimePicker.Text == "")
                {
                    errorProvider1.SetError(edDateDateTimePicker, "enter the Date!");
                    edDateDateTimePicker.Focus();
                }
                else if (paNumTextBox.Text == "")
                {
                    errorProvider1.SetError(paNumTextBox, "enter the page number!");
                    paNumTextBox.Focus();
                }
                else if (coNumTextBox.Text == "")
                {
                    errorProvider1.SetError(coNumTextBox, "enter the copy number!");
                    coNumTextBox.Focus();
                }
                else if (bSizeTextBox.Text == "")
                {
                    errorProvider1.SetError(bSizeTextBox, "enter the Book size!");
                    bSizeTextBox.Focus();
                }
                else if (bStateTextBox.Text == "")
                {
                    errorProvider1.SetError(bStateTextBox, "enter the Book State!");
                    bStateTextBox.Focus();
                }
                else if (sNoComboBox.Text == "")
                {
                    errorProvider1.SetError(sNoComboBox, "enter the Sort number!");
                    sNoComboBox.Focus();
                }
                else if (pubNoComboBox.Text == "")
                {
                    errorProvider1.SetError(pubNoComboBox, "enter the publoshing number!");
                    pubNoComboBox.Focus();
                }
                else if (aNoComboBox.Text == "")
                {
                    errorProvider1.SetError(aNoComboBox, "enter the Auther number!");
                    aNoComboBox.Focus();
                }
                else
                {
                    this.bookTableAdapter.UpdateQuery(bNameTextBox.Text, iSBNTextBox.Text, Convert.ToInt32(edNoTextBox.Text), edDateDateTimePicker.Text, Convert.ToInt32(paNumTextBox.Text), Convert.ToInt32(coNumTextBox.Text), bSizeTextBox.Text, bStateTextBox.Text, Convert.ToInt32(sNoComboBox.Text), Convert.ToInt32(pubNoComboBox.Text), Convert.ToInt32(aNoComboBox.Text),Convert.ToInt32(bNoTextBox.Text));
                  
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                    butEditBook.Text = "Edit";
                    errorProvider1.Clear();
                }
            }
        
        }

        private void butRefershBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Book().Show();
        }

        private void butSearchBook_Click(object sender, EventArgs e)
        { 
            try
            {
                if (searchTexbBook.Text == "")
                {
                    searchTexbBook.Focus();
                    searchCombBook.Text = "ID";
                }
                else if (searchCombBook.Text == "ID")
                {
                    this.bookTableAdapter.FillByID(this.database1DataSet.Book, Convert.ToInt32(bNoTextBox.Text));
                
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                }
                else if (searchCombBook.Text == "Name")
                {
                    this.bookTableAdapter.FillByName(this.database1DataSet.Book, "%" + bNameTextBox.Text + "%");
                  
                    // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
                    this.bookTableAdapter.Fill(this.database1DataSet.Book);
                }
                searchTexbBook.Clear();
                searchTexbBook.Focus();
                errorProvider1.Clear();
            }
            catch
            {
                errorProvider1.SetError(searchTexbBook, "entered error data type!!");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Publoshing_house obj = new Publoshing_house();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authers obj = new Authers();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

    }
}