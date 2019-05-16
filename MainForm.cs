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
    public partial class MainForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=ProElite;database=elevVS");

        public MainForm()
        {
            InitializeComponent();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from elev", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Adauga_Elev(object sender, EventArgs e)
        {
            InsertForm form4 = new InsertForm(this);
            form4.Show();
        }

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

        private void Button1_Click(object sender, EventArgs e)
        {
            DeleteForm form3 = new DeleteForm(this);
            form3.Show();
            DisplayElev();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateForm form2 = new UpdateForm(this);
            form2.Show();
            DisplayElev();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
        }

        private void DeleteAll()
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete elev from elev ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(cmd);
            sqlData.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            DisplayElev();
        }
    }
}
