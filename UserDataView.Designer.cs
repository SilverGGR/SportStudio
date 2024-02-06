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
            userBindingSource2 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            userBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            StreetNumber = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            PostalCode = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            monthlyFeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mukiAboDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            cardioAboDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            wasserAboDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            wellnessAboDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            membershipBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)membershipBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource2
            // 
            userBindingSource2.DataSource = typeof(User);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(User);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Email, Password, FirstName, LastName, Street, StreetNumber, City, PostalCode });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(944, 150);
            dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "Street";
            Street.Name = "Street";
            // 
            // StreetNumber
            // 
            StreetNumber.DataPropertyName = "StreetNumber";
            StreetNumber.HeaderText = "StreetNumber";
            StreetNumber.Name = "StreetNumber";
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "PostalCode";
            PostalCode.Name = "PostalCode";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, monthlyFeeDataGridViewTextBoxColumn, mukiAboDataGridViewCheckBoxColumn, cardioAboDataGridViewCheckBoxColumn, wasserAboDataGridViewCheckBoxColumn, wellnessAboDataGridViewCheckBoxColumn });
            dataGridView2.DataSource = membershipBindingSource;
            dataGridView2.Location = new Point(952, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(643, 150);
            dataGridView2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // monthlyFeeDataGridViewTextBoxColumn
            // 
            monthlyFeeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyFee";
            monthlyFeeDataGridViewTextBoxColumn.HeaderText = "MonthlyFee";
            monthlyFeeDataGridViewTextBoxColumn.Name = "monthlyFeeDataGridViewTextBoxColumn";
            // 
            // mukiAboDataGridViewCheckBoxColumn
            // 
            mukiAboDataGridViewCheckBoxColumn.DataPropertyName = "MukiAbo";
            mukiAboDataGridViewCheckBoxColumn.HeaderText = "MukiAbo";
            mukiAboDataGridViewCheckBoxColumn.Name = "mukiAboDataGridViewCheckBoxColumn";
            // 
            // cardioAboDataGridViewCheckBoxColumn
            // 
            cardioAboDataGridViewCheckBoxColumn.DataPropertyName = "CardioAbo";
            cardioAboDataGridViewCheckBoxColumn.HeaderText = "CardioAbo";
            cardioAboDataGridViewCheckBoxColumn.Name = "cardioAboDataGridViewCheckBoxColumn";
            // 
            // wasserAboDataGridViewCheckBoxColumn
            // 
            wasserAboDataGridViewCheckBoxColumn.DataPropertyName = "WasserAbo";
            wasserAboDataGridViewCheckBoxColumn.HeaderText = "WasserAbo";
            wasserAboDataGridViewCheckBoxColumn.Name = "wasserAboDataGridViewCheckBoxColumn";
            // 
            // wellnessAboDataGridViewCheckBoxColumn
            // 
            wellnessAboDataGridViewCheckBoxColumn.DataPropertyName = "WellnessAbo";
            wellnessAboDataGridViewCheckBoxColumn.HeaderText = "WellnessAbo";
            wellnessAboDataGridViewCheckBoxColumn.Name = "wellnessAboDataGridViewCheckBoxColumn";
            // 
            // membershipBindingSource
            // 
            membershipBindingSource.DataSource = typeof(Membership);
            // 
            // button1
            // 
            button1.Location = new Point(12, 190);
            button1.Name = "button1";
            button1.Size = new Size(91, 40);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserDataView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1656, 338);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserDataView";
            Text = "UserDataView";
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)membershipBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
        private BindingSource userBindingSource2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn StreetNumber;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn PostalCode;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn monthlyFeeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn mukiAboDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn cardioAboDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn wasserAboDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn wellnessAboDataGridViewCheckBoxColumn;
        private BindingSource membershipBindingSource;
        private Button button1;
    }
}