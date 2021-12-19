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
    public partial class JuryRecord : UserControl
    {
        string jid, fac1, fac2, fac3, ext1, ext2;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            if (fac2 == "-"){
                fac2 = "None";
            }
            if (fac3 == "-")
            {
                fac3 = "None";
            }
            if (ext1 == "-")
            {
                ext1 = "None";
            }
            if (ext2 == "-")
            {
                ext2 = "None";
            }
            JuryEdit edit = new JuryEdit(jid, fac1, fac2, fac3, ext1, ext2);
            edit.ShowDialog();
        }

        public JuryRecord(string jid,string fac1,string fac2,string fac3,string ext1,string ext2)
        {
            this.jid = jid;
            this.fac1 = fac1;
            this.fac2 = fac2;
            this.fac3 = fac3;
            this.ext1 = ext1;
            this.ext2 = ext2;

            InitializeComponent();
            idLabel.Text = jid;
            fac1Label.Text = fac1;
            fac2Label.Text = fac2;
            fac3Label.Text = fac3;
            external1Label.Text = ext1;
            external2Label.Text = ext2;

        }

        private void JuryRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
