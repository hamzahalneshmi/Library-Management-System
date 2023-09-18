namespace The_library_project
{
    partial class Categories
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
            System.Windows.Forms.Label sNoLabel;
            System.Windows.Forms.Label sNameLabel;
            System.Windows.Forms.Label sDescriptionLabel;
            System.Windows.Forms.Label numRangeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.bookSortDataGridView = new System.Windows.Forms.DataGridView();
            this.bookSortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.sNoTextBox = new System.Windows.Forms.TextBox();
            this.sNameTextBox = new System.Windows.Forms.TextBox();
            this.sDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.numRangeTextBox = new System.Windows.Forms.TextBox();
            this.butSearchBookSort = new System.Windows.Forms.Button();
            this.butAddBookSort = new System.Windows.Forms.Button();
            this.searchTexbBookSort = new System.Windows.Forms.TextBox();
            this.searchCombBookSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butRefershBookSort = new System.Windows.Forms.Button();
            this.butEditBookSort = new System.Windows.Forms.Button();
            this.butDeleteBookSort = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bookSortTableAdapter = new The_library_project.Database1DataSetTableAdapters.BookSortTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sNoLabel = new System.Windows.Forms.Label();
            sNameLabel = new System.Windows.Forms.Label();
            sDescriptionLabel = new System.Windows.Forms.Label();
            numRangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookSortDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookSortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sNoLabel
            // 
            sNoLabel.AutoSize = true;
            sNoLabel.Location = new System.Drawing.Point(5, 57);
            sNoLabel.Name = "sNoLabel";
            sNoLabel.Size = new System.Drawing.Size(30, 13);
            sNoLabel.TabIndex = 1;
            sNoLabel.Text = "Sort ";
            // 
            // sNameLabel
            // 
            sNameLabel.AutoSize = true;
            sNameLabel.Location = new System.Drawing.Point(5, 83);
            sNameLabel.Name = "sNameLabel";
            sNameLabel.Size = new System.Drawing.Size(57, 13);
            sNameLabel.TabIndex = 3;
            sNameLabel.Text = "Sort Name";
            // 
            // sDescriptionLabel
            // 
            sDescriptionLabel.AutoSize = true;
            sDescriptionLabel.Location = new System.Drawing.Point(5, 109);
            sDescriptionLabel.Name = "sDescriptionLabel";
            sDescriptionLabel.Size = new System.Drawing.Size(78, 13);
            sDescriptionLabel.TabIndex = 5;
            sDescriptionLabel.Text = "Sort discription";
            // 
            // numRangeLabel
            // 
            numRangeLabel.AutoSize = true;
            numRangeLabel.Location = new System.Drawing.Point(5, 155);
            numRangeLabel.Name = "numRangeLabel";
            numRangeLabel.Size = new System.Drawing.Size(78, 13);
            numRangeLabel.TabIndex = 7;
            numRangeLabel.Text = "Number Range";
            // 
            // bookSortDataGridView
            // 
            this.bookSortDataGridView.AutoGenerateColumns = false;
            this.bookSortDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookSortDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bookSortDataGridView.DataSource = this.bookSortBindingSource;
            this.bookSortDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookSortDataGridView.Location = new System.Drawing.Point(0, 235);
            this.bookSortDataGridView.Name = "bookSortDataGridView";
            this.bookSortDataGridView.Size = new System.Drawing.Size(538, 220);
            this.bookSortDataGridView.TabIndex = 1;
            // 
            // bookSortBindingSource
            // 
            this.bookSortBindingSource.DataMember = "BookSort";
            this.bookSortBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sNoTextBox
            // 
            this.sNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookSortBindingSource, "sNo", true));
            this.sNoTextBox.Enabled = false;
            this.sNoTextBox.Location = new System.Drawing.Point(83, 54);
            this.sNoTextBox.Name = "sNoTextBox";
            this.sNoTextBox.Size = new System.Drawing.Size(242, 20);
            this.sNoTextBox.TabIndex = 1;
            // 
            // sNameTextBox
            // 
            this.sNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookSortBindingSource, "sName", true));
            this.sNameTextBox.Location = new System.Drawing.Point(83, 80);
            this.sNameTextBox.Name = "sNameTextBox";
            this.sNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.sNameTextBox.TabIndex = 2;
            // 
            // sDescriptionTextBox
            // 
            this.sDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookSortBindingSource, "sDescription", true));
            this.sDescriptionTextBox.Location = new System.Drawing.Point(83, 106);
            this.sDescriptionTextBox.Multiline = true;
            this.sDescriptionTextBox.Name = "sDescriptionTextBox";
            this.sDescriptionTextBox.Size = new System.Drawing.Size(242, 40);
            this.sDescriptionTextBox.TabIndex = 3;
            // 
            // numRangeTextBox
            // 
            this.numRangeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookSortBindingSource, "numRange", true));
            this.numRangeTextBox.Location = new System.Drawing.Point(83, 152);
            this.numRangeTextBox.Name = "numRangeTextBox";
            this.numRangeTextBox.Size = new System.Drawing.Size(242, 20);
            this.numRangeTextBox.TabIndex = 4;
            // 
            // butSearchBookSort
            // 
            this.butSearchBookSort.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search;
            this.butSearchBookSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchBookSort.Location = new System.Drawing.Point(331, 6);
            this.butSearchBookSort.Name = "butSearchBookSort";
            this.butSearchBookSort.Size = new System.Drawing.Size(55, 39);
            this.butSearchBookSort.TabIndex = 37;
            this.butSearchBookSort.UseVisualStyleBackColor = true;
            this.butSearchBookSort.Click += new System.EventHandler(this.butSearchBookSort_Click);
            // 
            // butAddBookSort
            // 
            this.butAddBookSort.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add;
            this.butAddBookSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddBookSort.Location = new System.Drawing.Point(47, 178);
            this.butAddBookSort.Name = "butAddBookSort";
            this.butAddBookSort.Size = new System.Drawing.Size(103, 47);
            this.butAddBookSort.TabIndex = 5;
            this.butAddBookSort.Text = "Add";
            this.butAddBookSort.UseVisualStyleBackColor = true;
            this.butAddBookSort.Click += new System.EventHandler(this.butAddBookSort_Click);
            // 
            // searchTexbBookSort
            // 
            this.searchTexbBookSort.Location = new System.Drawing.Point(210, 13);
            this.searchTexbBookSort.Name = "searchTexbBookSort";
            this.searchTexbBookSort.Size = new System.Drawing.Size(115, 20);
            this.searchTexbBookSort.TabIndex = 35;
            // 
            // searchCombBookSort
            // 
            this.searchCombBookSort.FormattingEnabled = true;
            this.searchCombBookSort.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchCombBookSort.Location = new System.Drawing.Point(84, 13);
            this.searchCombBookSort.Name = "searchCombBookSort";
            this.searchCombBookSort.Size = new System.Drawing.Size(120, 21);
            this.searchCombBookSort.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search";
            // 
            // butRefershBookSort
            // 
            this.butRefershBookSort.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh;
            this.butRefershBookSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershBookSort.Location = new System.Drawing.Point(363, 178);
            this.butRefershBookSort.Name = "butRefershBookSort";
            this.butRefershBookSort.Size = new System.Drawing.Size(103, 47);
            this.butRefershBookSort.TabIndex = 8;
            this.butRefershBookSort.Text = "Refersh";
            this.butRefershBookSort.UseVisualStyleBackColor = true;
            this.butRefershBookSort.Click += new System.EventHandler(this.butRefershBookSort_Click);
            // 
            // butEditBookSort
            // 
            this.butEditBookSort.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil;
            this.butEditBookSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditBookSort.Location = new System.Drawing.Point(256, 178);
            this.butEditBookSort.Name = "butEditBookSort";
            this.butEditBookSort.Size = new System.Drawing.Size(103, 47);
            this.butEditBookSort.TabIndex = 7;
            this.butEditBookSort.Text = "Edit";
            this.butEditBookSort.UseVisualStyleBackColor = true;
            this.butEditBookSort.Click += new System.EventHandler(this.butEditBookSort_Click);
            // 
            // butDeleteBookSort
            // 
            this.butDeleteBookSort.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.butDeleteBookSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteBookSort.Location = new System.Drawing.Point(151, 178);
            this.butDeleteBookSort.Name = "butDeleteBookSort";
            this.butDeleteBookSort.Size = new System.Drawing.Size(103, 47);
            this.butDeleteBookSort.TabIndex = 6;
            this.butDeleteBookSort.Text = "Delete";
            this.butDeleteBookSort.UseVisualStyleBackColor = true;
            this.butDeleteBookSort.Click += new System.EventHandler(this.butDeleteBookSort_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bookSortTableAdapter
            // 
            this.bookSortTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookSortTableAdapter = this.bookSortTableAdapter;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.BorrowingTableAdapter = null;
            this.tableAdapterManager.IDTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sort ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sort Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sort Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numRange";
            this.dataGridViewTextBoxColumn4.HeaderText = "number Range";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 455);
            this.Controls.Add(this.butSearchBookSort);
            this.Controls.Add(this.butAddBookSort);
            this.Controls.Add(this.searchTexbBookSort);
            this.Controls.Add(this.searchCombBookSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRefershBookSort);
            this.Controls.Add(this.butEditBookSort);
            this.Controls.Add(this.butDeleteBookSort);
            this.Controls.Add(sNoLabel);
            this.Controls.Add(this.sNoTextBox);
            this.Controls.Add(sNameLabel);
            this.Controls.Add(this.sNameTextBox);
            this.Controls.Add(sDescriptionLabel);
            this.Controls.Add(this.sDescriptionTextBox);
            this.Controls.Add(numRangeLabel);
            this.Controls.Add(this.numRangeTextBox);
            this.Controls.Add(this.bookSortDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookSortDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookSortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bookSortBindingSource;
        private Database1DataSetTableAdapters.BookSortTableAdapter bookSortTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookSortDataGridView;
        private System.Windows.Forms.TextBox sNoTextBox;
        private System.Windows.Forms.TextBox sNameTextBox;
        private System.Windows.Forms.TextBox sDescriptionTextBox;
        private System.Windows.Forms.TextBox numRangeTextBox;
        private System.Windows.Forms.Button butSearchBookSort;
        private System.Windows.Forms.Button butAddBookSort;
        private System.Windows.Forms.TextBox searchTexbBookSort;
        private System.Windows.Forms.ComboBox searchCombBookSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRefershBookSort;
        private System.Windows.Forms.Button butEditBookSort;
        private System.Windows.Forms.Button butDeleteBookSort;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}