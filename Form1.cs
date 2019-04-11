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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=ProElite;database=elevVS");

        public Form1()
        {
            InitializeComponent();

            proElite = new GrupaElevi();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from elev", con);

            da.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void adauga_Elev(object sender, EventArgs e)
        {
            con.Open();

            String nume = numeTextBox.Text;
            String prenume = prenumeTextBox.Text;
            long varsta = Convert.ToInt64(varstaTextBox.Text);

            proElite.adaugaElev(new Elev(nume, prenume, varsta));

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into elev values('" + numeTextBox.Text + "' , '" +
                               prenumeTextBox.Text + "' , '" + varstaTextBox.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();

            DisplayElev();

           // MessageBox.Show("elev inserted successfully");

        }

        private void adaugaNume(object sender, EventArgs e)
        {
            numeTextBox.Text = "";
        }

        private void adaugaPrenume(object sender, EventArgs e)
        {
            prenumeTextBox.Clear();
        }

        private void adaugaVarsta(object sender, EventArgs e)
        {
            varstaTextBox.Text = "";
        }

        GrupaElevi proElite;

        public void DisplayElev()
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from elev ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(cmd);
            sqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Form1_Load(object sender , EventArgs e )
        {
            DisplayElev();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form3();
            newForm.Show();
            DisplayElev();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
            DisplayElev();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayElev();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from elev where Nume = '" + numeTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(cmd);
            sqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void DeleteAll()
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete elev from elevVS ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(cmd);
            sqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }
    }
}
