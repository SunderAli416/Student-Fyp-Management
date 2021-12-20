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
    public partial class JuryAdd : Form
    {
        public JuryAdd()
        {
            InitializeComponent();
        }

        private void JuryAdd_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            List<string> facIds = new List<string>();
            List<string> extIds = new List<string>();
            string query = "select * from faculty";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                facIds.Add(result.GetString(0));
            }
            Connection.CloseConnection();

            Connection.MakeConnection();
            query = "select * from externals";
            cmd = new MySqlCommand(query, Connection.conn);
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                extIds.Add(result.GetString(1));
            }
            Connection.CloseConnection();

            for(var i = 0; i < facIds.Count(); i++)
            {
                fac1Button.Items.Add(getName(facIds[i]));
                fac2Button.Items.Add(getName(facIds[i]));
                fac3Button.Items.Add(getName(facIds[i]));
            }
            for (var i = 0; i < extIds.Count(); i++)
            {
                ext1Button.Items.Add(getExtName(extIds[i]));
                ext2Button.Items.Add(getExtName(extIds[i]));
                
            }
            fac2Button.Items.Add("None");
            fac3Button.Items.Add("None");
            ext1Button.Items.Add("None");
            ext2Button.Items.Add("None");
        }

        private string getName(string id)
        {
            string name = "";
            Connection.MakeConnection();
            string query = $"Select * from faculty where e_id='{id}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                name = result.GetString(0) + " " + result.GetString(4) + " " + result.GetString(5);
            }
            Connection.CloseConnection();
            return name;
        }
        
        private string getExtName(string id)
        {
            string name = "";
            Connection.MakeConnection();
            string query = $"Select * from externals where email='{id}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                name = result.GetString(1)+" "+result.GetString(0);
            }
            Connection.CloseConnection();
            return name;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fac1 = fac1Button.Text;
            fac1 = fac1.Substring(0, fac1.IndexOf(' '));
            string fac2 = fac2Button.Text;
            if (fac2 == "None"){
                fac2 = "NULL";
            }
            else{
                fac2 = "'" + fac2.Substring(0, fac2.IndexOf(' ')) + "'";
            }
            string fac3 = fac3Button.Text;
            if (fac3 == "None")
            {
                fac3 = "NULL";
            }
            else
            {
                fac3 = "'" + fac3.Substring(0, fac3.IndexOf(' ')) + "'";
            }
            string ext1 = ext1Button.Text;
            if (ext1 == "None")
            {
                ext1 = "NULL";
            }
            else
            {
                ext1 = "'" + ext1.Substring(0, ext1.IndexOf(' ')) + "'";
            }
            string ext2 = ext2Button.Text;
            if (ext2 == "None")
            {
                ext2 = "NULL";
            }
            else
            {
                ext2 = "'" + ext2.Substring(0, ext2.IndexOf(' ')) + "'";
            }
            Connection.MakeConnection();
            string query = $"insert into jury (fc_1,fc_2,fc_3,ex_1,ex_2) values ('{fac1}',{fac2},{fac3},{ext1},{ext2});";
            var cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection.conn;
            cmd.ExecuteNonQuery();
            
            Connection.CloseConnection();
            this.Hide();
            Jury jury = new Jury();
            jury.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jury form = new Jury();
            form.ShowDialog();
        }
    }
}
