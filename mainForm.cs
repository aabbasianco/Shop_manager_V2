using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_manager_V2
{
    public partial class mainForm : Form
    {
        // VARIABLES -------------------------------------------------------------------------

        bool menubarDisplayButtonBool;
        int[] menuLogoPicProp;
        int[] userPicProp;
        Control[] costumersDatabaseSearchControlsArr;
        Control[] databasePanelsArr;
        Control[] infoPanelsArr;
        Control[] dateAndTimePanelsArr;
        Control[] ActiveStaffInfoPanelsArr;
        Control[] databaseSearchPanelsArr;

        // MAIN FORM ON LOAD --------------------------------------------------------------
        public mainForm()
        {
            InitializeComponent();
            menubarDisplayButtonBool = true;
            costumersDatabaseSearchControlsArr = new Control[6] { txtCostumersDatabaseSearchNormal,cmbCostumersDatabaseSearchStandardPersonalInfo,
            cmbCostumersDatabaseSearchStandardPlaceInfo,cmbCostumersDatabaseSearchStandardDate,lblCostumersDatabaseSearchStandardDate,
            lblCostumersDatabaseSearchStandardHour};
            databasePanelsArr = new Control[3] { pnlDatabase1, pnlDatabase2, pnlDatabase3 };
            infoPanelsArr = new Control[3] { pnlInfo1, pnlInfo2, pnlInfo3 };
            dateAndTimePanelsArr = new Control[7] { pnlTabDateAndTime0, pnlTabDateAndTime1, pnlTabDateAndTime2
            , pnlTabDateAndTime3, pnlTabDateAndTime4, pnlTabDateAndTime5, pnlTabDateAndTime6};
            ActiveStaffInfoPanelsArr = new Control[7] { pnlActiveStaffInfo0, pnlActiveStaffInfo1, pnlActiveStaffInfo2
            , pnlActiveStaffInfo3, pnlActiveStaffInfo4, pnlActiveStaffInfo5, pnlActiveStaffInfo6};
            databaseSearchPanelsArr = new Control[3] { pnlDatabaseSearch1, pnlDatabaseSearch2, pnlDatabaseSearch3 };
            for (int i = 0; i < databasePanelsArr.Length; i++)
            {
                databasePanelsArr[i].Width = 1120;
                infoPanelsArr[i].Width = 1120;
                databasePanelsArr[i].Location = new Point(20, 187);
                infoPanelsArr[i].Location = new Point(20, 792);
            }
            for (int i = 0; i < ActiveStaffInfoPanelsArr.Length; i++)
            {
                ActiveStaffInfoPanelsArr[i].Left = pnlTabDateAndTime0.Left + pnlTabDateAndTime0.Width + 100;
                dateAndTimePanelsArr[i].Width = pnlDatabase2.Width - pnlActiveStaffInfo0.Width - 100;
                ActiveStaffInfoPanelsArr[i].Top = 20;
                dateAndTimePanelsArr[i].Top = 20;
            }
        }

        // MAIN FORM SIZE CHANGE -------------------------------------------------------------
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            pnlMenuDown.Height = this.Height - (pnlMenuUp.Height + 39);
        }

        // MENUBAR DISPLAY BUTTON CLICK ------------------------------------------------------
        private void btnMenubarDisplay_Click(object sender, EventArgs e)
        {
            if (menubarDisplayButtonBool == true)
            {
                pnlMenuUp.BackgroundImage = null;
                btnMenubarDisplay.BackgroundImage = Properties.Resources.DoubleArrowLeftWhite;
                pnlMenubar.Width = btnMenuMainPageLogo.Width + 25;
                btnMenuRecivedProducts.Text = null;
                btnMenuTheme.BackgroundImage = Properties.Resources.LightModeWhite;

            }
            else
            {
                pnlMenuUp.BackgroundImage = Properties.Resources.BackgroundEvening;
                btnMenubarDisplay.BackgroundImage = Properties.Resources.DoubleArrowRightWhite;
                pnlMenubar.Width = btnMenuMainPageLogo.Width + 25 + btnMenuMainPage.Width;
                btnMenuRecivedProducts.Text = "حواله ورود محصول";
                btnMenuTheme.BackgroundImage = Properties.Resources.LightMode;
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
            btnMenuLogoutLogo.BackgroundImage = Properties.Resources.LogoutLightRedWhite;
        }

        private void btnMenuLogout_MouseUp(object sender, MouseEventArgs e)
        {
            btnMenuLogoutLogo.BackgroundImage = Properties.Resources.LogoutDarkRedWhite;
        }

        // COSTUMERS TAB ON SIZE CHANGE ------------------------------------------------------
        private void tabCostumers_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                pnlInfo2.SetFlowBreak(txtCostumerUsername, true);
                pnlInfo2.SetFlowBreak(txtCostumerHomePhone, true);
                pnlInfo2.SetFlowBreak(txtCostumerProvince, true);
                pnlInfo2.SetFlowBreak(txtCostumerId, false);
                pnlInfo2.SetFlowBreak(txtCostumerEmail, false);
            }
            else
            {
                pnlInfo2.SetFlowBreak(txtCostumerUsername, false);
                pnlInfo2.SetFlowBreak(txtCostumerHomePhone, false);
                pnlInfo2.SetFlowBreak(txtCostumerProvince, false);
                pnlInfo2.SetFlowBreak(txtCostumerId, true);
                pnlInfo2.SetFlowBreak(txtCostumerEmail, true);
            }
            CostumerInfoPanelHeight();
            CostumerInfoPanelHeightAndTopFunc(pnlInfo2, pnlDatabase2, tabCostumers, lblCostumerInfo);
            pnlDatabaseSearch2.Height = lblCostumersDatabaseSearchStandardHour.Top + 90 + lblCostumersDatabaseSearchStandardHour.Height +
                cmbCostumersDatabaseSearchStandardGroup.Top;
            dgvAllCostumers.Height = pnlDatabase2.Height - pnlDatabaseSearch2.Height - pnlDatabaseSearch2.Top - 10;
        }

        // COSTUMER TYPE COMBO BOX ON LEAVE --------------------------------------------------
        private void cmbCostumerType_Leave(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Text.Length > 0)
            {
                bool checkBool = false;
                foreach (var item in ((ComboBox)sender).Items)
                {
                    if (((ComboBox)sender).Text == item.ToString())
                    {
                        checkBool = true;
                    }
                }
                if (checkBool == false)
                {
                    MessageBox.Show("لطفا تنها از مقادیر تعریف شده استفاده نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ((ComboBox)sender).Text = null;
                    ((ComboBox)sender).Focus();
                    InvisibleSetterFunc(costumersDatabaseSearchControlsArr, txtCostumersDatabaseSearchNormal, false);
                }
            }
        }

        // FUNCTIONS *************************************************************************

        // COSTUMER INFO PANEL HIGHT SETTER FUNCTION -----------------------------------------
        void CostumerInfoPanelHeight()
        {
            pnlInfo2.Height = btnCostumerInfoChooseAsBuyer.Top + btnCostumerInfoChooseAsBuyer.Height + pnlInfo2.Padding.Top;
        }

        // COSTUMERS DATABASE PANEL HIGHT AND TOP SETTER FUNCTION ----------------------------
        void CostumerInfoPanelHeightAndTopFunc(Control mainPanel, Control topPanel, Control parent, Label title)
        {
            //mainPanel.Size = new Size(mainPanel.Width, 600);
            mainPanel.Top = topPanel.Top + topPanel.Height + 30;
            title.Top = mainPanel.Top - 16;
        }

        // INVISIBLE SETTER FUNCTION --------------------------------------------------------
        static void InvisibleSetterFunc(Control[] _invisibleArray, Control[] _visibleControls, bool _boolean)
        {
            foreach (var item in _invisibleArray)
            {
                item.Visible = false;
            }
            if (_boolean == true)
            {
                foreach (var item in _visibleControls)
                    item.Visible = true;
            }
        }
        static void InvisibleSetterFunc(Control[] invisibleArray, Control visibleControl, bool _boolean)
        {
            foreach (var item in invisibleArray)
            {
                item.Visible = false;
            }
            if (_boolean == true)
            {
                visibleControl.Visible = true;
            }
        }
    }
}