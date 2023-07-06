namespace Shop_manager_V2
{
    partial class messageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messageForm));
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMessageSenderInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessageSenderFullname = new System.Windows.Forms.Label();
            this.pnlMessageText = new System.Windows.Forms.Panel();
            this.txtMessageText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlMessageSenderInfo.SuspendLayout();
            this.pnlMessageText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblMessageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessageTitle.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.lblMessageTitle.ForeColor = System.Drawing.Color.White;
            this.lblMessageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessageTitle.Size = new System.Drawing.Size(768, 50);
            this.lblMessageTitle.TabIndex = 3;
            this.lblMessageTitle.Text = "عنوان پیام";
            this.lblMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(597, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(101, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "فرستنده :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMessageSenderInfo
            // 
            this.pnlMessageSenderInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMessageSenderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessageSenderInfo.Controls.Add(this.label2);
            this.pnlMessageSenderInfo.Controls.Add(this.lblMessageSenderFullname);
            this.pnlMessageSenderInfo.Controls.Add(this.label1);
            this.pnlMessageSenderInfo.Location = new System.Drawing.Point(34, 94);
            this.pnlMessageSenderInfo.Name = "pnlMessageSenderInfo";
            this.pnlMessageSenderInfo.Size = new System.Drawing.Size(700, 75);
            this.pnlMessageSenderInfo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(141, 73);
            this.label2.TabIndex = 6;
            this.label2.Text = "*سمت(جایگاه)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessageSenderFullname
            // 
            this.lblMessageSenderFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageSenderFullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessageSenderFullname.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.lblMessageSenderFullname.Location = new System.Drawing.Point(0, 0);
            this.lblMessageSenderFullname.Name = "lblMessageSenderFullname";
            this.lblMessageSenderFullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessageSenderFullname.Size = new System.Drawing.Size(597, 73);
            this.lblMessageSenderFullname.TabIndex = 5;
            this.lblMessageSenderFullname.Text = "نام و نام خانوادگی فرستنده";
            this.lblMessageSenderFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMessageText
            // 
            this.pnlMessageText.AutoScroll = true;
            this.pnlMessageText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMessageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessageText.Controls.Add(this.txtMessageText);
            this.pnlMessageText.Location = new System.Drawing.Point(34, 187);
            this.pnlMessageText.Name = "pnlMessageText";
            this.pnlMessageText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMessageText.Size = new System.Drawing.Size(700, 168);
            this.pnlMessageText.TabIndex = 7;
            // 
            // txtMessageText
            // 
            this.txtMessageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessageText.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.txtMessageText.Location = new System.Drawing.Point(0, 0);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.ReadOnly = true;
            this.txtMessageText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMessageText.Size = new System.Drawing.Size(698, 166);
            this.txtMessageText.TabIndex = 0;
            this.txtMessageText.Text = resources.GetString("txtMessageText.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(414, 372);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(320, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(34, 372);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(320, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "پاسخ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // messageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlMessageText);
            this.Controls.Add(this.pnlMessageSenderInfo);
            this.Controls.Add(this.lblMessageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیغام جدید";
            this.pnlMessageSenderInfo.ResumeLayout(false);
            this.pnlMessageText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMessageSenderInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessageSenderFullname;
        private System.Windows.Forms.Panel pnlMessageText;
        private System.Windows.Forms.RichTextBox txtMessageText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}