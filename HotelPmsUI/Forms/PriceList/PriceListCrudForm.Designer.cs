namespace HotelPmsUI.Forms.PriceList
{
    partial class PriceListCrudForm
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
            periodComboBox = new ComboBox();
            priceListBindingSource = new BindingSource(components);
            periodBindingSource = new BindingSource(components);
            descriptionText = new TextBox();
            periodNameLabel = new Label();
            descriptionLabel = new Label();
            priceListDetailBindingSource = new BindingSource(components);
            bottomPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            centerPanel = new Panel();
            centerDataGridPanel = new Panel();
            priceListDetailDataGridView = new DataGridView();
            roomTypeIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            typeCategoryBindingSource = new BindingSource(components);
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            centerButtonsPanel = new Panel();
            removeRowButton = new Button();
            addRowButton = new Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceListDetailBindingSource).BeginInit();
            bottomPanel.SuspendLayout();
            centerPanel.SuspendLayout();
            centerDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceListDetailDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).BeginInit();
            centerButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(periodComboBox);
            topPanel.Controls.Add(descriptionText);
            topPanel.Controls.Add(periodNameLabel);
            topPanel.Controls.Add(descriptionLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 110);
            topPanel.TabIndex = 0;
            // 
            // periodComboBox
            // 
            periodComboBox.DataBindings.Add(new Binding("SelectedItem", priceListBindingSource, "Period", true));
            periodComboBox.DataSource = periodBindingSource;
            periodComboBox.DisplayMember = "Name";
            periodComboBox.FormattingEnabled = true;
            periodComboBox.Location = new Point(147, 56);
            periodComboBox.Name = "periodComboBox";
            periodComboBox.Size = new Size(260, 36);
            periodComboBox.TabIndex = 3;
            periodComboBox.ValueMember = "Id";
            // 
            // priceListBindingSource
            // 
            priceListBindingSource.DataSource = typeof(DataAccessLibrary.Models.PriceList);
            // 
            // periodBindingSource
            // 
            periodBindingSource.DataSource = typeof(DataAccessLibrary.Models.Period);
            // 
            // descriptionText
            // 
            descriptionText.DataBindings.Add(new Binding("Text", priceListBindingSource, "Description", true));
            descriptionText.Location = new Point(147, 6);
            descriptionText.Name = "descriptionText";
            descriptionText.Size = new Size(308, 34);
            descriptionText.TabIndex = 2;
            // 
            // periodNameLabel
            // 
            periodNameLabel.AutoSize = true;
            periodNameLabel.Location = new Point(12, 59);
            periodNameLabel.Name = "periodNameLabel";
            periodNameLabel.Size = new Size(129, 28);
            periodNameLabel.TabIndex = 1;
            periodNameLabel.Text = "Period Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(20, 9);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(121, 28);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description: ";
            // 
            // priceListDetailBindingSource
            // 
            priceListDetailBindingSource.DataSource = typeof(DataAccessLibrary.Models.PriceListDetail);
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(cancelButton);
            bottomPanel.Controls.Add(saveButton);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bottomPanel.Location = new Point(0, 392);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(800, 58);
            bottomPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(656, 10);
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
            saveButton.Location = new Point(510, 9);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(145, 37);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(centerDataGridPanel);
            centerPanel.Controls.Add(centerButtonsPanel);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(0, 110);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(800, 282);
            centerPanel.TabIndex = 2;
            // 
            // centerDataGridPanel
            // 
            centerDataGridPanel.Controls.Add(priceListDetailDataGridView);
            centerDataGridPanel.Dock = DockStyle.Fill;
            centerDataGridPanel.Location = new Point(0, 39);
            centerDataGridPanel.Name = "centerDataGridPanel";
            centerDataGridPanel.Size = new Size(800, 243);
            centerDataGridPanel.TabIndex = 2;
            // 
            // priceListDetailDataGridView
            // 
            priceListDetailDataGridView.AllowUserToAddRows = false;
            priceListDetailDataGridView.AllowUserToDeleteRows = false;
            priceListDetailDataGridView.AllowUserToResizeRows = false;
            priceListDetailDataGridView.AutoGenerateColumns = false;
            priceListDetailDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            priceListDetailDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            priceListDetailDataGridView.Columns.AddRange(new DataGridViewColumn[] { roomTypeIdDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            priceListDetailDataGridView.DataSource = priceListDetailBindingSource;
            priceListDetailDataGridView.Dock = DockStyle.Fill;
            priceListDetailDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            priceListDetailDataGridView.Location = new Point(0, 0);
            priceListDetailDataGridView.Name = "priceListDetailDataGridView";
            priceListDetailDataGridView.RowHeadersWidth = 51;
            priceListDetailDataGridView.Size = new Size(800, 243);
            priceListDetailDataGridView.TabIndex = 0;
            priceListDetailDataGridView.RowEnter += priceListDetailDataGridView_RowEnter;
            // 
            // roomTypeIdDataGridViewTextBoxColumn
            // 
            roomTypeIdDataGridViewTextBoxColumn.DataPropertyName = "RoomTypeId";
            roomTypeIdDataGridViewTextBoxColumn.DataSource = typeCategoryBindingSource;
            roomTypeIdDataGridViewTextBoxColumn.DisplayMember = "Description";
            roomTypeIdDataGridViewTextBoxColumn.HeaderText = "Room Description";
            roomTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomTypeIdDataGridViewTextBoxColumn.Name = "roomTypeIdDataGridViewTextBoxColumn";
            roomTypeIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            roomTypeIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            roomTypeIdDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // typeCategoryBindingSource
            // 
            typeCategoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // centerButtonsPanel
            // 
            centerButtonsPanel.Controls.Add(removeRowButton);
            centerButtonsPanel.Controls.Add(addRowButton);
            centerButtonsPanel.Dock = DockStyle.Top;
            centerButtonsPanel.Location = new Point(0, 0);
            centerButtonsPanel.Name = "centerButtonsPanel";
            centerButtonsPanel.Size = new Size(800, 39);
            centerButtonsPanel.TabIndex = 1;
            // 
            // removeRowButton
            // 
            removeRowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeRowButton.FlatAppearance.BorderSize = 0;
            removeRowButton.FlatStyle = FlatStyle.Flat;
            removeRowButton.Image = Properties.Resources.remove_x;
            removeRowButton.Location = new Point(751, 3);
            removeRowButton.Name = "removeRowButton";
            removeRowButton.Size = new Size(46, 33);
            removeRowButton.TabIndex = 1;
            removeRowButton.UseVisualStyleBackColor = true;
            removeRowButton.Click += removeRowButton_Click;
            // 
            // addRowButton
            // 
            addRowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addRowButton.FlatAppearance.BorderSize = 0;
            addRowButton.FlatStyle = FlatStyle.Flat;
            addRowButton.Image = Properties.Resources.add_cross;
            addRowButton.Location = new Point(704, 3);
            addRowButton.Name = "addRowButton";
            addRowButton.Size = new Size(41, 34);
            addRowButton.TabIndex = 0;
            addRowButton.UseVisualStyleBackColor = true;
            addRowButton.Click += addRowButton_Click;
            // 
            // PriceListCrudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(centerPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PriceListCrudForm";
            Text = "PriceListCrudForm";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceListDetailBindingSource).EndInit();
            bottomPanel.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            centerDataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceListDetailDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).EndInit();
            centerButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel bottomPanel;
        private Panel centerPanel;
        private DataGridView priceListDetailDataGridView;
        private Label descriptionLabel;
        private ComboBox periodComboBox;
        private TextBox descriptionText;
        private Label periodNameLabel;
        private BindingSource priceListDetailBindingSource;
        private BindingSource periodBindingSource;
        private BindingSource priceListBindingSource;
        private DataGridViewComboBoxColumn roomTypeIdDataGridViewTextBoxColumn;
        private BindingSource typeCategoryBindingSource;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Button cancelButton;
        private Button saveButton;
        private Panel centerButtonsPanel;
        private Button removeRowButton;
        private Button addRowButton;
        private Panel centerDataGridPanel;
    }
}