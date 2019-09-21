using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class MainForm : MetroForm
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=ProElite;database=elevVS");

        public MainForm()
        {
            InitializeComponent();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from elev", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            metroGrid1.ReadOnly = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            metroGrid1.ClearSelection();
        }

        private void Insert_Student(object sender, EventArgs e)
        {
            InsertForm form4 = new InsertForm(this);
            form4.Show();
        }

        public void DisplayStudent()
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from elev ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sqlData = new MySqlDataAdapter(cmd);
            sqlData.Fill(dt);
            metroGrid1.DataSource = dt;

            con.Close();
        }

        private void Form1_Load(object sender , EventArgs e )
        {
            DisplayStudent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DeleteForm form3 = new DeleteForm(this);
            form3.Show();
            DisplayStudent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateForm form2 = new UpdateForm(this);
            form2.Show();
            DisplayStudent();
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
            metroGrid1.DataSource = dt;

            con.Close();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }


        private void MetroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            metroGrid1.ClearSelection();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            InsertForm form4 = new InsertForm(this);
            form4.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm form3 = new DeleteForm(this);
            form3.Show();
            DisplayStudent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm form2 = new UpdateForm(this);
            form2.Show();
            DisplayStudent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
        }
    }
}
