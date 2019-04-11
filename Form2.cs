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
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;Pwd=ProElite;database=elevVS");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  elev set Nume = '" + numeTextBox.Text + "' , Prenume =  '"
                              + prenumeTextBox.Text + "' , Varsta = '" + varstaTextBox.Text +
                              "' where Nume = '" + numeInitialTextBox.Text + "'";
          
            cmd.ExecuteNonQuery();
          //  MessageBox.Show("elev updated successfully");

            Form1 form = new Form1();
            form.DisplayElev();

            con.Close();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
