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
    public partial class GradeAdd : Form
    {
        string roll;
        public GradeAdd(string roll)
        {
            this.roll = roll;
            InitializeComponent();
        }

        private void GradeAdd_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = $"insert into grade values ('{roll}',{grade1Input.Text},{grade2Input.Text},{grade3Input.Text},{grade4Input.Text});";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            Connection.CloseConnection();
            this.Hide();
            Student student = new Student();
            student.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student form = new Student();
            form.ShowDialog();
        }
    }
}
