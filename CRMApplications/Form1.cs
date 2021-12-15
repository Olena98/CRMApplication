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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                AddProductsForm addProductsForm = new AddProductsForm();
                addProductsForm.Show();
                this.Visible = false;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
