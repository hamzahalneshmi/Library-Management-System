namespace The_library_project
{
    partial class EditCoustomer
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
            System.Windows.Forms.Label brNoLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label tellNo1Label;
            System.Windows.Forms.Label tellNo2Label;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label jobNoLabel;
            System.Windows.Forms.Label idNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCoustomer));
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.borrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowerTableAdapter = new The_library_project.Database1DataSetTableAdapters.BorrowerTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.brNoTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.tellNo1TextBox = new System.Windows.Forms.TextBox();
            this.tellNo2TextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.jobNoComboBox = new System.Windows.Forms.ComboBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idNoComboBox = new System.Windows.Forms.ComboBox();
            this.iDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowerDataGridView = new System.Windows.Forms.DataGridView();
            this.butRefershBor = new System.Windows.Forms.Button();
            this.butEditBor = new System.Windows.Forms.Button();
            this.butDeleteBor = new System.Windows.Forms.Button();
            this.butAddBor = new System.Windows.Forms.Button();
            this.butSearchBor = new System.Windows.Forms.Button();
            this.searchTexbBor = new System.Windows.Forms.TextBox();
            this.searchCombBor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.jobTableAdapter = new The_library_project.Database1DataSetTableAdapters.JobTableAdapter();
            this.iDTableAdapter = new The_library_project.Database1DataSetTableAdapters.IDTableAdapter();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            brNoLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            tellNo1Label = new System.Windows.Forms.Label();
            tellNo2Label = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            jobNoLabel = new System.Windows.Forms.Label();
            idNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // brNoLabel
            // 
            brNoLabel.AutoSize = true;
            brNoLabel.Location = new System.Drawing.Point(10, 42);
            brNoLabel.Name = "brNoLabel";
            brNoLabel.Size = new System.Drawing.Size(77, 13);
            brNoLabel.TabIndex = 1;
            brNoLabel.Text = "Customer Num";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(10, 68);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(58, 13);
            fNameLabel.TabIndex = 3;
            fNameLabel.Text = "First Name";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(10, 94);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(57, 13);
            lNameLabel.TabIndex = 5;
            lNameLabel.Text = "Last Name";
            // 
            // tellNo1Label
            // 
            tellNo1Label.AutoSize = true;
            tellNo1Label.Location = new System.Drawing.Point(10, 120);
            tellNo1Label.Name = "tellNo1Label";
            tellNo1Label.Size = new System.Drawing.Size(82, 13);
            tellNo1Label.TabIndex = 7;
            tellNo1Label.Text = "Tellphone num1";
            // 
            // tellNo2Label
            // 
            tellNo2Label.AutoSize = true;
            tellNo2Label.Location = new System.Drawing.Point(10, 146);
            tellNo2Label.Name = "tellNo2Label";
            tellNo2Label.Size = new System.Drawing.Size(82, 13);
            tellNo2Label.TabIndex = 9;
            tellNo2Label.Text = "TellPhone num2";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(10, 173);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(59, 13);
            birthDateLabel.TabIndex = 11;
            birthDateLabel.Text = "birth Date:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(10, 198);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(28, 13);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "city:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(10, 224);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(40, 13);
            streetLabel.TabIndex = 15;
            streetLabel.Text = "street:";
            // 
            // jobNoLabel
            // 
            jobNoLabel.AutoSize = true;
            jobNoLabel.Location = new System.Drawing.Point(10, 250);
            jobNoLabel.Name = "jobNoLabel";
            jobNoLabel.Size = new System.Drawing.Size(46, 13);
            jobNoLabel.TabIndex = 17;
            jobNoLabel.Text = "job Num";
            // 
            // idNoLabel
            // 
            idNoLabel.AutoSize = true;
            idNoLabel.Location = new System.Drawing.Point(10, 277);
            idNoLabel.Name = "idNoLabel";
            idNoLabel.Size = new System.Drawing.Size(39, 13);
            idNoLabel.TabIndex = 19;
            idNoLabel.Text = "id Num";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowerBindingSource
            // 
            this.borrowerBindingSource.DataMember = "Borrower";
            this.borrowerBindingSource.DataSource = this.database1DataSet;
            // 
            // borrowerTableAdapter
            // 
            this.borrowerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookSortTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = this.borrowerTableAdapter;
            this.tableAdapterManager.BorrowingTableAdapter = null;
            this.tableAdapterManager.IDTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // brNoTextBox
            // 
            this.brNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "brNo", true));
            this.brNoTextBox.Enabled = false;
            this.brNoTextBox.Location = new System.Drawing.Point(108, 39);
            this.brNoTextBox.Name = "brNoTextBox";
            this.brNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.brNoTextBox.TabIndex = 2;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "fName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(108, 65);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fNameTextBox.TabIndex = 4;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "lName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(108, 91);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lNameTextBox.TabIndex = 6;
            // 
            // tellNo1TextBox
            // 
            this.tellNo1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "tellNo1", true));
            this.tellNo1TextBox.Location = new System.Drawing.Point(108, 117);
            this.tellNo1TextBox.Name = "tellNo1TextBox";
            this.tellNo1TextBox.Size = new System.Drawing.Size(200, 20);
            this.tellNo1TextBox.TabIndex = 8;
            // 
            // tellNo2TextBox
            // 
            this.tellNo2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "tellNo2", true));
            this.tellNo2TextBox.Location = new System.Drawing.Point(108, 143);
            this.tellNo2TextBox.Name = "tellNo2TextBox";
            this.tellNo2TextBox.Size = new System.Drawing.Size(200, 20);
            this.tellNo2TextBox.TabIndex = 10;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.borrowerBindingSource, "birthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(108, 169);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(108, 195);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 14;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(108, 221);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(200, 20);
            this.streetTextBox.TabIndex = 16;
            // 
            // jobNoComboBox
            // 
            this.jobNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "jobNo", true));
            this.jobNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.borrowerBindingSource, "jobNo", true));
            this.jobNoComboBox.DataSource = this.jobBindingSource;
            this.jobNoComboBox.DisplayMember = "jobNo";
            this.jobNoComboBox.FormattingEnabled = true;
            this.jobNoComboBox.Location = new System.Drawing.Point(108, 247);
            this.jobNoComboBox.Name = "jobNoComboBox";
            this.jobNoComboBox.Size = new System.Drawing.Size(200, 21);
            this.jobNoComboBox.TabIndex = 18;
            this.jobNoComboBox.ValueMember = "jobNo";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.database1DataSet;
            // 
            // idNoComboBox
            // 
            this.idNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "idNo", true));
            this.idNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.borrowerBindingSource, "idNo", true));
            this.idNoComboBox.DataSource = this.iDBindingSource;
            this.idNoComboBox.DisplayMember = "idNo";
            this.idNoComboBox.FormattingEnabled = true;
            this.idNoComboBox.Location = new System.Drawing.Point(108, 274);
            this.idNoComboBox.Name = "idNoComboBox";
            this.idNoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idNoComboBox.TabIndex = 20;
            this.idNoComboBox.ValueMember = "idNo";
            // 
            // iDBindingSource
            // 
            this.iDBindingSource.DataMember = "ID";
            this.iDBindingSource.DataSource = this.database1DataSet;
            // 
            // borrowerDataGridView
            // 
            this.borrowerDataGridView.AutoGenerateColumns = false;
            this.borrowerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.borrowerDataGridView.DataSource = this.borrowerBindingSource;
            this.borrowerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borrowerDataGridView.Location = new System.Drawing.Point(0, 351);
            this.borrowerDataGridView.Name = "borrowerDataGridView";
            this.borrowerDataGridView.Size = new System.Drawing.Size(452, 220);
            this.borrowerDataGridView.TabIndex = 20;
            // 
            // butRefershBor
            // 
            this.butRefershBor.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh1;
            this.butRefershBor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershBor.Location = new System.Drawing.Point(337, 297);
            this.butRefershBor.Name = "butRefershBor";
            this.butRefershBor.Size = new System.Drawing.Size(88, 48);
            this.butRefershBor.TabIndex = 38;
            this.butRefershBor.Text = "Refersh";
            this.butRefershBor.UseVisualStyleBackColor = true;
            this.butRefershBor.Click += new System.EventHandler(this.butRefershBor_Click);
            // 
            // butEditBor
            // 
            this.butEditBor.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil;
            this.butEditBor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditBor.Location = new System.Drawing.Point(234, 297);
            this.butEditBor.Name = "butEditBor";
            this.butEditBor.Size = new System.Drawing.Size(88, 48);
            this.butEditBor.TabIndex = 37;
            this.butEditBor.Text = "Edit";
            this.butEditBor.UseVisualStyleBackColor = true;
            this.butEditBor.Click += new System.EventHandler(this.butEditBor_Click);
            // 
            // butDeleteBor
            // 
            this.butDeleteBor.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.butDeleteBor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteBor.Location = new System.Drawing.Point(129, 297);
            this.butDeleteBor.Name = "butDeleteBor";
            this.butDeleteBor.Size = new System.Drawing.Size(99, 48);
            this.butDeleteBor.TabIndex = 36;
            this.butDeleteBor.Text = "Delete";
            this.butDeleteBor.UseVisualStyleBackColor = true;
            this.butDeleteBor.Click += new System.EventHandler(this.butDeleteBor_Click);
            // 
            // butAddBor
            // 
            this.butAddBor.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add;
            this.butAddBor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddBor.Location = new System.Drawing.Point(27, 297);
            this.butAddBor.Name = "butAddBor";
            this.butAddBor.Size = new System.Drawing.Size(96, 48);
            this.butAddBor.TabIndex = 35;
            this.butAddBor.Text = "Add";
            this.butAddBor.UseVisualStyleBackColor = true;
            this.butAddBor.Click += new System.EventHandler(this.butAddBor_Click);
            // 
            // butSearchBor
            // 
            this.butSearchBor.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search;
            this.butSearchBor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchBor.Location = new System.Drawing.Point(324, 1);
            this.butSearchBor.Name = "butSearchBor";
            this.butSearchBor.Size = new System.Drawing.Size(50, 38);
            this.butSearchBor.TabIndex = 46;
            this.butSearchBor.UseVisualStyleBackColor = true;
            this.butSearchBor.Click += new System.EventHandler(this.butSearchBor_Click);
            // 
            // searchTexbBor
            // 
            this.searchTexbBor.Location = new System.Drawing.Point(213, 7);
            this.searchTexbBor.Name = "searchTexbBor";
            this.searchTexbBor.Size = new System.Drawing.Size(95, 20);
            this.searchTexbBor.TabIndex = 45;
            // 
            // searchCombBor
            // 
            this.searchCombBor.FormattingEnabled = true;
            this.searchCombBor.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchCombBor.Location = new System.Drawing.Point(110, 7);
            this.searchCombBor.Name = "searchCombBor";
            this.searchCombBor.Size = new System.Drawing.Size(97, 21);
            this.searchCombBor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // iDTableAdapter
            // 
            this.iDTableAdapter.ClearBeforeFill = true;
            // 
            // jobBindingSource1
            // 
            this.jobBindingSource1.DataMember = "Job";
            this.jobBindingSource1.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "brNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Borrower ID";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tellNo1";
            this.dataGridViewTextBoxColumn4.HeaderText = "tellNo1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tellNo2";
            this.dataGridViewTextBoxColumn5.HeaderText = "tellNo2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "birthDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Birth Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn7.HeaderText = "city";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "street";
            this.dataGridViewTextBoxColumn8.HeaderText = "street";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "jobNo";
            this.dataGridViewTextBoxColumn9.HeaderText = "job ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "idNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // EditCoustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 571);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butSearchBor);
            this.Controls.Add(this.searchTexbBor);
            this.Controls.Add(this.searchCombBor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRefershBor);
            this.Controls.Add(this.butEditBor);
            this.Controls.Add(this.butDeleteBor);
            this.Controls.Add(this.butAddBor);
            this.Controls.Add(this.borrowerDataGridView);
            this.Controls.Add(brNoLabel);
            this.Controls.Add(this.brNoTextBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(tellNo1Label);
            this.Controls.Add(this.tellNo1TextBox);
            this.Controls.Add(tellNo2Label);
            this.Controls.Add(this.tellNo2TextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(jobNoLabel);
            this.Controls.Add(this.jobNoComboBox);
            this.Controls.Add(idNoLabel);
            this.Controls.Add(this.idNoComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCoustomer";
            this.Text = "EditCoustomer";
            this.Load += new System.EventHandler(this.EditCoustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource borrowerBindingSource;
        private Database1DataSetTableAdapters.BorrowerTableAdapter borrowerTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox brNoTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox tellNo1TextBox;
        private System.Windows.Forms.TextBox tellNo2TextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.ComboBox jobNoComboBox;
        private System.Windows.Forms.ComboBox idNoComboBox;
        private System.Windows.Forms.DataGridView borrowerDataGridView;
        private System.Windows.Forms.Button butRefershBor;
        private System.Windows.Forms.Button butEditBor;
        private System.Windows.Forms.Button butDeleteBor;
        private System.Windows.Forms.Button butAddBor;
        private System.Windows.Forms.Button butSearchBor;
        private System.Windows.Forms.TextBox searchTexbBor;
        private System.Windows.Forms.ComboBox searchCombBor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private Database1DataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.BindingSource iDBindingSource;
        private Database1DataSetTableAdapters.IDTableAdapter iDTableAdapter;
        private System.Windows.Forms.BindingSource jobBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}