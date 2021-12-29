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
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            order.OrderNumber = ordersNumber;
            order.Id = Guid.NewGuid();
            order.ClientGuid = Guid.Parse(textBox1.Text);
            order.ProductGuid = Guid.Parse(textBox2.Text);
            if (String.IsNullOrWhiteSpace(textBox3.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                order.ClientPhone = textBox3.Text;
            }
            if (!Enum.TryParse(Console.ReadLine(), out Order.OrderStatus status))
            {
                order.Status = Order.OrderStatus.New;
            }
            else 
            {
                order.Status = status;
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedStatus);
            
        }
    }
}
