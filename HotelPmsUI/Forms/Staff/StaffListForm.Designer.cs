namespace HotelPmsUI.Forms.Staff
{
    partial class StaffListForm
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
            dataGridViewPanel = new Panel();
            staffDataGridView = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffBindingSource = new BindingSource(components);
            buttonPanel = new Panel();
            nextButton = new Button();
            previousButton = new Button();
            dataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPanel
            // 
            dataGridViewPanel.Controls.Add(staffDataGridView);
            dataGridViewPanel.Dock = DockStyle.Fill;
            dataGridViewPanel.Location = new Point(0, 0);
            dataGridViewPanel.Name = "dataGridViewPanel";
            dataGridViewPanel.Size = new Size(800, 408);
            dataGridViewPanel.TabIndex = 0;
            // 
            // staffDataGridView
            // 
            staffDataGridView.AllowUserToAddRows = false;
            staffDataGridView.AllowUserToDeleteRows = false;
            staffDataGridView.AutoGenerateColumns = false;
            staffDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffDataGridView.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn });
            staffDataGridView.DataSource = staffBindingSource;
            staffDataGridView.Dock = DockStyle.Fill;
            staffDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            staffDataGridView.Location = new Point(0, 0);
            staffDataGridView.Name = "staffDataGridView";
            staffDataGridView.ReadOnly = true;
            staffDataGridView.RowHeadersWidth = 51;
            staffDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGridView.Size = new Size(800, 408);
            staffDataGridView.TabIndex = 0;
            staffDataGridView.RowEnter += staffDataGridView_RowEnter;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn1.HeaderText = "LastName";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataSource = typeof(DataAccessLibrary.Models.Staff);
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(nextButton);
            buttonPanel.Controls.Add(previousButton);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 408);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(800, 42);
            buttonPanel.TabIndex = 1;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Image = Properties.Resources.next_arrow;
            nextButton.Location = new Point(703, 10);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 1;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Image = Properties.Resources.previous_arrow;
            previousButton.Location = new Point(612, 10);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(85, 29);
            previousButton.TabIndex = 0;
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // StaffListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewPanel);
            Controls.Add(buttonPanel);
            Name = "StaffListForm";
            Text = "StaffListForm";
            Load += StaffListForm_Load;
            dataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dataGridViewPanel;
        private Panel buttonPanel;
        private DataGridView staffDataGridView;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private BindingSource staffBindingSource;
        private Button nextButton;
        private Button previousButton;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}