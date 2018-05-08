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
    public partial class Booking : Form
    {
        Code.Query_DB utb = new Code.Query_DB();
        int carid;
        public Booking(Code.Query_DB cdbe,int car)
        {
            InitializeComponent();
            label7.Text=cdbe.NAME+" ,";
            utb = cdbe;
            carid = car;

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            Token.Text = System.IO.Path.GetRandomFileName().Replace(".", string.Empty);
            bool p=utb.CarCartupdate(carid);
            utb.CartAdd(utb,Token.Text,carid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
