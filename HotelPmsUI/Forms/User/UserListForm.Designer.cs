namespace HotelPmsUI.Forms.User
{
    partial class UserListForm
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
            buttonPanel = new Panel();
            previousPageButton = new Button();
            nextPageButton = new Button();
            userDataGrid = new DataGridView();
            userBindingSource = new BindingSource(components);
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(previousPageButton);
            buttonPanel.Controls.Add(nextPageButton);
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Location = new Point(0, 402);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(800, 48);
            buttonPanel.TabIndex = 0;
            // 
            // previousPageButton
            // 
            previousPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            previousPageButton.Location = new Point(594, 7);
            previousPageButton.Name = "previousPageButton";
            previousPageButton.Size = new Size(94, 29);
            previousPageButton.TabIndex = 3;
            previousPageButton.Text = "<";
            previousPageButton.UseVisualStyleBackColor = true;
            // 
            // nextPageButton
            // 
            nextPageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextPageButton.Location = new Point(694, 7);
            nextPageButton.Name = "nextPageButton";
            nextPageButton.Size = new Size(94, 29);
            nextPageButton.TabIndex = 4;
            nextPageButton.Text = ">";
            nextPageButton.UseVisualStyleBackColor = true;
            // 
            // userDataGrid
            // 
            userDataGrid.AllowUserToAddRows = false;
            userDataGrid.AllowUserToDeleteRows = false;
            userDataGrid.AutoGenerateColumns = false;
            userDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGrid.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            userDataGrid.DataSource = userBindingSource;
            userDataGrid.Dock = DockStyle.Fill;
            userDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            userDataGrid.Location = new Point(0, 0);
            userDataGrid.Name = "userDataGrid";
            userDataGrid.ReadOnly = true;
            userDataGrid.RowHeadersWidth = 51;
            userDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userDataGrid.Size = new Size(800, 402);
            userDataGrid.TabIndex = 1;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(DataAccessLibrary.Models.User);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userDataGrid);
            Controls.Add(buttonPanel);
            Name = "UserListForm";
            Text = "UserListForm";
            buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonPanel;
        private Button previousPageButton;
        private Button nextPageButton;
        private DataGridView userDataGrid;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}