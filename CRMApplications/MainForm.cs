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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
     
        private void createProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {            
                AddProductsForm addProductsForm = new AddProductsForm();
                addProductsForm.MdiParent = this;
                addProductsForm.Show();
            
        }

        private void searchProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchProductForm searchProductForm = new SearchProductForm();
            searchProductForm.MdiParent = this;
            searchProductForm.Show();          
        }      

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientsForm addClientsForm = new AddClientsForm();
            addClientsForm.MdiParent = this;
            addClientsForm.Show();
        }

        private void createNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrdersForm addOrdersForm = new AddOrdersForm();
            addOrdersForm.MdiParent = this;
            addOrdersForm.Show();
        }

        private void searchOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchOrderForm searchOrderForm = new SearchOrderForm();
            searchOrderForm.MdiParent = this;
            searchOrderForm.Show();
        }
    }
}
