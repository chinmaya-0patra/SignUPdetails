namespace SignUPdetails
{
    public partial class SignUPhome : Form
    {
        public static string fname;
        public static string lname;
        public static string email;
        public static Boolean sms;
        public static Boolean report;
        public static Boolean trans;



        public SignUPhome()
        {
            InitializeComponent();
        }

        private void checkBoxSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSMS.Checked)
            {
                sms = true;

                lblSmsMsg.Text = "Services Charges may apply";
            }
            else
            {
                sms = false;

                lblSmsMsg.Text = "";

            }
        }

        

        private void checkBoxReport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReport.Checked)
            {
                report = true;

                //lblTransMsg.Text = "Services Charges may apply";
            }
            else
            {
                report = false;

                //lblTransMsg.Text = "";

            }
        }

        private void checkBoxTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrans.Checked)
            {
                trans = true;

                lblTransMsg.Text = "Services Charges may apply for Transaction";
            }
            else
            {
                trans = false;

                lblTransMsg.Text = "";

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            fname = textFname.Text;
            lname = textLname.Text;
            email = textEmail.Text;

            Confirmation conf = new Confirmation();
            conf.Show();

        }
    }
}
