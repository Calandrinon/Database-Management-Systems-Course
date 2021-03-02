using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayUsersButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");
            String[] row = {"some id", "some other stuff", "some more", "less"};
            ListViewItem listViewItem = new ListViewItem(row);
            usersListView.Items.Add(listViewItem);
        }
    }
}
