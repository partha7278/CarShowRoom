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
    public partial class ChangeProfile : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public ChangeProfile(Code.Query_DB cdbe)
        {
            InitializeComponent();
            utb = cdbe;
        }

        private void ChangeProfile_Load(object sender, EventArgs e)
        {
            UName.Text = utb.NAME;
            UEmail.Text = utb.USER_EMAIL;
            UMobile.Text = utb.MOBILE;
            UAddress.Text = utb.ADDRESS;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UName.Text = utb.NAME;
            UEmail.Text = utb.USER_EMAIL;
            UMobile.Text = utb.MOBILE;
            UAddress.Text = utb.ADDRESS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utb.NAME = UName.Text;
            utb.USER_EMAIL=UEmail.Text;
            utb.MOBILE= UMobile.Text;
            utb.ADDRESS=UAddress.Text;


            if (utb.ProfileUpdate(utb))
            {
                MessageBox.Show("Profile Update sucessfuly");
            }
            else {
                MessageBox.Show("Try again");
            }
        }
    }
}
