using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace api_act8_lustre
{
    public partial class Form1 : Form

    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private async void btnGetAccounts_Click_1(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost/api/api.php?endpoint=accounts");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var accounts = JsonConvert.DeserializeObject(responseBody);
            dataGridView1.DataSource = accounts;
        }



        private async void btnPostAccount_Click_1(object sender, EventArgs e)
        {
            var newAccount = new
            {
                name = txtName.Text,
                username = txtUsername.Text,
                password = txtPassword.Text,
                email = txtEmail.Text,
                id = txtId.Text
            };
            var json = JsonConvert.SerializeObject(newAccount);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost/api/api.php?endpoint=accounts", content);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("Account created!");
        }




        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnPostUser_Click_1(object sender, EventArgs e)
        {
            var newUser = new
            {
                id = txtId.Text,
                name = txtUserNamee.Text,
                username = txtUserUsername.Text
            };
            var json = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost/api/api.php?endpoint=users", content);
            response.EnsureSuccessStatusCode();
            MessageBox.Show("User created!");
        }

        private async void btnGetUsers_Click_1(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost/api/api.php?endpoint=users");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject(responseBody);
            dataGridView2.DataSource = users;
        }

        private void txtUserNamee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
