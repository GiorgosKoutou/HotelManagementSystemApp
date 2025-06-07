namespace HotelPmsUI.Forms.User
{
    partial class UserFilterForm
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
            userNameLabel = new Label();
            userRoleLabel = new Label();
            fullNameLabel = new Label();
            clearButton = new Button();
            cancelButton = new Button();
            searchButton = new Button();
            userNameText = new TextBox();
            fullNameText = new TextBox();
            userRoleComboBox = new ComboBox();
            typeCategoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(12, 13);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(108, 28);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username: ";
            // 
            // userRoleLabel
            // 
            userRoleLabel.AutoSize = true;
            userRoleLabel.Location = new Point(12, 94);
            userRoleLabel.Name = "userRoleLabel";
            userRoleLabel.Size = new Size(98, 28);
            userRoleLabel.TabIndex = 1;
            userRoleLabel.Text = "UserRole: ";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(12, 53);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(100, 28);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Fullname: ";
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Image = Properties.Resources.clear_filters;
            clearButton.Location = new Point(565, 12);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(47, 31);
            clearButton.TabIndex = 16;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(513, 125);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(106, 35);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.Image = Properties.Resources.serach;
            searchButton.Location = new Point(369, 125);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(138, 38);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // userNameText
            // 
            userNameText.Location = new Point(126, 10);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(189, 34);
            userNameText.TabIndex = 17;
            // 
            // fullNameText
            // 
            fullNameText.Location = new Point(126, 50);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(189, 34);
            fullNameText.TabIndex = 18;
            // 
            // userRoleComboBox
            // 
            userRoleComboBox.DataSource = typeCategoryBindingSource;
            userRoleComboBox.DisplayMember = "Description";
            userRoleComboBox.FormattingEnabled = true;
            userRoleComboBox.Location = new Point(126, 91);
            userRoleComboBox.Name = "userRoleComboBox";
            userRoleComboBox.Size = new Size(188, 36);
            userRoleComboBox.TabIndex = 19;
            userRoleComboBox.ValueMember = "Description";
            // 
            // typeCategoryBindingSource
            // 
            typeCategoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // UserFilterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 175);
            Controls.Add(userRoleComboBox);
            Controls.Add(fullNameText);
            Controls.Add(userNameText);
            Controls.Add(clearButton);
            Controls.Add(cancelButton);
            Controls.Add(searchButton);
            Controls.Add(fullNameLabel);
            Controls.Add(userRoleLabel);
            Controls.Add(userNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UserFilterForm";
            Text = "UserFilterForm";
            ((System.ComponentModel.ISupportInitialize)typeCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label userRoleLabel;
        private Label fullNameLabel;
        private Button clearButton;
        private Button cancelButton;
        private Button searchButton;
        private TextBox userNameText;
        private TextBox fullNameText;
        private ComboBox userRoleComboBox;
        private BindingSource typeCategoryBindingSource;
    }
}