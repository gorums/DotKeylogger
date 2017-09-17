using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotKeylogger.Tray
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            trayComponent.Visible = true;
        }

        private void menuItem_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            Application.Exit();
        }
    }
}
