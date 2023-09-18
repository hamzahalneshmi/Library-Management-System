namespace The_library_project
{
    partial class Authers
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
            System.Windows.Forms.Label aNoLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authers));
            this.autherDataGridView = new System.Windows.Forms.DataGridView();
            this.autherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.aNoTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.searchTexbAuther = new System.Windows.Forms.TextBox();
            this.searchCombAuther = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.autherTableAdapter = new The_library_project.Database1DataSetTableAdapters.AutherTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.butSearchAuther = new System.Windows.Forms.Button();
            this.butAddAuther = new System.Windows.Forms.Button();
            this.butRefershAuther = new System.Windows.Forms.Button();
            this.butEditAuther = new System.Windows.Forms.Button();
            this.butDeleteAuther = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aNoLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // aNoLabel
            // 
            aNoLabel.AutoSize = true;
            aNoLabel.Location = new System.Drawing.Point(6, 48);
            aNoLabel.Name = "aNoLabel";
            aNoLabel.Size = new System.Drawing.Size(64, 13);
            aNoLabel.TabIndex = 2;
            aNoLabel.Text = "Auther Num";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(6, 74);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(58, 13);
            fNameLabel.TabIndex = 4;
            fNameLabel.Text = "First Name";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(6, 100);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(57, 13);
            lNameLabel.TabIndex = 6;
            lNameLabel.Text = "Last Name";
            // 
            // autherDataGridView
            // 
            this.autherDataGridView.AutoGenerateColumns = false;
            this.autherDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.autherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.autherDataGridView.DataSource = this.autherBindingSource;
            this.autherDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.autherDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.autherDataGridView.Location = new System.Drawing.Point(0, 174);
            this.autherDataGridView.Name = "autherDataGridView";
            this.autherDataGridView.Size = new System.Drawing.Size(462, 220);
            this.autherDataGridView.TabIndex = 1;
            // 
            // autherBindingSource
            // 
            this.autherBindingSource.DataMember = "Auther";
            this.autherBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNoTextBox
            // 
            this.aNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autherBindingSource, "aNo", true));
            this.aNoTextBox.Enabled = false;
            this.aNoTextBox.Location = new System.Drawing.Point(76, 45);
            this.aNoTextBox.Name = "aNoTextBox";
            this.aNoTextBox.Size = new System.Drawing.Size(242, 20);
            this.aNoTextBox.TabIndex = 3;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autherBindingSource, "fName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(76, 71);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.fNameTextBox.TabIndex = 5;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autherBindingSource, "lName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(76, 97);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.lNameTextBox.TabIndex = 7;
            // 
            // searchTexbAuther
            // 
            this.searchTexbAuther.Location = new System.Drawing.Point(202, 13);
            this.searchTexbAuther.Name = "searchTexbAuther";
            this.searchTexbAuther.Size = new System.Drawing.Size(116, 20);
            this.searchTexbAuther.TabIndex = 27;
            // 
            // searchCombAuther
            // 
            this.searchCombAuther.FormattingEnabled = true;
            this.searchCombAuther.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchCombAuther.Location = new System.Drawing.Point(76, 12);
            this.searchCombAuther.Name = "searchCombAuther";
            this.searchCombAuther.Size = new System.Drawing.Size(120, 21);
            this.searchCombAuther.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // autherTableAdapter
            // 
            this.autherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutherTableAdapter = this.autherTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookSortTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.BorrowingTableAdapter = null;
            this.tableAdapterManager.IDTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // butSearchAuther
            // 
            this.butSearchAuther.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search;
            this.butSearchAuther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchAuther.Location = new System.Drawing.Point(324, 4);
            this.butSearchAuther.Name = "butSearchAuther";
            this.butSearchAuther.Size = new System.Drawing.Size(45, 37);
            this.butSearchAuther.TabIndex = 29;
            this.butSearchAuther.UseVisualStyleBackColor = true;
            this.butSearchAuther.Click += new System.EventHandler(this.butSearchAuther_Click);
            // 
            // butAddAuther
            // 
            this.butAddAuther.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add;
            this.butAddAuther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddAuther.Location = new System.Drawing.Point(41, 123);
            this.butAddAuther.Name = "butAddAuther";
            this.butAddAuther.Size = new System.Drawing.Size(84, 42);
            this.butAddAuther.TabIndex = 28;
            this.butAddAuther.Text = "Add";
            this.butAddAuther.UseVisualStyleBackColor = true;
            this.butAddAuther.Click += new System.EventHandler(this.butAddAuther_Click);
            // 
            // butRefershAuther
            // 
            this.butRefershAuther.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh1;
            this.butRefershAuther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershAuther.Location = new System.Drawing.Point(335, 123);
            this.butRefershAuther.Name = "butRefershAuther";
            this.butRefershAuther.Size = new System.Drawing.Size(96, 42);
            this.butRefershAuther.TabIndex = 24;
            this.butRefershAuther.Text = "Refersh";
            this.butRefershAuther.UseVisualStyleBackColor = true;
            this.butRefershAuther.Click += new System.EventHandler(this.butRefershAuther_Click);
            // 
            // butEditAuther
            // 
            this.butEditAuther.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil;
            this.butEditAuther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditAuther.Location = new System.Drawing.Point(245, 123);
            this.butEditAuther.Name = "butEditAuther";
            this.butEditAuther.Size = new System.Drawing.Size(84, 42);
            this.butEditAuther.TabIndex = 23;
            this.butEditAuther.Text = "Edit";
            this.butEditAuther.UseVisualStyleBackColor = true;
            this.butEditAuther.Click += new System.EventHandler(this.butEditAuther_Click);
            // 
            // butDeleteAuther
            // 
            this.butDeleteAuther.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.butDeleteAuther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteAuther.Location = new System.Drawing.Point(131, 123);
            this.butDeleteAuther.Name = "butDeleteAuther";
            this.butDeleteAuther.Size = new System.Drawing.Size(108, 42);
            this.butDeleteAuther.TabIndex = 22;
            this.butDeleteAuther.Text = "Delete";
            this.butDeleteAuther.UseVisualStyleBackColor = true;
            this.butDeleteAuther.Click += new System.EventHandler(this.butDeleteAuther_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "aNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Authers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 394);
            this.Controls.Add(this.butSearchAuther);
            this.Controls.Add(this.butAddAuther);
            this.Controls.Add(this.searchTexbAuther);
            this.Controls.Add(this.searchCombAuther);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRefershAuther);
            this.Controls.Add(this.butEditAuther);
            this.Controls.Add(this.butDeleteAuther);
            this.Controls.Add(aNoLabel);
            this.Controls.Add(this.aNoTextBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.autherDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authers";
            this.Text = "Authers";
            this.Load += new System.EventHandler(this.Authers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource autherBindingSource;
        private Database1DataSetTableAdapters.AutherTableAdapter autherTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView autherDataGridView;
        private System.Windows.Forms.TextBox aNoTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Button butRefershAuther;
        private System.Windows.Forms.Button butEditAuther;
        private System.Windows.Forms.Button butDeleteAuther;
        private System.Windows.Forms.TextBox searchTexbAuther;
        private System.Windows.Forms.ComboBox searchCombAuther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSearchAuther;
        private System.Windows.Forms.Button butAddAuther;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}