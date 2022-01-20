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

                if (int.TryParse(DataChangeClient.CountOfClients.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedName = clientName.Text;

                if (String.IsNullOrWhiteSpace(changedName))
                {
                    MessageBox.Show("Inccorect input, please, try again!1");
                }
                else
                {
                    if (changedName == resultName[index].ClientName)
                    {
                        MessageBox.Show("You entered same name of the client.");
                    }
                    else
                    {
                        var newChangeEntry = new Client.ChangeEntry();
                        newChangeEntry.Name = resultName[index].ClientName;
                        resultName[index].ChangesEntries.Add(newChangeEntry);
                        resultName[index].ClientName = changedName;

                        ClientsDataBase.SaveAllClient();
                    }
                }
            }
            var resultSurname = ClientService.GetClientBySurname(DataChangeClient.SurnameOfClients);
            if (ClientService.GetClientBySurname(DataChangeClient.SurnameOfClients).Count > 0)
            {
                int index;

                if (int.TryParse(DataChangeClient.CountOfClients.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedSurname = Surname.Text;

                if (String.IsNullOrWhiteSpace(changedSurname))
                {
                    MessageBox.Show("Inccorect input, please, try again!1");
                }
                else
                {
                    if (changedSurname == resultSurname[index].ClientSurname)
                    {
                        MessageBox.Show("You entered same name of the client.");
                    }
                    else
                    {
                        var newChangeEntry = new Client.ChangeEntry();
                        newChangeEntry.Surname = resultSurname[index].ClientSurname;
                        resultSurname[index].ChangesEntries.Add(newChangeEntry);
                        resultSurname[index].ClientSurname = changedSurname;

                        ClientsDataBase.SaveAllClient();
                    }
                }
            }
            var resultEmail = ClientService.GetClientByEmail(DataChangeClient.EmailOfClients);
            if (ClientService.GetClientByEmail(DataChangeClient.EmailOfClients).Count > 0)
            {
                int index;

                if (int.TryParse(DataChangeClient.CountOfClients.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedEmail = Email.Text;

                if (String.IsNullOrWhiteSpace(changedEmail))
                {
                    MessageBox.Show("Inccorect input, please, try again!1");
                }
                else
                {
                    if (changedEmail == resultEmail[index].Email)
                    {
                        MessageBox.Show("You entered same name of the client.");
                    }
                    else
                    {
                        var newChangeEntry = new Client.ChangeEntry();
                        newChangeEntry.Email = resultEmail[index].Email;
                        resultEmail[index].ChangesEntries.Add(newChangeEntry);
                        resultEmail[index].Email = changedEmail;

                        ClientsDataBase.SaveAllClient();
                    }
                }
            }
            var resultPhone = ClientService.GetClientByPhone(DataChangeClient.PhoneOfClients);
            if (ClientService.GetClientByPhone(DataChangeClient.PhoneOfClients).Count > 0)
            {
                int index;

                if (int.TryParse(DataChangeClient.CountOfClients.ToString(), out index))
                {
                    MessageBox.Show("Thank`s, your count: " + index);
                }
                string changedPhone = clientPhoneNumber.Text;

                if (String.IsNullOrWhiteSpace(changedPhone))
                {
                    MessageBox.Show("Inccorect input, please, try again!1");
                }
                else
                {
                    if (changedPhone == resultPhone[index].PhoneNumber)
                    {
                        MessageBox.Show("You entered same name of the client.");
                    }
                    else
                    {
                        var newChangeEntry = new Client.ChangeEntry();
                        newChangeEntry.PhoneNumber = resultPhone[index].PhoneNumber;
                        resultPhone[index].ChangesEntries.Add(newChangeEntry);
                        resultPhone[index].PhoneNumber = changedPhone;

                        ClientsDataBase.SaveAllClient();
                    }
                }
            }
        }
    }
}
