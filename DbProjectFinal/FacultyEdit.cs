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
    public partial class FacultyEdit : Form
    {
        string eid;
        public FacultyEdit(string eid)
        {
            this.eid = eid;
            InitializeComponent();
            Connection.MakeConnection();
            string query = $"select * from faculty where e_id='{eid}'";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                eidInput.Text = result.GetString(0);
                emailInput.Text = result.GetString(1);
                codeInput.Text = result.GetString(2);
                titleInput.Text = result.GetString(3);
                fnameInput.Text = result.GetString(4);
                lnameInput.Text = result.GetString(5);
                designationInput.Text = result.GetString(6);
                statusInput.Text = result.GetString(7);
            }
            Connection.CloseConnection();
        }

        private void FacultyEdit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();

            string eid1=eidInput.Text;
            string email=emailInput.Text; 
            string code=codeInput.Text;
            string title=titleInput.Text;
            string fname=fnameInput.Text;
            string lname=lnameInput.Text;
            string designation=designationInput.Text;
            string status=statusInput.Text;
            string query = $"update faculty set e_id='{eid1}',email='{email}',code='{code}',title='{title}',f_name='{fname}',l_name='{lname}',designation='{designation}',status='{status}' where e_id='{eid}';";
            var cmd = new MySqlCommand();
            cmd.Connection = Connection.conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            this.Hide();
            Faculty faculty = new Faculty();
            faculty.ShowDialog();
            Connection.CloseConnection();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty form = new Faculty();
            form.ShowDialog();
        }
    }
}
