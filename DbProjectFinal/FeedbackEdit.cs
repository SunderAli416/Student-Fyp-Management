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
    public partial class FeedbackEdit : Form
    {
        string pid, mid;
        public FeedbackEdit(string pid,string mid)
        {
            this.pid = pid;
            this.mid = mid;
            InitializeComponent();
        }

        private void FeedbackEdit_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"select * from feed_back where pid='{pid}' and meeting_id='{mid}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                introInput.Text = result.GetString(2);
                featureInput.Text = result.GetString(3);
                methodologyInput.Text = result.GetString(4);
                planningInput.Text = result.GetString(5);
                systemInput.Text = result.GetString(6);
                commentInput.Text = result.GetString(7);
                statusInput.Text = result.GetString(8);
            }

            Connection.CloseConnection();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"update feed_back set introduction='{introInput.Text}',methodology='{methodologyInput.Text}',planning='{planningInput.Text}',system_diagram='{systemInput.Text}',comments='{commentInput.Text}',status='{statusInput.Text}',features='{featureInput.Text}' where pid='{pid}' and meeting_id='{mid}';";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            Connection.CloseConnection();
            this.Hide();
            Meeting meeting = new Meeting();
            meeting.ShowDialog();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            introInput.Enabled = true;
            featureInput.Enabled = true;
            methodologyInput.Enabled = true;
            planningInput.Enabled = true;
            systemInput.Enabled = true;
            commentInput.Enabled = true;
            statusInput.Enabled = true;
            guna2Button2.Visible = false;
            updateButton.Visible = true;
        }
    }
}
