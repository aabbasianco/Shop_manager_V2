using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_manager_V2
{
    public partial class mainForm : Form
    {
        // VARIABLES -------------------------------------------------------------------------

        bool menubarDisplayButtonBool;
        int[] userPicProp;

        // INITIALIZE COMPONENT --------------------------------------------------------------

        public mainForm()
        {
            InitializeComponent();
            menubarDisplayButtonBool = true;
            userPicProp = new int[4] { picMenuUser.Width, picMenuUser.Left, picMenuUser.Height, picMenuUser.Top };
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
                btnMenuRecivedProducts.Text = null;
                picMenuUser.Width = picMenuLogo.Width;
                picMenuUser.Left = picMenuLogo.Left;
                picMenuUser.Height = picMenuLogo.Height;
                picMenuUser.Top = picMenuLogo.Top + picMenuUser.Height + 60;
            }
            else
            {
                btnMenubarDisplay.BackgroundImage = Properties.Resources.DoubleArrowRightWhite;
                pnlMenubar.Width = btnMenuMainPageLogo.Width + 25 + btnMenuMainPage.Width;
                btnMenuRecivedProducts.Text = "حواله ورود محصول";
                picMenuUser.Width = userPicProp[0];
                picMenuUser.Left = userPicProp[1];
                picMenuUser.Height = userPicProp[2];
                picMenuUser.Top = userPicProp[3];
            }
            menubarDisplayButtonBool = !menubarDisplayButtonBool;
        }

        // MENU BUTTONS & TAB CONTROL SYNC----------------------------------------------------

        private void btnMenuMainPage_Click(object sender, EventArgs e)
        {
            int tabIndex = Convert.ToInt32(((Button)sender).Tag);
            if (tabCtrlMain.SelectedIndex != tabIndex)
            {
                tabCtrlMain.SelectedIndex = tabIndex;
            }
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

        // COSTUMERS TAB ON SIZE CHANGE ------------------------------------------------------

        private void tabCostumers_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                pnlCostumerInfo.SetFlowBreak(txtCostumerUsername, true);
                pnlCostumerInfo.SetFlowBreak(txtCostumerHomePhone, true);
                pnlCostumerInfo.SetFlowBreak(txtCostumerProvince, true);
                pnlCostumerInfo.SetFlowBreak(txtCostumerId, false);
                pnlCostumerInfo.SetFlowBreak(txtCostumerEmail, false);
            }
            else
            {
                pnlCostumerInfo.SetFlowBreak(txtCostumerUsername, false);
                pnlCostumerInfo.SetFlowBreak(txtCostumerHomePhone, false);
                pnlCostumerInfo.SetFlowBreak(txtCostumerProvince, false);
                pnlCostumerInfo.SetFlowBreak(txtCostumerId, true);
                pnlCostumerInfo.SetFlowBreak(txtCostumerEmail, true);
            }
            CostumerInfoPanelHeight();
        }

        // COSTUMER TYPE COMBO BOX CHECK -----------------------------------------------------

        private void cmbCostumerType_Leave(object sender, EventArgs e)
        {
            if (cmbCostumerType.Text.Length > 0)
            {
                bool costumerTypeCheck = false;
                foreach (var item in cmbCostumerType.Items)
                {
                    if (cmbCostumerType.Text == item.ToString())
                    {
                        costumerTypeCheck = true;
                    }
                }
                if (costumerTypeCheck == false)
                {
                    pnlCostumerInfo.SetFlowBreak(cmbCostumerType, false);
                    pnlCostumerInfo.SetFlowBreak(lblCostumerTypeAlert, true);
                    lblCostumerTypeAlert.Visible = true;
                    cmbCostumerType.Text = null;
                }
                else
                {
                    lblCostumerTypeAlert.Visible = false;
                    pnlCostumerInfo.SetFlowBreak(lblCostumerTypeAlert, false);
                    pnlCostumerInfo.SetFlowBreak(cmbCostumerType, true);
                }
            }
        }
        // FUNCTIONS #########################################################################

        void CostumerInfoPanelHeight()
        {
            pnlCostumerInfo.Size = new Size(pnlCostumerInfo.Size.Width, (btnCostumerInfoChooseAsBuyer.Top +
                btnCostumerInfoChooseAsBuyer.Height + pnlCostumerInfo.Padding.Top));
        }


    }
}