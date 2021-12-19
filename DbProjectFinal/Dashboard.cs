using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProjectFinal
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty faculty = new Faculty();
            faculty.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project project = new Project();
            project.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            External external = new External();
            external.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meeting meeting = new Meeting();
            meeting.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Jury jury = new Jury();
            this.Hide();
            jury.ShowDialog();
        }
    }
}
