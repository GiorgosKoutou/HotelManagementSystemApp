namespace HotelPmsUI.Forms.TypeCategories;
    partial class CatrgoriesCrudForm
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
            idLabel = new Label();
            descriptionLabel = new Label();
            idTextBox = new TextBox();
            typeCatgoryBindingSource = new BindingSource(components);
            descriptionTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)typeCatgoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F);
            idLabel.Location = new Point(19, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(35, 28);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F);
            descriptionLabel.Location = new Point(19, 55);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(116, 28);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // idTextBox
            // 
            idTextBox.DataBindings.Add(new Binding("Text", typeCatgoryBindingSource, "id", true));
            idTextBox.Font = new Font("Segoe UI", 12F);
            idTextBox.Location = new Point(132, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(125, 34);
            idTextBox.TabIndex = 3;
            // 
            // typeCatgoryBindingSource
            // 
            typeCatgoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCategory);
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.DataBindings.Add(new Binding("Text", typeCatgoryBindingSource, "Description", true));
            descriptionTextBox.Font = new Font("Segoe UI", 12F);
            descriptionTextBox.Location = new Point(132, 52);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(176, 34);
            descriptionTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(516, 79);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(133, 37);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(655, 79);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CatrgoriesCrudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 128);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(idTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(idLabel);
            Name = "CatrgoriesCrudForm";
            Text = "CatrgoriesCrudForm";
            ((System.ComponentModel.ISupportInitialize)typeCatgoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label descriptionLabel;
        private TextBox idTextBox;
        private TextBox descriptionTextBox;
        private BindingSource typeCatgoryBindingSource;
        private Button saveButton;
        private Button cancelButton;
    }
