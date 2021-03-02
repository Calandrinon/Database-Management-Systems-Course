
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionsListView = new System.Windows.Forms.ListView();
            this.displayUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.HideSelection = false;
            this.usersListView.Location = new System.Drawing.Point(35, 41);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(279, 167);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
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
            this.label2.Location = new System.Drawing.Point(476, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transactions";
            // 
            // transactionsListView
            // 
            this.transactionsListView.HideSelection = false;
            this.transactionsListView.Location = new System.Drawing.Point(476, 41);
            this.transactionsListView.Name = "transactionsListView";
            this.transactionsListView.Size = new System.Drawing.Size(279, 167);
            this.transactionsListView.TabIndex = 2;
            this.transactionsListView.UseCompatibleStateImageBehavior = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

