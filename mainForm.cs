﻿using System;
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
        int[] menuLogoPicProp;
        int[] userPicProp;

        // MAIN FORM ON LOAD --------------------------------------------------------------
        public mainForm()
        {
            InitializeComponent();
            menubarDisplayButtonBool = true;
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
            DatabasePanelHeightAndTopFunc(pnlCostumersDatabase, pnlCostumerInfo, tabCostumers, lblCostumersDatabase);
        }

        // COSTUMER TYPE COMBO BOX ON LEAVE --------------------------------------------------
        private void cmbCostumerType_Leave(object sender, EventArgs e)
        {
            ComboboxCheckerFunc(cmbCostumerType, lblCostumerTypeAlert, pnlCostumerInfo, true);
        }

        // FUNCTIONS *************************************************************************

        // COSTUMER INFO PANEL HIGHT SETTER FUNCTION -----------------------------------------
        void CostumerInfoPanelHeight()
        {
            pnlCostumerInfo.Size = new Size(pnlCostumerInfo.Width, (btnCostumerInfoChooseAsBuyer.Top +
                btnCostumerInfoChooseAsBuyer.Height + pnlCostumerInfo.Padding.Top));
        }

        // COSTUMERS DATABASE PANEL HIGHT AND TOP SETTER FUNCTION ----------------------------
        void DatabasePanelHeightAndTopFunc(Control mainPanel, Control topPanel, Control parent, Label title)
        {
            //mainPanel.Size = new Size(mainPanel.Width, 600);
            mainPanel.Top = topPanel.Top + topPanel.Height + 20;
            title.Top = mainPanel.Top - 16;
        }

        // COMBO BOX CHECKER FUNCTION --------------------------------------------------------
        void ComboboxCheckerFunc(ComboBox cmb, Control lblAlert, FlowLayoutPanel pnl, bool nextLine)
        {
            if (cmb.Text.Length > 0)
            {
                bool checkBool = false;
                foreach (var item in cmb.Items)
                {
                    if (cmb.Text == item.ToString())
                    {
                        checkBool = true;
                    }
                }
                if (checkBool == false && nextLine == true)
                {
                    pnl.SetFlowBreak(cmb, false);
                    pnl.SetFlowBreak(lblAlert, true);
                    lblAlert.Visible = true;
                    cmb.Text = null;
                }
                else
                {
                    lblAlert.Visible = false;
                    pnl.SetFlowBreak(lblAlert, false);
                    pnl.SetFlowBreak(cmb, true);
                }
            }
        }
    }
}