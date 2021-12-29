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
    public partial class SearchClientForm : Form
    {
        public SearchClientForm()
        {
            InitializeComponent();
        }

        private void SearchClient_Click(object sender, EventArgs e)
        {
            SearchAllClient();
        }
        public void SearchAllClient() 
        {
            string nameOfClient = textBox1.Text;
            if (String.IsNullOrWhiteSpace(nameOfClient))
            {
                MessageBox.Show("Incorrect input!");
            }
            else
            {
                var resultName = ClientService.GetClientByName(nameOfClient);
                OutputClientList(resultName);
            }
            string surnameOfClient = textBox1.Text;
            if (String.IsNullOrWhiteSpace(surnameOfClient))
            {
                MessageBox.Show("Incorrect input!");
            }
            else
            {
                var resultSurname = ClientService.GetClientBySurname(surnameOfClient);
                OutputClientList(resultSurname);
            }
            string lastnameOfClient = textBox1.Text;
            if (String.IsNullOrWhiteSpace(lastnameOfClient)) 
            {
                MessageBox.Show("Incorrect input!");
            }
            else 
            {
                var resultLastname = ClientService.GetClientByLastname(lastnameOfClient);
                OutputClientList(resultLastname);
            }
            string emailOfClient = textBox1.Text;
            if (String.IsNullOrWhiteSpace(emailOfClient)) 
            {
                MessageBox.Show("Incorrect input!");
            }
            else 
            {
                var resultEmail = ClientService.GetClientByEmail(emailOfClient);
                OutputClientList(resultEmail);
            }
            string phoneOfClient = textBox1.Text;
            if (String.IsNullOrWhiteSpace(phoneOfClient)) 
            {
                MessageBox.Show("Incorrect input!");
            }
            else 
            {
                var resultPhone = ClientService.GetClientByPhone(phoneOfClient);
                OutputClientList(resultPhone);
            }
            Guid guid; 
            if(Guid.TryParse(textBox1.Text, out guid))
            {
                var resultId = ClientService.GetClientByGuid(guid);
                OutputClientList(resultId);
            }
            
           
        }
        internal void OutputClientList(List<Client> clients)
        {
            if (clients.Count != 0)
            {
                MessageBox.Show("Count of products: " + clients.Count);
                foreach (var item in clients)
                {
                    listView1.Items.Add(item.ClientName);
                    listView1.Items.Add(item.ClientSurname);
                    listView1.Items.Add(item.ClientLastname);
                    listView1.Items.Add(item.Email);
                    listView1.Items.Add(item.PhoneNumber);
                    listView1.Items.Add(item.Id.ToString());
                }
            }

        }
    }
}
