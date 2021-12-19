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
            CreateProductFromForm();                                           
        }
       
        private void CreateProductFromForm()
        {
            var products = new Product();
            if (String.IsNullOrWhiteSpace(productName.ToString())) 
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else 
            {
                products.ProductName = productName.Text;
            }
            if (String.IsNullOrWhiteSpace(productDescription.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else 
            {
                products.ProductDescription = productDescription.Text;
            }         
            decimal price;
            if (!decimal.TryParse(productPrice.Text, out price))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            products.Price = price;
            int number;
            if (!int.TryParse(productNumber.Text, out number))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            products.ProductNumber = number;
            products.Existence = checkBoxProductExistence.Checked;
            products.Id = Guid.NewGuid();

            ProductService.AddNewProduct(products);
        }
    }
}
