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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from students;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            StudentRecord[] students = new StudentRecord[count];
            int i = 0;
            Connection.CloseConnection();
            Console.Write("Closed here");
            Connection.MakeConnection();
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();

            while (result.Read())
            {
                Console.WriteLine("Helow");
                students[i] = new StudentRecord();
                students[i].rollNo = result.GetString(0);
                students[i].fname = result.GetString(1);
                students[i].lname = result.GetString(2);
                students[i].section += result.GetChar(3);
                students[i].pid = result.GetString(4);
                flowLayoutPanel1.Controls.Add(students[i]);
                i++;
            }

            Connection.CloseConnection();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
