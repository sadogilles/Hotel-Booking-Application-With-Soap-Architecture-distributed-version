using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplicationConsole
{
    public partial class HomeWindowsForm : Form
    {
        public HomeWindowsForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void mosson_Click(object sender, EventArgs e)
        {

            AgencyMossonWindowsForm mosson = new AgencyMossonWindowsForm();
            mosson.Show();
            this.Hide();

        }

        private void odysseum_Click(object sender, EventArgs e)
        {
            AgencyOdysseumWindowsForm odysseum = new AgencyOdysseumWindowsForm();
            odysseum.Show();
            this.Hide();
        }
    }
}
