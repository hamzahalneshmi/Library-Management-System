namespace The_library_project
{
    partial class Job
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
            System.Windows.Forms.Label jobNoLabel;
            System.Windows.Forms.Label jobNameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job));
            this.jobNoTextBox = new System.Windows.Forms.TextBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.jobDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.jobTableAdapter = new The_library_project.Database1DataSetTableAdapters.JobTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.searchTexbJob = new System.Windows.Forms.TextBox();
            this.searchCombJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butSearchJob = new System.Windows.Forms.Button();
            this.butRefershJob = new System.Windows.Forms.Button();
            this.butEditJob = new System.Windows.Forms.Button();
            this.butDeleteJob = new System.Windows.Forms.Button();
            this.butAddJob = new System.Windows.Forms.Button();
            jobNoLabel = new System.Windows.Forms.Label();
            jobNameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // jobNoLabel
            // 
            jobNoLabel.AutoSize = true;
            jobNoLabel.Location = new System.Drawing.Point(24, 39);
            jobNoLabel.Name = "jobNoLabel";
            jobNoLabel.Size = new System.Drawing.Size(46, 13);
            jobNoLabel.TabIndex = 1;
            jobNoLabel.Text = "job Num";
            // 
            // jobNameLabel
            // 
            jobNameLabel.AutoSize = true;
            jobNameLabel.Location = new System.Drawing.Point(24, 65);
            jobNameLabel.Name = "jobNameLabel";
            jobNameLabel.Size = new System.Drawing.Size(56, 13);
            jobNameLabel.TabIndex = 3;
            jobNameLabel.Text = "job Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(24, 91);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(28, 13);
            cityLabel.TabIndex = 5;
            cityLabel.Text = "city:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(24, 117);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(40, 13);
            streetLabel.TabIndex = 7;
            streetLabel.Text = "street:";
            // 
            // jobNoTextBox
            // 
            this.jobNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "jobNo", true));
            this.jobNoTextBox.Enabled = false;
            this.jobNoTextBox.Location = new System.Drawing.Point(86, 36);
            this.jobNoTextBox.Name = "jobNoTextBox";
            this.jobNoTextBox.Size = new System.Drawing.Size(134, 20);
            this.jobNoTextBox.TabIndex = 2;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "jobName", true));
            this.jobNameTextBox.Location = new System.Drawing.Point(86, 62);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.jobNameTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(86, 88);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(134, 20);
            this.cityTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(86, 114);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(134, 20);
            this.streetTextBox.TabIndex = 8;
            // 
            // jobDataGridView
            // 
            this.jobDataGridView.AutoGenerateColumns = false;
            this.jobDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.jobDataGridView.DataSource = this.jobBindingSource;
            this.jobDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jobDataGridView.Location = new System.Drawing.Point(0, 204);
            this.jobDataGridView.Name = "jobDataGridView";
            this.jobDataGridView.Size = new System.Drawing.Size(406, 220);
            this.jobDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "jobNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "jobNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "jobName";
            this.dataGridViewTextBoxColumn2.HeaderText = "jobName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn3.HeaderText = "city";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "street";
            this.dataGridViewTextBoxColumn4.HeaderText = "street";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.JobTableAdapter = this.jobTableAdapter;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // searchTexbJob
            // 
            this.searchTexbJob.Location = new System.Drawing.Point(148, 8);
            this.searchTexbJob.Name = "searchTexbJob";
            this.searchTexbJob.Size = new System.Drawing.Size(72, 20);
            this.searchTexbJob.TabIndex = 41;
            // 
            // searchCombJob
            // 
            this.searchCombJob.FormattingEnabled = true;
            this.searchCombJob.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.searchCombJob.Location = new System.Drawing.Point(86, 7);
            this.searchCombJob.Name = "searchCombJob";
            this.searchCombJob.Size = new System.Drawing.Size(56, 21);
            this.searchCombJob.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Search";
            // 
            // butSearchJob
            // 
            this.butSearchJob.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search1;
            this.butSearchJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchJob.Location = new System.Drawing.Point(237, 0);
            this.butSearchJob.Name = "butSearchJob";
            this.butSearchJob.Size = new System.Drawing.Size(47, 35);
            this.butSearchJob.TabIndex = 42;
            this.butSearchJob.UseVisualStyleBackColor = true;
            this.butSearchJob.Click += new System.EventHandler(this.butSearchJob_Click);
            // 
            // butRefershJob
            // 
            this.butRefershJob.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh2;
            this.butRefershJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershJob.Location = new System.Drawing.Point(303, 148);
            this.butRefershJob.Name = "butRefershJob";
            this.butRefershJob.Size = new System.Drawing.Size(80, 50);
            this.butRefershJob.TabIndex = 38;
            this.butRefershJob.Text = "Refersh";
            this.butRefershJob.UseVisualStyleBackColor = true;
            this.butRefershJob.Click += new System.EventHandler(this.butRefershJob_Click);
            // 
            // butEditJob
            // 
            this.butEditJob.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil1;
            this.butEditJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditJob.Location = new System.Drawing.Point(208, 148);
            this.butEditJob.Name = "butEditJob";
            this.butEditJob.Size = new System.Drawing.Size(87, 50);
            this.butEditJob.TabIndex = 37;
            this.butEditJob.Text = "Edit";
            this.butEditJob.UseVisualStyleBackColor = true;
            this.butEditJob.Click += new System.EventHandler(this.butEditJob_Click);
            // 
            // butDeleteJob
            // 
            this.butDeleteJob.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons1;
            this.butDeleteJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteJob.Location = new System.Drawing.Point(104, 148);
            this.butDeleteJob.Name = "butDeleteJob";
            this.butDeleteJob.Size = new System.Drawing.Size(102, 50);
            this.butDeleteJob.TabIndex = 36;
            this.butDeleteJob.Text = "Delete";
            this.butDeleteJob.UseVisualStyleBackColor = true;
            this.butDeleteJob.Click += new System.EventHandler(this.butDeleteJob_Click);
            // 
            // butAddJob
            // 
            this.butAddJob.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add4;
            this.butAddJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddJob.Location = new System.Drawing.Point(12, 148);
            this.butAddJob.Name = "butAddJob";
            this.butAddJob.Size = new System.Drawing.Size(91, 50);
            this.butAddJob.TabIndex = 35;
            this.butAddJob.Text = "Add";
            this.butAddJob.UseVisualStyleBackColor = true;
            this.butAddJob.Click += new System.EventHandler(this.butAddJob_Click);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 424);
            this.Controls.Add(this.butSearchJob);
            this.Controls.Add(this.searchTexbJob);
            this.Controls.Add(this.searchCombJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRefershJob);
            this.Controls.Add(this.butEditJob);
            this.Controls.Add(this.butDeleteJob);
            this.Controls.Add(this.butAddJob);
            this.Controls.Add(this.jobDataGridView);
            this.Controls.Add(jobNoLabel);
            this.Controls.Add(this.jobNoTextBox);
            this.Controls.Add(jobNameLabel);
            this.Controls.Add(this.jobNameTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Job";
            this.Text = "Job";
            this.Load += new System.EventHandler(this.Job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private Database1DataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox jobNoTextBox;
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.DataGridView jobDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button butRefershJob;
        private System.Windows.Forms.Button butEditJob;
        private System.Windows.Forms.Button butDeleteJob;
        private System.Windows.Forms.Button butAddJob;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button butSearchJob;
        private System.Windows.Forms.TextBox searchTexbJob;
        private System.Windows.Forms.ComboBox searchCombJob;
        private System.Windows.Forms.Label label1;
    }
}