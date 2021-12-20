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
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from projects";
            var cmd = new MySqlCommand(query, Connection.conn);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                chooseButton.Items.Add(result.GetString(0));
            }
            Connection.CloseConnection();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            Connection.MakeConnection();
            string rollNo = rollInput.Text;
            string fname = fnameInput.Text;
            string lname = lnameInput.Text;
            string sectionText = sectionInput.Text;
            char section = sectionText[0];
            string pid = chooseButton.Text;
            if (validate(rollNo, fname, lname, sectionText, chooseButton.Text))
            {
                var cmd = new MySqlCommand();
                cmd.Connection = Connection.conn;
                string query = $"Insert into students values ('{rollNo}','{fname}','{lname}','{section}','{pid}');";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Connection.CloseConnection();
                this.Hide();
                Student students = new Student();
                students.ShowDialog();
            }
            else
            {
                MessageBox.Show("Make Sure to fill all details");
            }
            
        }

        bool validate(string roll,string fname,string lname,string section,string pid)
        {
            if(roll=="" || fname=="" || lname=="" || section=="" || pid=="Choose Project")
            {
                return false;
            }

            return true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student form = new Student();
            form.ShowDialog();
        }
    }
}
