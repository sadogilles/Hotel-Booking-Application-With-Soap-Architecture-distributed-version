using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplicationConsole
{
    class Program
    {
        static HomeWindowsForm home = new HomeWindowsForm();
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
           
            Application.Run(home);
        }
    }
}
