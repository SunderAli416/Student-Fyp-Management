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
    public partial class StudentRecord : UserControl
    {
        public string rollNo;
        public string fname;
        public string lname;
        public string section;
        public string pid;
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {
            rollLabel.Text = rollNo;
            fnameLabel.Text = fname;
            lnameLabel.Text = lname;
            sectionLabel.Text = section;
            pidLabel.Text = pid;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            StudentEdit edit = new StudentEdit(rollNo);
            edit.ShowDialog();
        }
    }
}
