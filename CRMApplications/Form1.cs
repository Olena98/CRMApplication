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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createProductToolStripMenuItem.Checked) 
            {
                AddProductsForm addProductsForm = new AddProductsForm();
                
                addProductsForm.MdiParent = this;
                addProductsForm.Show();
            }
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchProductToolStripMenuItem.Checked) 
            {
                SearchProductForm searchProductForm = new SearchProductForm();
              
                searchProductForm.MdiParent = this;
                searchProductForm.Show();
            }
        }
    }
}
