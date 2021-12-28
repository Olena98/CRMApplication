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
    public partial class SearchProductForm : Form
    {
        public SearchProductForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }
        public void SearchProduct() 
        {
            string nameOfProduct = textBox1.Text;
            if (String.IsNullOrWhiteSpace(nameOfProduct))
            {
                MessageBox.Show("Incorrect input!");
            }
            else
            {
                var resultName = ProductService.GetProductByName(nameOfProduct);
                OutputProductList(resultName);
                
            }
            string description = textBox1.Text;
            if (String.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Incorrect input!");
            }
            else
            {
                var resultDescription = ProductService.GetProductByDescription(description);
                OutputProductList(resultDescription);                
            }
            decimal price;
            if (decimal.TryParse(textBox1.Text, out price))
            {                
                var resultPrice = ProductService.GetProductByPrice(price);
                OutputProductList(resultPrice);
            }
           
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {              
                var resultNumber = ProductService.GetProductByNumber(number);
                OutputProductList(resultNumber);
            }
             
            bool existence;
            if (bool.TryParse(textBox1.Text, out existence))
            {              
                var resultExistence = ProductService.GetProductByExistence(existence);
                OutputProductList(resultExistence);
            }
            
            Guid guid;
            if (Guid.TryParse(textBox1.Text, out guid))
            {
                var resultId = ProductService.GetProductByGuid(guid);
                OutputProductList(resultId);            
            }
           
        }
        internal void OutputProductList(List<Product>products) 
        {
            if (products.Count != 0) 
            {
                MessageBox.Show("Count of products: " + products.Count);
                foreach (var item in products)
                {
                    listView1.Items.Add(item.ProductName);
                    listView1.Items.Add(item.ProductDescription);
                    listView1.Items.Add(item.ProductNumber.ToString());
                    listView1.Items.Add(item.Price.ToString());
                    listView1.Items.Add(item.Existence.ToString());
                    listView1.Items.Add(item.Id.ToString());
                }
             
            }
           
        }

      
    }
}
