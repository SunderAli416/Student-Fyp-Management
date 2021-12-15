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
    public partial class FacultyAdd : Form
    {
        public FacultyAdd()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();

            string eid = eidInput.Text;
            string email = emailInput.Text;
            string code = codeInput.Text;
            string title = titleInput.Text;
            string fname = fnameInput.Text;
            string lname = lnameInput.Text;
            string designation = designationInput.Text;
            string status = statusInput.Text;
            var cmd = new MySqlCommand();
            cmd.Connection = Connection.conn;
            string query = $"INSERT into faculty values ('{eid}','{email}','{code}','{title}','{fname}','{lname}','{designation}','{status}');";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            Connection.CloseConnection();
            this.Hide();
            Faculty faculty = new Faculty();
            faculty.ShowDialog();
        }
    }
}
