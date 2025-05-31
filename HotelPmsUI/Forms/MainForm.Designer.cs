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
            backroundPanel = new Panel();
            centerPanel = new Panel();
            topPanel = new Panel();
            logoutButton = new Button();
            welcomeLabel = new Label();
            buttonPanel = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            newButton = new Button();
            menuPanel = new Panel();
            staffButton = new Button();
            categoriesPanel = new Panel();
            categoriesButton = new Button();
            userCategoryButton = new Button();
            roomCategoriesButton = new Button();
            specialtyCategoriesButton = new Button();
            subTitlePanel = new Panel();
            imageTitleContainer = new SplitContainer();
            titleLabel = new Label();
            userButton = new Button();
            roomButton = new Button();
            customerButton = new Button();
            backroundPanel.SuspendLayout();
            topPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            categoriesPanel.SuspendLayout();
            subTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageTitleContainer).BeginInit();
            imageTitleContainer.Panel2.SuspendLayout();
            imageTitleContainer.SuspendLayout();
            SuspendLayout();
            // 
            // backroundPanel
            // 
            backroundPanel.Controls.Add(centerPanel);
            backroundPanel.Controls.Add(topPanel);
            backroundPanel.Controls.Add(buttonPanel);
            backroundPanel.Controls.Add(menuPanel);
            backroundPanel.Dock = DockStyle.Fill;
            backroundPanel.Location = new Point(0, 0);
            backroundPanel.Name = "backroundPanel";
            backroundPanel.Size = new Size(1003, 699);
            backroundPanel.TabIndex = 1;
            // 
            // centerPanel
            // 
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(198, 103);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(805, 531);
            centerPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Silver;
            topPanel.Controls.Add(logoutButton);
            topPanel.Controls.Add(welcomeLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(198, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(805, 103);
            topPanel.TabIndex = 2;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.Image = Properties.Resources.logout;
            logoutButton.Location = new Point(643, 22);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(150, 45);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "LogOut";
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(18, 21);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(157, 41);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome: ";
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.Silver;
            buttonPanel.Controls.Add(deleteButton);
            buttonPanel.Controls.Add(editButton);
            buttonPanel.Controls.Add(newButton);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(198, 634);
            buttonPanel.Margin = new Padding(10);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(805, 65);
            buttonPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Dock = DockStyle.Left;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Image = Properties.Resources.delete;
            deleteButton.Location = new Point(246, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(123, 65);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Dock = DockStyle.Left;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.Image = Properties.Resources.edit;
            editButton.Location = new Point(123, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(123, 65);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // newButton
            // 
            newButton.AutoSize = true;
            newButton.Dock = DockStyle.Left;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newButton.Image = Properties.Resources._new;
            newButton.Location = new Point(0, 0);
            newButton.Name = "newButton";
            newButton.Size = new Size(123, 65);
            newButton.TabIndex = 0;
            newButton.Text = "New";
            newButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Silver;
            menuPanel.Controls.Add(staffButton);
            menuPanel.Controls.Add(categoriesPanel);
            menuPanel.Controls.Add(subTitlePanel);
            menuPanel.Controls.Add(userButton);
            menuPanel.Controls.Add(roomButton);
            menuPanel.Controls.Add(customerButton);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(198, 699);
            menuPanel.TabIndex = 1;
            // 
            // staffButton
            // 
            staffButton.FlatAppearance.BorderSize = 0;
            staffButton.FlatStyle = FlatStyle.Flat;
            staffButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffButton.Image = Properties.Resources.staff;
            staffButton.ImageAlign = ContentAlignment.MiddleLeft;
            staffButton.Location = new Point(12, 379);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(176, 41);
            staffButton.TabIndex = 8;
            staffButton.Text = "Staff";
            staffButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            staffButton.UseVisualStyleBackColor = true;
            staffButton.Click += staffButton_Click;
            // 
            // categoriesPanel
            // 
            categoriesPanel.Controls.Add(categoriesButton);
            categoriesPanel.Controls.Add(userCategoryButton);
            categoriesPanel.Controls.Add(roomCategoriesButton);
            categoriesPanel.Controls.Add(specialtyCategoriesButton);
            categoriesPanel.Dock = DockStyle.Bottom;
            categoriesPanel.Location = new Point(0, 502);
            categoriesPanel.Name = "categoriesPanel";
            categoriesPanel.Size = new Size(198, 197);
            categoriesPanel.TabIndex = 7;
            // 
            // categoriesButton
            // 
            categoriesButton.FlatAppearance.BorderSize = 0;
            categoriesButton.FlatStyle = FlatStyle.Flat;
            categoriesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoriesButton.Image = Properties.Resources.categories;
            categoriesButton.Location = new Point(3, 3);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Size = new Size(164, 48);
            categoriesButton.TabIndex = 6;
            categoriesButton.Text = "Categories";
            categoriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            categoriesButton.UseVisualStyleBackColor = true;
            categoriesButton.Click += categoriesButton_Click;
            // 
            // userCategoryButton
            // 
            userCategoryButton.FlatAppearance.BorderSize = 0;
            userCategoryButton.FlatStyle = FlatStyle.Flat;
            userCategoryButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userCategoryButton.Image = Properties.Resources.user_categories;
            userCategoryButton.Location = new Point(33, 57);
            userCategoryButton.Name = "userCategoryButton";
            userCategoryButton.Size = new Size(217, 41);
            userCategoryButton.TabIndex = 1;
            userCategoryButton.Text = "User Categories";
            userCategoryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            userCategoryButton.UseVisualStyleBackColor = true;
            userCategoryButton.Click += userCategoryButton_Click;
            // 
            // roomCategoriesButton
            // 
            roomCategoriesButton.FlatAppearance.BorderSize = 0;
            roomCategoriesButton.FlatStyle = FlatStyle.Flat;
            roomCategoriesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomCategoriesButton.Image = Properties.Resources._categories;
            roomCategoriesButton.Location = new Point(33, 104);
            roomCategoriesButton.Name = "roomCategoriesButton";
            roomCategoriesButton.Size = new Size(229, 41);
            roomCategoriesButton.TabIndex = 3;
            roomCategoriesButton.Text = "Room Categories";
            roomCategoriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            roomCategoriesButton.UseVisualStyleBackColor = true;
            roomCategoriesButton.Click += roomCategoriesButton_Click;
            // 
            // specialtyCategoriesButton
            // 
            specialtyCategoriesButton.FlatAppearance.BorderSize = 0;
            specialtyCategoriesButton.FlatStyle = FlatStyle.Flat;
            specialtyCategoriesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialtyCategoriesButton.Image = Properties.Resources.specialty_categories;
            specialtyCategoriesButton.Location = new Point(33, 153);
            specialtyCategoriesButton.Name = "specialtyCategoriesButton";
            specialtyCategoriesButton.Size = new Size(264, 41);
            specialtyCategoriesButton.TabIndex = 7;
            specialtyCategoriesButton.Text = "Specialty Categories";
            specialtyCategoriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            specialtyCategoriesButton.UseVisualStyleBackColor = true;
            specialtyCategoriesButton.Click += specialtyCategoriesButton_Click;
            // 
            // subTitlePanel
            // 
            subTitlePanel.Controls.Add(imageTitleContainer);
            subTitlePanel.Dock = DockStyle.Top;
            subTitlePanel.Location = new Point(0, 0);
            subTitlePanel.Name = "subTitlePanel";
            subTitlePanel.Size = new Size(198, 135);
            subTitlePanel.TabIndex = 5;
            // 
            // imageTitleContainer
            // 
            imageTitleContainer.Dock = DockStyle.Fill;
            imageTitleContainer.Location = new Point(0, 0);
            imageTitleContainer.Name = "imageTitleContainer";
            // 
            // imageTitleContainer.Panel1
            // 
            imageTitleContainer.Panel1.BackgroundImage = Properties.Resources.hotel_2;
            imageTitleContainer.Panel1.BackgroundImageLayout = ImageLayout.Center;
            // 
            // imageTitleContainer.Panel2
            // 
            imageTitleContainer.Panel2.Controls.Add(titleLabel);
            imageTitleContainer.Size = new Size(198, 135);
            imageTitleContainer.SplitterDistance = 56;
            imageTitleContainer.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AllowDrop = true;
            titleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(140, 142);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Hotel Managment System";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userButton
            // 
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userButton.Image = Properties.Resources.users;
            userButton.ImageAlign = ContentAlignment.MiddleLeft;
            userButton.Location = new Point(12, 309);
            userButton.Name = "userButton";
            userButton.Size = new Size(176, 41);
            userButton.TabIndex = 4;
            userButton.Text = "Users";
            userButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += userButton_Click;
            // 
            // roomButton
            // 
            roomButton.FlatAppearance.BorderSize = 0;
            roomButton.FlatStyle = FlatStyle.Flat;
            roomButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomButton.Image = Properties.Resources.rooms;
            roomButton.ImageAlign = ContentAlignment.MiddleLeft;
            roomButton.Location = new Point(12, 242);
            roomButton.Name = "roomButton";
            roomButton.Size = new Size(176, 41);
            roomButton.TabIndex = 2;
            roomButton.Text = "Rooms";
            roomButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            roomButton.UseVisualStyleBackColor = true;
            roomButton.Click += roomButton_Click;
            // 
            // customerButton
            // 
            customerButton.AutoSize = true;
            customerButton.BackColor = Color.Silver;
            customerButton.FlatAppearance.BorderSize = 0;
            customerButton.FlatStyle = FlatStyle.Flat;
            customerButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerButton.Image = Properties.Resources.customers;
            customerButton.ImageAlign = ContentAlignment.MiddleLeft;
            customerButton.Location = new Point(3, 175);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(185, 49);
            customerButton.TabIndex = 0;
            customerButton.Text = "Customers";
            customerButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            customerButton.UseVisualStyleBackColor = false;
            customerButton.Click += customerButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 699);
            Controls.Add(backroundPanel);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            backroundPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            buttonPanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            categoriesPanel.ResumeLayout(false);
            subTitlePanel.ResumeLayout(false);
            imageTitleContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageTitleContainer).EndInit();
            imageTitleContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button1_(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel backroundPanel;
        private Panel centerPanel;
        private Panel buttonPanel;
        private Button deleteButton;
        private Button editButton;
        private Button newButton;
        private Panel topPanel;
        private Button logoutButton;
        private Label welcomeLabel;
        private Panel menuPanel;
        private Button staffButton;
        private Panel categoriesPanel;
        private Button categoriesButton;
        private Button userCategoryButton;
        private Button roomCategoriesButton;
        private Panel subTitlePanel;
        private SplitContainer imageTitleContainer;
        private Label titleLabel;
        private Button userButton;
        private Button roomButton;
        private Button customerButton;
        private Button specialtyCategoriesButton;
    }
}
