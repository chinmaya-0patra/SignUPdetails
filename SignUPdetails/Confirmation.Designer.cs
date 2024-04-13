namespace SignUPdetails
{
    partial class Confirmation
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
            lblSmsg = new Label();
            lblFname = new Label();
            label1 = new Label();
            label2 = new Label();
            fData = new Label();
            lData = new Label();
            mailData = new Label();
            label6 = new Label();
            smsTick = new Label();
            reportTick = new Label();
            transTick = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblSmsg
            // 
            lblSmsg.AutoSize = true;
            lblSmsg.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSmsg.Location = new Point(305, 60);
            lblSmsg.Name = "lblSmsg";
            lblSmsg.Size = new Size(64, 21);
            lblSmsg.TabIndex = 0;
            lblSmsg.Text = "label1";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.Location = new Point(217, 150);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(132, 23);
            lblFname.TabIndex = 2;
            lblFname.Text = "First Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 202);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 3;
            label1.Text = "Last Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, 255);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 4;
            label2.Text = "Email : ";
            // 
            // fData
            // 
            fData.AutoSize = true;
            fData.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fData.Location = new Point(403, 150);
            fData.Name = "fData";
            fData.Size = new Size(66, 23);
            fData.TabIndex = 5;
            fData.Text = "Fdata";
            fData.Click += fData_Click;
            // 
            // lData
            // 
            lData.AutoSize = true;
            lData.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lData.Location = new Point(403, 202);
            lData.Name = "lData";
            lData.Size = new Size(66, 23);
            lData.TabIndex = 6;
            lData.Text = "Ldata";
            // 
            // mailData
            // 
            mailData.AutoSize = true;
            mailData.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailData.Location = new Point(403, 255);
            mailData.Name = "mailData";
            mailData.Size = new Size(94, 23);
            mailData.TabIndex = 7;
            mailData.Text = "maildata";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(217, 388);
            label6.Name = "label6";
            label6.Size = new Size(190, 21);
            label6.TabIndex = 8;
            label6.Text = "Services you chose:";
            // 
            // smsTick
            // 
            smsTick.AutoSize = true;
            smsTick.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smsTick.Location = new Point(534, 443);
            smsTick.Name = "smsTick";
            smsTick.Size = new Size(21, 21);
            smsTick.TabIndex = 12;
            smsTick.Text = "X";
            // 
            // reportTick
            // 
            reportTick.AutoSize = true;
            reportTick.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportTick.Location = new Point(534, 488);
            reportTick.Name = "reportTick";
            reportTick.Size = new Size(21, 21);
            reportTick.TabIndex = 13;
            reportTick.Text = "X";
            // 
            // transTick
            // 
            transTick.AutoSize = true;
            transTick.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transTick.Location = new Point(534, 532);
            transTick.Name = "transTick";
            transTick.Size = new Size(21, 21);
            transTick.TabIndex = 14;
            transTick.Text = "X";
            transTick.Click += label9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Unicode MS", 12F);
            label3.Location = new Point(285, 439);
            label3.Name = "label3";
            label3.Size = new Size(169, 26);
            label3.TabIndex = 15;
            label3.Text = "SMS Notifications";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Unicode MS", 12F);
            label4.Location = new Point(285, 484);
            label4.Name = "label4";
            label4.Size = new Size(82, 26);
            label4.TabIndex = 16;
            label4.Text = "Reports";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Unicode MS", 12F);
            label5.Location = new Point(287, 530);
            label5.Name = "label5";
            label5.Size = new Size(192, 26);
            label5.TabIndex = 17;
            label5.Text = "Transaction Reports";
            label5.Click += label5_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(443, 610);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Confirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 697);
            Controls.Add(btnExit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(transTick);
            Controls.Add(reportTick);
            Controls.Add(smsTick);
            Controls.Add(label6);
            Controls.Add(mailData);
            Controls.Add(lData);
            Controls.Add(fData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFname);
            Controls.Add(lblSmsg);
            Name = "Confirmation";
            Text = "Confirmation";
            Load += Confirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSmsg;
        private Label lblFname;
        private Label label1;
        private Label label2;
        private Label fData;
        private Label lData;
        private Label mailData;
        private Label label6;
        private Label smsTick;
        private Label reportTick;
        private Label transTick;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnExit;
    }
}