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
    public partial class Admin : Form
    {
        Code.Query_DB utb = new Code.Query_DB();

        public Admin(Code.Query_DB cdbe)
        {
            InitializeComponent();
           utb = cdbe;
           
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            utb.CartViewAll(CartView);
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateQuantity ad = new UpdateQuantity();
            ad.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeProfile cp = new ChangeProfile(utb);
            cp.Show();
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserViews uv = new UserViews();
            uv.Show();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestDriveViews tv = new TestDriveViews();
            tv.Show();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellView sv = new SellView();
            sv.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(utb);
            cp.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFeedback vf = new ViewFeedback();
            vf.Show();
        }

        private void CartView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text=CartView.SelectedCells[6].Value.ToString();
            label6.Text = CartView.SelectedCells[9].Value.ToString();
            label7.Text = CartView.SelectedCells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            utb.OrderUpdate(Convert.ToInt32(label6.Text), Convert.ToInt32(textBox1.Text),Convert.ToInt32(label7.Text));
            utb.CartViewAll(CartView);
        }

       
    }
}
