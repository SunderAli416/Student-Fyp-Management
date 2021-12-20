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
    public partial class FacultyRecord : UserControl
    {
        public string eid;
        public string email;
        public string code;
        public string title;
        public string fname;
        public string lname;
        public string designation;
        public string status;
        public FacultyRecord(string eid, string email, string code, string title, string fname, string lname, string designation, string status)
        {
            InitializeComponent();
            this.eid = eid;
            this.email = email;
            this.code = code;
            this.title = title;
            this.fname = fname;
            this.lname = lname;
            this.designation = designation;
            this.status = status;

            eidLabel.Text = eid;
            emailLabel.Text = email;
            codeLabel.Text = code;
            titleLabel.Text = title;
            fnamelabel.Text = fname;
            lnameLabel.Text = lname;
            designationLabel.Text = designation;
            statusLabel.Text = status;
            
        }

        private void FacultyRecord_Load(object sender, EventArgs e)
        {

        }

        private void sectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            FacultyEdit edit = new FacultyEdit(eid);
            edit.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"delete from faculty where e_id='{eid}'";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            ((Form)this.TopLevelControl).Hide();
            Faculty student = new Faculty();
            student.ShowDialog();

            Connection.CloseConnection();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            List<string> pids = new List<string>();
            Connection.MakeConnection();
            string query = $"select * from supervisor where s_id='{code}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                pids.Add(result.GetString(1));
            }
            if (pids.Count == 0)
            {
                MessageBox.Show("The faculty member does not have any projects");
                Connection.CloseConnection();
                this.Hide();
                Faculty faculty = new Faculty();
                faculty.ShowDialog();
            }
            else
            {
                Connection.CloseConnection();
                Project project = new Project(pids);
                project.ShowDialog();
            }

            
        }
    }
}
