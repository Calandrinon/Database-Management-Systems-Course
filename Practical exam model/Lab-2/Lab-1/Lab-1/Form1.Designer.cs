
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
            this.components = new System.ComponentModel.Container();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.onlineMusicStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniFacebookDataSet = new Lab_1.MiniFacebookDataSet();
            this.miniFacebookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miniFacebookDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMusicStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniFacebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniFacebookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniFacebookDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.DataSource = this.miniFacebookDataSetBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 37);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(563, 174);
            this.usersDataGridView.TabIndex = 0;
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AutoGenerateColumns = false;
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.DataSource = this.miniFacebookDataSetBindingSource1;
            this.transactionsDataGridView.Location = new System.Drawing.Point(13, 262);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.RowHeadersWidth = 51;
            this.transactionsDataGridView.RowTemplate.Height = 24;
            this.transactionsDataGridView.Size = new System.Drawing.Size(562, 176);
            this.transactionsDataGridView.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(656, 217);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Posts";
            // 
            // onlineMusicStoreDataSetBindingSource
            // 
            this.onlineMusicStoreDataSetBindingSource.Position = 0;
            // 
            // onlineMusicStoreDataSet
            // 
            // 
            // miniFacebookDataSet
            // 
            this.miniFacebookDataSet.DataSetName = "MiniFacebookDataSet";
            this.miniFacebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miniFacebookDataSetBindingSource
            // 
            this.miniFacebookDataSetBindingSource.DataSource = this.miniFacebookDataSet;
            this.miniFacebookDataSetBindingSource.Position = 0;
            // 
            // miniFacebookDataSetBindingSource1
            // 
            this.miniFacebookDataSetBindingSource1.DataSource = this.miniFacebookDataSet;
            this.miniFacebookDataSetBindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.transactionsDataGridView);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMusicStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniFacebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniFacebookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniFacebookDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.BindingSource onlineMusicStoreDataSetBindingSource;
        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource miniFacebookDataSetBindingSource;
        private MiniFacebookDataSet miniFacebookDataSet;
        private System.Windows.Forms.BindingSource miniFacebookDataSetBindingSource1;
    }
}

