namespace HotelPmsUI.Forms.Staff
{
    partial class StaffCrudForm
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            specialtyLabel = new Label();
            firstNameText = new TextBox();
            staffBindingSource = new BindingSource(components);
            lastNameText = new TextBox();
            specialtyComboBox = new ComboBox();
            typeCategoryBindingSource = new BindingSource(components);
            cancelButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(16, 13);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(110, 28);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(16, 65);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 28);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name: ";
            // 
            // specialtyLabel
            // 
            specialtyLabel.AutoSize = true;
            specialtyLabel.Location = new Point(16, 120);
            specialtyLabel.Margin = new Padding(4, 0, 4, 0);
            specialtyLabel.Name = "specialtyLabel";
            specialtyLabel.Size = new Size(100, 28);
            specialtyLabel.TabIndex = 2;
            specialtyLabel.Text = "Specialty: ";
            // 
            // firstNameText
            // 
            firstNameText.DataBindings.Add(new Binding("Text", staffBindingSource, "FirstName", true));
            firstNameText.Location = new Point(133, 10);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(255, 34);
            firstNameText.TabIndex = 3;
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataSource = typeof(DataAccessLibrary.Models.Staff);
            // 
            // lastNameText
            // 
            lastNameText.DataBindings.Add(new Binding("Text", staffBindingSource, "LastName", true));
            lastNameText.Location = new Point(133, 62);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(255, 34);
            lastNameText.TabIndex = 4;
            // 
            // specialtyComboBox
            // 
            specialtyComboBox.DataBindings.Add(new Binding("SelectedItem", staffBindingSource, "Specialty", true));
            specialtyComboBox.DataSource = typeCategoryBindingSource;
            specialtyComboBox.DisplayMember = "Description";
            specialtyComboBox.FormattingEnabled = true;
            specialtyComboBox.Location = new Point(133, 117);
            specialtyComboBox.Name = "specialtyComboBox";
            specialtyComboBox.Size = new Size(255, 36);
            specialtyComboBox.TabIndex = 5;
            specialtyComboBox.ValueMember = "id";
            // 
            // typeCategoryBindingSource
            // 
            typeCategoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(637, 159);
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
            saveButton.Location = new Point(488, 159);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(145, 37);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // StaffCrudForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 207);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(specialtyComboBox);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(specialtyLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "StaffCrudForm";
            Text = "StaffCrudForm";
            Load += StaffCrudForm_Load;
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label specialtyLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private ComboBox specialtyComboBox;
        private Button cancelButton;
        private Button saveButton;
        private BindingSource staffBindingSource;
        private BindingSource typeCategoryBindingSource;
    }
}