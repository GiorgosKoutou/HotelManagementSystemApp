namespace HotelPmsUI.Forms.Staff
{
    partial class StaffFilterForm
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
            firstNameFromLabel = new Label();
            firstNameToLabel = new Label();
            lastnameFromLabel = new Label();
            lastnameToLabel = new Label();
            specialtyLabel = new Label();
            firstnameRangeCheckBox = new CheckBox();
            lastnameRangeCheckBox = new CheckBox();
            specialtyComboBox = new ComboBox();
            typeCategoryBindingSource = new BindingSource(components);
            firstnameText = new TextBox();
            firstnameFromText = new TextBox();
            firstnameToText = new TextBox();
            lastnameText = new TextBox();
            lastnameFromText = new TextBox();
            lastnameToText = new TextBox();
            clearButton = new Button();
            cancelButton = new Button();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(106, 28);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Firstname: ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 118);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(103, 28);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Lastname: ";
            // 
            // firstNameFromLabel
            // 
            firstNameFromLabel.AutoSize = true;
            firstNameFromLabel.Location = new Point(12, 60);
            firstNameFromLabel.Name = "firstNameFromLabel";
            firstNameFromLabel.Size = new Size(101, 28);
            firstNameFromLabel.TabIndex = 2;
            firstNameFromLabel.Text = "Firstname:";
            // 
            // firstNameToLabel
            // 
            firstNameToLabel.AutoSize = true;
            firstNameToLabel.Location = new Point(307, 60);
            firstNameToLabel.Name = "firstNameToLabel";
            firstNameToLabel.Size = new Size(20, 28);
            firstNameToLabel.TabIndex = 2;
            firstNameToLabel.Text = "-";
            // 
            // lastnameFromLabel
            // 
            lastnameFromLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lastnameFromLabel.AutoSize = true;
            lastnameFromLabel.Location = new Point(12, 169);
            lastnameFromLabel.Name = "lastnameFromLabel";
            lastnameFromLabel.Size = new Size(103, 28);
            lastnameFromLabel.TabIndex = 3;
            lastnameFromLabel.Text = "Lastname: ";
            // 
            // lastnameToLabel
            // 
            lastnameToLabel.AutoSize = true;
            lastnameToLabel.Location = new Point(307, 169);
            lastnameToLabel.Name = "lastnameToLabel";
            lastnameToLabel.Size = new Size(20, 28);
            lastnameToLabel.TabIndex = 4;
            lastnameToLabel.Text = "-";
            // 
            // specialtyLabel
            // 
            specialtyLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            specialtyLabel.AutoSize = true;
            specialtyLabel.Location = new Point(12, 236);
            specialtyLabel.Name = "specialtyLabel";
            specialtyLabel.Size = new Size(100, 28);
            specialtyLabel.TabIndex = 5;
            specialtyLabel.Text = "Specialty: ";
            // 
            // firstnameRangeCheckBox
            // 
            firstnameRangeCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            firstnameRangeCheckBox.AutoSize = true;
            firstnameRangeCheckBox.Location = new Point(598, 56);
            firstnameRangeCheckBox.Name = "firstnameRangeCheckBox";
            firstnameRangeCheckBox.Size = new Size(89, 32);
            firstnameRangeCheckBox.TabIndex = 6;
            firstnameRangeCheckBox.Text = "Range";
            firstnameRangeCheckBox.UseVisualStyleBackColor = true;
            firstnameRangeCheckBox.CheckedChanged += firstnameRangeCheckBox_CheckedChanged;
            // 
            // lastnameRangeCheckBox
            // 
            lastnameRangeCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lastnameRangeCheckBox.AutoSize = true;
            lastnameRangeCheckBox.Location = new Point(598, 165);
            lastnameRangeCheckBox.Name = "lastnameRangeCheckBox";
            lastnameRangeCheckBox.Size = new Size(89, 32);
            lastnameRangeCheckBox.TabIndex = 7;
            lastnameRangeCheckBox.Text = "Range";
            lastnameRangeCheckBox.UseVisualStyleBackColor = true;
            lastnameRangeCheckBox.CheckedChanged += lastnameRangeCheckBox_CheckedChanged;
            // 
            // specialtyComboBox
            // 
            specialtyComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            specialtyComboBox.DataSource = typeCategoryBindingSource;
            specialtyComboBox.DisplayMember = "Description";
            specialtyComboBox.FormattingEnabled = true;
            specialtyComboBox.Location = new Point(118, 233);
            specialtyComboBox.Name = "specialtyComboBox";
            specialtyComboBox.Size = new Size(183, 36);
            specialtyComboBox.TabIndex = 8;
            specialtyComboBox.ValueMember = "id";
            // 
            // typeCategoryBindingSource
            // 
            typeCategoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // firstnameText
            // 
            firstnameText.Location = new Point(121, 6);
            firstnameText.Name = "firstnameText";
            firstnameText.Size = new Size(180, 34);
            firstnameText.TabIndex = 9;
            // 
            // firstnameFromText
            // 
            firstnameFromText.Location = new Point(121, 57);
            firstnameFromText.Name = "firstnameFromText";
            firstnameFromText.Size = new Size(180, 34);
            firstnameFromText.TabIndex = 10;
            // 
            // firstnameToText
            // 
            firstnameToText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            firstnameToText.Location = new Point(333, 57);
            firstnameToText.Name = "firstnameToText";
            firstnameToText.Size = new Size(168, 34);
            firstnameToText.TabIndex = 11;
            // 
            // lastnameText
            // 
            lastnameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lastnameText.Location = new Point(121, 115);
            lastnameText.Name = "lastnameText";
            lastnameText.Size = new Size(180, 34);
            lastnameText.TabIndex = 12;
            // 
            // lastnameFromText
            // 
            lastnameFromText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lastnameFromText.Location = new Point(121, 166);
            lastnameFromText.Name = "lastnameFromText";
            lastnameFromText.Size = new Size(180, 34);
            lastnameFromText.TabIndex = 13;
            // 
            // lastnameToText
            // 
            lastnameToText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lastnameToText.Location = new Point(333, 166);
            lastnameToText.Name = "lastnameToText";
            lastnameToText.Size = new Size(168, 34);
            lastnameToText.TabIndex = 14;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Image = Properties.Resources.clear_filters;
            clearButton.Location = new Point(643, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(47, 31);
            clearButton.TabIndex = 17;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(588, 273);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(106, 35);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.Image = Properties.Resources.serach;
            searchButton.Location = new Point(444, 273);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(138, 38);
            searchButton.TabIndex = 15;
            searchButton.Text = "Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // StaffFilterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 323);
            Controls.Add(clearButton);
            Controls.Add(cancelButton);
            Controls.Add(searchButton);
            Controls.Add(lastnameToText);
            Controls.Add(lastnameFromText);
            Controls.Add(lastnameText);
            Controls.Add(firstnameToText);
            Controls.Add(firstnameFromText);
            Controls.Add(firstnameText);
            Controls.Add(specialtyComboBox);
            Controls.Add(lastnameRangeCheckBox);
            Controls.Add(firstnameRangeCheckBox);
            Controls.Add(specialtyLabel);
            Controls.Add(lastnameToLabel);
            Controls.Add(lastnameFromLabel);
            Controls.Add(firstNameToLabel);
            Controls.Add(firstNameFromLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "StaffFilterForm";
            Text = "StaffFilterForm";
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label firstNameFromLabel;
        private Label firstNameToLabel;
        private Label lastnameFromLabel;
        private Label lastnameToLabel;
        private Label specialtyLabel;
        private CheckBox firstnameRangeCheckBox;
        private CheckBox lastnameRangeCheckBox;
        private ComboBox specialtyComboBox;
        private TextBox firstnameText;
        private TextBox firstnameFromText;
        private TextBox firstnameToText;
        private TextBox lastnameText;
        private TextBox lastnameFromText;
        private TextBox lastnameToText;
        private Button clearButton;
        private Button cancelButton;
        private Button searchButton;
        private BindingSource typeCategoryBindingSource;
    }
}