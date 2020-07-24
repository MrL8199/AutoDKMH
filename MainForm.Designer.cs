namespace AutoDKMH
{
    partial class MainForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbCookiesValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbListSubjects = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.timerAntiTimeoutSession = new System.Windows.Forms.Timer(this.components);
            this.tbCookiesKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCSE_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCRD_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLichhoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbhidListReg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbhidSubNum = new System.Windows.Forms.TextBox();
            this.cbByMajor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblStatus.Location = new System.Drawing.Point(285, 310);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Đang chờ..";
            // 
            // tbCookiesValue
            // 
            this.tbCookiesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbCookiesValue.Location = new System.Drawing.Point(359, 69);
            this.tbCookiesValue.Name = "tbCookiesValue";
            this.tbCookiesValue.Size = new System.Drawing.Size(131, 23);
            this.tbCookiesValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cookies:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "List Subjects:";
            // 
            // tbListSubjects
            // 
            this.tbListSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbListSubjects.Location = new System.Drawing.Point(191, 101);
            this.tbListSubjects.Name = "tbListSubjects";
            this.tbListSubjects.Size = new System.Drawing.Size(299, 23);
            this.tbListSubjects.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(29, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbPassword.Location = new System.Drawing.Point(359, 40);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(131, 23);
            this.tbPassword.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbID.Location = new System.Drawing.Point(191, 40);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(162, 23);
            this.tbID.TabIndex = 0;
            // 
            // timerAntiTimeoutSession
            // 
            this.timerAntiTimeoutSession.Enabled = true;
            this.timerAntiTimeoutSession.Interval = 50000;
            this.timerAntiTimeoutSession.Tick += new System.EventHandler(this.timerAntiTimeoutSession_Tick);
            // 
            // tbCookiesKey
            // 
            this.tbCookiesKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbCookiesKey.Location = new System.Drawing.Point(191, 69);
            this.tbCookiesKey.Name = "tbCookiesKey";
            this.tbCookiesKey.Size = new System.Drawing.Size(162, 23);
            this.tbCookiesKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(29, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "List CSE_ID:";
            // 
            // tbCSE_ID
            // 
            this.tbCSE_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbCSE_ID.Location = new System.Drawing.Point(191, 130);
            this.tbCSE_ID.Name = "tbCSE_ID";
            this.tbCSE_ID.Size = new System.Drawing.Size(299, 23);
            this.tbCSE_ID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(29, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "List CRD_ID:";
            // 
            // tbCRD_ID
            // 
            this.tbCRD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbCRD_ID.Location = new System.Drawing.Point(191, 159);
            this.tbCRD_ID.Name = "tbCRD_ID";
            this.tbCRD_ID.Size = new System.Drawing.Size(299, 23);
            this.tbCRD_ID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(29, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "List Lichhoc:";
            // 
            // tbLichhoc
            // 
            this.tbLichhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbLichhoc.Location = new System.Drawing.Point(191, 188);
            this.tbLichhoc.Name = "tbLichhoc";
            this.tbLichhoc.Size = new System.Drawing.Size(299, 23);
            this.tbLichhoc.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(29, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "hidListReg:";
            // 
            // tbhidListReg
            // 
            this.tbhidListReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbhidListReg.Location = new System.Drawing.Point(191, 217);
            this.tbhidListReg.Name = "tbhidListReg";
            this.tbhidListReg.Size = new System.Drawing.Size(299, 23);
            this.tbhidListReg.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(29, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "hidSubNum:";
            // 
            // tbhidSubNum
            // 
            this.tbhidSubNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbhidSubNum.Location = new System.Drawing.Point(191, 246);
            this.tbhidSubNum.Name = "tbhidSubNum";
            this.tbhidSubNum.Size = new System.Drawing.Size(299, 23);
            this.tbhidSubNum.TabIndex = 2;
            // 
            // cbByMajor
            // 
            this.cbByMajor.AutoSize = true;
            this.cbByMajor.Location = new System.Drawing.Point(28, 278);
            this.cbByMajor.Name = "cbByMajor";
            this.cbByMajor.Size = new System.Drawing.Size(64, 17);
            this.cbByMajor.TabIndex = 4;
            this.cbByMajor.Text = "ByMajor";
            this.cbByMajor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 347);
            this.Controls.Add(this.cbByMajor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbhidSubNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbhidListReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLichhoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCRD_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCSE_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbListSubjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCookiesKey);
            this.Controls.Add(this.tbCookiesValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbCookiesValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbListSubjects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Timer timerAntiTimeoutSession;
        private System.Windows.Forms.TextBox tbCookiesKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCSE_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCRD_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLichhoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbhidListReg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbhidSubNum;
        private System.Windows.Forms.CheckBox cbByMajor;
    }
}

