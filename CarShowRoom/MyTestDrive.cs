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
    public partial class MyTestDrive : Form
    {
        Code.Query_DB cdb = new Code.Query_DB();

        public MyTestDrive(Code.Query_DB cdbe)
        {
            InitializeComponent();
            cdb = cdbe;
        }

        private void MyTestDrive_Load(object sender, EventArgs e)
        {
            cdb.MyTestDriveView(MyTestDriveView, cdb.ID);
        }
    }
}
