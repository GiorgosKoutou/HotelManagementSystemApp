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
            firstNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(204, 68);
            firstNameLabel.Margin = new Padding(5, 0, 5, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 31);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(204, 139);
            lastNameLabel.Margin = new Padding(5, 0, 5, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(127, 31);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // tinLabel
            // 
            tinLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tinLabel.AutoSize = true;
            tinLabel.Location = new Point(204, 219);
            tinLabel.Margin = new Padding(5, 0, 5, 0);
            tinLabel.Name = "tinLabel";
            tinLabel.Size = new Size(300, 31);
            tinLabel.TabIndex = 2;
            tinLabel.Text = "Tax Identificational Number:";
            // 
            // countryLabel
            // 
            countryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(204, 290);
            countryLabel.Margin = new Padding(5, 0, 5, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(99, 31);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(204, 357);
            cityLabel.Margin = new Padding(5, 0, 5, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(58, 31);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(204, 430);
            addressLabel.Margin = new Padding(5, 0, 5, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(102, 31);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(204, 499);
            phoneNumberLabel.Margin = new Padding(5, 0, 5, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(173, 31);
            phoneNumberLabel.TabIndex = 6;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // firstNameText
            // 
            firstNameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            firstNameText.BorderStyle = BorderStyle.None;
            firstNameText.DataBindings.Add(new Binding("Text", customerBindingSource, "FirstName", true));
            firstNameText.Location = new Point(533, 65);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(302, 31);
            firstNameText.TabIndex = 7;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(DataAccessLibrary.Models.Customer);
            // 
            // lastNameText
            // 
            lastNameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lastNameText.BorderStyle = BorderStyle.None;
            lastNameText.DataBindings.Add(new Binding("Text", customerBindingSource, "LastName", true));
            lastNameText.Location = new Point(533, 139);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(301, 31);
            lastNameText.TabIndex = 8;
            // 
            // tinText
            // 
            tinText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tinText.BorderStyle = BorderStyle.None;
            tinText.DataBindings.Add(new Binding("Text", customerBindingSource, "Tin", true));
            tinText.Location = new Point(533, 216);
            tinText.Name = "tinText";
            tinText.Size = new Size(302, 31);
            tinText.TabIndex = 9;
            // 
            // countryText
            // 
            countryText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            countryText.BorderStyle = BorderStyle.None;
            countryText.DataBindings.Add(new Binding("Text", customerBindingSource, "Country", true));
            countryText.Location = new Point(533, 287);
            countryText.Name = "countryText";
            countryText.Size = new Size(302, 31);
            countryText.TabIndex = 10;
            // 
            // cityText
            // 
            cityText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cityText.BorderStyle = BorderStyle.None;
            cityText.DataBindings.Add(new Binding("Text", customerBindingSource, "City", true));
            cityText.Location = new Point(534, 354);
            cityText.Name = "cityText";
            cityText.Size = new Size(301, 31);
            cityText.TabIndex = 11;
            // 
            // addressText
            // 
            addressText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addressText.BorderStyle = BorderStyle.None;
            addressText.DataBindings.Add(new Binding("Text", customerBindingSource, "Address", true));
            addressText.Location = new Point(534, 427);
            addressText.Name = "addressText";
            addressText.Size = new Size(301, 31);
            addressText.TabIndex = 12;
            // 
            // phoneNumberText
            // 
            phoneNumberText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            phoneNumberText.BorderStyle = BorderStyle.None;
            phoneNumberText.DataBindings.Add(new Binding("Text", customerBindingSource, "PhoneNumber", true));
            phoneNumberText.Location = new Point(533, 496);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(307, 31);
            phoneNumberText.TabIndex = 13;
            // 
            // addButton
            // 
            addButton.Location = new Point(283, 601);
            addButton.Name = "addButton";
            addButton.Size = new Size(283, 54);
            addButton.TabIndex = 14;
            addButton.Text = "Save";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(616, 601);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(289, 54);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // CustomerCrudForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 697);
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
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Margin = new Padding(5);
            Name = "CustomerCrudForm";
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