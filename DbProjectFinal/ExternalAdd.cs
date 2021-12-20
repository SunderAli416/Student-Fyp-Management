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
    public partial class ExternalAdd : Form
    {
        public ExternalAdd()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            var cmd = new MySqlCommand();
            cmd.Connection = Connection.conn;
            string name = nameInput.Text;
            string email = emailInput.Text;
            string phone = phoneInput.Text;
            string address = addressInput.Text;
            string company = companyInput.Text;
            string semester = semesterInput.Text;
            string account = accountInput.Text;
            if (validate(name, email, phone, address, company, semester, account))
            {
                try {
                    string query = $"insert into externals values ('{name}','{email}','{phone}','{address}','{company}','{semester}','{account}');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    External external = new External();
                    external.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Email already exists");
                }
                
            }
            else
            {
                MessageBox.Show("Make sure to fill all details");
            }
            


            Connection.CloseConnection();
        }
        bool validate(string name,string email,string phone,string address,string company,string semester,string account)
        {
            if(name=="" || email=="" || phone=="" || address=="" || company=="" || semester=="" || account == "")
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
