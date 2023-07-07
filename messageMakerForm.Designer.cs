namespace Shop_manager_V2
{
    partial class messageMakerForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMessageText = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessageText = new System.Windows.Forms.RichTextBox();
            this.pnlMessageSenderInfo = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlMessageText.SuspendLayout();
            this.pnlMessageSenderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(34, 372);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(210, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(524, 372);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(210, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlMessageText
            // 
            this.pnlMessageText.AutoScroll = true;
            this.pnlMessageText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMessageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessageText.Controls.Add(this.label2);
            this.pnlMessageText.Controls.Add(this.txtMessageText);
            this.pnlMessageText.Location = new System.Drawing.Point(34, 187);
            this.pnlMessageText.Name = "pnlMessageText";
            this.pnlMessageText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMessageText.Size = new System.Drawing.Size(700, 168);
            this.pnlMessageText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(597, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(101, 166);
            this.label2.TabIndex = 5;
            this.label2.Text = "متن پیام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessageText
            // 
            this.txtMessageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMessageText.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMessageText.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.txtMessageText.Location = new System.Drawing.Point(0, 0);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMessageText.Size = new System.Drawing.Size(597, 166);
            this.txtMessageText.TabIndex = 0;
            this.txtMessageText.Text = "";
            // 
            // pnlMessageSenderInfo
            // 
            this.pnlMessageSenderInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMessageSenderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessageSenderInfo.Controls.Add(this.comboBox1);
            this.pnlMessageSenderInfo.Controls.Add(this.label1);
            this.pnlMessageSenderInfo.Location = new System.Drawing.Point(34, 94);
            this.pnlMessageSenderInfo.Name = "pnlMessageSenderInfo";
            this.pnlMessageSenderInfo.Size = new System.Drawing.Size(700, 75);
            this.pnlMessageSenderInfo.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Koodak", 29F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(597, 75);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "به ترکیب فیلد های اسم و فامیل وصل بشه";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Koodak", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(597, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(101, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "گیرنده";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblMessageTitle.TabIndex = 9;
            this.lblMessageTitle.Text = "ایجاد پیام جدید";
            this.lblMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Koodak", 16F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(279, 372);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(210, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "پاک کردن";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // messageMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlMessageText);
            this.Controls.Add(this.pnlMessageSenderInfo);
            this.Controls.Add(this.lblMessageTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messageMakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "messageMakerForm";
            this.pnlMessageText.ResumeLayout(false);
            this.pnlMessageSenderInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMessageText;
        private System.Windows.Forms.RichTextBox txtMessageText;
        private System.Windows.Forms.Panel pnlMessageSenderInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}