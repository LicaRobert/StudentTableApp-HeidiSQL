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
    public partial class UpdateForm : Form
    {
        MainForm parent;

        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;Pwd=ProElite;database=elevVS");

        public UpdateForm(MainForm p)
        {
            parent = p;
            InitializeComponent();
        }


        private void UpdateForm_Activated(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from elev", con);

            da.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            da.Fill(dt);

            updateListBox.DataSource = null;
            updateListBox.DataSource = dt;
            updateListBox.DisplayMember = "Nume";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string numeText = updateListBox.GetItemText(updateListBox.SelectedItem);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  elev set Nume = '" + numeTextBox.Text + "' , Gen =  '"
                              + genTextBox.Text + "' , Varsta = '" + varstaTextBox.Text +
                              "' where Nume = '" + numeText + "'";
          
            cmd.ExecuteNonQuery();

            parent.DisplayElev();

            con.Close();

            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateListBox_Click(object sender, EventArgs e)
        {
            string numeText = updateListBox.GetItemText(updateListBox.SelectedItem);
            numeTextBox.Text = numeText;
        }

        private void varstaTextBox_Click(object sender, EventArgs e)
        {
            varstaTextBox.Text = "";
        }

        private void genTextBox_TextChanged(object sender, EventArgs e)
        {
            genTextBox.Text = "";
        }

        private void genTextBox_Click(object sender, EventArgs e)
        {
            genTextBox.Text = "";
        }
    }
}
