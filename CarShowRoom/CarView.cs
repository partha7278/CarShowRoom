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
    public partial class CarView : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        public static String pb;
        public static String model;
        public static String color;
        public CarView() {
            
        }
        public CarView(Code.Query_DB cdbe, String a, String b, String c, String d, String f, String g, String h, String i, String j)
        {
            InitializeComponent();
            utb = cdbe;
            pb=a;
            model = i;
            try
            {
                main.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + a + "\\1.jpg");
                P1.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + a + "\\1.jpg");
                P2.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + a + "\\2.jpg");
                P3.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + a + "\\3.jpg");
                P4.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + a + "\\4.jpg");
                Mile.Text=b;
                Fuel.Text = c;
                Tank.Text = d;
                Engine.Text = f;
                Capacity.Text = g;
                Speed.Text = h;
                CName.Text= i;
                CPrice.Text = j;

            }
            catch (Exception e) { erro.Text = e.Message; }
    
        }

        private void CarView_Load(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "White"))
            {
                CCart.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
            }
            color = "White";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void P1_Click(object sender, EventArgs e)
        {
            main.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + pb + "\\1.jpg");
        }

        private void P2_Click(object sender, EventArgs e)
        {
            main.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + pb + "\\2.jpg");
        }

        private void P3_Click(object sender, EventArgs e)
        {
            main.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + pb + "\\3.jpg");
        }

        private void P4_Click(object sender, EventArgs e)
        {
            main.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "") + "\\image\\" + pb + "\\4.jpg");
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "White"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "White";
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "Silver"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "Silver";
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "Grey"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "Grey";
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "DarkSeaGreen"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "DarkSeaGreen";
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "Chocolate"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "Chocolate";
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "LightCoral"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";

            }

            color = "LightCoral";
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "Moccasin"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "Moccasin";
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (!utb.CheckAvail(model, "PaleVioletRed"))
            {
                CCart.Enabled = false;
                TestDrive.Enabled = false;
                CCart.Text = "Out Of Stock";
            }
            else
            {
                CCart.Enabled = true;
                CCart.Text = "Add to Cart";
                TestDrive.Enabled = true;
                TestDrive.Text = "TestDrive";
            }

            color = "PaleVioletRed";
        }

        private void CCart_Click(object sender, EventArgs e)
        {
           int id=Convert.ToInt32(utb.CarQuantityId(model,color));
            Booking bk = new Booking(utb,id);
            bk.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestDrive_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(utb.CarQuantityId(model, color));
            TestDrive td = new TestDrive(utb,id);
            td.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeProfile cp = new ChangeProfile(utb);
            cp.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(utb);
            cp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyOrder mo = new MyOrder(utb);
            mo.Show();
        }

        private void myTestDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTestDrive mt = new MyTestDrive(utb);
            mt.Show();
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendFeedback sf = new SendFeedback(utb);
            sf.Show();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
