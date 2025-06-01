namespace HotelPmsUI.Forms
{
    partial class LoginForm
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
            loginButton = new Button();
            userNameLabel = new Label();
            passwordLabel = new Label();
            usernameText = new TextBox();
            passwordText = new TextBox();
            topPanel = new Panel();
            exitButton = new Button();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(289, 169);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(125, 37);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(139, 53);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(103, 28);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(139, 107);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(102, 28);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password: ";
            // 
            // usernameText
            // 
            usernameText.Location = new Point(248, 50);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(234, 34);
            usernameText.TabIndex = 3;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(247, 104);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(234, 34);
            passwordText.TabIndex = 4;
            passwordText.KeyDown += passwordText_KeyDown;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Silver;
            topPanel.Controls.Add(exitButton);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(645, 33);
            topPanel.TabIndex = 5;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(602, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(40, 28);
            exitButton.TabIndex = 0;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 249);
            ControlBox = false;
            Controls.Add(topPanel);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(loginButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowInTaskbar = false;
            Text = "LoginForm";
            Load += LoginForm_Load;
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox usernameText;
        private TextBox passwordText;
        private Panel topPanel;
        private Button exitButton;
    }
}