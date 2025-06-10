namespace HotelPmsUI.Forms.Period
{
    partial class PeriodCrudForm
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
            startDateLabel = new Label();
            endDateLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            periodNameLabel = new Label();
            periodNameText = new TextBox();
            cancelButton = new Button();
            saveButton = new Button();
            periodBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(12, 9);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(108, 28);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Start Date: ";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(297, 9);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(100, 28);
            endDateLabel.TabIndex = 1;
            endDateLabel.Text = "End Date: ";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.CustomFormat = "dd/MM/yyyy";
            startDateTimePicker.DataBindings.Add(new Binding("Value", periodBindingSource, "StartDate", true));
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.Location = new Point(126, 4);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(155, 34);
            startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.CustomFormat = "dd/MM/yyyy";
            endDateTimePicker.DataBindings.Add(new Binding("Value", periodBindingSource, "EndDate", true));
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.Location = new Point(403, 4);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(162, 34);
            endDateTimePicker.TabIndex = 3;
            // 
            // periodNameLabel
            // 
            periodNameLabel.AutoSize = true;
            periodNameLabel.Location = new Point(12, 63);
            periodNameLabel.Name = "periodNameLabel";
            periodNameLabel.Size = new Size(134, 28);
            periodNameLabel.TabIndex = 4;
            periodNameLabel.Text = "Period Name: ";
            // 
            // periodNameText
            // 
            periodNameText.DataBindings.Add(new Binding("Text", periodBindingSource, "Name", true));
            periodNameText.Location = new Point(152, 60);
            periodNameText.Name = "periodNameText";
            periodNameText.Size = new Size(179, 34);
            periodNameText.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(572, 121);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 37);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(423, 121);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(145, 37);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // periodBindingSource
            // 
            periodBindingSource.DataSource = typeof(DataAccessLibrary.Models.Period);
            // 
            // PeriodCrudForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 169);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(periodNameText);
            Controls.Add(periodNameLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(startDateLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PeriodCrudForm";
            Text = "PeriodCrudForm";
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startDateLabel;
        private Label endDateLabel;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Label periodNameLabel;
        private TextBox periodNameText;
        private Button cancelButton;
        private Button saveButton;
        private BindingSource periodBindingSource;
    }
}