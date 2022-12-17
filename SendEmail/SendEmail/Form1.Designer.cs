
namespace SendEmail
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.carbonCopyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sendMailButton
            // 
            this.sendMailButton.Location = new System.Drawing.Point(403, 69);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(75, 23);
            this.sendMailButton.TabIndex = 5;
            this.sendMailButton.Text = "Send!";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendButtonOnClick);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.sslCheckBox);
            this.Settings.Controls.Add(this.smtpTextBox);
            this.Settings.Controls.Add(this.label8);
            this.Settings.Controls.Add(this.portTextBox);
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.passWordTextBox);
            this.Settings.Controls.Add(this.userTextBox);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.sendMailButton);
            this.Settings.Location = new System.Drawing.Point(172, 297);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(508, 100);
            this.Settings.TabIndex = 3;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Location = new System.Drawing.Point(403, 22);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sslCheckBox.TabIndex = 1;
            this.sslCheckBox.Text = "SSL";
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // smtpTextBox
            // 
            this.smtpTextBox.Location = new System.Drawing.Point(202, 71);
            this.smtpTextBox.Name = "smtpTextBox";
            this.smtpTextBox.Size = new System.Drawing.Size(179, 20);
            this.smtpTextBox.TabIndex = 4;
            this.smtpTextBox.Text = "smtp.gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "SMTP:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(70, 71);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(80, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Port:";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(70, 45);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.PasswordChar = '●';
            this.passWordTextBox.Size = new System.Drawing.Size(311, 20);
            this.passWordTextBox.TabIndex = 2;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(70, 19);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(311, 20);
            this.userTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recipient of Email:";
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Location = new System.Drawing.Point(172, 51);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(508, 20);
            this.recipientTextBox.TabIndex = 0;
            // 
            // carbonCopyTextBox
            // 
            this.carbonCopyTextBox.Location = new System.Drawing.Point(172, 77);
            this.carbonCopyTextBox.Name = "carbonCopyTextBox";
            this.carbonCopyTextBox.Size = new System.Drawing.Size(508, 20);
            this.carbonCopyTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Carbon Copy address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(172, 103);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(508, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject:";
            // 
            // messageContent
            // 
            this.messageContent.Location = new System.Drawing.Point(172, 129);
            this.messageContent.Multiline = true;
            this.messageContent.Name = "messageContent";
            this.messageContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageContent.Size = new System.Drawing.Size(508, 162);
            this.messageContent.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.messageContent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carbonCopyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipientTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recipientTextBox;
        private System.Windows.Forms.TextBox carbonCopyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.TextBox smtpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

