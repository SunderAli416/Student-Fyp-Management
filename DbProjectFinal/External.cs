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
    public partial class External : Form
    {
        public External()
        {
            InitializeComponent();
        }

        private void External_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from externals;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            ExternalRecord[] external = new ExternalRecord[count];
            int i = 0;
            Connection.CloseConnection();
            Connection.MakeConnection();
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {

                external[i] = new ExternalRecord(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6));

                flowLayoutPanel1.Controls.Add(external[i]);
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
            ExternalAdd add = new ExternalAdd();
            add.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            External external = new External();
            external.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (searchInput.Text == "")
            {
                MessageBox.Show("Please Enter An email address");
            }
            else
            {
                Connection.MakeConnection();
                string query = $"select * from externals where email='{searchInput.Text}';";
                var cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader result = cmd.ExecuteReader();
                ExternalRecord external;
                if (result.HasRows)
                {
                    flowLayoutPanel1.Controls.Clear();
                    while (result.Read())
                    {
                        external = new ExternalRecord(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6));
                        flowLayoutPanel1.Controls.Add(external);
                    }
                }
                else
                {
                    MessageBox.Show("No external with that email exists");
                }
                Connection.CloseConnection();
            }
        }
    }
}
