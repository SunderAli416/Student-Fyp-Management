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
    public partial class ExternalRecord : UserControl
    {
        string name;
        string email;
        string phone;
        string address;
        string company;
        string semester;
        string account;
        public ExternalRecord(string name, string email, string phone, string address, string company, string semester, string account)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.company = company;
            this.semester = semester;
            this.account = account;
            InitializeComponent();
            nameLabel.Text = name;
            emailLabel.Text = email;
            phoneLabel.Text = phone;
            addressLabel.Text = address;
            companyLabel.Text = company;
            semesterLabel.Text = semester;
            accountLabel.Text = account;
        }

        private void ExternalRecord_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            ExternalEdit edit = new ExternalEdit(email);
            edit.ShowDialog();
        }
    }
}
