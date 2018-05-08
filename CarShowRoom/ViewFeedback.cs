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
    public partial class ViewFeedback : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public ViewFeedback()
        {
            InitializeComponent();
        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            utb.FeedbackView(dataGridView1);
        }
    }
}
