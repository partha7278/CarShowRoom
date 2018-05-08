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
    public partial class SendFeedback : Form
    {
        Code.Query_DB cdb = new Code.Query_DB();
        public SendFeedback(Code.Query_DB cd)
        {
            InitializeComponent();
            cdb = cd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cdb.FeedbackAdd(cdb, textBox1.Text))
            {
                MessageBox.Show("Thank for your Feedback");
                this.Dispose();
            }
            else {
                MessageBox.Show("try again");
            }
        }
    }
}
