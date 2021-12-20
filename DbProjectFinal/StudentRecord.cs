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
    public partial class StudentRecord : UserControl
    {
        public string rollNo;
        public string fname;
        public string lname;
        public string section;
        public string pid;
        public StudentRecord(string roll,string fn,string ln,string sec,string pid)
        {
            this.rollNo = roll;
            this.fname = fn;
            this.lname = ln;
            this.section = sec;
            this.pid = pid;
            InitializeComponent();
        }

        public StudentRecord()
        {
            InitializeComponent();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            rollLabel.Text = rollNo;
            fnameLabel.Text = fname;
            lnameLabel.Text = lname;
            sectionLabel.Text = section;
            pidLabel.Text = pid;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            StudentEdit edit = new StudentEdit(rollNo);
            edit.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"select * from grade where roll_no='{rollNo}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int i = 0;
            while (result.Read())
            {
                i++;
            }
            Connection.CloseConnection();
            if (i == 0)
            {
                ((Form)this.TopLevelControl).Hide();
                GradeAdd add = new GradeAdd(rollNo);
                add.ShowDialog();
            }
            else
            {
                ((Form)this.TopLevelControl).Hide();
                GradeEdit edit = new GradeEdit(rollNo);
                edit.ShowDialog();
            }
            Connection.CloseConnection();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            Project project = new Project(pid);
            project.ShowDialog();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"delete from students where roll_no='{rollNo}'";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            ((Form)this.TopLevelControl).Hide();
            Student student = new Student();
            student.ShowDialog();

            Connection.CloseConnection();
        }
    }
}
