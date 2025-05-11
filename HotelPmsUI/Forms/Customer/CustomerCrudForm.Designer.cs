namespace HotelPmsUI.Forms.Customer
{
    partial class CustomerCrudForm
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
            tinLabel = new Label();
            countryLabel = new Label();
            cityLabel = new Label();
            addressLabel = new Label();
            phoneNumberLabel = new Label();
            firstNameText = new TextBox();
            customerBindingSource = new BindingSource(components);
            lastNameText = new TextBox();
            tinText = new TextBox();
            countryText = new TextBox();
            cityText = new TextBox();
            addressText = new TextBox();
            phoneNumberText = new TextBox();
            addButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F);
            firstNameLabel.Location = new Point(26, 9);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(110, 28);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F);
            lastNameLabel.Location = new Point(26, 51);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(107, 28);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // tinLabel
            // 
            tinLabel.AutoSize = true;
            tinLabel.Font = new Font("Segoe UI", 12F);
            tinLabel.Location = new Point(26, 96);
            tinLabel.Margin = new Padding(4, 0, 4, 0);
            tinLabel.Name = "tinLabel";
            tinLabel.Size = new Size(46, 28);
            tinLabel.TabIndex = 2;
            tinLabel.Text = "TIN:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 12F);
            countryLabel.Location = new Point(26, 140);
            countryLabel.Margin = new Padding(4, 0, 4, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(86, 28);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 12F);
            cityLabel.Location = new Point(26, 180);
            cityLabel.Margin = new Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(50, 28);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F);
            addressLabel.Location = new Point(26, 224);
            addressLabel.Margin = new Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(86, 28);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI", 12F);
            phoneNumberLabel.Location = new Point(26, 269);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(148, 28);
            phoneNumberLabel.TabIndex = 6;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // firstNameText
            // 
            firstNameText.BorderStyle = BorderStyle.None;
            firstNameText.DataBindings.Add(new Binding("Text", customerBindingSource, "FirstName", true));
            firstNameText.Location = new Point(183, 9);
            firstNameText.Margin = new Padding(2);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(255, 27);
            firstNameText.TabIndex = 7;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // lastNameText
            // 
            lastNameText.BorderStyle = BorderStyle.None;
            lastNameText.DataBindings.Add(new Binding("Text", customerBindingSource, "LastName", true));
            lastNameText.Location = new Point(185, 51);
            lastNameText.Margin = new Padding(2);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(254, 27);
            lastNameText.TabIndex = 8;
            // 
            // tinText
            // 
            tinText.BorderStyle = BorderStyle.None;
            tinText.DataBindings.Add(new Binding("Text", customerBindingSource, "Tin", true));
            tinText.Location = new Point(185, 96);
            tinText.Margin = new Padding(2);
            tinText.Name = "tinText";
            tinText.Size = new Size(255, 27);
            tinText.TabIndex = 9;
            // 
            // countryText
            // 
            countryText.BorderStyle = BorderStyle.None;
            countryText.DataBindings.Add(new Binding("Text", customerBindingSource, "Country", true));
            countryText.Location = new Point(185, 140);
            countryText.Margin = new Padding(2);
            countryText.Name = "countryText";
            countryText.Size = new Size(255, 27);
            countryText.TabIndex = 10;
            // 
            // cityText
            // 
            cityText.BorderStyle = BorderStyle.None;
            cityText.DataBindings.Add(new Binding("Text", customerBindingSource, "City", true));
            cityText.Location = new Point(185, 180);
            cityText.Margin = new Padding(2);
            cityText.Name = "cityText";
            cityText.Size = new Size(254, 27);
            cityText.TabIndex = 11;
            // 
            // addressText
            // 
            addressText.BorderStyle = BorderStyle.None;
            addressText.DataBindings.Add(new Binding("Text", customerBindingSource, "Address", true));
            addressText.Location = new Point(185, 224);
            addressText.Margin = new Padding(2);
            addressText.Name = "addressText";
            addressText.Size = new Size(254, 27);
            addressText.TabIndex = 12;
            // 
            // phoneNumberText
            // 
            phoneNumberText.BorderStyle = BorderStyle.None;
            phoneNumberText.DataBindings.Add(new Binding("Text", customerBindingSource, "PhoneNumber", true));
            phoneNumberText.Location = new Point(185, 269);
            phoneNumberText.Margin = new Padding(2);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(260, 27);
            phoneNumberText.TabIndex = 13;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Location = new Point(539, 301);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(133, 37);
            addButton.TabIndex = 14;
            addButton.Text = "Save";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(688, 301);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // CustomerCrudForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 349);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(phoneNumberText);
            Controls.Add(addressText);
            Controls.Add(cityText);
            Controls.Add(countryText);
            Controls.Add(tinText);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(phoneNumberLabel);
            Controls.Add(addressLabel);
            Controls.Add(cityLabel);
            Controls.Add(countryLabel);
            Controls.Add(tinLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "CustomerCrudForm";
            ShowIcon = false;
            Text = "CustomerCrudForm";
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label tinLabel;
        private Label countryLabel;
        private Label cityLabel;
        private Label addressLabel;
        private Label phoneNumberLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox tinText;
        private TextBox countryText;
        private TextBox cityText;
        private TextBox addressText;
        private TextBox phoneNumberText;
        private Button addButton;
        private BindingSource customerBindingSource;
        private Button cancelButton;
    }
}