namespace HotelPmsUI.Forms.Reservation
{
    partial class ReservationBookForm
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
            centerPanel = new Panel();
            roomDataGridView = new DataGridView();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bedNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bathNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomBindingSource = new BindingSource(components);
            topPanel = new Panel();
            peopleNumber = new NumericUpDown();
            searchButton = new Button();
            reservationToDateTimePicker = new DateTimePicker();
            reservationBindingSource = new BindingSource(components);
            reservationFromDateTimePicker = new DateTimePicker();
            peopleLabel = new Label();
            reservationToLabel = new Label();
            reservationDateFromLabel = new Label();
            bottomPanel = new Panel();
            customerInfoText = new TextBox();
            newCustomerCheckBox = new CheckBox();
            roomText = new TextBox();
            customerInfoComboBox = new ComboBox();
            customerBindingSource = new BindingSource(components);
            cancelButton = new Button();
            saveButton = new Button();
            roomNumberLabel = new Label();
            customerInfoLabel = new Label();
            typeCategoryBindingSource = new BindingSource(components);
            centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)peopleNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(roomDataGridView);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 102);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(985, 293);
            centerPanel.TabIndex = 0;
            // 
            // roomDataGridView
            // 
            roomDataGridView.AllowUserToAddRows = false;
            roomDataGridView.AllowUserToDeleteRows = false;
            roomDataGridView.AutoGenerateColumns = false;
            roomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomDataGridView.Columns.AddRange(new DataGridViewColumn[] { roomNumberDataGridViewTextBoxColumn, floorDataGridViewTextBoxColumn, bedNumberDataGridViewTextBoxColumn, bathNumberDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            roomDataGridView.DataSource = roomBindingSource;
            roomDataGridView.Dock = DockStyle.Fill;
            roomDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            roomDataGridView.Location = new Point(0, 0);
            roomDataGridView.Name = "roomDataGridView";
            roomDataGridView.ReadOnly = true;
            roomDataGridView.RowHeadersWidth = 51;
            roomDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomDataGridView.Size = new Size(985, 293);
            roomDataGridView.TabIndex = 0;
            roomDataGridView.RowEnter += roomDataGridView_RowEnter;
            roomDataGridView.DoubleClick += roomDataGridView_DoubleClick;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            floorDataGridViewTextBoxColumn.MinimumWidth = 6;
            floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            floorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedNumberDataGridViewTextBoxColumn
            // 
            bedNumberDataGridViewTextBoxColumn.DataPropertyName = "BedNumber";
            bedNumberDataGridViewTextBoxColumn.HeaderText = "BedNumber";
            bedNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            bedNumberDataGridViewTextBoxColumn.Name = "bedNumberDataGridViewTextBoxColumn";
            bedNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bathNumberDataGridViewTextBoxColumn
            // 
            bathNumberDataGridViewTextBoxColumn.DataPropertyName = "BathNumber";
            bathNumberDataGridViewTextBoxColumn.HeaderText = "BathNumber";
            bathNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            bathNumberDataGridViewTextBoxColumn.Name = "bathNumberDataGridViewTextBoxColumn";
            bathNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(DataAccessLibrary.Models.Room);
            // 
            // topPanel
            // 
            topPanel.Controls.Add(peopleNumber);
            topPanel.Controls.Add(searchButton);
            topPanel.Controls.Add(reservationToDateTimePicker);
            topPanel.Controls.Add(reservationFromDateTimePicker);
            topPanel.Controls.Add(peopleLabel);
            topPanel.Controls.Add(reservationToLabel);
            topPanel.Controls.Add(reservationDateFromLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(985, 102);
            topPanel.TabIndex = 1;
            // 
            // peopleNumber
            // 
            peopleNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            peopleNumber.Location = new Point(186, 58);
            peopleNumber.Name = "peopleNumber";
            peopleNumber.Size = new Size(150, 34);
            peopleNumber.TabIndex = 8;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.Location = new Point(841, 60);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 36);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // reservationToDateTimePicker
            // 
            reservationToDateTimePicker.Anchor = AnchorStyles.Left;
            reservationToDateTimePicker.CustomFormat = "dd/MM/yyyy";
            reservationToDateTimePicker.DataBindings.Add(new Binding("Value", reservationBindingSource, "ReservationDateTo", true));
            reservationToDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservationToDateTimePicker.Location = new Point(369, 4);
            reservationToDateTimePicker.Name = "reservationToDateTimePicker";
            reservationToDateTimePicker.Size = new Size(151, 34);
            reservationToDateTimePicker.TabIndex = 5;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(DataAccessLibrary.Models.Reservation);
            // 
            // reservationFromDateTimePicker
            // 
            reservationFromDateTimePicker.CustomFormat = "dd/MM/yyyy";
            reservationFromDateTimePicker.DataBindings.Add(new Binding("Value", reservationBindingSource, "ReservationDateFrom", true));
            reservationFromDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservationFromDateTimePicker.Location = new Point(186, 4);
            reservationFromDateTimePicker.Name = "reservationFromDateTimePicker";
            reservationFromDateTimePicker.Size = new Size(151, 34);
            reservationFromDateTimePicker.TabIndex = 4;
            reservationFromDateTimePicker.Value = new DateTime(2025, 6, 8, 11, 26, 45, 0);
            // 
            // peopleLabel
            // 
            peopleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            peopleLabel.AutoSize = true;
            peopleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            peopleLabel.Location = new Point(100, 60);
            peopleLabel.Name = "peopleLabel";
            peopleLabel.Size = new Size(80, 28);
            peopleLabel.TabIndex = 2;
            peopleLabel.Text = "People: ";
            // 
            // reservationToLabel
            // 
            reservationToLabel.AutoSize = true;
            reservationToLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationToLabel.Location = new Point(343, 4);
            reservationToLabel.Name = "reservationToLabel";
            reservationToLabel.Size = new Size(20, 28);
            reservationToLabel.TabIndex = 1;
            reservationToLabel.Text = "-";
            // 
            // reservationDateFromLabel
            // 
            reservationDateFromLabel.AutoSize = true;
            reservationDateFromLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationDateFromLabel.Location = new Point(12, 9);
            reservationDateFromLabel.Name = "reservationDateFromLabel";
            reservationDateFromLabel.Size = new Size(168, 28);
            reservationDateFromLabel.TabIndex = 0;
            reservationDateFromLabel.Text = "Reservation Date: ";
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(customerInfoText);
            bottomPanel.Controls.Add(newCustomerCheckBox);
            bottomPanel.Controls.Add(roomText);
            bottomPanel.Controls.Add(customerInfoComboBox);
            bottomPanel.Controls.Add(cancelButton);
            bottomPanel.Controls.Add(saveButton);
            bottomPanel.Controls.Add(roomNumberLabel);
            bottomPanel.Controls.Add(customerInfoLabel);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bottomPanel.Location = new Point(0, 395);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(985, 157);
            bottomPanel.TabIndex = 1;
            // 
            // customerInfoText
            // 
            customerInfoText.Location = new Point(521, 16);
            customerInfoText.Name = "customerInfoText";
            customerInfoText.Size = new Size(288, 34);
            customerInfoText.TabIndex = 21;
            // 
            // newCustomerCheckBox
            // 
            newCustomerCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newCustomerCheckBox.AutoSize = true;
            newCustomerCheckBox.FlatStyle = FlatStyle.System;
            newCustomerCheckBox.Location = new Point(811, 6);
            newCustomerCheckBox.Name = "newCustomerCheckBox";
            newCustomerCheckBox.Size = new Size(171, 33);
            newCustomerCheckBox.TabIndex = 20;
            newCustomerCheckBox.Text = "New Customer";
            newCustomerCheckBox.UseVisualStyleBackColor = true;
            newCustomerCheckBox.CheckedChanged += newCustomerCheckBox_CheckedChanged;
            // 
            // roomText
            // 
            roomText.Location = new Point(162, 60);
            roomText.Name = "roomText";
            roomText.ReadOnly = true;
            roomText.Size = new Size(174, 34);
            roomText.TabIndex = 19;
            // 
            // customerInfoComboBox
            // 
            customerInfoComboBox.DataBindings.Add(new Binding("SelectedItem", reservationBindingSource, "Customer", true));
            customerInfoComboBox.DataSource = customerBindingSource;
            customerInfoComboBox.DisplayMember = "Fullname";
            customerInfoComboBox.FormattingEnabled = true;
            customerInfoComboBox.Location = new Point(180, 16);
            customerInfoComboBox.Name = "customerInfoComboBox";
            customerInfoComboBox.Size = new Size(335, 36);
            customerInfoComboBox.TabIndex = 18;
            customerInfoComboBox.ValueMember = "Id";
            customerInfoComboBox.DropDown += customerInfoComboBox_DropDown;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(841, 109);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(692, 109);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(145, 37);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Location = new Point(83, 63);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(73, 28);
            roomNumberLabel.TabIndex = 1;
            roomNumberLabel.Text = "Room: ";
            // 
            // customerInfoLabel
            // 
            customerInfoLabel.AutoSize = true;
            customerInfoLabel.Location = new Point(12, 19);
            customerInfoLabel.Name = "customerInfoLabel";
            customerInfoLabel.Size = new Size(162, 28);
            customerInfoLabel.TabIndex = 0;
            customerInfoLabel.Text = "Customer Name: ";
            // 
            // typeCategoryBindingSource
            // 
            typeCategoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // ReservationBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 552);
            Controls.Add(centerPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ReservationBookForm";
            Text = "ReservationBookForm";
            centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)peopleNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel centerPanel;
        private Panel topPanel;
        private Panel bottomPanel;
        private DataGridView roomDataGridView;
        private Label reservationToLabel;
        private Label reservationDateFromLabel;
        private DateTimePicker reservationFromDateTimePicker;
        private DateTimePicker reservationToDateTimePicker;
        private Button searchButton;
        private Label peopleLabel;
        private BindingSource typeCategoryBindingSource;
        private NumericUpDown peopleNumber;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bathNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
        private Label roomNumberLabel;
        private Label customerInfoLabel;
        private Button cancelButton;
        private Button saveButton;
        private TextBox roomText;
        private ComboBox customerInfoComboBox;
        private BindingSource customerBindingSource;
        private BindingSource reservationBindingSource;
        private TextBox customerInfoText;
        private CheckBox newCustomerCheckBox;
    }
}