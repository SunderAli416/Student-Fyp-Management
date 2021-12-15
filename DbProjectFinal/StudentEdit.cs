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
    public partial class StudentEdit : Form
    {
        string roll;
        public StudentEdit(string roll)
        {
            this.roll = roll;
            InitializeComponent();
            Connection.MakeConnection();
            string query = $"select * from students where roll_no='{roll}'";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                rollInput.Text = result.GetString(0);
                fnameInput.Text = result.GetString(1);
                lnameInput.Text = result.GetString(2);
                sectionInput.Text = result.GetString(3);
                chooseButton.Text = result.GetString(4);
            }
            Connection.CloseConnection();
            Connection.MakeConnection();
            query = $"select * from projects";
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                chooseButton.Items.Add(result.GetString(0));
            }

            Connection.CloseConnection();
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string rollNo = rollInput.Text;
            string fname = fnameInput.Text;
            string lname = lnameInput.Text;
            string section = sectionInput.Text;
            string pid = chooseButton.Text;
            string query = $"UPDATE students set roll_no='{rollNo}',f_name='{fname}',l_name='{lname}',section='{section}',pid='{pid}' where roll_no='{roll}';";
            Connection.MakeConnection();
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            this.Hide();
            Student student = new Student();
            student.ShowDialog();
            Connection.CloseConnection();
        }
    }
}
