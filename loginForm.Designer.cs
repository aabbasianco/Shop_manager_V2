namespace Shop_manager_V2
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRememberme = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picCloseLock = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picPasswordTextbox = new System.Windows.Forms.PictureBox();
            this.picUsernameTextbox = new System.Windows.Forms.PictureBox();
            this.tmrWelcomeLabel = new System.Windows.Forms.Timer(this.components);
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picSmallLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameTextbox)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.chkRememberme);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.picCloseLock);
            this.pnlLogin.Controls.Add(this.picUser);
            this.pnlLogin.Controls.Add(this.picPasswordTextbox);
            this.pnlLogin.Controls.Add(this.picUsernameTextbox);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLogin.Location = new System.Drawing.Point(734, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(8);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(450, 611);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "scsxdxc";
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 16F);
            this.txtPassword.Location = new System.Drawing.Point(132, 312);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(228, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleDescription = "scsxdxc";
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 16F);
            this.txtUsername.Location = new System.Drawing.Point(132, 216);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 27);
            this.txtUsername.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(81, 444);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(298, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // chkRememberme
            // 
            this.chkRememberme.Location = new System.Drawing.Point(205, 370);
            this.chkRememberme.Name = "chkRememberme";
            this.chkRememberme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRememberme.Size = new System.Drawing.Size(171, 40);
            this.chkRememberme.TabIndex = 3;
            this.chkRememberme.Text = "نمایش رمز";
            this.chkRememberme.UseVisualStyleBackColor = true;
            this.chkRememberme.CheckedChanged += new System.EventHandler(this.chkRememberme_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Koodak", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(202, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "رمز عبور";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Koodak", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(202, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام کاربری";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Koodak", 30F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(143, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 70);
            this.label4.TabIndex = 2;
            this.label4.Text = "ورود کاربر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Koodak", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 611);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCloseLock
            // 
            this.picCloseLock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picCloseLock.Image = global::Shop_manager_V2.Properties.Resources.CloseLock;
            this.picCloseLock.Location = new System.Drawing.Point(94, 312);
            this.picCloseLock.Margin = new System.Windows.Forms.Padding(8);
            this.picCloseLock.Name = "picCloseLock";
            this.picCloseLock.Size = new System.Drawing.Size(27, 27);
            this.picCloseLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCloseLock.TabIndex = 0;
            this.picCloseLock.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picUser.Image = global::Shop_manager_V2.Properties.Resources.User;
            this.picUser.Location = new System.Drawing.Point(94, 216);
            this.picUser.Margin = new System.Windows.Forms.Padding(8);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(27, 27);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // picPasswordTextbox
            // 
            this.picPasswordTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPasswordTextbox.Image = global::Shop_manager_V2.Properties.Resources.TextBox;
            this.picPasswordTextbox.Location = new System.Drawing.Point(81, 297);
            this.picPasswordTextbox.Margin = new System.Windows.Forms.Padding(8);
            this.picPasswordTextbox.Name = "picPasswordTextbox";
            this.picPasswordTextbox.Size = new System.Drawing.Size(298, 55);
            this.picPasswordTextbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPasswordTextbox.TabIndex = 0;
            this.picPasswordTextbox.TabStop = false;
            // 
            // picUsernameTextbox
            // 
            this.picUsernameTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picUsernameTextbox.Image = global::Shop_manager_V2.Properties.Resources.TextBox;
            this.picUsernameTextbox.Location = new System.Drawing.Point(81, 201);
            this.picUsernameTextbox.Margin = new System.Windows.Forms.Padding(8);
            this.picUsernameTextbox.Name = "picUsernameTextbox";
            this.picUsernameTextbox.Size = new System.Drawing.Size(298, 55);
            this.picUsernameTextbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsernameTextbox.TabIndex = 0;
            this.picUsernameTextbox.TabStop = false;
            // 
            // tmrWelcomeLabel
            // 
            this.tmrWelcomeLabel.Interval = 70;
            this.tmrWelcomeLabel.Tick += new System.EventHandler(this.tmrWelcomeLabel_Tick);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlLogo.BackgroundImage = global::Shop_manager_V2.Properties.Resources.LoginFormBackground;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.lblWelcome);
            this.pnlLogo.Controls.Add(this.picSmallLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(8);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(1184, 611);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Koodak", 50F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(737, 385);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(329, 116);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "خوش آمدید";
            // 
            // picSmallLogo
            // 
            this.picSmallLogo.BackColor = System.Drawing.Color.Transparent;
            this.picSmallLogo.Image = global::Shop_manager_V2.Properties.Resources.MainLogoSmall;
            this.picSmallLogo.Location = new System.Drawing.Point(556, 17);
            this.picSmallLogo.Margin = new System.Windows.Forms.Padding(8);
            this.picSmallLogo.Name = "picSmallLogo";
            this.picSmallLogo.Size = new System.Drawing.Size(162, 160);
            this.picSmallLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSmallLogo.TabIndex = 0;
            this.picSmallLogo.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Koodak", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه ورود";
            this.TopMost = true;
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameTextbox)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picSmallLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picUsernameTextbox;
        private System.Windows.Forms.PictureBox picCloseLock;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPasswordTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRememberme;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer tmrWelcomeLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}