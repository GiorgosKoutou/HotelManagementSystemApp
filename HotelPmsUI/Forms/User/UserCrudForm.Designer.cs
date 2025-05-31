namespace HotelPmsUI.Forms.User
{
    partial class UserCrudForm
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
            passwordLabel = new Label();
            fullNameLabel = new Label();
            userRole = new Label();
            userNameText = new TextBox();
            userBindingSource = new BindingSource(components);
            passwordText = new TextBox();
            fullNameText = new TextBox();
            userRoleBox = new ComboBox();
            userRoleBindingSource = new BindingSource(components);
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(31, 9);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(108, 28);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(31, 50);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(102, 28);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password: ";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(31, 95);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(109, 28);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name: ";
            // 
            // userRole
            // 
            userRole.AutoSize = true;
            userRole.Location = new Point(31, 138);
            userRole.Name = "userRole";
            userRole.Size = new Size(103, 28);
            userRole.TabIndex = 3;
            userRole.Text = "User Role: ";
            userRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userNameText
            // 
            userNameText.DataBindings.Add(new Binding("Text", userBindingSource, "UserName", true));
            userNameText.Location = new Point(139, 6);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(180, 34);
            userNameText.TabIndex = 4;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(DataAccessLibrary.Models.User);
            // 
            // passwordText
            // 
            passwordText.DataBindings.Add(new Binding("Text", userBindingSource, "Password", true));
            passwordText.Location = new Point(139, 47);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(180, 34);
            passwordText.TabIndex = 5;
            // 
            // fullNameText
            // 
            fullNameText.DataBindings.Add(new Binding("Text", userBindingSource, "FullName", true));
            fullNameText.Location = new Point(139, 92);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(180, 34);
            fullNameText.TabIndex = 6;
            // 
            // userRoleBox
            // 
            userRoleBox.DataBindings.Add(new Binding("SelectedItem", userBindingSource, "UserRole", true));
            userRoleBox.DataSource = userRoleBindingSource;
            userRoleBox.DisplayMember = "Description";
            userRoleBox.FormattingEnabled = true;
            userRoleBox.Location = new Point(140, 138);
            userRoleBox.Name = "userRoleBox";
            userRoleBox.Size = new Size(179, 36);
            userRoleBox.TabIndex = 7;
            userRoleBox.ValueMember = "id";
            // 
            // userRoleBindingSource
            // 
            userRoleBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(398, 185);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(133, 37);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(537, 185);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // UserCrudForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 234);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(userRoleBox);
            Controls.Add(fullNameText);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Controls.Add(userRole);
            Controls.Add(fullNameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UserCrudForm";
            Text = "UserCrudForm";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private Label fullNameLabel;
        private Label userRole;
        private TextBox userNameText;
        private BindingSource userBindingSource;
        private TextBox passwordText;
        private TextBox fullNameText;
        private ComboBox userRoleBox;
        private BindingSource userRoleBindingSource;
        private Button saveButton;
        private Button cancelButton;
    }
}