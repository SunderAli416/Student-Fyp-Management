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
    public partial class FeedbackAdd : Form
    {
        string pid, mid;
        public FeedbackAdd(string pid,string mid)
        {
            this.pid = pid;
            this.mid = mid;
            InitializeComponent();
        }

        private void FeedbackAdd_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string intro = introInput.Text;
            string features = featureInput.Text;
            string methodology = methodologyInput.Text;
            string planning = planningInput.Text;
            string system = systemInput.Text;
            string comment = commentInput.Text;
            string status = statusInput.Text;
            var cmd = new MySqlCommand();
            string query = $"insert into feed_back (pid,introduction,features,methodology,planning,system_diagram,comments,status,meeting_id) values ('{pid}','{intro}','{features}','{methodology}','{planning}','{system}','{comment}','{status}','{mid}');";
            cmd.Connection = Connection.conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Connection.CloseConnection();
            this.Hide();
            Meeting meeting = new Meeting();
            meeting.ShowDialog();
        }
    }
}
