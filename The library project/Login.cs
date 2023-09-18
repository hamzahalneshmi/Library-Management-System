using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_library_project
{
    public partial class Login : Form
    {
         SqlConnection cn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
        
        //SqlDataAdapter da;
      // DataTable dt = new DataTable();
       
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
           
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                string qry = "SELECT count(*) from \"User\" where  username = '" + uName.Text + "' and  password = '" + uPassword.Text + "' ";
                SqlCommand comnd = new SqlCommand(qry, cn);

                int result = Convert.ToInt32(comnd.ExecuteScalar());
                if (result > 0 || (uPassword.Text==Properties.Settings.Default.password && uName.Text==Properties.Settings.Default.Name))
                {

                    if (comboBox1.Text == "Manager")
                    {
                        this.Hide();
                        new Main().Show();
                    }
                    else if (comboBox1.Text == "Normal")
                    {
                        this.Hide();
                        new Main().Show();
                        Main.getMainform.openToolStripMenuItem.Enabled = false;
                        Main.getMainform.printToolStripMenuItem.Enabled = false;
                        Main.getMainform.cutToolStripMenuItem.Enabled = false;

                    }
                    
                }
                else
                { MessageBox.Show("Invalid username or password");
                //uName.Clear();
                uPassword.Clear();
                }

                if (cn.State == ConnectionState.Open)
                    cn.Close();
                
                }

            catch (Exception ex) { MessageBox.Show(ex.Message);
            
            }

  
  
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
