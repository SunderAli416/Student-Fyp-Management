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
    public partial class ProjectRecord : UserControl
    {
        public string pid;
        public string title;
        public string semester;
        public string cosup;
        
        public ProjectRecord(string pid, string title, string semester, string cosup)
        {
            this.pid = pid;
            this.title = title;
            this.semester = semester;
            this.cosup = cosup;
            
            InitializeComponent();
            pidLabel.Text = pid;
            titleLabel.Text = title;
            semesterLabel.Text = semester;
            cosupLabel.Text = cosup;
           
        }

        private void ProjectRecord_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            ProjectEdit edit = new ProjectEdit(pid);
            edit.ShowDialog();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"delete from projects where pid='{pid}'";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            ((Form)this.TopLevelControl).Hide();
            Project student = new Project();
            student.ShowDialog();

            Connection.CloseConnection();
        }

        private void cosupLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            Student student = new Student(pid);
            student.ShowDialog();
        }
    }
}
