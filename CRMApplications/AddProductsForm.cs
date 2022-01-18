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
            ChangeProduct();
        }
        public void ChangeProduct() 
        {
            var resultName = ProductService.GetProductByName(DataChangeProduct.NameOfProducts);
            var resultDescription = ProductService.GetProductByDescription(DataChangeProduct.NameOfProducts);
            var resultPrice = ProductService.GetProductByPrice(DataChangeProduct.Price);
            var resultNumber = ProductService.GetProductByNumber(DataChangeProduct.NumberOfProducts);
            var resultExistence = ProductService.GetProductByExistence(DataChangeProduct.ExistenceOfProducts);
            if (ProductService.GetProductByName(DataChangeProduct.NameOfProducts).Count>0)
            {
                int index;
                
                if (int.TryParse(DataChangeProduct.CountOfProducts.ToString(), out index) )
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedName = productName.Text;
              
                if (String.IsNullOrWhiteSpace(changedName) )
                {
                    MessageBox.Show("Inccorect input, please, try again!1");
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
            if(ProductService.GetProductByDescription(DataChangeProduct.NameOfProducts).Count > 0) 
            {
                int index;
                if (int.TryParse(DataChangeProduct.CountOfProducts.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedDescription = productDescription.Text;
               
                if (String.IsNullOrWhiteSpace(changedDescription))
                {
                    MessageBox.Show("Inccorect input, please, try again!2");
                }
                else
                {
                    if (changedDescription == resultDescription[index].ProductDescription)
                    {
                        MessageBox.Show("You entered same name of the product.");
                    }
                    else
                    {
                        var newChangeEntry = new Product.ChangeEntry();
                        
                        newChangeEntry.ProductDescription = resultDescription[index].ProductDescription;
                        resultDescription[index].ChangeEntries.Add(newChangeEntry);
                        resultDescription[index].ProductDescription = changedDescription;
                      
                        ProductsDataBase.SaveAllProducts();
                    }
                }
            }
            if (ProductService.GetProductByPrice(DataChangeProduct.Price).Count > 0)
            {
                int index;
                if (int.TryParse(DataChangeProduct.CountOfProducts.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                decimal changedPrice;
                if (decimal.TryParse(productPrice.Text, out changedPrice))
                {
                    if (changedPrice == resultPrice[index].Price)
                    {
                        Console.WriteLine("You entered same price of the product.");
                    }
                    else
                    {
                        var newChangeEntry = new Product.ChangeEntry();
                        newChangeEntry.Price = resultPrice[index].Price;
                        resultPrice[index].ChangeEntries.Add(newChangeEntry);
                        resultPrice[index].Price = changedPrice;
                        ProductsDataBase.SaveAllProducts();
                    }
                }
            }
                if (ProductService.GetProductByNumber(DataChangeProduct.NumberOfProducts).Count > 0)
                {
                    int indexOfNumber;
                    if (int.TryParse(DataChangeProduct.CountOfProducts.ToString(), out indexOfNumber))
                    {
                        MessageBox.Show("Thank`s, your count: " + indexOfNumber);
                    }
                    int changedNumber;
                    if (int.TryParse(productNumber.Text, out changedNumber))
                    {
                        if (changedNumber == resultNumber[indexOfNumber].ProductNumber)
                        {
                            Console.WriteLine("You entered same price of the product.");
                        }
                        else
                        {
                            var newChangeEntry = new Product.ChangeEntry();
                            newChangeEntry.ProductNumber = resultNumber[indexOfNumber].ProductNumber;
                            resultNumber[indexOfNumber].ChangeEntries.Add(newChangeEntry);
                            resultNumber[indexOfNumber].ProductNumber = changedNumber;
                            ProductsDataBase.SaveAllProducts();
                        }
                    }
                }
            if (ProductService.GetProductByExistence(DataChangeProduct.ExistenceOfProducts).Count > 0)
            {
                int indexOfExistence;
                if (int.TryParse(DataChangeProduct.CountOfProducts.ToString(), out indexOfExistence))
                {
                    MessageBox.Show("Thank`s, your count: " + indexOfExistence);
                }
                bool changedExistence;
                if (bool.TryParse(checkBoxProductExistence.Checked.ToString(), out changedExistence))
                {
                    if (changedExistence == resultExistence[indexOfExistence].Existence)
                    {
                        Console.WriteLine("You entered same price of the product.");
                    }
                    else
                    {
                        var newChangeEntry = new Product.ChangeEntry();
                        newChangeEntry.Existence = resultExistence[indexOfExistence].Existence;
                        resultExistence[indexOfExistence].ChangeEntries.Add(newChangeEntry);
                        resultExistence[indexOfExistence].Existence = changedExistence;
                        ProductsDataBase.SaveAllProducts();
                    }
                }
            }


        }
    }
       
       
       
    
}
