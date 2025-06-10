namespace HotelPmsUI.Forms.Period
{
    partial class PeriodListForm
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
            periodDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            periodBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)periodDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // periodDataGridView
            // 
            periodDataGridView.AllowUserToAddRows = false;
            periodDataGridView.AllowUserToDeleteRows = false;
            periodDataGridView.AutoGenerateColumns = false;
            periodDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            periodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            periodDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn });
            periodDataGridView.DataSource = periodBindingSource;
            periodDataGridView.Dock = DockStyle.Fill;
            periodDataGridView.Location = new Point(0, 0);
            periodDataGridView.Name = "periodDataGridView";
            periodDataGridView.ReadOnly = true;
            periodDataGridView.RowHeadersWidth = 51;
            periodDataGridView.Size = new Size(800, 450);
            periodDataGridView.TabIndex = 0;
            periodDataGridView.RowEnter += periodDataGridView_RowEnter;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodBindingSource
            // 
            periodBindingSource.DataSource = typeof(DataAccessLibrary.Models.Period);
            // 
            // PeriodListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(periodDataGridView);
            Name = "PeriodListForm";
            Text = "PeriodListForm";
            ((System.ComponentModel.ISupportInitialize)periodDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)periodBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView periodDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private BindingSource periodBindingSource;
    }
}