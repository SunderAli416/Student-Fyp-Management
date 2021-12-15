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
    }
}
