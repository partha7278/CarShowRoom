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
    public partial class TestDrive : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        int carid;
        public TestDrive(Code.Query_DB cdbe,int car)
        {
            InitializeComponent();
            utb = cdbe;
            carid = car;
        }

        private void TestDrive_Load(object sender, EventArgs e)
        {
            label2.Text = utb.NAME;
            utb.TestDriveAdd(utb,carid);


        }
    }
}
