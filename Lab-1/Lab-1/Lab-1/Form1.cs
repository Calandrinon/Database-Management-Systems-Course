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
    }
}
