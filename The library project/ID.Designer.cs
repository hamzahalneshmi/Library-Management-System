namespace The_library_project
{
    partial class ID
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
            System.Windows.Forms.Label idNoLabel;
            System.Windows.Forms.Label issueDateLabel;
            System.Windows.Forms.Label issuePlaceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ID));
            this.idNoTextBox = new System.Windows.Forms.TextBox();
            this.iDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new The_library_project.Database1DataSet();
            this.issueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.issuePlaceTextBox = new System.Windows.Forms.TextBox();
            this.iDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTexbID = new System.Windows.Forms.TextBox();
            this.searchCombID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butDeleteImagID = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.iDTableAdapter = new The_library_project.Database1DataSetTableAdapters.IDTableAdapter();
            this.tableAdapterManager = new The_library_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.butRefershID = new System.Windows.Forms.Button();
            this.butEditID = new System.Windows.Forms.Button();
            this.butDeleteID = new System.Windows.Forms.Button();
            this.butAddID = new System.Windows.Forms.Button();
            this.butAddImagID = new System.Windows.Forms.Button();
            this.butSearchID = new System.Windows.Forms.Button();
            this.borImagePictureBox = new System.Windows.Forms.PictureBox();
            idNoLabel = new System.Windows.Forms.Label();
            issueDateLabel = new System.Windows.Forms.Label();
            issuePlaceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idNoLabel
            // 
            idNoLabel.AutoSize = true;
            idNoLabel.Location = new System.Drawing.Point(4, 60);
            idNoLabel.Name = "idNoLabel";
            idNoLabel.Size = new System.Drawing.Size(42, 13);
            idNoLabel.TabIndex = 1;
            idNoLabel.Text = "ID Num";
            // 
            // issueDateLabel
            // 
            issueDateLabel.AutoSize = true;
            issueDateLabel.Location = new System.Drawing.Point(4, 87);
            issueDateLabel.Name = "issueDateLabel";
            issueDateLabel.Size = new System.Drawing.Size(61, 13);
            issueDateLabel.TabIndex = 3;
            issueDateLabel.Text = "issue Date:";
            // 
            // issuePlaceLabel
            // 
            issuePlaceLabel.AutoSize = true;
            issuePlaceLabel.Location = new System.Drawing.Point(4, 112);
            issuePlaceLabel.Name = "issuePlaceLabel";
            issuePlaceLabel.Size = new System.Drawing.Size(63, 13);
            issuePlaceLabel.TabIndex = 5;
            issuePlaceLabel.Text = "issue Place:";
            // 
            // idNoTextBox
            // 
            this.idNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iDBindingSource, "idNo", true));
            this.idNoTextBox.Location = new System.Drawing.Point(73, 57);
            this.idNoTextBox.Name = "idNoTextBox";
            this.idNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idNoTextBox.TabIndex = 2;
            // 
            // iDBindingSource
            // 
            this.iDBindingSource.DataMember = "ID";
            this.iDBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueDateDateTimePicker
            // 
            this.issueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iDBindingSource, "issueDate", true));
            this.issueDateDateTimePicker.Location = new System.Drawing.Point(73, 83);
            this.issueDateDateTimePicker.Name = "issueDateDateTimePicker";
            this.issueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issueDateDateTimePicker.TabIndex = 4;
            // 
            // issuePlaceTextBox
            // 
            this.issuePlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iDBindingSource, "issuePlace", true));
            this.issuePlaceTextBox.Location = new System.Drawing.Point(73, 109);
            this.issuePlaceTextBox.Name = "issuePlaceTextBox";
            this.issuePlaceTextBox.Size = new System.Drawing.Size(200, 20);
            this.issuePlaceTextBox.TabIndex = 6;
            // 
            // iDDataGridView
            // 
            this.iDDataGridView.AutoGenerateColumns = false;
            this.iDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.iDDataGridView.DataSource = this.iDBindingSource;
            this.iDDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iDDataGridView.Location = new System.Drawing.Point(0, 265);
            this.iDDataGridView.Name = "iDDataGridView";
            this.iDDataGridView.Size = new System.Drawing.Size(442, 187);
            this.iDDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "issueDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Issue Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "issuePlace";
            this.dataGridViewTextBoxColumn3.HeaderText = "Issue Place";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // searchTexbID
            // 
            this.searchTexbID.Location = new System.Drawing.Point(166, 20);
            this.searchTexbID.Name = "searchTexbID";
            this.searchTexbID.Size = new System.Drawing.Size(107, 20);
            this.searchTexbID.TabIndex = 27;
            // 
            // searchCombID
            // 
            this.searchCombID.FormattingEnabled = true;
            this.searchCombID.Items.AddRange(new object[] {
            "ID",
            "Place"});
            this.searchCombID.Location = new System.Drawing.Point(73, 19);
            this.searchCombID.Name = "searchCombID";
            this.searchCombID.Size = new System.Drawing.Size(87, 21);
            this.searchCombID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // butDeleteImagID
            // 
            this.butDeleteImagID.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_Picture_delete;
            this.butDeleteImagID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteImagID.Enabled = false;
            this.butDeleteImagID.Location = new System.Drawing.Point(376, 154);
            this.butDeleteImagID.Name = "butDeleteImagID";
            this.butDeleteImagID.Size = new System.Drawing.Size(56, 41);
            this.butDeleteImagID.TabIndex = 30;
            this.butDeleteImagID.UseVisualStyleBackColor = true;
            this.butDeleteImagID.Click += new System.EventHandler(this.butDeleteImagUser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // iDTableAdapter
            // 
            this.iDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutherTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookSortTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.BorrowingTableAdapter = null;
            this.tableAdapterManager.IDTableAdapter = this.iDTableAdapter;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.Publoshing_houseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_library_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // butRefershID
            // 
            this.butRefershID.BackgroundImage = global::The_library_project.Properties.Resources.Custom_Icon_Design_Flatastic_8_Refresh;
            this.butRefershID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRefershID.Location = new System.Drawing.Point(339, 207);
            this.butRefershID.Name = "butRefershID";
            this.butRefershID.Size = new System.Drawing.Size(103, 52);
            this.butRefershID.TabIndex = 34;
            this.butRefershID.Text = "Refersh";
            this.butRefershID.UseVisualStyleBackColor = true;
            this.butRefershID.Click += new System.EventHandler(this.butRefershUser_Click);
            // 
            // butEditID
            // 
            this.butEditID.BackgroundImage = global::The_library_project.Properties.Resources.Turbomilk_Livejournal_10_Pencil;
            this.butEditID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEditID.Location = new System.Drawing.Point(230, 207);
            this.butEditID.Name = "butEditID";
            this.butEditID.Size = new System.Drawing.Size(103, 52);
            this.butEditID.TabIndex = 33;
            this.butEditID.Text = "Edit";
            this.butEditID.UseVisualStyleBackColor = true;
            this.butEditID.Click += new System.EventHandler(this.butEditUser_Click);
            // 
            // butDeleteID
            // 
            this.butDeleteID.BackgroundImage = global::The_library_project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.butDeleteID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDeleteID.Location = new System.Drawing.Point(124, 207);
            this.butDeleteID.Name = "butDeleteID";
            this.butDeleteID.Size = new System.Drawing.Size(103, 52);
            this.butDeleteID.TabIndex = 32;
            this.butDeleteID.Text = "Delete";
            this.butDeleteID.UseVisualStyleBackColor = true;
            this.butDeleteID.Click += new System.EventHandler(this.butDeleteUser_Click);
            // 
            // butAddID
            // 
            this.butAddID.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_User_add;
            this.butAddID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddID.Location = new System.Drawing.Point(15, 207);
            this.butAddID.Name = "butAddID";
            this.butAddID.Size = new System.Drawing.Size(103, 52);
            this.butAddID.TabIndex = 31;
            this.butAddID.Text = "Add";
            this.butAddID.UseVisualStyleBackColor = true;
            this.butAddID.Click += new System.EventHandler(this.butAddUser_Click);
            // 
            // butAddImagID
            // 
            this.butAddImagID.BackgroundImage = global::The_library_project.Properties.Resources.Icojam_Blue_Bits_Picture_add;
            this.butAddImagID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAddImagID.Enabled = false;
            this.butAddImagID.Location = new System.Drawing.Point(315, 154);
            this.butAddImagID.Name = "butAddImagID";
            this.butAddImagID.Size = new System.Drawing.Size(55, 41);
            this.butAddImagID.TabIndex = 29;
            this.butAddImagID.UseVisualStyleBackColor = true;
            this.butAddImagID.Click += new System.EventHandler(this.butAddImagUser_Click);
            // 
            // butSearchID
            // 
            this.butSearchID.BackgroundImage = global::The_library_project.Properties.Resources.Awicons_Vista_Artistic_Search;
            this.butSearchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSearchID.Location = new System.Drawing.Point(288, 7);
            this.butSearchID.Name = "butSearchID";
            this.butSearchID.Size = new System.Drawing.Size(48, 44);
            this.butSearchID.TabIndex = 28;
            this.butSearchID.UseVisualStyleBackColor = true;
            this.butSearchID.Click += new System.EventHandler(this.butSearchUser_Click);
            // 
            // borImagePictureBox
            // 
            this.borImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iDBindingSource, "borImage", true));
            this.borImagePictureBox.Location = new System.Drawing.Point(321, 57);
            this.borImagePictureBox.Name = "borImagePictureBox";
            this.borImagePictureBox.Size = new System.Drawing.Size(109, 91);
            this.borImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borImagePictureBox.TabIndex = 8;
            this.borImagePictureBox.TabStop = false;
            // 
            // ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 452);
            this.Controls.Add(this.butRefershID);
            this.Controls.Add(this.butEditID);
            this.Controls.Add(this.butDeleteID);
            this.Controls.Add(this.butAddID);
            this.Controls.Add(this.butDeleteImagID);
            this.Controls.Add(this.butAddImagID);
            this.Controls.Add(this.butSearchID);
            this.Controls.Add(this.searchTexbID);
            this.Controls.Add(this.searchCombID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iDDataGridView);
            this.Controls.Add(idNoLabel);
            this.Controls.Add(this.idNoTextBox);
            this.Controls.Add(issueDateLabel);
            this.Controls.Add(this.issueDateDateTimePicker);
            this.Controls.Add(issuePlaceLabel);
            this.Controls.Add(this.issuePlaceTextBox);
            this.Controls.Add(this.borImagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ID";
            this.Text = "ID";
            this.Load += new System.EventHandler(this.ID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource iDBindingSource;
        private Database1DataSetTableAdapters.IDTableAdapter iDTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idNoTextBox;
        private System.Windows.Forms.DateTimePicker issueDateDateTimePicker;
        private System.Windows.Forms.TextBox issuePlaceTextBox;
        private System.Windows.Forms.PictureBox borImagePictureBox;
        private System.Windows.Forms.DataGridView iDDataGridView;
        private System.Windows.Forms.Button butSearchID;
        private System.Windows.Forms.TextBox searchTexbID;
        private System.Windows.Forms.ComboBox searchCombID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDeleteImagID;
        private System.Windows.Forms.Button butAddImagID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button butRefershID;
        private System.Windows.Forms.Button butEditID;
        private System.Windows.Forms.Button butDeleteID;
        private System.Windows.Forms.Button butAddID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}