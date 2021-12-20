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
        string pid;
        public Student()
        {
            this.pid = "";
            InitializeComponent();
        }
        public Student(string pid)
        {
            this.pid = pid;
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
            string query;
            if (pid == "")
            {
                query = "select * from students;";
            }
            else
            {
                query = $"select * from students where pid='{pid}';";
            }
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAdd add = new StudentAdd();
            add.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (searchInput.Text == "")
            {
                MessageBox.Show("Please Enter A Roll No");
            }
            else
            {
                Connection.MakeConnection();
                string query = $"select * from students where roll_no='{searchInput.Text}';";
                var cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader result = cmd.ExecuteReader();
                StudentRecord studentRecord;
                if (result.HasRows)
                {
                    flowLayoutPanel1.Controls.Clear();
                    while (result.Read())
                    {
                        studentRecord = new StudentRecord(result.GetString(0), result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4));
                        flowLayoutPanel1.Controls.Add(studentRecord);
                    }
                }
                else
                {
                    MessageBox.Show("No record with that roll number found");
                }
                

                Connection.CloseConnection();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.ShowDialog();
        }
    }
}
