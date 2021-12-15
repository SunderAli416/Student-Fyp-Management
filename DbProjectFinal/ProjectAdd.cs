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
    public partial class ProjectAdd : Form
    {
        public ProjectAdd()
        {
            InitializeComponent();
        }

        private void ProjectAdd_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from faculty";
            var cmd = new MySqlCommand(query, Connection.conn);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                chooseButton.Items.Add(result.GetString(2));
            }
            Connection.CloseConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string pid = pidInput.Text;
            string title = titleInput.Text;
            string semester = semesterInput.Text;
            string cosup = cosupInput.Text;
            var cmd = new MySqlCommand();
            string query = $"INSERT into projects values ('{pid}','{title}','{semester}','{cosup}');";
            cmd.Connection = Connection.conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            query = $"INSERT into supervisor values ('{chooseButton.Text}','{pid}');";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Connection.CloseConnection();

            this.Hide();
            Project project = new Project();
            project.ShowDialog();
        }
    }
}
