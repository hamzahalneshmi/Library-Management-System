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
    public partial class Borrowing : Form
    {
        public Borrowing()
        {
            InitializeComponent();
        }
        public void clear()
        {
           // borrNoTextBox.Clear();
            brNoTextBox.Clear();
            bNoTextBox.Clear();
            bookstateComboBox.Text = "OFF";
            lateDayTextBox.Clear();
            costTextBox.Clear();


        }
        private int CalaculeDays()
        {
            try
            {
                DateTime ReturnDate = Convert.ToDateTime(realBackDateDateTimePicker.Text);
                DateTime DueDate = Convert.ToDateTime(backdateDateTimePicker.Text.Trim());
                return ReturnDate.Subtract(DueDate).Days;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }


        }

        private void borrowingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void borrowingBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Borrowing_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database1DataSet.Job' table. You can move, or remove it, as needed.
           // this.jobTableAdapter.Fill(this.database1DataSet.Job);
            // TODO: This line of code loads data into the 'database1DataSet.Borrower' table. You can move, or remove it, as needed.
           // this.borrowerTableAdapter.Fill(this.database1DataSet.Borrower);
            // TODO: This line of code loads data into the 'database1DataSet.Book' table. You can move, or remove it, as needed.
           // this.bookTableAdapter.Fill(this.database1DataSet.Book);
            // TODO: This line of code loads data into the 'database1DataSet.Borrowing' table. You can move, or remove it, as needed.
         //   this.borrowingTableAdapter.Fill(this.database1DataSet.Borrowing);
            this.borrowingTableAdapter.Fill(this.database1DataSet.Borrowing);
        }

        private void brNoTextBox_Leave(object sender, EventArgs e)
        {
            try
            {

                this.borrowerTableAdapter.FillByID(this.database1DataSet.Borrower, Convert.ToInt32(brNoTextBox.Text));
            }
            catch { }
        }

        private void bNoTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillByID(this.database1DataSet.Book, Convert.ToInt32(bNoTextBox.Text));
            }
            catch { }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Borrowing")
            {
                costTextBox.Visible = false;
                lateDayTextBox.Visible = false;
                realBackDateDateTimePicker.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            else
            {
                costTextBox.Visible = true;
                lateDayTextBox.Visible = true;
                realBackDateDateTimePicker.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
        }

         private void button1_Click(object sender, EventArgs e)
          {
              try
              {
                  if (bStateTextBox.Text == "OFF       ")
                  {
                      MessageBox.Show("The book is not existing now.");
                  }
                  else
                  {
                      brNoTextBox.Focus();
                      if (comboBox1.Text == "Borrowing")
                      {
                          if (butBorro.Text == "Borrowing")
                          {
                              clear();
                              realBackDateDateTimePicker.Visible = false;
                              lateDayTextBox.Visible = false;
                              costTextBox.Visible = false;
                              butBorro.Text = "Save";




                          }
                          else if (butBorro.Text == "Save")
                          {
                              this.borrowingTableAdapter.InsertQuery(Convert.ToInt32(brNoTextBox.Text), Convert.ToInt32(bNoTextBox.Text), Convert.ToDateTime(borrDateDateTimePicker.Text), Convert.ToDateTime(backdateDateTimePicker.Text), bookstateComboBox.Text);
                              this.bookTableAdapter.UpdateQuery1State(bookstateComboBox.Text, Convert.ToInt32(bNoTextBox.Text));
                              this.borrowingTableAdapter.Fill(this.database1DataSet.Borrowing);

                              butBorro.Text = "Borrowing";

                          }
                      }

                  }
              }
              catch { }
         
               } 
         
          

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void butNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrowing ob = new Borrowing();
            ob.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                brNoTextBox.Focus();
                if (comboBox1.Text == "Return")
                {
                    if (butReturn.Text == "Return")
                    {
                        realBackDateDateTimePicker.Visible = true;
                        lateDayTextBox.Visible = true;
                        costTextBox.Visible = true;
                        butReturn.Text = "Save";
                        clear();

                    }
                    else if (butReturn.Text == "Save")
                    {

                        this.borrowingTableAdapter.UpdateQueryReturn(bookstateComboBox.Text, Convert.ToDateTime(realBackDateDateTimePicker.Text), Convert.ToInt32(lateDayTextBox.Text), Convert.ToDecimal(costTextBox.Text), Convert.ToInt32(borrNoTextBox.Text));
                        this.bookTableAdapter.UpdateQuery1State(bookstateComboBox.Text, Convert.ToInt32(bNoTextBox.Text));
                        this.borrowingTableAdapter.Fill(this.database1DataSet.Borrowing);
                        butReturn.Text = "Return";
                    }




                }

            }
            catch { }

        }

        private void realBackDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            if (realBackDateDateTimePicker != null)
            {

                int LateDays = CalaculeDays();
                int cost = 0;
                if (LateDays >= 0)
                {
                    cost = LateDays * 2;
                }

                costTextBox.Text = cost.ToString();
                lateDayTextBox.Text = LateDays.ToString();

            }
            else
            {
                MessageBox.Show("Please Enter Return Date", "Calculate Demurrage");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Borrowing")
            {
                butBorro.Enabled = true;
                butReturn.Enabled = false;

            }
            else if (comboBox1.Text == "Return")
            {
                butReturn.Enabled = true;
                butBorro.Enabled = false;
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.borrowingTableAdapter.FillByIDBro(this.database1DataSet.Borrowing, Convert.ToInt32(textSearchbBro.Text));
            }
            catch { }
        }
    }
}
