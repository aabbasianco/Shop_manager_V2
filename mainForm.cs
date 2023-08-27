using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_manager_V2
{
    public partial class mainForm : Form
    {
        // VARIABLES -------------------------------------------------------------------------

        bool menubarDisplayButtonBool;
        bool darkModeBool;
        int[] menuLogoPicProp;
        int[] userPicProp;
        Control[] costumersDatabaseSearchControlsArr;
        Control[] mainDatabasePanelsArr;
        Control[] infoPanelsArr;
        Control[] dateAndTimePanelsArr;
        Control[] ActiveStaffInfoPanelsArr;
        Control[] databaseSearchPanelsArr;
        Control[] mainDatabaseDgvArr;
        Control[] mainDatabaseLabelArr;
        Control[] infoPanelLabelArr;

        // MAIN FORM ON LOAD --------------------------------------------------------------
        public mainForm()
        {
            InitializeComponent();
            darkModeBool = false;
            menubarDisplayButtonBool = true;
            costumersDatabaseSearchControlsArr = new Control[6] { txtCostumersDatabaseSearchNormal,cmbCostumersDatabaseSearchStandardPersonalInfo,
            cmbCostumersDatabaseSearchStandardPlaceInfo,cmbCostumersDatabaseSearchStandardDate,lblCostumersDatabaseSearchStandardDate,
            lblCostumersDatabaseSearchStandardHour};
            mainDatabasePanelsArr = new Control[4] { pnlMainDatabase1, pnlMainDatabase2, pnlMainDatabase3, pnlMainDatabase6 };
            infoPanelsArr = new Control[4] { pnlInfo1, pnlInfo2, pnlInfo3, pnlInfo6 };
            dateAndTimePanelsArr = new Control[7] { pnlTabDateAndTime0, pnlTabDateAndTime1, pnlTabDateAndTime2
            , pnlTabDateAndTime3, pnlTabDateAndTime4, pnlTabDateAndTime5, pnlTabDateAndTime6};
            ActiveStaffInfoPanelsArr = new Control[7] { pnlActiveStaffInfo0, pnlActiveStaffInfo1, pnlActiveStaffInfo2
            , pnlActiveStaffInfo3, pnlActiveStaffInfo4, pnlActiveStaffInfo5, pnlActiveStaffInfo6};
            databaseSearchPanelsArr = new Control[4] { pnlDatabaseSearch1, pnlDatabaseSearch2, pnlDatabaseSearch3, pnlDatabaseSearch6 };
            mainDatabaseDgvArr = new Control[4] { dgvMain1, dgvMain2, dgvMain3, dgvMain6 };
            mainDatabaseLabelArr = new Control[4] { lblMainDatabase1, lblMainDatabase2, lblMainDatabase3, lblMainDatabase6 };
            infoPanelLabelArr = new Control[4] { lblInfoPanel1, lblInfoPanel2, lblInfoPanel3, lblInfoPanel6 };
            for (int i = 0; i < mainDatabasePanelsArr.Length; i++)
            {
                mainDatabasePanelsArr[i].Width = 1120;
                infoPanelsArr[i].Width = 1120;
                infoPanelsArr[i].Height = infoPanelsArr[i].Controls[infoPanelsArr[i].Controls.Count - 1].Top + infoPanelsArr[i].Controls[0].Top;
                mainDatabasePanelsArr[i].Location = new Point(20, 187);
                infoPanelsArr[i].Location = new Point(20, 792);
                mainDatabaseDgvArr[i].Height = pnlMainDatabase2.Height - pnlDatabaseSearch2.Height - pnlDatabaseSearch2.Top - 10;
                mainDatabaseLabelArr[i].Location = new Point(988, 169);
                infoPanelLabelArr[i].Location = new Point(988, 773);
                //databaseSearchPanelsArr[i].Height = 130;
            }
            pnlMainDatabase5.Width = 1120;
            pnlMainDatabase5.Location = new Point(20, 187);
            pnlInfo5.Width = 1120;
            pnlInfo5.Location = new Point(20, 792);
            for (int i = 0; i < ActiveStaffInfoPanelsArr.Length; i++)
            {
                ActiveStaffInfoPanelsArr[i].Left = pnlTabDateAndTime0.Left + pnlTabDateAndTime0.Width + 100;
                dateAndTimePanelsArr[i].Width = pnlMainDatabase2.Width - pnlActiveStaffInfo0.Width - 100;
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
                if (darkModeBool == false)
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.LightModeWhite;
                }
                else
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.DarkModeWhite;
                }
            }
            else
            {
                pnlMenuUp.BackgroundImage = Properties.Resources.BackgroundEvening;
                btnMenubarDisplay.BackgroundImage = Properties.Resources.DoubleArrowRightWhite;
                pnlMenubar.Width = btnMenuMainPageLogo.Width + 25 + btnMenuMainPage.Width;
                btnMenuRecivedProducts.Text = "حواله ورود محصول";
                if (darkModeBool == false)
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.LightMode;
                }
                else
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.DarkMode;
                }
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
            CostumerInfoPanelHeightAndTopFunc(pnlInfo2, pnlMainDatabase2, tabCostumers, lblInfoPanel2);
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

        private void btnMenuTheme_Click(object sender, EventArgs e)
        {
            darkModeBool = !darkModeBool;
            if (darkModeBool == true)
            {
                //MessageBox.Show(tabCtrlMain.Controls.Count.ToString());
                this.BackColor = ColorTranslator.FromHtml("#101019");
                Control[] themeControls = new Control[] {tabCtrlMain, pnlActiveStaffInfo0, pnlActiveStaffInfo1, pnlActiveStaffInfo2
                , pnlActiveStaffInfo3 , pnlActiveStaffInfo4, pnlActiveStaffInfo5,pnlActiveStaffInfo6,tabMainPage,tabProducts,tabCostumers,
                tabSellReport, tabRecivedProducts, tabCart, tabStaff, pnlMainDatabase1, pnlMainDatabase2, pnlMainDatabase3
                , pnlMainDatabase6};
                for (int i = 0; i < themeControls.Length; i++)
                {
                    for (int j = 0; j < themeControls[i].Controls.Count; j++)
                    {
                        themeControls[i].Controls[j].BackColor = ColorTranslator.FromHtml("#101019");
                        themeControls[i].Controls[j].ForeColor = Color.White;
                    }
                }
                dgvMain1.BackgroundColor = ColorTranslator.FromHtml("#101019");
                dgvMain2.BackgroundColor = ColorTranslator.FromHtml("#101019");
                dgvMain3.BackgroundColor = ColorTranslator.FromHtml("#101019");
                dgvMain6.BackgroundColor = ColorTranslator.FromHtml("#101019");
                dgvMain1.ForeColor = Color.White;
                dgvMain2.ForeColor = Color.White;
                dgvMain3.ForeColor = Color.White;
                dgvMain6.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                Control[] themeControls = new Control[] {tabCtrlMain, pnlActiveStaffInfo0, pnlActiveStaffInfo1, pnlActiveStaffInfo2
                , pnlActiveStaffInfo3 , pnlActiveStaffInfo4, pnlActiveStaffInfo5,pnlActiveStaffInfo6,tabMainPage,tabProducts,tabCostumers,
                tabSellReport, tabRecivedProducts,tabCart,tabStaff,pnlMainDatabase1,pnlMainDatabase2,pnlMainDatabase3
                ,pnlMainDatabase6};
                for (int i = 0; i < themeControls.Length; i++)
                {
                    for (int j = 0; j < themeControls[i].Controls.Count; j++)
                    {
                        themeControls[i].Controls[j].BackColor = Color.White;
                        themeControls[i].Controls[j].ForeColor = Color.Black;
                    }
                }
                dgvMain1.BackgroundColor = Color.White;
                dgvMain2.BackgroundColor = Color.White;
                dgvMain3.BackgroundColor = Color.White;
                dgvMain6.BackgroundColor = Color.White;
                dgvMain1.ForeColor = Color.Black;
                dgvMain2.ForeColor = Color.Black;
                dgvMain3.ForeColor = Color.Black;
                dgvMain6.ForeColor = Color.Black;
            }

            // THEME ICON
            if (menubarDisplayButtonBool == false)
            {
                if (darkModeBool == false)
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.LightModeWhite;
                }
                else
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.DarkModeWhite;
                }
            }
            else
            {
                if (darkModeBool == false)
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.LightMode;
                }
                else
                {
                    btnMenuTheme.BackgroundImage = Properties.Resources.DarkMode;
                }
            }

            dgvMain1.ForeColor = Color.Black;
            dgvMain2.ForeColor = Color.Black;
            dgvMain3.ForeColor = Color.Black;
            dgvMain6.ForeColor = Color.Black;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // TODO: This line of code loads data into the 'application_DBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.application_DBDataSet.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control[] textBoxes = new Control[] { textBox0, textBox1, textBox2, textBox3, textBox4, textBox5 };
            int emptyCounter = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text.Length > 0)
                {
                    emptyCounter++;
                }
            }
            if (emptyCounter > 0)
            {
                productsTableAdapter.FillByName_Brand(application_DBDataSet.Products, textBox0.Text, textBox4.Text);
                productsTableAdapter.Fill(application_DBDataSet.Products);
                int index = dgvMain1.CurrentCell.RowIndex;
                string oldStock = dgvMain1.Rows[index].Cells[3].Value.ToString();
                int rowCounter = dgvMain1.RowCount;
                if (rowCounter > 0)
                {
                    short a = short.Parse(textBox3.Text);
                    short sOldStock = short.Parse(oldStock);
                    a += sOldStock;
                    productsTableAdapter.UpdateQueryInsertAgainProduct(textBox1.Text, int.Parse(textBox2.Text), a, (textBox4.Text).ToString(), DateTime.Parse(textBox5.Text), textBox1.Text, textBox4.Text);
                    productsTableAdapter.Fill(application_DBDataSet.Products);
                    MessageBox.Show("محصولی با همین مشخصات وجود داشت و  به موجودی آن اضافه گردید");
                }
                else
                {
                    productsTableAdapter.InsertQueryProduct(textBox1.Text, int.Parse(textBox2.Text), short.Parse(textBox3.Text), textBox4.Text, DateTime.Parse(textBox5.Text));
                    productsTableAdapter.Fill(application_DBDataSet.Products);
                }

            }
            else
            {
                MessageBox.Show("لطفا تمامی مقادیر را پر کنید");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Control[] textBoxes = new Control[] { textBox0, textBox1, textBox2, textBox3, textBox4, textBox5 };
            int emptyCounter = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text.Length > 0)
                {
                    emptyCounter++;
                }
            }
            if (emptyCounter > 0)
            {
                productsTableAdapter.UpdateQueryProduct(textBox1.Text, int.Parse(textBox2.Text), short.Parse(textBox3.Text), textBox4.Text, DateTime.Parse(textBox5.Text), int.Parse(textBox0.Text));
                productsTableAdapter.Fill(application_DBDataSet.Products);
            }
            else
            {
                MessageBox.Show("برای ویرایش لطفا تمامی مقادیر را پر کنید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox0.Text.Length > 0)
            {
                productsTableAdapter.DeleteQueryProduct(int.Parse(textBox0.Text));
                productsTableAdapter.Fill(application_DBDataSet.Products);
            }
            else
            {
                MessageBox.Show("برای حذف لطفا کد محصول را پر کنید");
            }
        }

        private void dgvMain1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMain1.CurrentCell.RowIndex;
            textBox0.Text = dgvMain1.Rows[index].Cells[0].Value.ToString();
            textBox1.Text = dgvMain1.Rows[index].Cells[1].Value.ToString();
            textBox2.Text = dgvMain1.Rows[index].Cells[2].Value.ToString();
            textBox3.Text = dgvMain1.Rows[index].Cells[3].Value.ToString();
            textBox4.Text = dgvMain1.Rows[index].Cells[4].Value.ToString();
            textBox5.Text = dgvMain1.Rows[index].Cells[5].Value.ToString();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
            string dayOfWeek = today.DayOfWeek.ToString();
            Control[] todayLabels = new Control[] { label27, label34, label152, label2, lblCostumerSignupDate, label115, label44, label53, label63, label73, label92 };
            Control[] timeLabels = new Control[] { label18, label94, label36, label97, lblCostumerSignupTime, label117, label46, label55, label65, label75, label124 };
            Control[] dayLabels = new Control[] { label153, label96, label38, label154, lblCostumerSignupDay, label119, label48, label57, label67, label77, label126 };
            for (int i = 0; i < todayLabels.Length; i++)
            {
                todayLabels[i].Text = today.Date.ToString("MM/dd/yy");
                timeLabels[i].Text = now.ToString("hh:mm tt");
                dayLabels[i].Text = today.Day.ToString();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}