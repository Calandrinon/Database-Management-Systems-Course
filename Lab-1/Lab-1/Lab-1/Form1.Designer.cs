
namespace Lab_1
{
    partial class Form1
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
            this.usersListView = new System.Windows.Forms.ListView();
            this.userIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registrationDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionsListView = new System.Windows.Forms.ListView();
            this.transactionIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userIdFKColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recordIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionDatetimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displayUsersButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.recordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timeTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userIdColumn,
            this.usernameColumn,
            this.passwordColumn,
            this.registrationDateColumn});
            this.usersListView.GridLines = true;
            this.usersListView.HideSelection = false;
            this.usersListView.Location = new System.Drawing.Point(38, 41);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(365, 167);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            this.usersListView.SelectedIndexChanged += new System.EventHandler(this.usersListView_SelectedIndexChanged);
            // 
            // userIdColumn
            // 
            this.userIdColumn.Text = "User ID";
            // 
            // usernameColumn
            // 
            this.usernameColumn.Text = "Username";
            // 
            // passwordColumn
            // 
            this.passwordColumn.Text = "Password";
            // 
            // registrationDateColumn
            // 
            this.registrationDateColumn.Text = "Registration date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transactions";
            // 
            // transactionsListView
            // 
            this.transactionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transactionIdColumn,
            this.userIdFKColumn,
            this.recordIdColumn,
            this.transactionDatetimeColumn});
            this.transactionsListView.GridLines = true;
            this.transactionsListView.HideSelection = false;
            this.transactionsListView.Location = new System.Drawing.Point(409, 41);
            this.transactionsListView.Name = "transactionsListView";
            this.transactionsListView.Size = new System.Drawing.Size(349, 167);
            this.transactionsListView.TabIndex = 2;
            this.transactionsListView.UseCompatibleStateImageBehavior = false;
            this.transactionsListView.View = System.Windows.Forms.View.Details;
            // 
            // transactionIdColumn
            // 
            this.transactionIdColumn.Text = "Transaction ID";
            // 
            // userIdFKColumn
            // 
            this.userIdFKColumn.Text = "User ID";
            // 
            // recordIdColumn
            // 
            this.recordIdColumn.Text = "Record ID";
            // 
            // transactionDatetimeColumn
            // 
            this.transactionDatetimeColumn.Text = "Time";
            // 
            // displayUsersButton
            // 
            this.displayUsersButton.Location = new System.Drawing.Point(38, 228);
            this.displayUsersButton.Name = "displayUsersButton";
            this.displayUsersButton.Size = new System.Drawing.Size(103, 28);
            this.displayUsersButton.TabIndex = 4;
            this.displayUsersButton.Text = "Display users";
            this.displayUsersButton.UseVisualStyleBackColor = true;
            this.displayUsersButton.Click += new System.EventHandler(this.displayUsersButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(149, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(364, 368);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(595, 368);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(124, 282);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 22);
            this.userTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "User ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Transaction time:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(124, 338);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Record ID:";
            // 
            // recordTextBox
            // 
            this.recordTextBox.Location = new System.Drawing.Point(124, 310);
            this.recordTextBox.Name = "recordTextBox";
            this.recordTextBox.Size = new System.Drawing.Size(100, 22);
            this.recordTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "New transaction time:";
            // 
            // timeTextBox2
            // 
            this.timeTextBox2.Location = new System.Drawing.Point(364, 340);
            this.timeTextBox2.Name = "timeTextBox2";
            this.timeTextBox2.Size = new System.Drawing.Size(100, 22);
            this.timeTextBox2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.displayUsersButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transactionsListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView transactionsListView;
        private System.Windows.Forms.Button displayUsersButton;
        private System.Windows.Forms.ColumnHeader userIdColumn;
        private System.Windows.Forms.ColumnHeader usernameColumn;
        private System.Windows.Forms.ColumnHeader passwordColumn;
        private System.Windows.Forms.ColumnHeader registrationDateColumn;
        private System.Windows.Forms.ColumnHeader transactionIdColumn;
        private System.Windows.Forms.ColumnHeader userIdFKColumn;
        private System.Windows.Forms.ColumnHeader recordIdColumn;
        private System.Windows.Forms.ColumnHeader transactionDatetimeColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeTextBox2;
    }
}

