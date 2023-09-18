namespace The_library_project
{
    partial class Book
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
            System.Windows.Forms.Label bNoLabel;
            System.Windows.Forms.Label bNameLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label edNoLabel;
            System.Windows.Forms.Label edDateLabel;
            System.Windows.Forms.Label paNumLabel;
            System.Windows.Forms.Label coNumLabel;
            System.Windows.Forms.Label bSizeLabel;
            System.Windows.Forms.Label bStateLabel;
            System.Windows.Forms.Label sNoLabel;
            System.Windows.Forms.Label pubNoLabel;
            System.Windows.Forms.Label aNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new The_library_project.Database1DataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.borrowingTableAdapter = new The_library_project.Database1DataSetTableAdapters.BorrowingTableAdapter();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butRefershBook = new System.Windows.Forms.Button();
            this.butEditBook = new System.Windows.Forms.Button();
            this.butDeleteBook = new System.Windows.Forms.Button();
            this.butAddBook = new System.Windows.Forms.Button();
            this.bNoTextBox = new System.Windows.Forms.TextBox();
            this.bNameTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.edNoTextBox = new System.Windows.Forms.TextBox();
            this.edDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paNumTextBox = new System.Windows.Forms.TextBox();
            this.coNumTextBox = new System.Windows.Forms.TextBox();
            this.bSizeTextBox = new System.Windows.Forms.TextBox();
            this.bStateTextBox = new System.Windows.Forms.TextBox();
            this.sNoComboBox = new System.Windows.Forms.ComboBox();
            this.bookSortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubNoComboBox = new System.Windows.Forms.ComboBox();
            this.publoshinghouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNoComboBox = new System.Windows.Forms.ComboBox();
            this.autherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bookSortTableAdapter = new The_library_project.Database1DataSetTableAdapters.BookSortTableAdapter();
            this.publoshing_houseTableAdapter = new The_library_project.Database1DataSetTableAdapters.Publoshing_houseTableAdapter();
            this.autherTableAdapter = new The_library_project.Database1DataSetTableAdapters.AutherTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCombBook = new System.Windows.Forms.ComboBox();
            this.searchTexbBook = new System.Windows.Forms.TextBox();
            this.butSearchBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            bNoLabel = new System.Windows.Forms.Label();
            bNameLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            edNoLabel = new System.Windows.Forms.Label();
            edDateLabel = new System.Windows.Forms.Label();
            paNumLabel = new System.Windows.Forms.Label();
            coNumLabel = new System.Windows.Forms.Label();
            bSizeLabel = new System.Windows.Forms.Label();
            bStateLabel = new System.Windows.Forms.Label();
            sNoLabel = new System.Windows.Forms.Label();
            pubNoLabel = new System.Windows.Forms.Label();
            aNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookSortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publoshinghouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bNoLabel
            // 
            bNoLabel.AutoSize = true;
            bNoLabel.Location = new System.Drawing.Point(11, 33);
            bNoLabel.Name = "bNoLabel";
            bNoLabel.Size = new System.Drawing.Size(44, 13);
            bNoLabel.TabIndex = 54;
            bNoLabel.Text = "Book ID";
            // 
            // bNameLabel
            // 
            bNameLabel.AutoSize = true;
            bNameLabel.Location = new System.Drawing.Point(11, 59);
            bNameLabel.Name = "bNameLabel";
            bNameLabel.Size = new System.Drawing.Size(53, 13);
            bNameLabel.TabIndex = 56;
            bNameLabel.Text = "Book Title";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(11, 85);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(34, 13);
            iSBNLabel.TabIndex = 58;
            iSBNLabel.Text = "ISBN:";
            // 
            // edNoLabel
            // 
            edNoLabel.AutoSize = true;
            edNoLabel.Location = new System.Drawing.Point(11, 111);
            edNoLabel.Name = "edNoLabel";
            edNoLabel.Size = new System.Drawing.Size(83, 13);
            edNoLabel.TabIndex = 60;
            edNoLabel.Text = "Edation Number";
            // 
            // edDateLabel
            // 
            edDateLabel.AutoSize = true;
            edDateLabel.Location = new System.Drawing.Point(11, 138);
            edDateLabel.Name = "edDateLabel";
            edDateLabel.Size = new System.Drawing.Size(69, 13);
            edDateLabel.TabIndex = 62;
            edDateLabel.Text = "Edation Date";
            // 
            // paNumLabel
            // 
            paNumLabel.AutoSize = true;
            paNumLabel.Location = new System.Drawing.Point(11, 163);
            paNumLabel.Name = "paNumLabel";
            paNumLabel.Size = new System.Drawing.Size(71, 13);
            paNumLabel.TabIndex = 64;
            paNumLabel.Text = "Page Number";
            // 
            // coNumLabel
            // 
            coNumLabel.AutoSize = true;
            coNumLabel.Location = new System.Drawing.Point(11, 189);
            coNumLabel.Name = "coNumLabel";
            coNumLabel.Size = new System.Drawing.Size(56, 13);
            coNumLabel.TabIndex = 66;
            coNumLabel.Text = "Copy Num";
            // 
            // bSizeLabel
            // 
            bSizeLabel.AutoSize = true;
            bSizeLabel.Location = new System.Drawing.Point(11, 215);
            bSizeLabel.Name = "bSizeLabel";
            bSizeLabel.Size = new System.Drawing.Size(52, 13);
            bSizeLabel.TabIndex = 68;
            bSizeLabel.Text = "Book Size";
            // 
            // bStateLabel
            // 
            bStateLabel.AutoSize = true;
            bStateLabel.Location = new System.Drawing.Point(11, 241);
            bStateLabel.Name = "bStateLabel";
            bStateLabel.Size = new System.Drawing.Size(59, 13);
            bStateLabel.TabIndex = 70;
            bStateLabel.Text = "Book State";
            // 
            // sNoLabel
            // 
            sNoLabel.AutoSize = true;
            sNoLabel.Location = new System.Drawing.Point(11, 267);
            sNoLabel.Name = "sNoLabel";
            sNoLabel.Size = new System.Drawing.Size(30, 13);
            sNoLabel.TabIndex = 72;
            sNoLabel.Text = "Sort ";
            // 
            // pubNoLabel
            // 
            pubNoLabel.AutoSize = true;
            pubNoLabel.Location = new System.Drawing.Point(-1, 294);
            pubNoLabel.Name = "pubNoLabel";
            pubNoLabel.Size = new System.Drawing.Size(74, 13);
            pubNoLabel.TabIndex = 74;
            pubNoLabel.Text = "PubloshHouse";
            // 
            // aNoLabel
            // 
            aNoLabel.AutoSize = true;
            aNoLabel.Location = new System.Drawing.Point(11, 321);
            aNoLabel.Name = "aNoLabel";
            aNoLabel.Size = new System.Drawing.Size(43, 13);
            aNoLabel.TabIndex = 76;
            aNoLabel.Text = "Auther ";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.database1DataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookSortTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.BorrowingTableAdapter = this.borrowingTableAdapter;
            this.tableAdapterManager.IDTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // borrowingTableAdapter
            // 
            this.borrowingTableAdapter.ClearBeforeFill = true;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataMember = "FK_Borrowing_ToBook";
            this.borrowingBindingSource.DataSource = this.bookBindingSource;
            // 
            // butRefershBook
            // 
            this.butRefershBook.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh;
            this.butRefershBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershBook.Location = new System.Drawing.Point(357, 348);
            this.butRefershBook.Name = "butRefershBook";
            this.butRefershBook.Size = new System.Drawing.Size(92, 50);
            this.butRefershBook.TabIndex = 14;
            this.butRefershBook.Text = "Refersh";
            this.butRefershBook.UseVisualStyleBackColor = true;
            this.butRefershBook.Click += new System.EventHandler(this.butRefershBook_Click);
            // 
            // butEditBook
            // 
            this.butEditBook.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil;
            this.butEditBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditBook.Location = new System.Drawing.Point(259, 348);
            this.butEditBook.Name = "butEditBook";
            this.butEditBook.Size = new System.Drawing.Size(92, 50);
            this.butEditBook.TabIndex = 13;
            this.butEditBook.Text = "Edit";
            this.butEditBook.UseVisualStyleBackColor = true;
            this.butEditBook.Click += new System.EventHandler(this.butEditBook_Click);
            // 
            // butDeleteBook
            // 
            this.butDeleteBook.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.butDeleteBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteBook.Location = new System.Drawing.Point(154, 348);
            this.butDeleteBook.Name = "butDeleteBook";
            this.butDeleteBook.Size = new System.Drawing.Size(99, 50);
            this.butDeleteBook.TabIndex = 12;
            this.butDeleteBook.Text = "Delete";
            this.butDeleteBook.UseVisualStyleBackColor = true;
            this.butDeleteBook.Click += new System.EventHandler(this.butDeleteBook_Click);
            // 
            // butAddBook
            // 
            this.butAddBook.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add;
            this.butAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddBook.Location = new System.Drawing.Point(52, 348);
            this.butAddBook.Name = "butAddBook";
            this.butAddBook.Size = new System.Drawing.Size(92, 50);
            this.butAddBook.TabIndex = 11;
            this.butAddBook.Text = "Add";
            this.butAddBook.UseVisualStyleBackColor = true;
            this.butAddBook.Click += new System.EventHandler(this.butAddBook_Click);
            // 
            // bNoTextBox
            // 
            this.bNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bNo", true));
            this.bNoTextBox.Enabled = false;
            this.bNoTextBox.Location = new System.Drawing.Point(100, 30);
            this.bNoTextBox.Name = "bNoTextBox";
            this.bNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.bNoTextBox.TabIndex = 55;
            // 
            // bNameTextBox
            // 
            this.bNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bName", true));
            this.bNameTextBox.Location = new System.Drawing.Point(100, 56);
            this.bNameTextBox.Name = "bNameTextBox";
            this.bNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.bNameTextBox.TabIndex = 0;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(100, 82);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(200, 20);
            this.iSBNTextBox.TabIndex = 1;
            // 
            // edNoTextBox
            // 
            this.edNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "edNo", true));
            this.edNoTextBox.Location = new System.Drawing.Point(100, 108);
            this.edNoTextBox.Name = "edNoTextBox";
            this.edNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.edNoTextBox.TabIndex = 2;
            // 
            // edDateDateTimePicker
            // 
            this.edDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "edDate", true));
            this.edDateDateTimePicker.Location = new System.Drawing.Point(100, 134);
            this.edDateDateTimePicker.Name = "edDateDateTimePicker";
            this.edDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.edDateDateTimePicker.TabIndex = 3;
            // 
            // paNumTextBox
            // 
            this.paNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "paNum", true));
            this.paNumTextBox.Location = new System.Drawing.Point(100, 160);
            this.paNumTextBox.Name = "paNumTextBox";
            this.paNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.paNumTextBox.TabIndex = 4;
            // 
            // coNumTextBox
            // 
            this.coNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "coNum", true));
            this.coNumTextBox.Location = new System.Drawing.Point(100, 186);
            this.coNumTextBox.Name = "coNumTextBox";
            this.coNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.coNumTextBox.TabIndex = 5;
            // 
            // bSizeTextBox
            // 
            this.bSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bSize", true));
            this.bSizeTextBox.Location = new System.Drawing.Point(100, 212);
            this.bSizeTextBox.Name = "bSizeTextBox";
            this.bSizeTextBox.Size = new System.Drawing.Size(200, 20);
            this.bSizeTextBox.TabIndex = 6;
            // 
            // bStateTextBox
            // 
            this.bStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "bState", true));
            this.bStateTextBox.Location = new System.Drawing.Point(100, 238);
            this.bStateTextBox.Name = "bStateTextBox";
            this.bStateTextBox.Size = new System.Drawing.Size(200, 20);
            this.bStateTextBox.TabIndex = 7;
            // 
            // sNoComboBox
            // 
            this.sNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "sNo", true));
            this.sNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookBindingSource, "sNo", true));
            this.sNoComboBox.DataSource = this.bookSortBindingSource;
            this.sNoComboBox.DisplayMember = "sNo";
            this.sNoComboBox.FormattingEnabled = true;
            this.sNoComboBox.Location = new System.Drawing.Point(100, 264);
            this.sNoComboBox.Name = "sNoComboBox";
            this.sNoComboBox.Size = new System.Drawing.Size(200, 21);
            this.sNoComboBox.TabIndex = 8;
            this.sNoComboBox.ValueMember = "sNo";
            // 
            // bookSortBindingSource
            // 
            this.bookSortBindingSource.DataMember = "BookSort";
            this.bookSortBindingSource.DataSource = this.database1DataSet;
            // 
            // pubNoComboBox
            // 
            this.pubNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "pubNo", true));
            this.pubNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookBindingSource, "pubNo", true));
            this.pubNoComboBox.DataSource = this.publoshinghouseBindingSource;
            this.pubNoComboBox.DisplayMember = "pubNo";
            this.pubNoComboBox.FormattingEnabled = true;
            this.pubNoComboBox.Location = new System.Drawing.Point(100, 291);
            this.pubNoComboBox.Name = "pubNoComboBox";
            this.pubNoComboBox.Size = new System.Drawing.Size(200, 21);
            this.pubNoComboBox.TabIndex = 9;
            this.pubNoComboBox.ValueMember = "pubNo";
            // 
            // publoshinghouseBindingSource
            // 
            this.publoshinghouseBindingSource.DataMember = "Publoshing_house";
            this.publoshinghouseBindingSource.DataSource = this.database1DataSet;
            // 
            // aNoComboBox
            // 
            this.aNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "aNo", true));
            this.aNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookBindingSource, "aNo", true));
            this.aNoComboBox.DataSource = this.autherBindingSource;
            this.aNoComboBox.DisplayMember = "aNo";
            this.aNoComboBox.FormattingEnabled = true;
            this.aNoComboBox.Location = new System.Drawing.Point(100, 318);
            this.aNoComboBox.Name = "aNoComboBox";
            this.aNoComboBox.Size = new System.Drawing.Size(200, 21);
            this.aNoComboBox.TabIndex = 10;
            this.aNoComboBox.ValueMember = "aNo";
            // 
            // autherBindingSource
            // 
            this.autherBindingSource.DataMember = "Auther";
            this.autherBindingSource.DataSource = this.database1DataSet;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(335, 29);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.Size = new System.Drawing.Size(488, 310);
            this.bookDataGridView.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Book Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "edNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Edation Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "edDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Edation Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "paNum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Page Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "coNum";
            this.dataGridViewTextBoxColumn7.HeaderText = "Copy Number";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bSize";
            this.dataGridViewTextBoxColumn8.HeaderText = "Book Size";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bState";
            this.dataGridViewTextBoxColumn9.HeaderText = "Book State";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "sNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Sort ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "pubNo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Publoshing House";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "aNo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Auther";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bookSortTableAdapter
            // 
            this.bookSortTableAdapter.ClearBeforeFill = true;
            // 
            // publoshing_houseTableAdapter
            // 
            this.publoshing_houseTableAdapter.ClearBeforeFill = true;
            // 
            // autherTableAdapter
            // 
            this.autherTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Search";
            // 
            // searchCombBook
            // 
            this.searchCombBook.FormattingEnabled = true;
            this.searchCombBook.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchCombBook.Location = new System.Drawing.Point(71, 3);
            this.searchCombBook.Name = "searchCombBook";
            this.searchCombBook.Size = new System.Drawing.Size(56, 21);
            this.searchCombBook.TabIndex = 48;
            // 
            // searchTexbBook
            // 
            this.searchTexbBook.Location = new System.Drawing.Point(142, 4);
            this.searchTexbBook.Name = "searchTexbBook";
            this.searchTexbBook.Size = new System.Drawing.Size(86, 20);
            this.searchTexbBook.TabIndex = 49;
            // 
            // butSearchBook
            // 
            this.butSearchBook.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search;
            this.butSearchBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchBook.Location = new System.Drawing.Point(250, -4);
            this.butSearchBook.Name = "butSearchBook";
            this.butSearchBook.Size = new System.Drawing.Size(50, 34);
            this.butSearchBook.TabIndex = 50;
            this.butSearchBook.UseVisualStyleBackColor = true;
            this.butSearchBook.Click += new System.EventHandler(this.butSearchBook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 79;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 80;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 400);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(bNoLabel);
            this.Controls.Add(this.bNoTextBox);
            this.Controls.Add(bNameLabel);
            this.Controls.Add(this.bNameTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(edNoLabel);
            this.Controls.Add(this.edNoTextBox);
            this.Controls.Add(edDateLabel);
            this.Controls.Add(this.edDateDateTimePicker);
            this.Controls.Add(paNumLabel);
            this.Controls.Add(this.paNumTextBox);
            this.Controls.Add(coNumLabel);
            this.Controls.Add(this.coNumTextBox);
            this.Controls.Add(bSizeLabel);
            this.Controls.Add(this.bSizeTextBox);
            this.Controls.Add(bStateLabel);
            this.Controls.Add(this.bStateTextBox);
            this.Controls.Add(sNoLabel);
            this.Controls.Add(this.sNoComboBox);
            this.Controls.Add(pubNoLabel);
            this.Controls.Add(this.pubNoComboBox);
            this.Controls.Add(aNoLabel);
            this.Controls.Add(this.aNoComboBox);
            this.Controls.Add(this.butRefershBook);
            this.Controls.Add(this.butEditBook);
            this.Controls.Add(this.butDeleteBook);
            this.Controls.Add(this.butAddBook);
            this.Controls.Add(this.butSearchBook);
            this.Controls.Add(this.searchTexbBook);
            this.Controls.Add(this.searchCombBook);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookSortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publoshinghouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private Database1DataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.BorrowingTableAdapter borrowingTableAdapter;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private System.Windows.Forms.Button butRefershBook;
        private System.Windows.Forms.Button butEditBook;
        private System.Windows.Forms.Button butDeleteBook;
        private System.Windows.Forms.Button butAddBook;
        private System.Windows.Forms.TextBox bNoTextBox;
        private System.Windows.Forms.TextBox bNameTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox edNoTextBox;
        private System.Windows.Forms.DateTimePicker edDateDateTimePicker;
        private System.Windows.Forms.TextBox paNumTextBox;
        private System.Windows.Forms.TextBox coNumTextBox;
        private System.Windows.Forms.TextBox bSizeTextBox;
        private System.Windows.Forms.TextBox bStateTextBox;
        private System.Windows.Forms.ComboBox sNoComboBox;
        private System.Windows.Forms.ComboBox pubNoComboBox;
        private System.Windows.Forms.ComboBox aNoComboBox;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bookSortBindingSource;
        private Database1DataSetTableAdapters.BookSortTableAdapter bookSortTableAdapter;
        private System.Windows.Forms.BindingSource publoshinghouseBindingSource;
        private Database1DataSetTableAdapters.Publoshing_houseTableAdapter publoshing_houseTableAdapter;
        private System.Windows.Forms.BindingSource autherBindingSource;
        private Database1DataSetTableAdapters.AutherTableAdapter autherTableAdapter;
        private System.Windows.Forms.Button butSearchBook;
        private System.Windows.Forms.TextBox searchTexbBook;
        private System.Windows.Forms.ComboBox searchCombBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}