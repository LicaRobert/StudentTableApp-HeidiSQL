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
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class UpdateForm : MetroForm
    {
        MainForm parent;

        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;Pwd=ProElite;database=elevVS");

        string gender = "";

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
            updateListBox.DisplayMember = "Name";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string numeText = updateListBox.GetItemText(updateListBox.SelectedItem);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  elev set Name = '" + nameTextBox.Text + "' , Gender =  '"
            + gender + "' , Age = '" + ageTextBox.Text +"' where Name = '" + numeText + "'";
          
            cmd.ExecuteNonQuery();

            parent.DisplayStudent();

            con.Close();

            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateListBox_Click(object sender, EventArgs e)
        {
            string numeText = updateListBox.GetItemText(updateListBox.SelectedItem);
            nameTextBox.Text = numeText;
        }

        private void VarstaTextBox_Click(object sender, EventArgs e)
        {
            ageTextBox.Text = "";
        }


        private void VarstaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RadioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void RadioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }
    }
}
