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
            SearchAllOrders();
        }
        public void SearchAllOrders() 
        {
            DateTime dateTime;
            if(DateTime.TryParse(textBox1.Text, out dateTime)) 
            {
                var resultDate = OrdersService.GetOrderByDate(dateTime);
                OutputOrdersList(resultDate);
            }
            int number;
            if(int.TryParse(textBox1.Text, out number)) 
            {
                var resultNumber = OrdersService.GetOrderByNumber(number);
                OutputOrdersList(resultNumber);
            }
            Guid clientGuid;
            if(Guid.TryParse(textBox1.Text, out clientGuid)) 
            {
                var resultClientGuid = OrdersService.GetOrdersByClientId(clientGuid);
                OutputOrdersList(resultClientGuid);
            }
            if(Enum.TryParse(textBox1.Text, out Order.OrderStatus orderStatus)) 
            {
                var resultStatus = OrdersService.GetOrdersByStatus(orderStatus);
                OutputOrdersList(resultStatus);
            }
            Guid productGuid;
            if (Guid.TryParse(textBox1.Text, out productGuid)) 
            {
                var resultProductGuid = OrdersService.GetOrdersByProductId(productGuid);
                OutputOrdersList(resultProductGuid);
            }
            string clientPhone = textBox1.Text;
            if (String.IsNullOrWhiteSpace(clientPhone)) 
            {
                var resultPhone = OrdersService.GetOrdersByClientPhone(clientPhone);
                OutputOrdersList(resultPhone);
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
                    listView1.Items.Add("Status: " + item.Status);
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
