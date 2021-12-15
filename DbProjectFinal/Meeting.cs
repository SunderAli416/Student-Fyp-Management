﻿using System;
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
    public partial class Meeting : Form
    {
        public Meeting()
        {
            InitializeComponent();
        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from meetings;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            MeetingRecord[] meeting = new MeetingRecord[count];
            int i = 0;
            Connection.CloseConnection();
            Connection.MakeConnection();
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                string mystr = result.GetValue(1).ToString();
                meeting[i] = new MeetingRecord(result.GetString(0), result.GetValue(1).ToString().Substring(0,mystr.IndexOf(' ')), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(6));

                flowLayoutPanel1.Controls.Add(meeting[i]);
                i++;
            }
            Connection.CloseConnection();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MeetingAdd add = new MeetingAdd();
            add.ShowDialog();
        }
    }
}
