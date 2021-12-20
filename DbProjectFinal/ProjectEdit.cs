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
    public partial class ProjectEdit : Form
    {
        string pid;
        public ProjectEdit(string pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void ProjectEdit_Load(object sender, EventArgs e)
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

            Connection.MakeConnection();
            query = $"select * from projects where pid='{pid}'";
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                pidInput.Text = pid;
                titleInput.Text = result.GetString(1);
                semesterInput.Text = result.GetString(2);
                cosupInput.Text = result.GetString(3);
            }
            Connection.CloseConnection();
            Connection.MakeConnection();
            query = $"select * from supervisor where pid='{pid}'";
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                chooseButton.Text = result.GetString(0);
            }
            Connection.CloseConnection();

            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string pid1 = pidInput.Text;
            string title1 = titleInput.Text;
            string semester1 = semesterInput.Text;
            string cosup1 = cosupInput.Text;
            if (validate(pid1, title1, semester1, cosup1, chooseButton.Text))
            {
                if (validateSupervisor(chooseButton.Text))
                {
                    try
                    {
                        Connection.MakeConnection();
                        var cmd = new MySqlCommand();
                        cmd.Connection = Connection.conn;
                        string query = $"update projects set pid='{pid1}',title='{title1}',semester='{semester1}',cosupervisor='{cosup1}' where pid='{pid}';";
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        Connection.CloseConnection();
                        Connection.MakeConnection();
                        string supervisor = chooseButton.Text;
                        query = $"update supervisor set s_id='{supervisor}' where pid='{pid}'";
                        cmd.Connection = Connection.conn;
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
                    Console.WriteLine("e");
                }
                
            }
            else
            {
                MessageBox.Show("Make Sure to fill all details");
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

        bool validate(string pid, string title, string semester, string cosup, string sid)
        {
            if (pid == "" || title == "" || semester == "" || cosup == "" || sid == "Choose Supervisor")
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
