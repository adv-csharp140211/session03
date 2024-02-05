namespace session02.UI
{
    partial class FormUser
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
            label1 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            buttonCreate = new Button();
            dataGridViewUsers = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            buttonLoadData = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(97, 15);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(231, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(97, 44);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(231, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 47);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(97, 73);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(231, 23);
            textBoxUserName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 76);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "User Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxFirstName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 138);
            panel1.TabIndex = 6;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(253, 102);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { id, firstName, lastName, userName, delete });
            dataGridViewUsers.Location = new Point(12, 156);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.Size = new Size(799, 269);
            dataGridViewUsers.TabIndex = 7;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "شناسه";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.DataPropertyName = "FirstName";
            firstName.HeaderText = "نام";
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.DataPropertyName = "LastName";
            lastName.HeaderText = "نام خانوادگی";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // userName
            // 
            userName.DataPropertyName = "UserName";
            userName.HeaderText = "نام کاربری";
            userName.Name = "userName";
            userName.ReadOnly = true;
            // 
            // delete
            // 
            delete.HeaderText = "حذف";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "حذف";
            delete.UseColumnTextForButtonValue = true;
            // 
            // buttonLoadData
            // 
            buttonLoadData.Location = new Point(736, 127);
            buttonLoadData.Name = "buttonLoadData";
            buttonLoadData.Size = new Size(75, 23);
            buttonLoadData.TabIndex = 8;
            buttonLoadData.Text = "Load Data";
            buttonLoadData.UseVisualStyleBackColor = true;
            buttonLoadData.Click += buttonLoadData_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 437);
            Controls.Add(buttonLoadData);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panel1);
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxUserName;
        private Label label3;
        private Panel panel1;
        private Button buttonCreate;
        private DataGridView dataGridViewUsers;
        private Button buttonLoadData;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewButtonColumn delete;
    }
}