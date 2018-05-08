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
    public partial class Home : Form
    {
        String bp;
        Code.Query_DB cdb = new Code.Query_DB();
        
        public Home(Code.Query_DB cdbe)
        {
            cdb = cdbe;
            InitializeComponent();
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bp = "l Aventador";
            CarView cv = new CarView(cdb, bp, "16.00 kmpl", "Petrol", "90.0", "6498 CC", "2", "350", "Lamborghini Aventador", "₹ 5.85 Crore");
            cv.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bp = "l Centenario";
            CarView cv = new CarView(cdb, bp, "	6.25 kmpl", "Petrol", "80.0", "6498 cc", "2", "350 ", "Lamborghini Centenario", "13 crore.");
            cv.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bp = "l Huracan";
            CarView cv = new CarView(cdb, bp, "11.91 kmpl", "Petrol", "90.0", "5204 CC", "2", "320", "Lamborghini Huracan", "₹ 3.49 - 4.64 Crore");
            cv.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bp = "Ferrari California";
            CarView cv = new CarView(cdb, bp, "9.52 kmpl", "Petrol", "70.0", "3855 CC", "2", "315", "Ferrari California", "₹ 4.44 Crore");
            cv.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bp="Ferrari 488";
            CarView cv = new CarView(cdb, bp, "8.77 Kmpl", "Petrol", " 78.0", "3902 cc", "2", "345", "Ferrari 488 Spider", "₹ 3.68 Crores");
            cv.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            bp = "Ferrari GTC4 Lusso";
            CarView cv = new CarView(cdb, bp, "9.00 kmpl", "Petrol", "91.0", "3855 CC", "4", "320", "Ferrari GTC4 Lusso", "₹ 4.91 - 6.07 Crore");
            cv.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            bp = "BMW 3 Series 2017";
            CarView cv = new CarView(cdb, bp, "16.05 kmpl", "Petrol", "60.0", "1998 CC", "5", "250", "BMW 3 Series", "₹ 52.86 - 50.99 Lakh");
            cv.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            bp = "BMW i8";
            CarView cv = new CarView(cdb, bp, "47.45 kmpl", "Petrol", "42.0", "1499 CC", "4", "250", "BMW i8", "₹ 3.06 Crore");
            cv.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            bp = "BMW X5 2017";
            CarView cv = new CarView(cdb, bp, "15.97 kmpl", "Diesel", "85.0", "2993 CC", "5", "230", "BMW X5", "₹ 87.31 - 93.62 Lakh");
            cv.Show();
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeProfile cp = new ChangeProfile(cdb);
            cp.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(cdb);
            cp.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyOrder mo =new MyOrder(cdb);
            mo.Show();
        }

        private void myTestDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTestDrive mt = new MyTestDrive(cdb);
            mt.Show();
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendFeedback sf = new SendFeedback(cdb);
            sf.Show();
        }

        private void exitToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
