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
        internal void OutputProductList(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                listView1.Items.Add("Count: " + i);
                listView1.Items.Add("Product name: " + products[i].ProductName);
                listView1.Items.Add("Product description: " + products[i].ProductDescription);
                listView1.Items.Add("Product number: " + products[i].ProductNumber.ToString());
                listView1.Items.Add("Product price: " + products[i].Price.ToString());
                listView1.Items.Add("Product existence: " + products[i].Existence.ToString());
                listView1.Items.Add("Guid: " + products[i].Id.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeProduct();
        }
        public void ChangeProduct() 
        {
            string nameOfProduct = textBox1.Text;           
            var resultName = ProductService.GetProductByName(nameOfProduct);
            OutputProductList(resultName);
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                MessageBox.Show(resultName[index].ToString());
            }
            string changedName = changeProductName.Text;
            if (String.IsNullOrWhiteSpace(changedName))
            {
                Console.WriteLine("Inccorect input, please, try again!");
            }
            else
            {
                if (changedName == resultName[index].ProductName)
                {
                    MessageBox.Show("You entered same name of the product.");
                }
                else
                {
                    var newChangeEntry = new Product.ChangeEntry();
                    newChangeEntry.ProductName = resultName[index].ProductName;
                    resultName[index].ChangeEntries.Add(newChangeEntry);
                    resultName[index].ProductName = changedName;
                    ProductsDataBase.SaveAllProducts();
                }
            }


        }
    }
}
