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
    public partial class MeetingEdit : Form
    {
        string mid;
        public MeetingEdit(string mid)
        {
            this.mid = mid;
            InitializeComponent();
            Connection.MakeConnection();
            string query = $"select * from meetings where meeting_id='{mid}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                startTime.Text = result.GetString(2);
                endTime.Text = result.GetString(3);
                venueInput.Text = result.GetString(4);
                datePicker.Value= DateTime.Parse(result.GetDateTime(1).ToString());

            }
            Connection.CloseConnection();

            Connection.MakeConnection();
            query = "Select * from projects;";
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            List<String> facIds = new List<String>();
            List<String> juryIds = new List<String>();
            List<String> facNames = new List<String>();
            while (result.Read())
            {

                projectButton.Items.Add(result.GetString(0) + " " + result.GetString(1));
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
            foreach (string id in facIds)
            {
                string name;
                Connection.MakeConnection();
                query = $"Select * from faculty where code='{id}';";
                cmd = new MySqlCommand(query, Connection.conn);
                result = cmd.ExecuteReader();

                while (result.Read())
                {
                    name = result.GetString(3) + " " + result.GetString(4) + " " + result.GetString(5);
                    juryButton.Items.Add(juryIds.ElementAt(i) + " " + name);
                }
                i++;
                Connection.CloseConnection();
            }
            }

        private void MeetingEdit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (validate(venueInput.Text, juryButton.Text, projectButton.Text))
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
                string query = $"update meetings set eval_date='{date}',start_time='{start}',end_time='{end}',venue='{venue}',pid='{pid1}',jury_id='{jid2}' where meeting_id='{mid}';";
                var cmd = new MySqlCommand();
                cmd.Connection = Connection.conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Connection.CloseConnection();
                this.Hide();
                Meeting meeting = new Meeting();
                meeting.ShowDialog();
            }
            else
            {
                MessageBox.Show("Make sure to fill all details");
            }
            
        }
        bool validate(string venue, string jid, string pid)
        {
            if (venue == "" || jid == "Choose Jury" || pid == "Choose Project")
            {
                return false;
            }

            return true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meeting form = new Meeting();
            form.ShowDialog();
        }
    }
}
