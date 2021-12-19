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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from projects;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            ProjectRecord[] project = new ProjectRecord[count];
            int i = 0;
            Connection.CloseConnection();
            Connection.MakeConnection();
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                

                project[i] = new ProjectRecord(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3));

                flowLayoutPanel1.Controls.Add(project[i]);
                i++;
            }
            Connection.CloseConnection();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectAdd add = new ProjectAdd();
            add.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (searchInput.Text == "")
            {
                MessageBox.Show("Please Enter A Project Id");
            }
            else
            {
                Connection.MakeConnection();
                string query = $"select * from projects where pid='{searchInput.Text}';";
                var cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader result = cmd.ExecuteReader();
                ProjectRecord project;
                if (result.HasRows)
                {
                    flowLayoutPanel1.Controls.Clear();
                    while (result.Read())
                    {
                        project = new ProjectRecord(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3));
                        flowLayoutPanel1.Controls.Add(project);
                    }
                }
                else
                {
                    MessageBox.Show("No projects with that project id exist");
                }
                Connection.CloseConnection();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project project = new Project();
            project.ShowDialog();
        }
    }
}
