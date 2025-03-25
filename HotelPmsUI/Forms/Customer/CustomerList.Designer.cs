namespace HotelPmsUI.Forms.Customer
{
    partial class CustomerListForm
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
            components = new System.ComponentModel.Container();
            CustomerTable = new DataGridView();
            customerBindingSource = new BindingSource(components);
            editButton = new Button();
            deleteButton = new Button();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GridEditButton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)CustomerTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CustomerTable
            // 
            CustomerTable.AllowUserToAddRows = false;
            CustomerTable.AllowUserToDeleteRows = false;
            CustomerTable.AutoGenerateColumns = false;
            CustomerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CustomerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerTable.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, tinDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, GridEditButton });
            CustomerTable.DataSource = customerBindingSource;
            CustomerTable.Dock = DockStyle.Top;
            CustomerTable.Location = new Point(0, 0);
            CustomerTable.MultiSelect = false;
            CustomerTable.Name = "CustomerTable";
            CustomerTable.ReadOnly = true;
            CustomerTable.RowHeadersVisible = false;
            CustomerTable.RowHeadersWidth = 51;
            CustomerTable.Size = new Size(1056, 322);
            CustomerTable.TabIndex = 0;
            CustomerTable.RowEnter += CustomerTable_RowEnter;
            CustomerTable.DoubleClick += CustomerTable_DoubleClick;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // editButton
            // 
            editButton.Location = new Point(211, 375);
            editButton.Name = "editButton";
            editButton.Size = new Size(182, 47);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(630, 375);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(209, 47);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.Frozen = true;
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.Frozen = true;
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 104;
            // 
            // tinDataGridViewTextBoxColumn
            // 
            tinDataGridViewTextBoxColumn.DataPropertyName = "Tin";
            tinDataGridViewTextBoxColumn.Frozen = true;
            tinDataGridViewTextBoxColumn.HeaderText = "Tin";
            tinDataGridViewTextBoxColumn.MinimumWidth = 6;
            tinDataGridViewTextBoxColumn.Name = "tinDataGridViewTextBoxColumn";
            tinDataGridViewTextBoxColumn.ReadOnly = true;
            tinDataGridViewTextBoxColumn.Width = 58;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.Frozen = true;
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            countryDataGridViewTextBoxColumn.Width = 89;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.Frozen = true;
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 63;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.Frozen = true;
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 91;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Frozen = true;
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 133;
            // 
            // GridEditButton
            // 
            GridEditButton.DataPropertyName = "Id";
            GridEditButton.Frozen = true;
            GridEditButton.HeaderText = "Button";
            GridEditButton.MinimumWidth = 6;
            GridEditButton.Name = "GridEditButton";
            GridEditButton.ReadOnly = true;
            GridEditButton.Text = "Edit";
            GridEditButton.UseColumnTextForButtonValue = true;
            GridEditButton.Width = 59;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 460);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(CustomerTable);
            Name = "CustomerListForm";
            Text = "CustomerList";
            FormClosed += CustomerListForm_FormClosed;
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CustomerTable;
        private BindingSource customerBindingSource;
        private Button editButton;
        private Button deleteButton;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn GridEditButton;
    }
}