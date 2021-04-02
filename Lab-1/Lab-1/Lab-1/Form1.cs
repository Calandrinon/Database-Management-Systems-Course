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
        private DataSet dataSet { get; set; }
        private SqlDataAdapter daUser { get; set; }
        private SqlDataAdapter daTransaction { get; set; }
        private BindingSource bsUser { get; set; }
        private BindingSource bsTransaction { get; set; }
        private String connectionString;
        public Form1()
        {
            InitializeComponent();
            this.connectionString = "Data Source=DESKTOP-0I4E1BF\\SQLEXPRESS; Initial Catalog=OnlineMusicStore; Integrated Security=true";
            databaseConnection = new SqlConnection(this.connectionString);
            dataSet = new DataSet();
            daUser = new SqlDataAdapter("select * from ClientUser", databaseConnection);
            daTransaction = new SqlDataAdapter("select * from UserTransaction", databaseConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(daTransaction);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daUser.Fill(dataSet, "ClientUser");
            daTransaction.Fill(dataSet, "UserTransaction");

            DataRelation dr = new DataRelation("FK_ClientUser_UserTransaction", dataSet.Tables["ClientUser"].Columns["UserId"],
                dataSet.Tables["UserTransaction"].Columns["UserId"]);
            dataSet.Relations.Add(dr);

            bsUser = new BindingSource();
            bsUser.DataSource = dataSet;
            bsUser.DataMember = "ClientUser";

            bsTransaction = new BindingSource();
            bsTransaction.DataSource = bsUser;
            bsTransaction.DataMember = "FK_ClientUser_UserTransaction";

            usersDataGridView.AutoGenerateColumns = true;
            transactionsDataGridView.AutoGenerateColumns = true;
            usersDataGridView.DataSource = bsUser;
            transactionsDataGridView.DataSource = bsTransaction;

            Console.WriteLine("Form load complete.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            daTransaction.Update(dataSet, "UserTransaction");
        }

    }
}
