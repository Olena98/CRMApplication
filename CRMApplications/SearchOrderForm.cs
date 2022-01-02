using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMApplications
{
    public partial class SearchOrderForm : Form
    {
        public SearchOrderForm()
        {
            InitializeComponent();
        }


        private void SearchOrders_Click(object sender, EventArgs e)
        {

        }
        public void SearchAllOrders() 
        {
            DateTime dateTime;
            if(DateTime.TryParse(textBox1.Text, out dateTime)) 
            {
               
            }
        }
        internal void OutputOrdersList(List<Order>orders)  
        {
            if (orders.Count != 0)
            {
                MessageBox.Show("Count of orders: " + orders.Count);
                foreach (var item in orders)
                {
                    listView1.Items.Add("Order date: " + item.OrderDate.ToString());
                    listView1.Items.Add("Order number: " + item.OrderNumber.ToString());
                    listView1.Items.Add("Client guid id: " + item.ClientGuid.ToString());
                    listView1.Items.Add("Product guid id: " + item.ProductGuid.ToString());
                    listView1.Items.Add("Client phone: " + item.ClientPhone.ToString());
                    listView1.Items.Add("Guid: " + item.Id.ToString());
                }
            }

        }
    }
}
