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
       
        public AddProductsForm()
                
        {
            InitializeComponent();
        }

        public void productCreate_Click(object sender, EventArgs e)
        {
            var products = new Product();
            products.ProductName = productName.Text;
            products.ProductDescription = productDescription.Text;
            decimal price;
            if (!decimal.TryParse(productPrice.Text, out price))
            {
              MessageBox.Show("Incorrect input. Please try again");
            }
            products.Price = price;
            int number;
            if(!int.TryParse(productNumber.Text, out number)) 
            {
               MessageBox.Show("Incorrect input. Please try again");
            }
            products.ProductNumber = number;
            bool existence;
            if (!bool.TryParse(Console.ReadLine(), out existence))
            {
                MessageBox.Show("Incorrect input. Please try again");
            }
            products.Existence = existence;
            MessageBox.Show("Products guid id: " + products.Id.ToString());
            products.Id = Guid.NewGuid();
           
            ProductService.AddNewProduct(products);
                                           
        }
       



    }


}
