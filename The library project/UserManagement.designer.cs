namespace The_library_project
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label uNoLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label uTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.uNoTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.uTypeComboBox = new System.Windows.Forms.ComboBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.butDeleteUser = new System.Windows.Forms.Button();
            this.butAddImagUser = new System.Windows.Forms.Button();
            this.butEditUser = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.butDeleteImagUser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butRefershUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCombUser = new System.Windows.Forms.ComboBox();
            this.searchTexbUser = new System.Windows.Forms.TextBox();
            this.userTableAdapter = new The_library_project.Database1DataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.butSearchUser = new System.Windows.Forms.Button();
            this.butAddUser = new System.Windows.Forms.Button();
            this.userImagePictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uNoLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            uTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uNoLabel
            // 
            uNoLabel.AutoSize = true;
            uNoLabel.Location = new System.Drawing.Point(9, 52);
            uNoLabel.Name = "uNoLabel";
            uNoLabel.Size = new System.Drawing.Size(43, 13);
            uNoLabel.TabIndex = 1;
            uNoLabel.Text = "User ID";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(9, 78);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(58, 13);
            fNameLabel.TabIndex = 3;
            fNameLabel.Text = "First Name";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(9, 104);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(57, 13);
            lNameLabel.TabIndex = 5;
            lNameLabel.Text = "Last Name";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(9, 130);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(59, 13);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(9, 156);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(53, 13);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // uTypeLabel
            // 
            uTypeLabel.AutoSize = true;
            uTypeLabel.Location = new System.Drawing.Point(9, 182);
            uTypeLabel.Name = "uTypeLabel";
            uTypeLabel.Size = new System.Drawing.Size(56, 13);
            uTypeLabel.TabIndex = 11;
            uTypeLabel.Text = "User Type";
            // 
            // uNoTextBox
            // 
            this.uNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "uNo", true));
            this.uNoTextBox.Enabled = false;
            this.uNoTextBox.Location = new System.Drawing.Point(80, 49);
            this.uNoTextBox.Name = "uNoTextBox";
            this.uNoTextBox.Size = new System.Drawing.Size(252, 20);
            this.uNoTextBox.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "fName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(80, 75);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.fNameTextBox.TabIndex = 4;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(80, 101);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.lNameTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(80, 127);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(252, 20);
            this.usernameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(80, 153);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(252, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // uTypeComboBox
            // 
            this.uTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "uType", true));
            this.uTypeComboBox.FormattingEnabled = true;
            this.uTypeComboBox.Items.AddRange(new object[] {
            "Manager",
            "Normal"});
            this.uTypeComboBox.Location = new System.Drawing.Point(80, 179);
            this.uTypeComboBox.Name = "uTypeComboBox";
            this.uTypeComboBox.Size = new System.Drawing.Size(120, 21);
            this.uTypeComboBox.TabIndex = 12;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userDataGridView.Location = new System.Drawing.Point(0, 309);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(535, 220);
            this.userDataGridView.TabIndex = 14;
            // 
            // butDeleteUser
            // 
            this.butDeleteUser.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons1;
            this.butDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteUser.Location = new System.Drawing.Point(130, 235);
            this.butDeleteUser.Name = "butDeleteUser";
            this.butDeleteUser.Size = new System.Drawing.Size(99, 58);
            this.butDeleteUser.TabIndex = 16;
            this.butDeleteUser.Text = "Delete";
            this.butDeleteUser.UseVisualStyleBackColor = true;
            this.butDeleteUser.Click += new System.EventHandler(this.butDeleteUser_Click);
            // 
            // butAddImagUser
            // 
            this.butAddImagUser.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_Picture_add;
            this.butAddImagUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddImagUser.Enabled = false;
            this.butAddImagUser.Location = new System.Drawing.Point(398, 162);
            this.butAddImagUser.Name = "butAddImagUser";
            this.butAddImagUser.Size = new System.Drawing.Size(45, 46);
            this.butAddImagUser.TabIndex = 17;
            this.butAddImagUser.UseVisualStyleBackColor = true;
            this.butAddImagUser.Click += new System.EventHandler(this.butAddImagUser_Click);
            // 
            // butEditUser
            // 
            this.butEditUser.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil1;
            this.butEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditUser.Location = new System.Drawing.Point(235, 235);
            this.butEditUser.Name = "butEditUser";
            this.butEditUser.Size = new System.Drawing.Size(97, 58);
            this.butEditUser.TabIndex = 18;
            this.butEditUser.Text = "Edit";
            this.butEditUser.UseVisualStyleBackColor = true;
            this.butEditUser.Click += new System.EventHandler(this.butEditUser_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // butDeleteImagUser
            // 
            this.butDeleteImagUser.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_Picture_delete;
            this.butDeleteImagUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteImagUser.Enabled = false;
            this.butDeleteImagUser.Location = new System.Drawing.Point(462, 162);
            this.butDeleteImagUser.Name = "butDeleteImagUser";
            this.butDeleteImagUser.Size = new System.Drawing.Size(46, 46);
            this.butDeleteImagUser.TabIndex = 19;
            this.butDeleteImagUser.UseVisualStyleBackColor = true;
            this.butDeleteImagUser.Click += new System.EventHandler(this.butDeleteImagUser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // butRefershUser
            // 
            this.butRefershUser.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh2;
            this.butRefershUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershUser.Location = new System.Drawing.Point(338, 235);
            this.butRefershUser.Name = "butRefershUser";
            this.butRefershUser.Size = new System.Drawing.Size(98, 58);
            this.butRefershUser.TabIndex = 20;
            this.butRefershUser.Text = "Refersh";
            this.butRefershUser.UseVisualStyleBackColor = true;
            this.butRefershUser.Click += new System.EventHandler(this.butRefershUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search";
            // 
            // searchCombUser
            // 
            this.searchCombUser.FormattingEnabled = true;
            this.searchCombUser.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Type"});
            this.searchCombUser.Location = new System.Drawing.Point(80, 15);
            this.searchCombUser.Name = "searchCombUser";
            this.searchCombUser.Size = new System.Drawing.Size(121, 21);
            this.searchCombUser.TabIndex = 22;
            // 
            // searchTexbUser
            // 
            this.searchTexbUser.Location = new System.Drawing.Point(206, 15);
            this.searchTexbUser.Name = "searchTexbUser";
            this.searchTexbUser.Size = new System.Drawing.Size(126, 20);
            this.searchTexbUser.TabIndex = 23;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookSortTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.BorrowingTableAdapter = null;
            this.tableAdapterManager.IDTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // butSearchUser
            // 
            this.butSearchUser.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search3;
            this.butSearchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchUser.Location = new System.Drawing.Point(338, 11);
            this.butSearchUser.Name = "butSearchUser";
            this.butSearchUser.Size = new System.Drawing.Size(54, 37);
            this.butSearchUser.TabIndex = 24;
            this.butSearchUser.UseVisualStyleBackColor = true;
            this.butSearchUser.Click += new System.EventHandler(this.butSearchUser_Click);
            // 
            // butAddUser
            // 
            this.butAddUser.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add6;
            this.butAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddUser.Location = new System.Drawing.Point(28, 235);
            this.butAddUser.Name = "butAddUser";
            this.butAddUser.Size = new System.Drawing.Size(96, 58);
            this.butAddUser.TabIndex = 15;
            this.butAddUser.Text = "Add";
            this.butAddUser.UseVisualStyleBackColor = true;
            this.butAddUser.Click += new System.EventHandler(this.butAddUser_Click);
            // 
            // userImagePictureBox
            // 
            this.userImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "userImage", true));
            this.userImagePictureBox.Location = new System.Drawing.Point(398, 19);
            this.userImagePictureBox.Name = "userImagePictureBox";
            this.userImagePictureBox.Size = new System.Drawing.Size(121, 137);
            this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImagePictureBox.TabIndex = 14;
            this.userImagePictureBox.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "User ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn4.HeaderText = "username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn5.HeaderText = "password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uType";
            this.dataGridViewTextBoxColumn6.HeaderText = "User Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 529);
            this.Controls.Add(this.butSearchUser);
            this.Controls.Add(this.searchTexbUser);
            this.Controls.Add(this.searchCombUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRefershUser);
            this.Controls.Add(this.butDeleteImagUser);
            this.Controls.Add(this.butEditUser);
            this.Controls.Add(this.butAddImagUser);
            this.Controls.Add(this.butDeleteUser);
            this.Controls.Add(this.butAddUser);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(uNoLabel);
            this.Controls.Add(this.uNoTextBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(uTypeLabel);
            this.Controls.Add(this.uTypeComboBox);
            this.Controls.Add(this.userImagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Database1DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uNoTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox uTypeComboBox;
        private System.Windows.Forms.PictureBox userImagePictureBox;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button butAddUser;
        private System.Windows.Forms.Button butDeleteUser;
        private System.Windows.Forms.Button butAddImagUser;
        private System.Windows.Forms.Button butEditUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button butDeleteImagUser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button butRefershUser;
        private System.Windows.Forms.Button butSearchUser;
        private System.Windows.Forms.TextBox searchTexbUser;
        private System.Windows.Forms.ComboBox searchCombUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    }
}