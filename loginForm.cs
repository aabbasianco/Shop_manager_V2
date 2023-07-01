using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_manager_V2
{
    public partial class loginForm : Form
    {
        int remembermeCounter;
        int welcomeTimerCounter = 0;
        public loginForm()
        {
            InitializeComponent();
            tmrWelcomeLabel.Enabled = true;
        }

        private void tmrWelcomeLabel_Tick(object sender, EventArgs e)
        {
            welcomeTimerCounter += 1;
            if (lblWelcome.Left > 403)
            {
                lblWelcome.Left -= welcomeTimerCounter;
            }
            else
            {
                tmrWelcomeLabel.Enabled = false;
            }
        }
    }
}
