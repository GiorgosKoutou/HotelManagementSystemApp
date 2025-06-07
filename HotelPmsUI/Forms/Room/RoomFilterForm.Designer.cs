namespace HotelPmsUI.Forms.Room
{
    partial class RoomFilterForm
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
            roomNumberLabel = new Label();
            floorLabel = new Label();
            descriptionLabel = new Label();
            roomNumberText = new TextBox();
            descripitonComboBox = new ComboBox();
            roomBindingSource = new BindingSource(components);
            typeCategoryBindingSource = new BindingSource(components);
            cancelButton = new Button();
            searchButton = new Button();
            clearButton = new Button();
            floorNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floorNumeric).BeginInit();
            SuspendLayout();
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Location = new Point(12, 18);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(140, 28);
            roomNumberLabel.TabIndex = 0;
            roomNumberLabel.Text = "RoomNumber:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new Point(85, 63);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(67, 28);
            floorLabel.TabIndex = 1;
            floorLabel.Text = "Floor: ";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(31, 107);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(121, 28);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description: ";
            // 
            // roomNumberText
            // 
            roomNumberText.Location = new Point(158, 15);
            roomNumberText.Name = "roomNumberText";
            roomNumberText.Size = new Size(184, 34);
            roomNumberText.TabIndex = 3;
            // 
            // descripitonComboBox
            // 
            descripitonComboBox.DataBindings.Add(new Binding("SelectedItem", roomBindingSource, "RoomTypeCategory", true));
            descripitonComboBox.DataSource = typeCategoryBindingSource;
            descripitonComboBox.DisplayMember = "Description";
            descripitonComboBox.FormattingEnabled = true;
            descripitonComboBox.Location = new Point(158, 104);
            descripitonComboBox.Name = "descripitonComboBox";
            descripitonComboBox.Size = new Size(184, 36);
            descripitonComboBox.TabIndex = 5;
            descripitonComboBox.ValueMember = "id";
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(DataAccessLibrary.Models.Room);
            // 
            // typeCategoryBindingSource
            // 
            typeCategoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(522, 157);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(106, 35);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.Image = Properties.Resources.serach;
            searchButton.Location = new Point(378, 157);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(138, 38);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Image = Properties.Resources.clear_filters;
            clearButton.Location = new Point(581, 12);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(47, 31);
            clearButton.TabIndex = 13;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // floorNumeric
            // 
            floorNumeric.Location = new Point(158, 61);
            floorNumeric.Name = "floorNumeric";
            floorNumeric.Size = new Size(184, 34);
            floorNumeric.TabIndex = 14;
            // 
            // RoomFilterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 204);
            ControlBox = false;
            Controls.Add(floorNumeric);
            Controls.Add(clearButton);
            Controls.Add(cancelButton);
            Controls.Add(searchButton);
            Controls.Add(descripitonComboBox);
            Controls.Add(roomNumberText);
            Controls.Add(descriptionLabel);
            Controls.Add(floorLabel);
            Controls.Add(roomNumberLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoomFilterForm";
            Text = "RoomFilterForm";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)floorNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomNumberLabel;
        private Label floorLabel;
        private Label descriptionLabel;
        private TextBox roomNumberText;
        private ComboBox descripitonComboBox;
        private BindingSource roomBindingSource;
        private BindingSource typeCategoryBindingSource;
        private Button cancelButton;
        private Button searchButton;
        private Button clearButton;
        private NumericUpDown floorNumeric;
    }
}