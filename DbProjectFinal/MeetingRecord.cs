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
    public partial class MeetingRecord : UserControl
    {
        string mid, date, start, end, venue, pid, juryid;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            Connection.MakeConnection();
            string query = $"select * from feed_back where pid='{pid}' and meeting_id='{mid}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            if (count == 0)
            {
                Connection.CloseConnection();
                FeedbackAdd feedback = new FeedbackAdd(pid, mid);
                feedback.ShowDialog();
            }
            else
            {
                Connection.CloseConnection();
                FeedbackEdit feedback = new FeedbackEdit(pid, mid);
                feedback.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            MeetingEdit edit = new MeetingEdit(mid);
            edit.ShowDialog();
        }

        private void endLabel_Click(object sender, EventArgs e)
        {

        }

        public MeetingRecord(string mid,string date,string start,string end,string venue,string pid,string juryid)
        {
            this.mid = mid;
            this.date = date;
            this.start = start;
            this.end = end;
            this.venue = venue;
            this.pid = pid;
            this.juryid = juryid;
            InitializeComponent();
            midLabel.Text = mid;
            dateLabel.Text = date;
            startLabel.Text = start;
            endLabel.Text = end;
            venueLabel.Text = venue;
            pidLabel.Text = pid;
            juryidLabel.Text = juryid;
        }

        private void MeetingRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
