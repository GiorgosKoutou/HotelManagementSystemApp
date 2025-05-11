namespace HotelPmsUI.Forms.TypeCategories
{
    partial class CategoriesListForm
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
            categoriesGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeCatgoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)categoriesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeCatgoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // categoriesGridView
            // 
            categoriesGridView.AllowUserToAddRows = false;
            categoriesGridView.AllowUserToDeleteRows = false;
            categoriesGridView.AutoGenerateColumns = false;
            categoriesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            categoriesGridView.DataSource = typeCatgoryBindingSource;
            categoriesGridView.Dock = DockStyle.Fill;
            categoriesGridView.Location = new Point(0, 0);
            categoriesGridView.MultiSelect = false;
            categoriesGridView.Name = "categoriesGridView";
            categoriesGridView.ReadOnly = true;
            categoriesGridView.RowHeadersWidth = 51;
            categoriesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriesGridView.Size = new Size(800, 450);
            categoriesGridView.TabIndex = 0;
            categoriesGridView.RowEnter += categoriesGridView_RowEnter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeCatgoryBindingSource
            // 
            typeCatgoryBindingSource.DataSource = typeof(DataAccessLibrary.Models.TypeCatgory);
            // 
            // CategoriesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(categoriesGridView);
            Name = "CategoriesListForm";
            Text = "CategoriesListForm";
            ((System.ComponentModel.ISupportInitialize)categoriesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeCatgoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView categoriesGridView;
        private BindingSource typeCatgoryBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}