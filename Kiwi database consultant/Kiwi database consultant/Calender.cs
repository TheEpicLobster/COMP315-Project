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
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Appointment a = new Appointment();
            a.ShowDialog();
            Close();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
