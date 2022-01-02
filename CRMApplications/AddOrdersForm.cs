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
    public partial class AddOrdersForm : Form
    {
        public AddOrdersForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateOrderFromForm();
        }
        public void CreateOrderFromForm()
        {
            var order = new Order();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd:MM:yyyy HH:mm";
            order.OrderDate = dateTimePicker1.Value;
            MessageBox.Show(order.OrderDate.ToString());
            int ordersNumber;
            if (!int.TryParse(orderNumber.Text, out ordersNumber))
            {
               order.OrderNumber = UniqueNumericNumberHelper.GetUniqueOrderNumericNumber();
              
            }
            else 
            {
                order.OrderNumber = ordersNumber;
            }
            
            order.Id = Guid.NewGuid();
            order.ClientGuid = Guid.Parse(textBox2.Text);
            order.ProductGuid = Guid.Parse(textBox1.Text);
            if (String.IsNullOrWhiteSpace(textBox3.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                order.ClientPhone = textBox3.Text;
            }
            if (Enum.TryParse(comboBox1.Text, out Order.OrderStatus status))
            {
               
                order.Status = status;
                MessageBox.Show(status.ToString());
            }
            else
            {
                order.Status = Order.OrderStatus.New;
               
            }
            OrdersService.AddNewOrder(order);

        }
    }
}
