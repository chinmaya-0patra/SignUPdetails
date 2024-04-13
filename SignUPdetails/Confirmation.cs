using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUPdetails
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblSmsg.Text = "Thanks for SignUp. We'll be in touch with you soon!";

            fData.Text = SignUPhome.fname;
            lData.Text = SignUPhome.lname;
            mailData.Text = SignUPhome.email;

            if (SignUPhome.sms)
            {
                smsTick.Text = "✔";
            }
            if (SignUPhome.report)
            {
                reportTick.Text = "✔";
            }
            if (SignUPhome.trans)
            {
                transTick.Text = "✔";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fData_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUPhome sh = new SignUPhome();
            sh.Show();
        }
    }
}
