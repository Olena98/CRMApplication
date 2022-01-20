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
    public partial class AddClientsForm : Form
    {
        public AddClientsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateClientFromForm();

        }
        public void CreateClientFromForm() 
        {
            var clients = new Client();
            if (String.IsNullOrWhiteSpace(clientName.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                clients.ClientName = clientName.Text;
            }
            if (String.IsNullOrWhiteSpace(Surname.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                clients.ClientSurname = Surname.Text;
            }
            if (String.IsNullOrWhiteSpace(LastName.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                clients.ClientLastname = LastName.Text;
            }
            if (String.IsNullOrWhiteSpace(Email.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                clients.Email = Email.Text;
            }
            if (String.IsNullOrWhiteSpace(clientPhoneNumber.ToString()))
            {
                MessageBox.Show("Incorrect input. Please try again");
                return;
            }
            else
            {
                clients.PhoneNumber = clientPhoneNumber.Text;
            }
            clients.Id = Guid.NewGuid();

            ClientService.AddNewClient(clients);
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeClient();
        }
        public void ChangeClient() 
        {
            var resultName = ClientService.GetClientByName(DataChangeClient.NameOfClients);
            if (ClientService.GetClientByName(DataChangeClient.NameOfClients).Count > 0)
            {
                int index;

                if (int.TryParse(DataChangeProduct.CountOfProducts.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedName = productName.Text;

                if (String.IsNullOrWhiteSpace(changedName))
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
        }
    }
}
