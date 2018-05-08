using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarShowRoom
{
    public partial class Login1 : Form
    {
        Code.Query_DB cdbe = new Code.Query_DB();

        public Login1()
        {
            InitializeComponent();
          
        }

        private void Login1_Load(object sender, EventArgs e)
        {
           
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            SignupPage sp = new SignupPage();
            sp.Show();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            cdbe.USER_EMAIL = UserName.Text;
            cdbe.PASSWORD = Password.Text;
            if (cdbe.VerifyAddUser(cdbe))
            {
                cdbe = cdbe.GetUserDetails(cdbe);
                Admin ad = new Admin(cdbe);
                ad.Show();
                UserName.Text = "";
                Password.Text = "";
                Wrong.Text = "";

            }
            else
            {
                if (cdbe.VerifyUser(cdbe))
                {
                    cdbe = cdbe.GetUserDetails(cdbe);
                    Home hm = new Home(cdbe);
                    hm.Show();
                    UserName.Text = "";
                    Password.Text = "";
                    Wrong.Text = "";
                }
                else
                {
                    Wrong.Text = "** Wrong Username OR Password **";

                }
            }
        }
    }
}
