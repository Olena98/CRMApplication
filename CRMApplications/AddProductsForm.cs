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
    public partial class AddProductsForm : Form
    {
        public static List<AddProductsForm> Products = new List<AddProductsForm>();
       
        public AddProductsForm( decimal price) { }
        public AddProductsForm(int number) { }      
        public AddProductsForm(string name) { }
       
        public AddProductsForm(bool existence) { }

        public AddProductsForm()
                
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            decimal price = decimal.Parse(productPrice.Text);
            Products.Add(new AddProductsForm (price));
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            int number = int.Parse(productNumber.Text);
            Products.Add(new AddProductsForm(number));
           
        }

        private void AddProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
            
            string name = productName.Text.ToString();
            Products.Add(new AddProductsForm(name));
            
        }

        private void productDescription_TextChanged(object sender, EventArgs e)
        {
            
            string description = productDescription.Text.ToString();
           
            
        }

        private void productExistence_TextChanged(object sender, EventArgs e)
        {
            bool existence = bool.Parse(productExistence.Text);
            Products.Add(new AddProductsForm(existence));
           
        }

        private void productCreate_Click(object sender, EventArgs e)
        {
           foreach(AddProductsForm a in Products) 
            {
                MessageBox.Show(productName.ToString() + productPrice.ToString() + productNumber.ToString());
                
            }
        }
        
    }
}
