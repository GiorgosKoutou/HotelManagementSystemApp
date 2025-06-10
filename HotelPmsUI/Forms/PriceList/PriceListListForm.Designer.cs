namespace HotelPmsUI.Forms.PriceList
{
    partial class PriceListListForm
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
            priceListDataGridView = new DataGridView();
            periodNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceListBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)priceListDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceListBindingSource).BeginInit();
            SuspendLayout();
            // 
            // priceListDataGridView
            // 
            priceListDataGridView.AllowUserToAddRows = false;
            priceListDataGridView.AllowUserToDeleteRows = false;
            priceListDataGridView.AutoGenerateColumns = false;
            priceListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            priceListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            priceListDataGridView.Columns.AddRange(new DataGridViewColumn[] { periodNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            priceListDataGridView.DataSource = priceListBindingSource;
            priceListDataGridView.Dock = DockStyle.Fill;
            priceListDataGridView.Location = new Point(0, 0);
            priceListDataGridView.Name = "priceListDataGridView";
            priceListDataGridView.ReadOnly = true;
            priceListDataGridView.RowHeadersWidth = 51;
            priceListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            priceListDataGridView.Size = new Size(800, 450);
            priceListDataGridView.TabIndex = 0;
            priceListDataGridView.RowEnter += priceListDataGridView_RowEnter;
            // 
            // periodNameDataGridViewTextBoxColumn
            // 
            periodNameDataGridViewTextBoxColumn.DataPropertyName = "PeriodName";
            periodNameDataGridViewTextBoxColumn.HeaderText = "Period Name";
            periodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            periodNameDataGridViewTextBoxColumn.Name = "periodNameDataGridViewTextBoxColumn";
            periodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceListBindingSource
            // 
            priceListBindingSource.DataSource = typeof(DataAccessLibrary.Models.PriceList);
            // 
            // PriceListListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(priceListDataGridView);
            Name = "PriceListListForm";
            Text = "PriceListListForm";
            ((System.ComponentModel.ISupportInitialize)priceListDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceListBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView priceListDataGridView;
        private DataGridViewTextBoxColumn periodNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource priceListBindingSource;
    }
}