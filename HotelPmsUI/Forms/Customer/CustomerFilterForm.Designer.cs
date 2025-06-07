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
            firstNameRangeCheckBox = new CheckBox();
            lastnameFromLabel = new Label();
            lastnameToLabel = new Label();
            tinToLabel = new Label();
            tinFromLabel = new Label();
            lastnameFromText = new TextBox();
            lastnameToText = new TextBox();
            tinFromText = new TextBox();
            tinToText = new TextBox();
            tinRangeCheckBox = new CheckBox();
            lastnameRangeCheckBox = new CheckBox();
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
            tinLabel.Location = new Point(16, 232);
            tinLabel.Margin = new Padding(4, 0, 4, 0);
            tinLabel.Name = "tinLabel";
            tinLabel.Size = new Size(255, 28);
            tinLabel.TabIndex = 3;
            tinLabel.Text = "Tax Identificational Number:";
            // 
            // tinText
            // 
            tinText.Location = new Point(278, 229);
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
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.Image = Properties.Resources.clear_filters;
            clearButton.Location = new Point(978, 12);
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
            searchButton.Location = new Point(775, 347);
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
            cancelButton.Location = new Point(919, 347);
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
            // firstNameRangeCheckBox
            // 
            firstNameRangeCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            firstNameRangeCheckBox.AutoSize = true;
            firstNameRangeCheckBox.Location = new Point(936, 73);
            firstNameRangeCheckBox.Name = "firstNameRangeCheckBox";
            firstNameRangeCheckBox.Size = new Size(89, 32);
            firstNameRangeCheckBox.TabIndex = 14;
            firstNameRangeCheckBox.Text = "Range";
            firstNameRangeCheckBox.UseVisualStyleBackColor = true;
            firstNameRangeCheckBox.CheckedChanged += firstNameRangeButton_CheckedChanged;
            // 
            // lastnameFromLabel
            // 
            lastnameFromLabel.AutoSize = true;
            lastnameFromLabel.Location = new Point(19, 182);
            lastnameFromLabel.Name = "lastnameFromLabel";
            lastnameFromLabel.Size = new Size(103, 28);
            lastnameFromLabel.TabIndex = 15;
            lastnameFromLabel.Text = "Lastname: ";
            // 
            // lastnameToLabel
            // 
            lastnameToLabel.AutoSize = true;
            lastnameToLabel.Location = new Point(349, 182);
            lastnameToLabel.Name = "lastnameToLabel";
            lastnameToLabel.Size = new Size(20, 28);
            lastnameToLabel.TabIndex = 16;
            lastnameToLabel.Text = "-";
            // 
            // tinToLabel
            // 
            tinToLabel.AutoSize = true;
            tinToLabel.Location = new Point(502, 284);
            tinToLabel.Name = "tinToLabel";
            tinToLabel.Size = new Size(20, 28);
            tinToLabel.TabIndex = 17;
            tinToLabel.Text = "-";
            // 
            // tinFromLabel
            // 
            tinFromLabel.AutoSize = true;
            tinFromLabel.Location = new Point(19, 284);
            tinFromLabel.Name = "tinFromLabel";
            tinFromLabel.Size = new Size(260, 28);
            tinFromLabel.TabIndex = 18;
            tinFromLabel.Text = "Tax Identificational Number: ";
            // 
            // lastnameFromText
            // 
            lastnameFromText.Location = new Point(125, 179);
            lastnameFromText.Name = "lastnameFromText";
            lastnameFromText.Size = new Size(218, 34);
            lastnameFromText.TabIndex = 19;
            // 
            // lastnameToText
            // 
            lastnameToText.Location = new Point(375, 179);
            lastnameToText.Name = "lastnameToText";
            lastnameToText.Size = new Size(218, 34);
            lastnameToText.TabIndex = 20;
            // 
            // tinFromText
            // 
            tinFromText.Location = new Point(278, 281);
            tinFromText.Name = "tinFromText";
            tinFromText.Size = new Size(218, 34);
            tinFromText.TabIndex = 21;
            // 
            // tinToText
            // 
            tinToText.Location = new Point(528, 281);
            tinToText.Name = "tinToText";
            tinToText.Size = new Size(218, 34);
            tinToText.TabIndex = 22;
            // 
            // tinRangeCheckBox
            // 
            tinRangeCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tinRangeCheckBox.AutoSize = true;
            tinRangeCheckBox.Location = new Point(936, 280);
            tinRangeCheckBox.Name = "tinRangeCheckBox";
            tinRangeCheckBox.Size = new Size(89, 32);
            tinRangeCheckBox.TabIndex = 23;
            tinRangeCheckBox.Text = "Range";
            tinRangeCheckBox.UseVisualStyleBackColor = true;
            tinRangeCheckBox.CheckedChanged += tinRangeCheckBox_CheckedChanged;
            // 
            // lastnameRangeCheckBox
            // 
            lastnameRangeCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lastnameRangeCheckBox.AutoSize = true;
            lastnameRangeCheckBox.Location = new Point(936, 181);
            lastnameRangeCheckBox.Name = "lastnameRangeCheckBox";
            lastnameRangeCheckBox.Size = new Size(89, 32);
            lastnameRangeCheckBox.TabIndex = 24;
            lastnameRangeCheckBox.Text = "Range";
            lastnameRangeCheckBox.UseVisualStyleBackColor = true;
            lastnameRangeCheckBox.CheckedChanged += lastnameCheckBox_CheckedChanged;
            // 
            // CustomerFilterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 397);
            ControlBox = false;
            Controls.Add(lastnameRangeCheckBox);
            Controls.Add(tinRangeCheckBox);
            Controls.Add(tinToText);
            Controls.Add(tinFromText);
            Controls.Add(lastnameToText);
            Controls.Add(lastnameFromText);
            Controls.Add(tinFromLabel);
            Controls.Add(tinToLabel);
            Controls.Add(lastnameToLabel);
            Controls.Add(lastnameFromLabel);
            Controls.Add(firstNameRangeCheckBox);
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
        private CheckBox firstNameRangeCheckBox;
        private Label lastnameFromLabel;
        private Label lastnameToLabel;
        private Label tinToLabel;
        private Label tinFromLabel;
        private TextBox lastnameFromText;
        private TextBox lastnameToText;
        private TextBox tinFromText;
        private TextBox tinToText;
        private CheckBox tinRangeCheckBox;
        private CheckBox lastnameRangeCheckBox;
    }
}