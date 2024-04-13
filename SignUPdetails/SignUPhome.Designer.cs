namespace SignUPdetails
{
    partial class SignUPhome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textFname = new TextBox();
            lblFname = new Label();
            textLname = new TextBox();
            lblLname = new Label();
            textEmail = new TextBox();
            lblEmail = new Label();
            Services = new GroupBox();
            lblTransMsg = new Label();
            lblSmsMsg = new Label();
            checkBoxTrans = new CheckBox();
            checkBoxReport = new CheckBox();
            checkBoxSMS = new CheckBox();
            btnSubmit = new Button();
            Services.SuspendLayout();
            SuspendLayout();
            // 
            // textFname
            // 
            textFname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textFname.Location = new Point(380, 128);
            textFname.Name = "textFname";
            textFname.Size = new Size(573, 27);
            textFname.TabIndex = 0;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.Location = new Point(191, 128);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(152, 27);
            lblFname.TabIndex = 1;
            lblFname.Text = "First Name : ";
            // 
            // textLname
            // 
            textLname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textLname.Location = new Point(380, 189);
            textLname.Name = "textLname";
            textLname.Size = new Size(573, 27);
            textLname.TabIndex = 3;
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLname.Location = new Point(191, 186);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(150, 27);
            lblLname.TabIndex = 2;
            lblLname.Text = "Last Name : ";
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textEmail.Location = new Point(381, 248);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(572, 27);
            textEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(191, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(92, 27);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email : ";
            // 
            // Services
            // 
            Services.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Services.Controls.Add(lblTransMsg);
            Services.Controls.Add(lblSmsMsg);
            Services.Controls.Add(checkBoxTrans);
            Services.Controls.Add(checkBoxReport);
            Services.Controls.Add(checkBoxSMS);
            Services.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Services.Location = new Point(191, 315);
            Services.Name = "Services";
            Services.Size = new Size(762, 205);
            Services.TabIndex = 6;
            Services.TabStop = false;
            Services.Text = "Services";
            // 
            // lblTransMsg
            // 
            lblTransMsg.AutoSize = true;
            lblTransMsg.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTransMsg.ForeColor = Color.IndianRed;
            lblTransMsg.Location = new Point(357, 144);
            lblTransMsg.Name = "lblTransMsg";
            lblTransMsg.Size = new Size(64, 21);
            lblTransMsg.TabIndex = 4;
            lblTransMsg.Text = "label5";
            // 
            // lblSmsMsg
            // 
            lblSmsMsg.AutoSize = true;
            lblSmsMsg.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSmsMsg.ForeColor = Color.IndianRed;
            lblSmsMsg.Location = new Point(357, 58);
            lblSmsMsg.Name = "lblSmsMsg";
            lblSmsMsg.Size = new Size(54, 21);
            lblSmsMsg.TabIndex = 3;
            lblSmsMsg.Text = "4444";
            // 
            // checkBoxTrans
            // 
            checkBoxTrans.AutoSize = true;
            checkBoxTrans.Location = new Point(34, 143);
            checkBoxTrans.Name = "checkBoxTrans";
            checkBoxTrans.Size = new Size(232, 27);
            checkBoxTrans.TabIndex = 2;
            checkBoxTrans.Text = "Transaction Reports";
            checkBoxTrans.UseVisualStyleBackColor = true;
            checkBoxTrans.CheckedChanged += checkBoxTrans_CheckedChanged;
            // 
            // checkBoxReport
            // 
            checkBoxReport.AutoSize = true;
            checkBoxReport.Location = new Point(34, 99);
            checkBoxReport.Name = "checkBoxReport";
            checkBoxReport.Size = new Size(110, 27);
            checkBoxReport.TabIndex = 1;
            checkBoxReport.Text = "Reports";
            checkBoxReport.UseVisualStyleBackColor = true;
            checkBoxReport.CheckedChanged += checkBoxReport_CheckedChanged;
            // 
            // checkBoxSMS
            // 
            checkBoxSMS.AutoSize = true;
            checkBoxSMS.Location = new Point(34, 54);
            checkBoxSMS.Name = "checkBoxSMS";
            checkBoxSMS.Size = new Size(202, 27);
            checkBoxSMS.TabIndex = 0;
            checkBoxSMS.Text = "SMS Notifications";
            checkBoxSMS.UseVisualStyleBackColor = true;
            checkBoxSMS.CheckedChanged += checkBoxSMS_CheckedChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(508, 583);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // SignUPhome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 755);
            Controls.Add(btnSubmit);
            Controls.Add(Services);
            Controls.Add(textEmail);
            Controls.Add(lblEmail);
            Controls.Add(textLname);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(textFname);
            Name = "SignUPhome";
            Text = "SignUP";
            Services.ResumeLayout(false);
            Services.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFname;
        private Label lblFname;
        private TextBox textLname;
        private Label lblLname;
        private TextBox textEmail;
        private Label lblEmail;
        private GroupBox Services;
        private CheckBox checkBoxTrans;
        private CheckBox checkBoxReport;
        private CheckBox checkBoxSMS;
        private Label lblTransMsg;
        private Label lblSmsMsg;
        private Button btnSubmit;
    }
}
