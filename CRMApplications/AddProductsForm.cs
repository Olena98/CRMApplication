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
            var products = new AddProductsForm();
            List<AddProductsForm> Product = new List<AddProductsForm>();

            string name = productName.Text;
            string description = productDescription.Text;
            int number = int.Parse(productNumber.Text);
            decimal price = decimal.Parse(productPrice.Text);
            bool existence = bool.Parse(productExistence.Text);
            Product.Add(products);
            foreach (AddProductsForm a in Products)
            {
                MessageBox.Show("Name: " + name + "Description: " + description + " Number: " + number + "Price: " + price + "Existence: " + existence);
                MessageBox.Show(a.ToString());
            }

           
        }
       
        
      

    }


}
