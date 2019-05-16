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
    public partial class DeleteForm : Form
    {
        MainForm parent;

        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;Pwd=ProElite;database=elevVS");

        DataTable dt = new DataTable();

        public DeleteForm(MainForm p)
        {
            parent = p;
            InitializeComponent();

            checkBoxNume.Checked = false;
            comboBoxNume.Enabled = false;

            checkBoxVarsta.Checked = false;
            comboBoxVarsta.Enabled = false;
        }


        private void DeleteForm_Activated(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from elev", con);

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxNume.Items.Add(dt.Rows[i]["nume"]);
                comboBoxVarsta.Items.Add(dt.Rows[i]["varsta"]);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            string numeText = comboBoxNume.GetItemText(comboBoxNume.SelectedItem);
            string varstaText = comboBoxVarsta.GetItemText(comboBoxVarsta.SelectedItem);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            if(checkBoxNume.Checked == true)
            {
                checkBoxVarsta.Checked = false;
                cmd1.CommandText = "delete from elev where nume = '" + numeText + "'";
                cmd1.ExecuteNonQuery();
            }
            if(checkBoxVarsta.Checked == true)
            {
                checkBoxNume.Checked = false;
                cmd.CommandText = "delete from elev where varsta = '" + varstaText + "'";
                cmd.ExecuteNonQuery();
            }

            parent.DisplayElev();

            con.Close();

            Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBoxNume_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNume.Checked == true)
            {
                checkBoxVarsta.Checked = false;
                comboBoxNume.Enabled = true;
                comboBoxVarsta.Enabled = false;
                comboBoxNume.SelectedIndex = 0;
                comboBoxNume.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxVarsta.SelectedIndex = comboBoxNume.SelectedIndex;
            }
            if(checkBoxNume.Checked == false)
            {
                comboBoxVarsta.Enabled = true;
                comboBoxNume.Enabled = false;
            }
        }

        private void checkBoxVarsta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVarsta.Checked == true)
            {
                checkBoxNume.Checked = false;
                comboBoxVarsta.Enabled = true;
                comboBoxNume.Enabled = false;
                comboBoxVarsta.SelectedIndex = 0;
                comboBoxVarsta.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxNume.SelectedIndex = comboBoxVarsta.SelectedIndex;
            }
            if(checkBoxVarsta.Checked == false)
            {
                comboBoxVarsta.Enabled = false;
                comboBoxNume.Enabled = true;
            }
        }
    }
}
