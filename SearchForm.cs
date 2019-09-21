using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SearchForm : MetroForm
    {
        MainForm parent;

        public SearchForm(MainForm p)
        {
            parent = p;
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=ProElite;database=elevVS");

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from elev where Name = '" + searchAfterName.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(cmd);
            sqlData.Fill(dt);
            parent.metroGrid1.DataSource = dt;

            con.Close();

            Close();
        }
    }
}
