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
                chooseButton.Items.Add(result.GetString(0));
            }
            Connection.CloseConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(validate(pidInput.Text,titleInput.Text,semesterInput.Text,cosupInput.Text,chooseButton.Text))
            {
                if (validateSupervisor(chooseButton.Text))
                {
                    try
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
                    catch
                    {
                        MessageBox.Show("A project with this project id already exists");
                    }
                    

                }
                else
                {
                    MessageBox.Show("This supervisor already has maximum number of projects");
                }


            }
            else
            {
                MessageBox.Show("Make sure to fill all details");
            }
            
        }

        bool validateSupervisor(string sid)
        {
            Connection.MakeConnection();
            string query = $"select * from supervisor where s_id='{sid}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int i = 0;
            while (result.Read())
            {
                i++;
            }
            Connection.CloseConnection();
            if (i >= 6)
            {
                return false;
            }
            return true;
        }

        bool validate(string pid,string title,string semester,string cosup,string sid)
        {
            if(pid=="" || title=="" || semester=="" || cosup=="" || sid=="Choose Supervisor")
            {
                return false;
            }
            return true;
        }
        

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project form = new Project();
            form.ShowDialog();
        }
    }
}
