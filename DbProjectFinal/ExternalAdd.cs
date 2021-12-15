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
            int semester = int.Parse(semesterInput.Text);
            string account = accountInput.Text;
            string query = $"insert into externals values ('{name}','{email}','{phone}','{address}','{company}',{semester},'{account}');";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            this.Hide();
            External external = new External();
            external.ShowDialog();


            Connection.CloseConnection();
        }
    }
}
