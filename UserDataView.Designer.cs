namespace SportStudio
{
    partial class UserDataView
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
            userDataViewTable = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eMailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAdminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postalCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userDataViewTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userDataViewTable
            // 
            userDataViewTable.AutoGenerateColumns = false;
            userDataViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataViewTable.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, eMailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, isAdminDataGridViewCheckBoxColumn, streetDataGridViewTextBoxColumn, streetNumberDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, postalCodeDataGridViewTextBoxColumn });
            userDataViewTable.DataSource = userBindingSource;
            userDataViewTable.Location = new Point(12, 12);
            userDataViewTable.Name = "userDataViewTable";
            userDataViewTable.RowHeadersWidth = 51;
            userDataViewTable.RowTemplate.Height = 29;
            userDataViewTable.Size = new Size(1304, 188);
            userDataViewTable.TabIndex = 0;
            userDataViewTable.DataSource = Form1.users;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            eMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            eMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            isAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            isAdminDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            isAdminDataGridViewCheckBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            streetDataGridViewTextBoxColumn.HeaderText = "Street";
            streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            streetNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            streetNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            postalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            postalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // UserDataView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 450);
            Controls.Add(userDataViewTable);
            Name = "UserDataView";
            Text = "UserDataView";
            ((System.ComponentModel.ISupportInitialize)userDataViewTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataViewTable;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}