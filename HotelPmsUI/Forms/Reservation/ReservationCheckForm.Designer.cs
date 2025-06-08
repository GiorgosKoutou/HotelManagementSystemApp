namespace HotelPmsUI.Forms.Reservation
{
    partial class ReservationCheckForm
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
            topPanel = new Panel();
            customerCombobox = new ComboBox();
            reservationBindingSource = new BindingSource(components);
            customerBindingSource = new BindingSource(components);
            customerLabel = new Label();
            searchButton = new Button();
            reservationDateTimePicker = new DateTimePicker();
            reservationDateLabel = new Label();
            bottomPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            totalPriceText = new TextBox();
            roomPriceText = new TextBox();
            totalPriceLabel = new Label();
            roomPriceLabel = new Label();
            checkOutCheckBox = new CheckBox();
            checkInCheckBox = new CheckBox();
            centerPanel = new Panel();
            reservationDataGridView = new DataGridView();
            RoomNumber = new DataGridViewTextBoxColumn();
            CustomerFullname = new DataGridViewTextBoxColumn();
            reservationDateFromDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationDateToDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            bottomPanel.SuspendLayout();
            centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationDataGridView).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(customerCombobox);
            topPanel.Controls.Add(customerLabel);
            topPanel.Controls.Add(searchButton);
            topPanel.Controls.Add(reservationDateTimePicker);
            topPanel.Controls.Add(reservationDateLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1007, 124);
            topPanel.TabIndex = 0;
            // 
            // customerCombobox
            // 
            customerCombobox.DataBindings.Add(new Binding("SelectedItem", reservationBindingSource, "Customer", true));
            customerCombobox.DataSource = customerBindingSource;
            customerCombobox.DisplayMember = "Fullname";
            customerCombobox.FormattingEnabled = true;
            customerCombobox.Location = new Point(186, 46);
            customerCombobox.Name = "customerCombobox";
            customerCombobox.Size = new Size(263, 36);
            customerCombobox.TabIndex = 10;
            customerCombobox.ValueMember = "Id";
            customerCombobox.DropDown += customerCombobox_DropDown;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(DataAccessLibrary.Models.Reservation);
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new Point(75, 49);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(105, 28);
            customerLabel.TabIndex = 9;
            customerLabel.Text = "Customer: ";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.Location = new Point(863, 82);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 36);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // reservationDateTimePicker
            // 
            reservationDateTimePicker.CustomFormat = "dd/MM/yyyy";
            reservationDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservationDateTimePicker.Location = new Point(186, 4);
            reservationDateTimePicker.Name = "reservationDateTimePicker";
            reservationDateTimePicker.Size = new Size(190, 34);
            reservationDateTimePicker.TabIndex = 6;
            reservationDateTimePicker.Value = new DateTime(2025, 6, 8, 11, 26, 45, 0);
            // 
            // reservationDateLabel
            // 
            reservationDateLabel.AutoSize = true;
            reservationDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationDateLabel.Location = new Point(12, 9);
            reservationDateLabel.Name = "reservationDateLabel";
            reservationDateLabel.Size = new Size(168, 28);
            reservationDateLabel.TabIndex = 5;
            reservationDateLabel.Text = "Reservation Date: ";
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(cancelButton);
            bottomPanel.Controls.Add(saveButton);
            bottomPanel.Controls.Add(totalPriceText);
            bottomPanel.Controls.Add(roomPriceText);
            bottomPanel.Controls.Add(totalPriceLabel);
            bottomPanel.Controls.Add(roomPriceLabel);
            bottomPanel.Controls.Add(checkOutCheckBox);
            bottomPanel.Controls.Add(checkInCheckBox);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bottomPanel.Location = new Point(0, 364);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1007, 118);
            bottomPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(863, 70);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(726, 71);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(132, 36);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // totalPriceText
            // 
            totalPriceText.Location = new Point(385, 51);
            totalPriceText.Name = "totalPriceText";
            totalPriceText.ReadOnly = true;
            totalPriceText.Size = new Size(125, 34);
            totalPriceText.TabIndex = 5;
            // 
            // roomPriceText
            // 
            roomPriceText.Location = new Point(138, 51);
            roomPriceText.Name = "roomPriceText";
            roomPriceText.Size = new Size(125, 34);
            roomPriceText.TabIndex = 4;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(269, 54);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(110, 28);
            totalPriceLabel.TabIndex = 3;
            totalPriceLabel.Text = "Total Price: ";
            // 
            // roomPriceLabel
            // 
            roomPriceLabel.AutoSize = true;
            roomPriceLabel.Location = new Point(12, 54);
            roomPriceLabel.Name = "roomPriceLabel";
            roomPriceLabel.Size = new Size(120, 28);
            roomPriceLabel.TabIndex = 2;
            roomPriceLabel.Text = "Room Price: ";
            // 
            // checkOutCheckBox
            // 
            checkOutCheckBox.AutoSize = true;
            checkOutCheckBox.Location = new Point(144, 6);
            checkOutCheckBox.Name = "checkOutCheckBox";
            checkOutCheckBox.Size = new Size(124, 32);
            checkOutCheckBox.TabIndex = 1;
            checkOutCheckBox.Text = "Check Out";
            checkOutCheckBox.UseVisualStyleBackColor = true;
            checkOutCheckBox.CheckedChanged += checkOutCheckBox_CheckedChanged;
            // 
            // checkInCheckBox
            // 
            checkInCheckBox.AutoSize = true;
            checkInCheckBox.Location = new Point(12, 6);
            checkInCheckBox.Name = "checkInCheckBox";
            checkInCheckBox.Size = new Size(107, 32);
            checkInCheckBox.TabIndex = 0;
            checkInCheckBox.Text = "Check In";
            checkInCheckBox.UseVisualStyleBackColor = true;
            checkInCheckBox.CheckedChanged += checkInCheckBox_CheckedChanged;
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(reservationDataGridView);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 124);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(1007, 240);
            centerPanel.TabIndex = 2;
            // 
            // reservationDataGridView
            // 
            reservationDataGridView.AllowUserToAddRows = false;
            reservationDataGridView.AllowUserToDeleteRows = false;
            reservationDataGridView.AutoGenerateColumns = false;
            reservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationDataGridView.Columns.AddRange(new DataGridViewColumn[] { RoomNumber, CustomerFullname, reservationDateFromDataGridViewTextBoxColumn, reservationDateToDataGridViewTextBoxColumn, checkInDateDataGridViewTextBoxColumn, checkOutDateDataGridViewTextBoxColumn });
            reservationDataGridView.DataSource = reservationBindingSource;
            reservationDataGridView.Dock = DockStyle.Fill;
            reservationDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            reservationDataGridView.Location = new Point(0, 0);
            reservationDataGridView.Name = "reservationDataGridView";
            reservationDataGridView.ReadOnly = true;
            reservationDataGridView.RowHeadersWidth = 51;
            reservationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationDataGridView.Size = new Size(1007, 240);
            reservationDataGridView.TabIndex = 0;
            reservationDataGridView.RowEnter += reservationDataGridView_RowEnter;
            reservationDataGridView.DoubleClick += reservationDataGridView_DoubleClick;
            // 
            // RoomNumber
            // 
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // CustomerFullname
            // 
            CustomerFullname.DataPropertyName = "CustomerFullname";
            CustomerFullname.HeaderText = "Full Name";
            CustomerFullname.MinimumWidth = 6;
            CustomerFullname.Name = "CustomerFullname";
            CustomerFullname.ReadOnly = true;
            // 
            // reservationDateFromDataGridViewTextBoxColumn
            // 
            reservationDateFromDataGridViewTextBoxColumn.DataPropertyName = "ReservationDateFrom";
            reservationDateFromDataGridViewTextBoxColumn.HeaderText = "ReservationDateFrom";
            reservationDateFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservationDateFromDataGridViewTextBoxColumn.Name = "reservationDateFromDataGridViewTextBoxColumn";
            reservationDateFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationDateToDataGridViewTextBoxColumn
            // 
            reservationDateToDataGridViewTextBoxColumn.DataPropertyName = "ReservationDateTo";
            reservationDateToDataGridViewTextBoxColumn.HeaderText = "ReservationDateTo";
            reservationDateToDataGridViewTextBoxColumn.MinimumWidth = 6;
            reservationDateToDataGridViewTextBoxColumn.Name = "reservationDateToDataGridViewTextBoxColumn";
            reservationDateToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            checkInDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
            checkInDateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            checkOutDateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // ReservationCheckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 482);
            Controls.Add(centerPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Name = "ReservationCheckForm";
            Text = "ReservationCheckForm";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservationDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel bottomPanel;
        private Panel centerPanel;
        private DateTimePicker reservationDateTimePicker;
        private Label reservationDateLabel;
        private Label customerLabel;
        private Button searchButton;
        private DataGridView reservationDataGridView;
        private BindingSource reservationBindingSource;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn CustomerFullname;
        private DataGridViewTextBoxColumn reservationDateFromDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationDateToDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private TextBox totalPriceText;
        private TextBox roomPriceText;
        private Label totalPriceLabel;
        private Label roomPriceLabel;
        private CheckBox checkOutCheckBox;
        private CheckBox checkInCheckBox;
        private Button saveButton;
        private ComboBox customerCombobox;
        private BindingSource customerBindingSource;
        private Button cancelButton;
    }
}