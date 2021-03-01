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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            message.Text = "";
            String connectionString = "Data Source=DESKTOP-KPQA7E3\\SQLEXPRESS; Initial Catalog=OnlineMusicStore; Integrated Security=true";
            DataSet ds = new DataSet();

            using (SqlConnection dbConn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Artist", dbConn);
                dbConn.Open();
                da.Fill(ds, "Artist");
                DataTable dt = ds.Tables["Artist"];
                foreach (DataRow row in dt.Rows)
                {
                    message.Text += row["Name"] + "\n";
                }
            }
        }
    }
}
