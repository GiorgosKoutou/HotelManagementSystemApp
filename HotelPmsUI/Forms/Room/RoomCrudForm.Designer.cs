namespace HotelPmsUI.Forms.Room
{
    partial class RoomCrudForm
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
            bedNumberLabel = new Label();
            roomTypeLabel = new Label();
            bathNumberLabel = new Label();
            roomNumberText = new TextBox();
            roomBindingSource = new BindingSource(components);
            bathNumberText = new TextBox();
            floorText = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            bedNumberText = new TextBox();
            roomTypeComboBox = new ComboBox();
            typeCatgoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeCatgoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new Font("Segoe UI", 12F);
            roomNumberLabel.Location = new Point(31, 9);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(145, 28);
            roomNumberLabel.TabIndex = 0;
            roomNumberLabel.Text = "Room Number:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new Font("Segoe UI", 12F);
            floorLabel.Location = new Point(31, 48);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(62, 28);
            floorLabel.TabIndex = 1;
            floorLabel.Text = "Floor:";
            // 
            // bedNumberLabel
            // 
            bedNumberLabel.AutoSize = true;
            bedNumberLabel.Font = new Font("Segoe UI", 12F);
            bedNumberLabel.Location = new Point(31, 84);
            bedNumberLabel.Name = "bedNumberLabel";
            bedNumberLabel.Size = new Size(126, 28);
            bedNumberLabel.TabIndex = 2;
            bedNumberLabel.Text = "Bed Number:";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.Font = new Font("Segoe UI", 12F);
            roomTypeLabel.Location = new Point(31, 157);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(173, 28);
            roomTypeLabel.TabIndex = 4;
            roomTypeLabel.Text = "Room Description:";
            // 
            // bathNumberLabel
            // 
            bathNumberLabel.AutoSize = true;
            bathNumberLabel.Font = new Font("Segoe UI", 12F);
            bathNumberLabel.Location = new Point(31, 121);
            bathNumberLabel.Name = "bathNumberLabel";
            bathNumberLabel.Size = new Size(132, 28);
            bathNumberLabel.TabIndex = 3;
            bathNumberLabel.Text = "Bath Number:";
            // 
            // roomNumberText
            // 
            roomNumberText.DataBindings.Add(new Binding("Text", roomBindingSource, "RoomNumber", true));
            roomNumberText.Location = new Point(182, 13);
            roomNumberText.Name = "roomNumberText";
            roomNumberText.Size = new Size(167, 27);
            roomNumberText.TabIndex = 6;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(DataAccessLibrary.Models.Room);
            // 
            // bathNumberText
            // 
            bathNumberText.DataBindings.Add(new Binding("Text", roomBindingSource, "BathNumber", true));
            bathNumberText.Location = new Point(182, 125);
            bathNumberText.Name = "bathNumberText";
            bathNumberText.Size = new Size(167, 27);
            bathNumberText.TabIndex = 9;
            // 
            // floorText
            // 
            floorText.DataBindings.Add(new Binding("Text", roomBindingSource, "Floor", true));
            floorText.Location = new Point(182, 52);
            floorText.Name = "floorText";
            floorText.Size = new Size(167, 27);
            floorText.TabIndex = 11;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Font = new Font("Segoe UI", 12F);
            saveButton.Location = new Point(415, 200);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(133, 37);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Font = new Font("Segoe UI", 12F);
            cancelButton.Location = new Point(554, 200);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // bedNumberText
            // 
            bedNumberText.DataBindings.Add(new Binding("Text", roomBindingSource, "BedNumber", true));
            bedNumberText.Location = new Point(182, 88);
            bedNumberText.Name = "bedNumberText";
            bedNumberText.Size = new Size(167, 27);
            bedNumberText.TabIndex = 14;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.DataBindings.Add(new Binding("SelectedItem", roomBindingSource, "RoomTypeCategory", true));
            roomTypeComboBox.DataSource = typeCatgoryBindingSource;
            roomTypeComboBox.DisplayMember = "Description";
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.Location = new Point(210, 161);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.Size = new Size(141, 28);
            roomTypeComboBox.TabIndex = 15;
            roomTypeComboBox.ValueMember = "id";
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // typeCatgoryBindingSource
            // 
            typeCatgoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // RoomCrudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 249);
            ControlBox = false;
            Controls.Add(roomTypeComboBox);
            Controls.Add(bedNumberText);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(floorText);
            Controls.Add(bathNumberText);
            Controls.Add(roomNumberText);
            Controls.Add(roomTypeLabel);
            Controls.Add(bathNumberLabel);
            Controls.Add(bedNumberLabel);
            Controls.Add(floorLabel);
            Controls.Add(roomNumberLabel);
            Name = "RoomCrudForm";
            Text = "RoomCrudForm";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeCatgoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomNumberLabel;
        private Label floorLabel;
        private Label bedNumberLabel;
        private Label roomTypeLabel;
        private Label bathNumberLabel;
        private TextBox roomNumberText;
        private TextBox bathNumberText;
        private TextBox floorText;
        private Button saveButton;
        private Button cancelButton;
        private BindingSource roomBindingSource;
        private TextBox bedNumberText;
        private ComboBox roomTypeComboBox;
        private BindingSource typeCatgoryBindingSource;
    }
}