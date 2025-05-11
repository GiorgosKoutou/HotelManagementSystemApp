namespace HotelPmsUI.Forms.Room
{
    partial class RoomListForm
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
            roomsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            roomBindingSource = new BindingSource(components);
            previousPageButton = new Button();
            nextPageButton = new Button();
            buttonPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // roomsDataGridView
            // 
            roomsDataGridView.AllowUserToAddRows = false;
            roomsDataGridView.AllowUserToDeleteRows = false;
            roomsDataGridView.AutoGenerateColumns = false;
            roomsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            roomsDataGridView.DataSource = roomBindingSource;
            roomsDataGridView.Dock = DockStyle.Fill;
            roomsDataGridView.Location = new Point(0, 0);
            roomsDataGridView.Name = "roomsDataGridView";
            roomsDataGridView.ReadOnly = true;
            roomsDataGridView.RowHeadersWidth = 51;
            roomsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomsDataGridView.Size = new Size(1238, 547);
            roomsDataGridView.TabIndex = 0;
            roomsDataGridView.RowEnter += roomsDataGridView_RowEnter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
            dataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Floor";
            dataGridViewTextBoxColumn2.HeaderText = "Floor";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "BedNumber";
            dataGridViewTextBoxColumn3.HeaderText = "BedNumber";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "BathNumber";
            dataGridViewTextBoxColumn4.HeaderText = "BathNumber";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "RoomTypeId";
            dataGridViewTextBoxColumn5.HeaderText = "RoomTypeId";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(DataAccessLibrary.Models.Room);
            // 
            // previousPageButton
            // 
            previousPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            previousPageButton.Location = new Point(2037, 23);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(94, 29);
            previousPageButton.TabIndex = 1;
            previousPageButton.Text = "<";
            previousPageButton.UseVisualStyleBackColor = true;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextPageButton.Location = new Point(2137, 23);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(94, 29);
            nextPageButton.TabIndex = 2;
            nextPageButton.Text = ">";
            nextPageButton.UseVisualStyleBackColor = true;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(previousPageButton);
            buttonPanel.Controls.Add(nextPageButton);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 432);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(1238, 115);
            buttonPanel.TabIndex = 4;
            // 
            // RoomListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 547);
            Controls.Add(buttonPanel);
            Controls.Add(roomsDataGridView);
            Name = "RoomListForm";
            Text = "RoomListForm";
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView roomsDataGridView;
        private Button previousPageButton;
        private Button nextPageButton;
        private Panel buttonPanel;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bathNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource roomBindingSource;
    }
}