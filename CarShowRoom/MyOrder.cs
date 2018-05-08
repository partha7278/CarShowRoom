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
    public partial class MyOrder : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public MyOrder(Code.Query_DB cdbe)
        {
            InitializeComponent();
            utb = cdbe;
        }

        private void MyOrder_Load(object sender, EventArgs e)
        {
            utb.MyOrderView(MyOrders,utb.ID);
        }
    }
}
