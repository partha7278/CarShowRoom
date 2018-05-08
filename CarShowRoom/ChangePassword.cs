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
    public partial class ChangePassword : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public ChangePassword(Code.Query_DB cdbe)
        {
            InitializeComponent();
            utb = cdbe;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            OPassword.Text = "";
            NPassword.Text = "";
            RNPassword.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (NPassword.Text.Equals(RNPassword.Text))
            {
                if (OPassword.Text.Equals(utb.PASSWORD)) {

                    utb.PASSWORD = NPassword.Text;
                    if (utb.ChangePassword(utb))
                    {
                        MessageBox.Show("Password Changed Successfully");
                        this.Dispose();
                    }

                }
                else { MessageBox.Show("Password Not correct"); }
            }
            else { MessageBox.Show("Password Not match "); }
        }
    }
}
