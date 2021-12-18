using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CRMApplications
{
    public partial class AddProductsForm : Form
    {
        List<AddProductsForm> Products { get; set; }
        public AddProductsForm()
                
        {
            InitializeComponent();
        }

        private void productCreate_Click(object sender, EventArgs e)
        {
            var products = new Product();
            products.ProductName = productName.Text;
            products.Description = productDescription.Text;
            decimal price;
            while (!decimal.TryParse(productPrice.Text, out price))
            {
              MessageBox.Show("Incorrect input. Please try again");
            }
            products.Price = price;
            int number;
            while(!int.TryParse(productNumber.Text, out number)) 
            {
               MessageBox.Show("Incorrect input. Please try again");
            }
            products.ProductNumber = number;
            bool existence;
            while (!bool.TryParse(Console.ReadLine(), out existence))
            {
                MessageBox.Show("Incorrect input. Please try again");
            }
            products.Existence = existence;
            MessageBox.Show("Products guid id: ");
            products.Id = Guid.NewGuid();
            MessageBox.Show(products.Id.ToString());


            foreach (AddProductsForm a in Products)
            {
                MessageBox.Show("Name: " + ProductName + "Description: " + " Number: " + number + "Price: " + price + "Existence: " + existence);
                MessageBox.Show(a.ToString());
            }

           
        }
       
        
      

    }


}
