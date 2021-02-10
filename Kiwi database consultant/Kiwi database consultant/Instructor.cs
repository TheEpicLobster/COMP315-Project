using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwi_database_consultant
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SQL.selectQuery("SELECT * FROM  Instructor");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    // listBoxInstructors.Items.Add(SQL.read[0]);
                    dataGridView1.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[4]);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }
            Hide();
            SelectTime selectTime = new SelectTime(value1);
            selectTime.ShowDialog();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }

            SQL.selectQuery("SELECT * FROM  Instructor Where ID = '" + value1 + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    IFname.Text = SQL.read[0].ToString();
                    Ilname.Text = SQL.read[1].ToString();
                    Email.Text = SQL.read[3].ToString();
                    Phone.Text = SQL.read[2].ToString();
                    Dob.Text = SQL.read[5].ToString();
                    //textBoxAddress2.Text = SQL.read[8].ToString();
                 //   textBoxPhone.Text = SQL.read[2].ToString();
                    // listBoxInstructors.Items.Add(SQL.read[0]);
                    //dataGridViewClients.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = IFname.Text.Substring(0, 1) + Ilname.Text.Substring(0, 1);
            int i = 1;
            SQL.selectQuery("SELECT * FROM  Instructor");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (SQL.read[1].ToString().Substring(0, 2) == s)
                    {
                        i++;
                    }

                }
            }
            s = s + i;
            SQL.executeQuery("insert into Instructor values('" + IFname.Text + "','" + Ilname.Text + "','" + Email.Text + "','"  + Phone.Text + "','" + s + "','"  + Dob.Text + "')");
            SQL.selectQuery("SELECT * FROM  Instructor where ID = '" + s + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    dataGridView1.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[4]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            SQL.executeQuery("DELETE FROM Instructor WHERE ID = '" + value1 + "'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }
            SQL.executeQuery("UPDATE Instructor SET fname = '" + IFname.Text +
                "', lname = '" + Ilname.Text +
                "', phone = '" + Phone.Text +
                "', email = '" + Email.Text +
                "', dob = '" + Dob.Text + "'");
            // MessageBox.Show(value1);
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            SQL.selectQuery("SELECT * FROM  Instructor where ID = '" + value1 + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    dataGridView1.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }

            SQL.selectQuery("SELECT * FROM  Instructor Where ID = '" + value1 + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    IFname.Text = SQL.read[0].ToString();
                    Ilname.Text = SQL.read[1].ToString();
                    Email.Text = SQL.read[3].ToString();
                    Phone.Text = SQL.read[2].ToString();
                    Dob.Text = SQL.read[5].ToString();
                    //textBoxAddress2.Text = SQL.read[8].ToString();
                    //   textBoxPhone.Text = SQL.read[2].ToString();
                    // listBoxInstructors.Items.Add(SQL.read[0]);
                    //dataGridViewClients.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Appointment a = new Appointment();
            a.ShowDialog();
            Close();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
