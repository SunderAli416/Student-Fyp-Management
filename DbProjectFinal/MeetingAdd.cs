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
    public partial class MeetingAdd : Form
    {
        public MeetingAdd()
        {
            InitializeComponent();
        }

        private void MeetingAdd_Load(object sender, EventArgs e)
        {
            datePicker.CustomFormat = "yyyy-MM-dd";
            Connection.MakeConnection();
            string query = "Select * from projects;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            List<String> facIds=new List<String>();
            List<String> juryIds = new List<String>();
            List<String> facNames = new List<String>();
            while (result.Read())
            {

                projectButton.Items.Add(result.GetString(0)+" "+result.GetString(1));
            }
            Connection.CloseConnection();
            Connection.MakeConnection();
            query = "Select * from jury;";
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                facIds.Add(result.GetString(1));
                juryIds.Add(result.GetString(0));
            }
            Connection.CloseConnection();
            int i = 0;
            foreach(string id in facIds)
            {
                string name;
                Connection.MakeConnection();
                query = $"Select * from faculty where code='{id}';";
                cmd = new MySqlCommand(query, Connection.conn);
                result = cmd.ExecuteReader();
                
                while (result.Read())
                {
                    name = result.GetString(3)+" "+result.GetString(4) + " " + result.GetString(5);
                    juryButton.Items.Add(juryIds.ElementAt(i) + " " + name);
                }
                i++;
                Connection.CloseConnection();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string pid = projectButton.Text;
            int ind1 = pid.IndexOf(' ');
            string pid1 = pid.Substring(0, ind1);
            string jid = juryButton.Text;
            int ind2 = jid.IndexOf(' ');
            string jid2 = jid.Substring(0, ind2);
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string start = startTime.Text;
            string end = endTime.Text;
            string venue = venueInput.Text;
            string query = $"INSERT INTO meetings (eval_date,start_time,end_time,venue,pid,jury_id) values ('{date}','{start}','{end}','{venue}','{pid1}',{jid2});";
            var cmd = new MySqlCommand();
            cmd.Connection = Connection.conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Connection.CloseConnection();
            this.Hide();
            Meeting meeting = new Meeting();
            meeting.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meeting form = new Meeting();
            form.ShowDialog();
        }
    }
}
