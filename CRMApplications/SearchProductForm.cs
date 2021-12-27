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
            MessageBox.Show(ProductService.Products.Count.ToString());
            foreach (var item in ProductService.Products)
            {

                listView1.Items.Add("Product name: ").SubItems.Add(item.ProductName);

            }

        }
        public void SearchProduct() 
        {
        
        }

      
    }
}
