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
    public partial class GradeEdit : Form
    {
        string roll;
        public GradeEdit(string roll)
        {
            this.roll = roll;
            InitializeComponent();
        }

        private void GradeEdit_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"select * from grade where roll_no='{roll}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result= cmd.ExecuteReader();
            while (result.Read())
            {
                grade1Input.Text = result.GetString(1);
                grade2Input.Text = result.GetString(2);
                grade3Input.Text = result.GetString(3);
                grade4Input.Text = result.GetString(4);
            }
            fyp1.Text = gradeCalc(Int32.Parse(grade1Input.Text), Int32.Parse(grade2Input.Text));
            fyp2.Text = gradeCalc(Int32.Parse(grade3Input.Text), Int32.Parse(grade4Input.Text));
            Connection.CloseConnection();
        }

        private string gradeCalc(int mark1,int mark2)
        {
            return "A1";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            grade1Input.Enabled = true;
            grade2Input.Enabled = true;
            grade3Input.Enabled = true;
            grade4Input.Enabled = true;
            guna2Button2.Visible = false;
            updateButton.Visible = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"Update grade set fyp_1_mid={grade1Input.Text},fyp_1_final={grade2Input.Text},fyp_2_mid={grade3Input.Text},fyp_2_final={grade4Input.Text} where roll_no='{roll}';";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            
            Connection.CloseConnection();
            this.Hide();
            Student student = new Student();
            student.ShowDialog();
        }
    }
}
