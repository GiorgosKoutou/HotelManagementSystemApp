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
            roomBindingSource = new BindingSource(components);
            previousPageButton = new Button();
            nextPageButton = new Button();
            roomButtonPanel = new Panel();
            roomNextButton = new Button();
            roomPreviousButton = new Button();
            dataGridPanel = new Panel();
            roomDataGridView = new DataGridView();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bedNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bathNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            roomButtonPanel.SuspendLayout();
            dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            SuspendLayout();
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(DataAccessLibrary.Models.Room);
            // 
            // previousPageButton
            // 
            previousPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            previousPageButton.Location = new Point(2120, -50);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(94, 29);
            previousPageButton.TabIndex = 1;
            previousPageButton.Text = "<";
            previousPageButton.UseVisualStyleBackColor = true;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextPageButton.Location = new Point(2220, -50);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(94, 29);
            nextPageButton.TabIndex = 2;
            nextPageButton.Text = ">";
            nextPageButton.UseVisualStyleBackColor = true;
            // 
            // roomButtonPanel
            // 
            roomButtonPanel.Controls.Add(roomNextButton);
            roomButtonPanel.Controls.Add(roomPreviousButton);
            roomButtonPanel.Controls.Add(previousPageButton);
            roomButtonPanel.Controls.Add(nextPageButton);
            roomButtonPanel.Dock = DockStyle.Bottom;
            roomButtonPanel.Location = new Point(0, 600);
            roomButtonPanel.Name = "roomButtonPanel";
            roomButtonPanel.Size = new Size(1321, 42);
            roomButtonPanel.TabIndex = 4;
            // 
            // roomNextButton
            // 
            roomNextButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roomNextButton.FlatAppearance.BorderSize = 0;
            roomNextButton.FlatStyle = FlatStyle.Flat;
            roomNextButton.Image = Properties.Resources.next_arrow;
            roomNextButton.Location = new Point(1227, 7);
            roomNextButton.Name = "roomNextButton";
            roomNextButton.Size = new Size(94, 29);
            roomNextButton.TabIndex = 4;
            roomNextButton.UseVisualStyleBackColor = true;
            roomNextButton.Click += roomNextButton_Click;
            // 
            // roomPreviousButton
            // 
            roomPreviousButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roomPreviousButton.FlatAppearance.BorderSize = 0;
            roomPreviousButton.FlatStyle = FlatStyle.Flat;
            roomPreviousButton.Image = Properties.Resources.previous_arrow;
            roomPreviousButton.Location = new Point(1127, 7);
            roomPreviousButton.Name = "roomPreviousButton";
            roomPreviousButton.Size = new Size(94, 29);
            roomPreviousButton.TabIndex = 3;
            roomPreviousButton.UseVisualStyleBackColor = true;
            roomPreviousButton.Click += roomPreviousButton_Click;
            // 
            // dataGridPanel
            // 
            dataGridPanel.Controls.Add(roomDataGridView);
            dataGridPanel.Dock = DockStyle.Fill;
            dataGridPanel.Location = new Point(0, 0);
            dataGridPanel.Name = "dataGridPanel";
            dataGridPanel.Size = new Size(1321, 600);
            dataGridPanel.TabIndex = 5;
            // 
            // roomDataGridView
            // 
            roomDataGridView.AllowUserToAddRows = false;
            roomDataGridView.AllowUserToDeleteRows = false;
            roomDataGridView.AutoGenerateColumns = false;
            roomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomDataGridView.Columns.AddRange(new DataGridViewColumn[] { roomNumberDataGridViewTextBoxColumn, floorDataGridViewTextBoxColumn, bedNumberDataGridViewTextBoxColumn, bathNumberDataGridViewTextBoxColumn, Description });
            roomDataGridView.DataSource = roomBindingSource;
            roomDataGridView.Dock = DockStyle.Fill;
            roomDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            roomDataGridView.Location = new Point(0, 0);
            roomDataGridView.Name = "roomDataGridView";
            roomDataGridView.ReadOnly = true;
            roomDataGridView.RowHeadersWidth = 51;
            roomDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomDataGridView.Size = new Size(1321, 600);
            roomDataGridView.TabIndex = 0;
            roomDataGridView.RowEnter += roomDataGridView_RowEnter;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            floorDataGridViewTextBoxColumn.MinimumWidth = 6;
            floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            floorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bedNumberDataGridViewTextBoxColumn
            // 
            bedNumberDataGridViewTextBoxColumn.DataPropertyName = "BedNumber";
            bedNumberDataGridViewTextBoxColumn.HeaderText = "BedNumber";
            bedNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            bedNumberDataGridViewTextBoxColumn.Name = "bedNumberDataGridViewTextBoxColumn";
            bedNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bathNumberDataGridViewTextBoxColumn
            // 
            bathNumberDataGridViewTextBoxColumn.DataPropertyName = "BathNumber";
            bathNumberDataGridViewTextBoxColumn.HeaderText = "BathNumber";
            bathNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            bathNumberDataGridViewTextBoxColumn.Name = "bathNumberDataGridViewTextBoxColumn";
            bathNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Room Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // RoomListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 642);
            Controls.Add(dataGridPanel);
            Controls.Add(roomButtonPanel);
            Name = "RoomListForm";
            Text = "RoomListForm";
            Load += RoomListForm_Load;
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            roomButtonPanel.ResumeLayout(false);
            dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button previousPageButton;
        private Button nextPageButton;
        private Panel roomButtonPanel;
        private BindingSource roomBindingSource;
        private Button roomNextButton;
        private Button roomPreviousButton;
        private Panel dataGridPanel;
        private DataGridView roomDataGridView;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bathNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Description;
    }
}