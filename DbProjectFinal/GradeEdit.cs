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
            int sum = mark1 + mark2;
            float avg = (float)sum / 2;
            if (avg < 5)
                return "F";
            else if (avg >= 5 && avg < 6)
                return "D";
            else if (avg >= 6 && avg < 7)
                return "C";
            else if (avg >= 7 && avg < 8)
                return "B";
            else if (avg >= 8 && avg < 9)
                return "A";
            else if (avg >= 9 && avg <= 10)
                return "A+";
            else
            {
                return "Invalid";
            }

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
            if (validate(grade1Input.Text, grade2Input.Text, grade3Input.Text, grade4Input.Text))
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
            else
            {
                MessageBox.Show("Make sure to fill all details..Leave 0 for default value");
            }
            
        }

        bool validate(string grade1, string grade2, string grade3, string grade4)
        {
            if (grade1 == "" || grade2 == "" || grade3 == "" || grade4 == "")
            {
                return false;
            }

            return true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student form = new Student();
            form.ShowDialog();
        }
    }
}
