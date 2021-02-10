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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Hide();
            Calender Calender = new Calender();
            Calender.ShowDialog();
            Close();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Hide();
            Client client = new Client();
            client.ShowDialog();
            Close();
        }

        private void buttonInstructor_Click(object sender, EventArgs e)
        {
            Hide();
            Instructor instructor = new Instructor();
            instructor.ShowDialog();
            Close();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            Hide();
            Client client = new Client();
            client.ShowDialog();
            Close();
        }

        private void buttonVechile_Click(object sender, EventArgs e)
        {
            Hide();
            Vehicle ve = new Vehicle();
            ve.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Client client = new Client();
            client.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Vehicle ve = new Vehicle();
            ve.ShowDialog();
            Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Client client = new Client();
            client.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Instructor instructor = new Instructor();
            instructor.ShowDialog();
            Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
