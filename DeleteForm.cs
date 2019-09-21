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
    public partial class DeleteForm : MetroForm
    {
        MainForm parent;

        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;Pwd=ProElite;database=elevVS");

        DataTable dt = new DataTable();

        public DeleteForm(MainForm p)
        {
            parent = p;
            InitializeComponent();

            nameCheckBox.Checked = false;
            nameComboBox.Enabled = false;

            ageCheckBox.Checked = false;
            ageComboBox.Enabled = false;
        }


        private void DeleteForm_Activated(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from elev", con);

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nameComboBox.Items.Add(dt.Rows[i]["Name"]);
                ageComboBox.Items.Add(dt.Rows[i]["Age"]);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            con.Open();

            string numeText = nameComboBox.GetItemText(nameComboBox.SelectedItem);
            string varstaText = ageComboBox.GetItemText(ageComboBox.SelectedItem);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            if(nameCheckBox.Checked == true)
            {
                ageCheckBox.Checked = false;
                cmd1.CommandText = "delete from elev where Name = '" + numeText + "'";
                cmd1.ExecuteNonQuery();
            }
            if(ageCheckBox.Checked == true)
            {
                nameCheckBox.Checked = false;
                cmd.CommandText = "delete from elev where Age = '" + varstaText + "'";
                cmd.ExecuteNonQuery();
            }

            parent.DisplayStudent();

            con.Close();

            Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBoxNume_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheckBox.Checked == true)
            {
                ageCheckBox.Checked = false;
                nameComboBox.Enabled = true;
                ageComboBox.Enabled = false;
                nameComboBox.SelectedIndex = 0;
                nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                ageComboBox.SelectedIndex = nameComboBox.SelectedIndex;
            }
            if(nameCheckBox.Checked == false)
            {
                ageComboBox.Enabled = true;
                nameComboBox.Enabled = false;
            }
        }

        private void CheckBoxVarsta_CheckedChanged(object sender, EventArgs e)
        {
            if (ageCheckBox.Checked == true)
            {
                nameCheckBox.Checked = false;
                ageComboBox.Enabled = true;
                nameComboBox.Enabled = false;
                ageComboBox.SelectedIndex = 0;
                ageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                nameComboBox.SelectedIndex = ageComboBox.SelectedIndex;
            }
            if(ageCheckBox.Checked == false)
            {
                ageComboBox.Enabled = false;
                nameComboBox.Enabled = true;
            }
        }
    }
}
