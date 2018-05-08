using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarShowRoom
{
    public partial class SignupPage : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public SignupPage()
        {
            InitializeComponent();
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SName.Text = "";
            SEmail.Text = "";
            SAddress.Text = "";
            SMobile.Text = "";
            SPassword.Text = "";
        }

        private void SignupP_Click(object sender, EventArgs e)
        {
            if (!SName.Text.Equals("") && !SEmail.Text.Equals("") && !SAddress.Text.Equals("") && !SMobile.Text.Equals("") && !SPassword.Text.Equals(""))
            {
                utb.USER_EMAIL = SEmail.Text;
                if (!utb.CheckUser(utb))
                {
                    utb.PASSWORD = SPassword.Text;
                    utb.NAME = SName.Text;
                    utb.ADDRESS= SAddress.Text;
                    utb.MOBILE= SMobile.Text;
                    utb.USER_TYPE = 0;

                    if (utb.CreateUser(utb))
                    {
                        MessageBox.Show("User Created");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("There is some problem in creating user");
                    }
                }
            }
        }
    }
}
