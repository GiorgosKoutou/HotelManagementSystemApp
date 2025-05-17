namespace HotelPmsUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPanel = new Panel();
            roomCategoriesButton = new Button();
            roomButton = new Button();
            categoryButton = new Button();
            customerButton = new Button();
            backroundPanel = new Panel();
            mainPanel = new Panel();
            buttonPanel = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            newButton = new Button();
            userButton = new Button();
            menuPanel.SuspendLayout();
            backroundPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(userButton);
            menuPanel.Controls.Add(roomCategoriesButton);
            menuPanel.Controls.Add(roomButton);
            menuPanel.Controls.Add(categoryButton);
            menuPanel.Controls.Add(customerButton);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(233, 507);
            menuPanel.TabIndex = 0;
            // 
            // roomCategoriesButton
            // 
            roomCategoriesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomCategoriesButton.Location = new Point(15, 214);
            roomCategoriesButton.Name = "roomCategoriesButton";
            roomCategoriesButton.Size = new Size(200, 41);
            roomCategoriesButton.TabIndex = 3;
            roomCategoriesButton.Text = "Room Categories";
            roomCategoriesButton.UseVisualStyleBackColor = true;
            roomCategoriesButton.Click += roomCategoriesButton_Click;
            // 
            // roomButton
            // 
            roomButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomButton.Location = new Point(11, 88);
            roomButton.Name = "roomButton";
            roomButton.Size = new Size(185, 41);
            roomButton.TabIndex = 2;
            roomButton.Text = "Rooms";
            roomButton.UseVisualStyleBackColor = true;
            roomButton.Click += roomButton_Click;
            // 
            // categoryButton
            // 
            categoryButton.AutoSize = true;
            categoryButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryButton.Location = new Point(15, 152);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(185, 41);
            categoryButton.TabIndex = 1;
            categoryButton.Text = "User Categories";
            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.Click += categoryButton_Click;
            // 
            // customerButton
            // 
            customerButton.AutoSize = true;
            customerButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerButton.Location = new Point(11, 20);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(185, 41);
            customerButton.TabIndex = 0;
            customerButton.Text = "Customer";
            customerButton.UseVisualStyleBackColor = true;
            customerButton.Click += customerButton_Click;
            // 
            // backroundPanel
            // 
            backroundPanel.Controls.Add(mainPanel);
            backroundPanel.Controls.Add(buttonPanel);
            backroundPanel.Dock = DockStyle.Fill;
            backroundPanel.Location = new Point(233, 0);
            backroundPanel.Name = "backroundPanel";
            backroundPanel.Size = new Size(738, 507);
            backroundPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(738, 444);
            mainPanel.TabIndex = 1;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Controls.Add(editButton);
            buttonPanel.Controls.Add(newButton);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 444);
            buttonPanel.Margin = new Padding(10);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(738, 63);
            buttonPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.AutoSize = true;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(408, 12);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 38);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.None;
            editButton.AutoSize = true;
            editButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.Location = new Point(269, 12);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 38);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.None;
            newButton.AutoSize = true;
            newButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newButton.Location = new Point(135, 12);
            newButton.Name = "newButton";
            newButton.Size = new Size(94, 38);
            newButton.TabIndex = 0;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // userButton
            // 
            userButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userButton.Location = new Point(15, 271);
            userButton.Name = "userButton";
            userButton.Size = new Size(200, 41);
            userButton.TabIndex = 4;
            userButton.Text = "Users";
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += userButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 507);
            Controls.Add(backroundPanel);
            Controls.Add(menuPanel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            backroundPanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            buttonPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void button1_(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel menuPanel;
        private Panel backroundPanel;
        private Button customerButton;
        private Panel mainPanel;
        private Panel buttonPanel;
        private Button deleteButton;
        private Button editButton;
        private Button newButton;
        private Button categoryButton;
        private Button roomButton;
        private Button roomCategoriesButton;
        private Button userButton;
    }
}
