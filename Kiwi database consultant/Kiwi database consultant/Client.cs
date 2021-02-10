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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SQL.selectQuery("SELECT * FROM  Client");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                   // listBoxInstructors.Items.Add(SQL.read[0]);
                    dataGridViewClients.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }
            Hide();
            SelectTime selectTime = new SelectTime(value1);
            selectTime.ShowDialog();
            Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

       

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }
            //MessageBox.Show(value1);
            SQL.selectQuery("SELECT * FROM  Client Where CID = '" + value1 + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    textBoxFname.Text = SQL.read[0].ToString();
                    textBoxLname.Text = SQL.read[1].ToString();
                    textBoxEmail.Text = SQL.read[5].ToString();
                    textBoxDOB.Text = SQL.read[6].ToString();
                    textBoxNationality.Text = SQL.read[4].ToString();
                    textBoxAddress1.Text = SQL.read[7].ToString();
                    textBoxAddress2.Text = SQL.read[8].ToString();
                    textBoxPhone.Text = SQL.read[2].ToString();
                    // listBoxInstructors.Items.Add(SQL.read[0]);
                    //dataGridViewClients.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
        }
        /// <summary>
        /// add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>




        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBoxFname.Text.Substring(0,1) + textBoxLname.Text.Substring(0,1);
            int i = 1;
            SQL.selectQuery("SELECT * FROM  Client");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (SQL.read[3].ToString().Substring(0,2) == s)
                    {
                        i++;
                    }
                   
                }
            }
            s = s + i;
            SQL.executeQuery("insert into Client values('" + textBoxFname.Text + "', '" + textBoxLname.Text + "', '" + textBoxPhone.Text + "','" + s + "','" + textBoxNationality.Text + "','" + textBoxEmail.Text + "','" + textBoxDOB.Text + "', '" + textBoxAddress1.Text + "', '" + textBoxAddress2.Text + "')");
            SQL.selectQuery("SELECT * FROM  Client where CID = '" + s + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    dataGridViewClients.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
        }
        /// <summary>
        /// REomve button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void button4_Click(object sender, EventArgs e)
        {
            string value1 = "";
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
                dataGridViewClients.Rows.RemoveAt(row.Index);
            }
            SQL.executeQuery("DELETE FROM Client WHERE CID = '" + value1 + "'");      
        }
        /// <summary>
        /// update button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button3_Click(object sender, EventArgs e)
        {
             string value1 = "";
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
            {
                value1 = row.Cells[2].Value.ToString();
            }
            SQL.executeQuery("UPDATE Client SET fname = '" + textBoxFname.Text + 
                "', lname = '" + textBoxLname.Text + 
                "', Phone = '" + textBoxPhone.Text + 
                "', Nationality = '" + textBoxNationality.Text + 
                "', email = '" + textBoxEmail.Text + 
                "', DOB = '" + textBoxDOB.Text + 
                "', address1 = '" + textBoxAddress1.Text + 
                "', address2 = '" + textBoxAddress2.Text + 
                "' Where CID = '" + value1 + "'");
           // MessageBox.Show(value1);
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
            {
                dataGridViewClients.Rows.RemoveAt(row.Index);
            }
            SQL.selectQuery("SELECT * FROM  Client where CID = '" + value1 + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    dataGridViewClients.Rows.Add(SQL.read[0], SQL.read[1], SQL.read[3]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            string value = "";
            foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
            {
                value = row.Cells[2].Value.ToString();
            }
            Congratulation cn = new Congratulation(value);
            cn.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Appointment a = new Appointment();
            a.ShowDialog();
            Close();
        }
    }
}
