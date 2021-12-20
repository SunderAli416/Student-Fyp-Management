using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DbProjectFinal
{
    public partial class ExternalEdit : Form
    {
        string email;
        public ExternalEdit(string email)
        {
            this.email = email;
            InitializeComponent();
            Connection.MakeConnection();
            string query = $"select * from externals where email='{email}';";
            var cmd = new MySqlCommand(query,Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                nameInput.Text = result.GetString(0);
                emailInput.Text = result.GetString(1);
                phoneInput.Text = result.GetString(2);
                addressInput.Text = result.GetString(3);
                companyInput.Text = result.GetString(4);
                semesterInput.Text = result.GetString(5);
                accountInput.Text = result.GetString(6);
            }
            Connection.CloseConnection();
        }

        private void ExternalEdit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name1 = nameInput.Text;
            string email1 = emailInput.Text;
            string phone1 = phoneInput.Text;
            string address1 = addressInput.Text;
            string company1 = companyInput.Text;
            string semester1 = semesterInput.Text;
            string account1 = accountInput.Text;
            Connection.MakeConnection();
            var cmd = new MySqlCommand();
            cmd.Connection = Connection.conn;
            if (validate(name1, email1, phone1, address1, company1, semester1, account1))
            {
                string query = $"update externals set name='{name1}',email='{email1}',phone_no='{phone1}',address='{address1}',company='{company1}',semester='{semester1}',account_no='{account1}' where email='{email}';";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Connection.CloseConnection();
                this.Hide();
                External external = new External();
                external.ShowDialog();
            }
            else
            {
                MessageBox.Show("Make sure to fill All details");
                Connection.CloseConnection();
            }
            
        }

        bool validate(string name, string email, string phone, string address, string company, string semester, string account)
        {
            if (name == "" || email == "" || phone == "" || address == "" || company == "" || semester == "" || account == "")
            {
                return false;
            }
            return true;
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            External form = new External();
            form.ShowDialog();
        }
    }
}
