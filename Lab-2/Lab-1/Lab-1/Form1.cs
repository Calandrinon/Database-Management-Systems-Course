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
using System.Configuration;

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
        private String selectClientUser, selectSecondTable;
        private String tableClientUser, tableSecond;
        private String foreignKeyRelation;
        private String commonColumn;
        public Form1()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            Console.WriteLine("This is the connection string: {0}", this.connectionString);
            this.selectClientUser = ConfigurationManager.AppSettings["select1"];
            this.selectSecondTable = ConfigurationManager.AppSettings["select2"];
            this.tableClientUser = ConfigurationManager.AppSettings["table1"];
            this.tableSecond = ConfigurationManager.AppSettings["table2"];
            this.foreignKeyRelation = ConfigurationManager.AppSettings["foreignKey"];
            this.commonColumn = ConfigurationManager.AppSettings["column1"];

            databaseConnection = new SqlConnection(this.connectionString);
            dataSet = new DataSet();
            daUser = new SqlDataAdapter(selectClientUser, databaseConnection);
            daTransaction = new SqlDataAdapter(selectSecondTable, databaseConnection);
            SqlCommandBuilder cb = new SqlCommandBuilder(daTransaction);

            label1.Text = tableClientUser + "s";
            label2.Text = tableSecond + "s";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            daUser.Fill(dataSet, tableClientUser);
            daTransaction.Fill(dataSet, tableSecond);

            DataRelation dr = new DataRelation(foreignKeyRelation, dataSet.Tables[tableClientUser].Columns[commonColumn],
                dataSet.Tables[tableSecond].Columns[commonColumn]);
            dataSet.Relations.Add(dr);

            bsUser = new BindingSource();
            bsUser.DataSource = dataSet;
            bsUser.DataMember = tableClientUser;

            bsTransaction = new BindingSource();
            bsTransaction.DataSource = bsUser;
            bsTransaction.DataMember = foreignKeyRelation;

            usersDataGridView.AutoGenerateColumns = true;
            transactionsDataGridView.AutoGenerateColumns = true;
            usersDataGridView.DataSource = bsUser;
            transactionsDataGridView.DataSource = bsTransaction;

            Console.WriteLine("Form load complete.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            daTransaction.Update(dataSet, tableSecond);
        }

    }
}
