namespace HotelPmsUI.Forms.Customer
{
    partial class CustomerFilterForm
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
            firstnameFromLabel = new Label();
            firstnameToLabel = new Label();
            lastnameLabel = new Label();
            tinLabel = new Label();
            tinText = new TextBox();
            lastnameText = new TextBox();
            firstnameToText = new TextBox();
            firstnameFromText = new TextBox();
            clearButton = new Button();
            searchButton = new Button();
            cancelButton = new Button();
            firstNameLabel = new Label();
            firstNameText = new TextBox();
            firstNameRangeButton = new CheckBox();
            SuspendLayout();
            // 
            // firstnameFromLabel
            // 
            firstnameFromLabel.AutoSize = true;
            firstnameFromLabel.Location = new Point(16, 74);
            firstnameFromLabel.Margin = new Padding(4, 0, 4, 0);
            firstnameFromLabel.Name = "firstnameFromLabel";
            firstnameFromLabel.Size = new Size(106, 28);
            firstnameFromLabel.TabIndex = 0;
            firstnameFromLabel.Text = "Firstname: ";
            // 
            // firstnameToLabel
            // 
            firstnameToLabel.AutoSize = true;
            firstnameToLabel.Location = new Point(350, 74);
            firstnameToLabel.Margin = new Padding(4, 0, 4, 0);
            firstnameToLabel.Name = "firstnameToLabel";
            firstnameToLabel.Size = new Size(20, 28);
            firstnameToLabel.TabIndex = 1;
            firstnameToLabel.Text = "-";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(16, 129);
            lastnameLabel.Margin = new Padding(4, 0, 4, 0);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(98, 28);
            lastnameLabel.TabIndex = 2;
            lastnameLabel.Text = "Lastname:";
            // 
            // tinLabel
            // 
            tinLabel.AutoSize = true;
            tinLabel.Location = new Point(13, 197);
            tinLabel.Margin = new Padding(4, 0, 4, 0);
            tinLabel.Name = "tinLabel";
            tinLabel.Size = new Size(255, 28);
            tinLabel.TabIndex = 3;
            tinLabel.Text = "Tax Identificational Number:";
            // 
            // tinText
            // 
            tinText.Location = new Point(275, 194);
            tinText.Name = "tinText";
            tinText.Size = new Size(218, 34);
            tinText.TabIndex = 4;
            // 
            // lastnameText
            // 
            lastnameText.Location = new Point(125, 126);
            lastnameText.Name = "lastnameText";
            lastnameText.Size = new Size(218, 34);
            lastnameText.TabIndex = 5;
            // 
            // firstnameToText
            // 
            firstnameToText.Location = new Point(377, 71);
            firstnameToText.Name = "firstnameToText";
            firstnameToText.Size = new Size(231, 34);
            firstnameToText.TabIndex = 6;
            // 
            // firstnameFromText
            // 
            firstnameFromText.Location = new Point(125, 71);
            firstnameFromText.Name = "firstnameFromText";
            firstnameFromText.Size = new Size(218, 34);
            firstnameFromText.TabIndex = 7;
            // 
            // clearButton
            // 
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Image = Properties.Resources.clear_filters;
            clearButton.Location = new Point(673, 13);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(47, 31);
            clearButton.TabIndex = 8;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.Image = Properties.Resources.serach;
            searchButton.Location = new Point(537, 289);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(138, 38);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(681, 289);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(106, 35);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(16, 16);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(106, 28);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "Firstname: ";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(125, 13);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(218, 34);
            firstNameText.TabIndex = 13;
            // 
            // firstNameRangeButton
            // 
            firstNameRangeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            firstNameRangeButton.AutoSize = true;
            firstNameRangeButton.Location = new Point(631, 74);
            firstNameRangeButton.Name = "firstNameRangeButton";
            firstNameRangeButton.Size = new Size(89, 32);
            firstNameRangeButton.TabIndex = 14;
            firstNameRangeButton.Text = "Range";
            firstNameRangeButton.UseVisualStyleBackColor = true;
            firstNameRangeButton.CheckedChanged += firstNameRangeButton_CheckedChanged;
            // 
            // CustomerFilterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 339);
            ControlBox = false;
            Controls.Add(firstNameRangeButton);
            Controls.Add(firstNameText);
            Controls.Add(firstNameLabel);
            Controls.Add(cancelButton);
            Controls.Add(searchButton);
            Controls.Add(clearButton);
            Controls.Add(firstnameFromText);
            Controls.Add(firstnameToText);
            Controls.Add(lastnameText);
            Controls.Add(tinText);
            Controls.Add(tinLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(firstnameToLabel);
            Controls.Add(firstnameFromLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerFilterForm";
            Text = "CustomerFilterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstnameFromLabel;
        private Label firstnameToLabel;
        private Label lastnameLabel;
        private Label tinLabel;
        private TextBox tinText;
        private TextBox lastnameText;
        private TextBox firstnameToText;
        private TextBox firstnameFromText;
        private Button clearButton;
        private Button searchButton;
        private Button cancelButton;
        private Label firstNameLabel;
        private TextBox firstNameText;
        private CheckBox firstNameRangeButton;
    }
}