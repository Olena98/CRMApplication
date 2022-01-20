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
            DateTime.TryParse(textBox1.Text, out dateTime);           
            var resultDate = OrdersService.GetOrderByDate(dateTime);
            OutputOrdersList(resultDate);   
            
            int number;
            bool numberOfOrder = int.TryParse(textBox1.Text, out number);
            var resultNumber = OrdersService.GetOrderByNumber(number);
            OutputOrdersList(resultNumber);    
            
            Guid clientGuid;
            bool clientGuidOfOrder = Guid.TryParse(textBox1.Text, out clientGuid);           
            var resultClientGuid = OrdersService.GetOrdersByClientId(clientGuid);
            OutputOrdersList(resultClientGuid);

            Enum.TryParse(textBox1.Text, out Order.OrderStatus orderStatus);            
            var resultStatus = OrdersService.GetOrdersByStatus(orderStatus);
            OutputOrdersList(resultStatus);  
            
            Guid productGuid;
            Guid.TryParse(textBox1.Text, out productGuid);          
            var resultProductGuid = OrdersService.GetOrdersByProductId(productGuid);
            OutputOrdersList(resultProductGuid);
            
            string clientPhone = textBox1.Text;           
            var resultPhone = OrdersService.GetOrdersByClientPhone(clientPhone);
            OutputOrdersList(resultPhone);
            

        }
        internal void OutputOrdersList(List<Order>orders)  
        {
           
            for (int i = 0; i < orders.Count; i++)
            {
                listView1.Items.Add("Order №: " + i + "(" + orders[i].OrderDate + "," + orders[i].Status + orders[i].OrderNumber + ")");
                listView1.Focus();

            }

        }

        private void orderChange_Click(object sender, EventArgs e)
        {
            DataChangeOrder.CountOfOrders = listView1.SelectedIndices[0];
            DateTime dateTime;
            DateTime.TryParse(textBox1.Text, out dateTime);            
            DataChangeOrder.DateOfOrders = dateTime;
            Enum.TryParse(textBox1.Text, out Order.OrderStatus orderStatus);
            DataChangeOrder.StatusOfOrders = orderStatus;
            AddOrdersForm addOrdersForm = new AddOrdersForm();
            addOrdersForm.Show();
        }
    }
}
