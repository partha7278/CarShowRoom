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
    public partial class TestDriveViews : Form
    {
        Code.Query_DB cdbe = new Code.Query_DB();
        public TestDriveViews()
        {
            InitializeComponent();
        }

        private void TestDriveViews_Load(object sender, EventArgs e)
        {
            cdbe.TestDriveViewAll(TestDriveView);
        }
    }
}
