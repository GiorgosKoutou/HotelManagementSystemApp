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
            customerBindingSource = new BindingSource(components);
            previousPageButton = new Button();
            nextPageButton = new Button();
            buttonpanel = new Panel();
            dataGridViewPanel = new Panel();
            customerDataGridView = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            buttonpanel.SuspendLayout();
            dataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // previousPageButton
            // 
            previousPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            previousPageButton.FlatAppearance.BorderSize = 0;
            previousPageButton.FlatStyle = FlatStyle.Flat;
            previousPageButton.Image = Properties.Resources.previous_arrow;
            previousPageButton.Location = new Point(864, 5);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(94, 29);
            previousPageButton.TabIndex = 1;
            previousPageButton.TextAlign = ContentAlignment.MiddleLeft;
            previousPageButton.UseVisualStyleBackColor = true;
            previousPageButton.Click += previousPageButton_Click;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextPageButton.FlatAppearance.BorderSize = 0;
            nextPageButton.FlatStyle = FlatStyle.Flat;
            nextPageButton.Image = Properties.Resources.next_arrow;
            nextPageButton.Location = new Point(964, 5);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(94, 29);
            nextPageButton.TabIndex = 2;
            nextPageButton.UseVisualStyleBackColor = true;
            nextPageButton.Click += nextPageButton_Click;
            // 
            // buttonpanel
            // 
            buttonpanel.Controls.Add(previousPageButton);
            buttonpanel.Controls.Add(nextPageButton);
            buttonpanel.Dock = DockStyle.Bottom;
            buttonpanel.Location = new Point(0, 431);
            buttonpanel.Name = "buttonpanel";
            buttonpanel.Size = new Size(1061, 37);
            buttonpanel.TabIndex = 3;
            // 
            // dataGridViewPanel
            // 
            dataGridViewPanel.Controls.Add(customerDataGridView);
            dataGridViewPanel.Dock = DockStyle.Fill;
            dataGridViewPanel.Location = new Point(0, 0);
            dataGridViewPanel.Name = "dataGridViewPanel";
            dataGridViewPanel.Size = new Size(1061, 431);
            dataGridViewPanel.TabIndex = 4;
            // 
            // customerDataGridView
            // 
            customerDataGridView.AllowUserToAddRows = false;
            customerDataGridView.AllowUserToDeleteRows = false;
            customerDataGridView.AutoGenerateColumns = false;
            customerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, tinDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            customerDataGridView.DataSource = customerBindingSource;
            customerDataGridView.Dock = DockStyle.Fill;
            customerDataGridView.Location = new Point(0, 0);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.ReadOnly = true;
            customerDataGridView.RowHeadersWidth = 51;
            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGridView.Size = new Size(1061, 431);
            customerDataGridView.TabIndex = 0;
            customerDataGridView.RowEnter += customerDataGridView_RowEnter;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinDataGridViewTextBoxColumn
            // 
            tinDataGridViewTextBoxColumn.DataPropertyName = "Tin";
            tinDataGridViewTextBoxColumn.HeaderText = "Tin";
            tinDataGridViewTextBoxColumn.MinimumWidth = 6;
            tinDataGridViewTextBoxColumn.Name = "tinDataGridViewTextBoxColumn";
            tinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 468);
            Controls.Add(dataGridViewPanel);
            Controls.Add(buttonpanel);
            Name = "CustomerListForm";
            Text = "CustomerList";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            buttonpanel.ResumeLayout(false);
            dataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource customerBindingSource;
        private Button previousPageButton;
        private Button nextPageButton;
        private Panel buttonpanel;
        private Panel dataGridViewPanel;
        private DataGridView customerDataGridView;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}