using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private SqlConnection databaseConnection;
        public Form1()
        {
            InitializeComponent();
            String connectionString = "Data Source=DESKTOP-KPQA7E3\\SQLEXPRESS; Initial Catalog=OnlineMusicStore; Integrated Security=true";
            this.databaseConnection = new SqlConnection(connectionString);
        }

        private void displayUsersButton_Click(object sender, EventArgs e)
        {
            usersListView.Items.Clear();

            databaseConnection.Open();
            DataSet dataSet = new DataSet();
            String query = "SELECT * FROM ClientUser";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, databaseConnection);
            dataAdapter.Fill(dataSet, "ClientUser");
            DataTable dataTable = dataSet.Tables["ClientUser"];

            foreach (DataRow dataRow in dataTable.Rows)
            {                        
                String[] rowStringArray = {dataRow["UserId"].ToString(),
                    dataRow["Username"].ToString(),
                    dataRow["EncryptedPassword"].ToString(),
                    dataRow["RegistrationDate"].ToString()};
                ListViewItem listViewItem = new ListViewItem(rowStringArray);

                usersListView.Items.Add(listViewItem);

                Console.WriteLine(dataRow["UserId"] + " " + dataRow["Username"].ToString() + " " + dataRow["EncryptedPassword"] + " " + dataRow["RegistrationDate"]);
            }

            databaseConnection.Close();
        }

        private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count > 0)
            {
                databaseConnection.Open();
                transactionsListView.Items.Clear();
                ListViewItem user = usersListView.SelectedItems[0];
                int userId = Int32.Parse(user.Text);
                Console.WriteLine(userId);

                String queryCode = "SELECT * FROM UserTransaction WHERE UserId=@UID";
                SqlCommand queryCommand = new SqlCommand(queryCode, databaseConnection);
                SqlParameter userIdParameter = new SqlParameter();
                userIdParameter.ParameterName = "@UID";
                userIdParameter.Value = userId;
                queryCommand.Parameters.Add(userIdParameter);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryCommand);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "UserTransaction");
                DataTable transactionTable = dataSet.Tables["UserTransaction"];

                foreach (DataRow dataRow in transactionTable.Rows)
                {
                    String[] rowStringArray = {dataRow["TransactionId"].ToString(),
                        dataRow["UserId"].ToString(),
                        dataRow["RecordId"].ToString(),
                        dataRow["TransactionDateTime"].ToString()};
                    ListViewItem listViewItem = new ListViewItem(rowStringArray);
                    transactionsListView.Items.Add(listViewItem);
                }

                databaseConnection.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();  
            SqlParameter userIdParameter = new SqlParameter();
            userIdParameter.ParameterName = "@UID";
            userIdParameter.Value = userTextBox.Text;
            SqlParameter recordIdParameter = new SqlParameter();
            recordIdParameter.ParameterName = "@RID";
            recordIdParameter.Value = recordTextBox.Text;
            SqlParameter timeParameter = new SqlParameter();
            timeParameter.ParameterName = "@TIME";
            timeParameter.Value = timeTextBox.Text;

            SqlCommand userRecordLinkInsertion = new SqlCommand();
            userRecordLinkInsertion.CommandText = "INSERT INTO Users_Records(UserId, RecordId) VALUES (@UID, @RID)";
            userRecordLinkInsertion.CommandType = CommandType.Text;
            userRecordLinkInsertion.Connection = databaseConnection;
            userRecordLinkInsertion.Parameters.Add(userIdParameter);
            userRecordLinkInsertion.Parameters.Add(recordIdParameter);
            try {    
                userRecordLinkInsertion.ExecuteNonQuery();
            } catch (Exception exception) {
                Console.Write("Adding a new link between user {0} and record {1} was not needed: ", userIdParameter.Value, recordIdParameter.Value);
                Console.Write(exception.Message);
            }

            userRecordLinkInsertion.Parameters.Clear();

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = "INSERT INTO UserTransaction(UserId, RecordId, TransactionDateTime) VALUES (@UID, @RID, @TIME)";
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Connection = databaseConnection;
            insertCommand.Parameters.Add(userIdParameter);
            insertCommand.Parameters.Add(recordIdParameter);
            insertCommand.Parameters.Add(timeParameter);
            insertCommand.ExecuteNonQuery();
            insertCommand.Parameters.Clear();
            transactionsListView.Items.Clear();

            String queryCode = "SELECT * FROM UserTransaction WHERE UserId=@UID";
            SqlCommand queryCommand = new SqlCommand(queryCode, databaseConnection);
            queryCommand.Parameters.Add(userIdParameter);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryCommand);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "UserTransaction");
            DataTable transactionTable = dataSet.Tables["UserTransaction"];

            foreach (DataRow dataRow in transactionTable.Rows)
            {
                String[] rowStringArray = {dataRow["TransactionId"].ToString(),
                    dataRow["UserId"].ToString(),
                    dataRow["RecordId"].ToString(),
                    dataRow["TransactionDateTime"].ToString()};
                ListViewItem listViewItem = new ListViewItem(rowStringArray);
                transactionsListView.Items.Add(listViewItem);
            }
            
            databaseConnection.Close();  
        }

        private void updateButton_Click(object sender, EventArgs e)
        { 
            databaseConnection.Open();  
            SqlParameter userIdParameter = new SqlParameter();
            userIdParameter.ParameterName = "@UID";
            SqlParameter timeParameter = new SqlParameter();
            timeParameter.ParameterName = "@TIME";
            timeParameter.Value = timeTextBox.Text;
            SqlParameter transactionIdParameter = new SqlParameter();
            transactionIdParameter.ParameterName = "@TID";

            if (transactionsListView.SelectedItems.Count == 0)
            {
                databaseConnection.Close();  
                return;
            }
            ListViewItem transaction = transactionsListView.SelectedItems[0];
            int transactionId = Int32.Parse(transaction.Text);
            Console.WriteLine("transactionIdSelected: {0}", transactionId);

            SqlCommand updateCommand = new SqlCommand();
            transactionIdParameter.Value = transactionId;
            updateCommand.CommandText = "UPDATE UserTransaction SET TransactionDateTime=@TIME WHERE TransactionId=@TID";
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Connection = databaseConnection;
            updateCommand.Parameters.Add(timeParameter);
            updateCommand.Parameters.Add(transactionIdParameter);
            updateCommand.ExecuteNonQuery();
            updateCommand.Parameters.Clear();
            transactionsListView.Items.Clear();

            userIdParameter.Value = Int32.Parse(usersListView.SelectedItems[0].Text);
            String queryCode = "SELECT * FROM UserTransaction WHERE UserId=@UID";
            SqlCommand queryCommand = new SqlCommand(queryCode, databaseConnection);
            queryCommand.Parameters.Add(userIdParameter);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryCommand);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "UserTransaction");
            DataTable transactionTable = dataSet.Tables["UserTransaction"];

            foreach (DataRow dataRow in transactionTable.Rows)
            {
                String[] rowStringArray = {dataRow["TransactionId"].ToString(),
                    dataRow["UserId"].ToString(),
                    dataRow["RecordId"].ToString(),
                    dataRow["TransactionDateTime"].ToString()};
                ListViewItem listViewItem = new ListViewItem(rowStringArray);
                transactionsListView.Items.Add(listViewItem);
            }
            
            databaseConnection.Close();  
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
