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
    public partial class mainForm : Form
    {
        // VARIABLES -------------------------------------------------------------------------

        bool menubarDisplayButtonBool;

        // INITIALIZE COMPONENT --------------------------------------------------------------

        public mainForm()
        {
            InitializeComponent();
            menubarDisplayButtonBool = true;
        }

        // MAIN FORM SIZE CHANGE -------------------------------------------------------------

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            lblMenuColor.Height = this.Height - btnMenuMainPage.Top;
            lblMenuColor.Top = btnMenuMainPage.Top;
        }

        // MENUBAR DISPLAY BUTTON CLICK ------------------------------------------------------

        private void btnMenubarDisplay_Click(object sender, EventArgs e)
        {
            if (menubarDisplayButtonBool == true)
            {
                btnMenubarDisplay.BackgroundImage = Properties.Resources.DoubleArrowLeftWhite;
                pnlMenubar.Width = btnMenuMainPageLogo.Width + 25;
                MenuButtonsLeftFunc(13);
                picMenuLogo.Width = 60;
                picMenuLogo.Top += 10;
                picMenuLogo.Height -= 100;
                picMenuLogo.BackgroundImage = Properties.Resources.MainLogoSmall;
                btnMenuRecivedProducts.Text = null;
            }
            else
            {
                btnMenubarDisplay.BackgroundImage = Properties.Resources.DoubleArrowRightWhite;
                pnlMenubar.Width = btnMenuMainPageLogo.Width + 25 + btnMenuMainPage.Width;
                MenuButtonsLeftFunc(btnMenuMainPage.Width + 13);
                picMenuLogo.Width = pnlMenubar.Width;
                picMenuLogo.Top -= 10;
                picMenuLogo.Height += 100;
                picMenuLogo.BackgroundImage = Properties.Resources.MainLogoBig;
                btnMenuRecivedProducts.Text = "حواله ورود محصول";
            }
            menubarDisplayButtonBool = !menubarDisplayButtonBool;
        }

        // LOGOUT MENU BUTTON MOUSE DOWN/UP --------------------------------------------------

        private void btnMenuLogout_MouseDown(object sender, MouseEventArgs e)
        {
            btnMenuLogout.BackgroundImage = Properties.Resources.LogoutLightRed;
        }

        private void btnMenuLogout_MouseUp(object sender, MouseEventArgs e)
        {
            btnMenuLogout.BackgroundImage = Properties.Resources.LogoutDarkRed;
        }

        // FUNCTIONS #########################################################################

        // MENU BUTTONS LEFT FUNCTION --------------------------------------------------------

        void MenuButtonsLeftFunc(int x)
        {
            btnMenuMainPageLogo.Left = x;
            btnMenuProductsLogo.Left =x;
            btnMenuSellReportLogo.Left =x;
            btnMenuRecivedProductsLogo.Left =x;
            btnMenuCartLogo.Left =x;
            btnMenuStaffLogo.Left =x;
            btnMenuSettingLogo.Left =x;
            btnMenuAboutLogo.Left =x;
        }
    }
}