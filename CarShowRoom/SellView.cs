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
    public partial class SellView : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public SellView()
        {
            InitializeComponent();
        }

        private void SellView_Load(object sender, EventArgs e)
        {
            utb.SellViewAll(SellViews);
        }
    }
}
