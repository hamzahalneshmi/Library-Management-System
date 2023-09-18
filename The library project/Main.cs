using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace The_library_project
{
    public partial class Main : Form
    {
        private static Main frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Main getMainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new Main();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);

                }
                return frm;
            }
        }
        public Main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 obj = new AboutBox1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process yourProcess = new Process();
            yourProcess.StartInfo.FileName = @"C:\Windows\System32\calc.exe";

            yourProcess.Start();
          
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process yourProcess = new Process();
            yourProcess.StartInfo.FileName = @"C:\Windows\System32\notepad.exe";

            yourProcess.Start();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCoustomer obj = new EditCoustomer();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCoustomer obj = new EditCoustomer();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void editJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Job obj = new Job();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void editIDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID obj = new ID();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Book.ActiveForm.Equals(1))
            {

            }
            else
            {
                Book obj = new Book();
                obj.MdiParent = Main.ActiveForm;
                obj.Show();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement obj = new UserManagement();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publoshing_house obj = new Publoshing_house();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authers obj = new Authers();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void borrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrowing obj = new Borrowing();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void changBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
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
                BackgroundImage= Image.FromFile(Chosen_File);
            }
            catch
            {
                MessageBox.Show("Opraton canseled");
            }
        }

        private void editColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reselt = colorDialog1.ShowDialog();
            if (reselt == DialogResult.OK)
            {
              this.BackColor= colorDialog1.Color;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help obj = new Help();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void borrowingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Borrowing obj = new Borrowing();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.MdiParent = Main.ActiveForm;
            obj.Show();
        }
    }
}
