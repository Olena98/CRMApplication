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
       
        public void CreateProductFromForm()
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
               products.ProductNumber =  UniqueNumericNumberHelper.GetUniqueProductNumericNumber();
            }
            else 
            {
                products.ProductNumber = number;
            }
          
            products.Existence = checkBoxProductExistence.Checked;
            products.Id = Guid.NewGuid();

            ProductService.AddNewProduct(products);
            
        }     

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show(DataChangeProduct.Count.ToString());

        }
        public void ChangeProduct() 
        {
           
            var resultName = ProductService.GetProductByName(DataChangeProduct.Name);

            int index;
            if (int.TryParse(DataChangeProduct.Count.ToString(), out index))
            {

                MessageBox.Show(resultName[index].ToString());

            }
            MessageBox.Show(index.ToString());
            string changedName = productName.Text;
            if (String.IsNullOrWhiteSpace(changedName))
            {
                MessageBox.Show("Inccorect input, please, try again!");
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
