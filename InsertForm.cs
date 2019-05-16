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
    public partial class InsertForm : Form
    {
        MainForm parent;
        GrupaElevi proElite;
        String gender = "";

        public InsertForm(MainForm p)
        {
            parent = p;
            InitializeComponent();
            proElite = new GrupaElevi();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=ProElite;database=elevVS");

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void radioMaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void radioFemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void AdaugaNume(object sender, EventArgs e)
        {
            numeTextBox.Text = "";
        }

        private void AdaugaVarsta(object sender, EventArgs e)
        {
            varstaTextBox.Text = "";
        }

        private void numeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void varstaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numeTextBox.Text == "")
                {
                    MessageBox.Show("Fill the name text box.");
                }

                if (varstaTextBox.Text == "")
                {
                    MessageBox.Show("Fill the age text box.");
                }

                con.Open();

                String nume = numeTextBox.Text;
                String gen = gender;
                long varsta = Convert.ToInt64(varstaTextBox.Text);

                proElite.adaugaElev(new Elev(nume, gen, varsta));

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into elev values('" + numeTextBox.Text + "' , '" +
                                               gender + "' , '" + varstaTextBox.Text + "')";

                cmd.ExecuteNonQuery();

                con.Close();

                Close();

                parent.DisplayElev();
            }
            catch(Exception)
            {

            }
        }

        private void numeTextBox_Click(object sender, EventArgs e)
        {
            numeTextBox.Text = "";
        }

        private void varstaTextBox_Click(object sender, EventArgs e)
        {
            varstaTextBox.Text = "";
        }

    }
}
