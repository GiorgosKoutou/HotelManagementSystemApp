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
            customerTable = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GridEditButton = new DataGridViewButtonColumn();
            customerBindingSource = new BindingSource(components);
            previousPageButton = new Button();
            nextPageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // customerTable
            // 
            customerTable.AllowUserToAddRows = false;
            customerTable.AllowUserToDeleteRows = false;
            customerTable.AutoGenerateColumns = false;
            customerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            customerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerTable.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, tinDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, GridEditButton });
            customerTable.DataSource = customerBindingSource;
            customerTable.Dock = DockStyle.Top;
            customerTable.Location = new Point(0, 0);
            customerTable.MultiSelect = false;
            customerTable.Name = "customerTable";
            customerTable.ReadOnly = true;
            customerTable.RowHeadersVisible = false;
            customerTable.RowHeadersWidth = 51;
            customerTable.Size = new Size(934, 381);
            customerTable.TabIndex = 0;
            customerTable.CellClick += CustomerTable_CellClick;
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
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // previousPageButton
            // 
            previousPageButton.Anchor = AnchorStyles.None;
            previousPageButton.Location = new Point(346, 407);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(94, 29);
            previousPageButton.TabIndex = 1;
            previousPageButton.Text = "<";
            previousPageButton.UseVisualStyleBackColor = true;
            previousPageButton.Click += previousPageButton_Click;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.None;
            nextPageButton.Location = new Point(471, 407);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(94, 29);
            nextPageButton.TabIndex = 2;
            nextPageButton.Text = ">";
            nextPageButton.UseVisualStyleBackColor = true;
            nextPageButton.Click += nextPageButton_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 587);
            Controls.Add(nextPageButton);
            Controls.Add(previousPageButton);
            Controls.Add(customerTable);
            Name = "CustomerListForm";
            Text = "CustomerList";
            FormClosed += CustomerListForm_FormClosed;
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customerTable;
        private BindingSource customerBindingSource;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn GridEditButton;
        private Button previousPageButton;
        private Button nextPageButton;
    }
}