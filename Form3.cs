using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;Pwd=ProElite;database=elevVS");

        public Form3()
        {
            InitializeComponent();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from elev where Nume = '" + numeTextBox.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();

            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
