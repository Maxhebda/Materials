using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zamowienia_WinForms.DataSet1TableAdapters;

namespace Zamowienia_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void downloadData(string customerID)
        {
            DataSet1 myData = new DataSet1();
            CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
            OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();

            customersTableAdapter.Fill(myData.Customers, customerID);
            ordersTableAdapter.Fill(myData.Orders, customerID);

            dataGridView1.DataSource = myData.Tables["Customers"];
            dataGridView2.DataSource = myData.Tables["Orders"];

        }
    }
}
