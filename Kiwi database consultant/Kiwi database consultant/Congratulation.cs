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
    public partial class Congratulation : Form
    {
        public Congratulation(string CID)
        {
            List<string> _items = new List<string>(); // <-- Add this
            InitializeComponent();
            SQL.selectQuery("SELECT * FROM  Client Where CID = '" + CID + "'");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    textBox3.Text = "" + SQL.read[0] + " " + SQL.read[1];
                }
            }

            _items.Add("To Whom It May Concern");
            _items.Add("");
            _items.Add("");
            _items.Add("");
            _items.Add("");

            _items.Add("This is to certify that...(employee title)... (employee name) was working at...(organization name) As Driver from... (joining date) to...(last working date).");
            _items.Add("During this period, his services were found to be satisfactory in carrying out the job duties, his responsibilities were to:");
            _items.Add("");
            _items.Add("");
            _items.Add("");


            _items.Add("1) Drive completed motor vehicle off assembly line to specified repair, shipping, or storage area");
            _items.Add("2) May test performance of parts, like lights, horn and windshield wipers");
            _items.Add("3) May drive completed vehicle onto railroad freight car secure vehicle for shipping");
            _items.Add("4) May drive customers vehicle to and from service area of repair shop be designated Car Jockey automotive ser. .");
            _items.Add("We wish him / her all the best in his future For...");

            _items.Add("");
            _items.Add("");
            _items.Add("");
            _items.Add("(name)");
_items.Add("(position)");
_items.Add("(organization stamp)"); // <-- Add these
           // _items.Add("Two");
           // _items.Add("Three");

            listBox1.DataSource = _items;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Printed");
            Hide();
            Appointment app = new Appointment();
            app.ShowDialog();
            this.Close();
        }

        private void Congratulation_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
