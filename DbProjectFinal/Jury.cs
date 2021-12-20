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
    public partial class Jury : Form
    {
        public Jury()
        {
            InitializeComponent();
        }

        private void Jury_Load(object sender, EventArgs e)
        {
            Connection.MakeConnection();
            string query = "Select * from jury;";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            int count = 0;
            while (result.Read())
            {
                count++;
            }
            JuryRecord[] jury = new JuryRecord[count];
            Connection.CloseConnection();
            Connection.MakeConnection();
            cmd = new MySqlCommand(query, Connection.conn);
            List<string> jidl=new List<string>();
            List<string> fac1l = new List<string>();
            List<string> fac2l = new List<string>();
            List<string> fac3l = new List<string>();
            List<string> ext1l = new List<string>();
            List<string> ext2l = new List<string>();
            result = cmd.ExecuteReader();
            while (result.Read())
            {
                string jid, fac1, fac2, fac3, ext1, ext2;
                jid = result.GetString(0);
                jidl.Add(jid);
                try
                {
                    fac1 = result.GetString(1);
                }
                catch
                {
                    fac1 = "-";
                }
                
                fac1l.Add(fac1);
                try{
                    fac2 = result.GetString(2);
                }
                catch(Exception ex){
                    fac2 = "-";
                }
                try
                {
                    fac3 = result.GetString(3);
                }
                catch (Exception ex)
                {
                    fac3 = "-";
                }
                try
                {
                    ext1 = result.GetString(4);
                }
                catch (Exception ex)
                {
                    ext1 = "-";
                }
                try
                {
                    ext2 = result.GetString(5);
                }
                catch (Exception ex)
                {
                    ext2 = "-";
                }
                fac2l.Add(fac2);
                fac3l.Add(fac3);
                ext1l.Add(ext1);
                ext2l.Add(ext2);
            }
            Connection.CloseConnection();
            for(var i = 0; i < fac1l.Count(); i++)
            {
                jury[i] = new JuryRecord(jidl[i],getName(fac1l[i]),getName(fac2l[i]), getName(fac3l[i]), getExtName(ext1l[i]), getExtName(ext2l[i]));
                flowLayoutPanel1.Controls.Add(jury[i]);
            }
        }

        private string getName(string id)
        {
            if (id == "-")
            {
                return "-";
            }
            string name="";
            Connection.MakeConnection();
            string query = $"Select * from faculty where e_id='{id}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                name = result.GetString(4) + " " + result.GetString(5);
            }
            Connection.CloseConnection();
            return name;
        }

        private string getExtName(string id)
        {
            if (id == "-")
            {
                return "-";
            }
            string name = "";
            Connection.MakeConnection();
            string query = $"Select * from externals where email='{id}';";
            var cmd = new MySqlCommand(query, Connection.conn);
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                name = result.GetString(0);
            }
            Connection.CloseConnection();
            return name;
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
            JuryAdd add = new JuryAdd();
            add.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jury jury = new Jury();
            jury.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (searchInput.Text == "")
            {
                MessageBox.Show("Please Enter A Jury Id");
            }
            else
            {
                Connection.MakeConnection();
                string query = $"select * from jury where jury_id='{searchInput.Text}';";
                var cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataReader result = cmd.ExecuteReader();
                JuryRecord jury;
                if (result.HasRows)
                {
                    flowLayoutPanel1.Controls.Clear();
                    while (result.Read())
                    {
                        string str2, str3, str4, str5;
                        try{
                           str2 = result.GetString(2);
                        }
                        catch(Exception ex){
                            str2 = "-";
                        }
                        try
                        {
                            str3 = result.GetString(3);
                        }
                        catch (Exception ex)
                        {
                            str3 = "-";
                        }
                        try
                        {
                            str4 = result.GetString(4);
                        }
                        catch (Exception ex)
                        {
                           str4 = "-";
                        }
                        try
                        {
                            str5 = result.GetString(5);
                        }
                        catch (Exception ex)
                        {
                            str5 = "-";
                        }



                        jury = new JuryRecord(result.GetString(0), result.GetString(1),str2,str3,str4,str5);
                        flowLayoutPanel1.Controls.Add(jury);
                    }
                }
                else
                {
                    MessageBox.Show("No jury with that jury id exist");
                }
                Connection.CloseConnection();
            }
        }
    }
}
