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
    public partial class InsertForm : MetroForm
    {
        MainForm parent;
        StudentsGroup proElite;
        String gender = "";

        public InsertForm(MainForm p)
        {
            parent = p;
            InitializeComponent();
            proElite = new StudentsGroup();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=ProElite;database=elevVS");

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void RadioMaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void RadioFemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void InsertName(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void InsertAge(object sender, EventArgs e)
        {
            ageTextBox.Text = "";
        }

        private void NumeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void VarstaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Fill the name text box.");
                }

                if (ageTextBox.Text == "")
                {
                    MessageBox.Show("Fill the age text box.");
                }

                con.Open();

                String nume = nameTextBox.Text;
                String gen = gender;
                long varsta = Convert.ToInt64(ageTextBox.Text);

                proElite.addStudent(new Student(nume, gen, varsta));

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into elev values('" + nameTextBox.Text + "' , '" + gender + "' , '" + ageTextBox.Text + "')";

                cmd.ExecuteNonQuery();

                con.Close();

                Close();

                parent.DisplayStudent();
            }
            catch(Exception)
            {

            }
        }

        private void NumeTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void VarstaTextBox_Click(object sender, EventArgs e)
        {
            ageTextBox.Text = "";
        }

    }
}
