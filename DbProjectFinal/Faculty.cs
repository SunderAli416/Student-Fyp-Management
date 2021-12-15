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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from faculty;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            FacultyRecord[] faculty = new FacultyRecord[count];
            int i = 0;
            Connection.CloseConnection();
            Connection.MakeConnection();
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {

                faculty[i] = new FacultyRecord(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6), result.GetString(7));

                flowLayoutPanel1.Controls.Add(faculty[i]);
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
