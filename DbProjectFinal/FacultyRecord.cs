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
    public partial class FacultyRecord : UserControl
    {
        public string eid;
        public string email;
        public string code;
        public string title;
        public string fname;
        public string lname;
        public string designation;
        public string status;
        public FacultyRecord(string eid, string email, string code, string title, string fname, string lname, string designation, string status)
        {
            InitializeComponent();
            this.eid = eid;
            this.email = email;
            this.code = code;
            this.title = title;
            this.fname = fname;
            this.lname = lname;
            this.designation = designation;
            this.status = status;

            eidLabel.Text = eid;
            emailLabel.Text = email;
            codeLabel.Text = code;
            titleLabel.Text = title;
            fnamelabel.Text = fname;
            lnameLabel.Text = lname;
            designationLabel.Text = designation;
            statusLabel.Text = status;
            
        }

        private void FacultyRecord_Load(object sender, EventArgs e)
        {

        }

        private void sectionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
