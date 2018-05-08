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
    public partial class UpdateQuantity : Form
    {
        Code.Query_DB utb = new Code.Query_DB();

        public UpdateQuantity()
        {
            InitializeComponent();
        }

        private void UpdateQuantity_Load(object sender, EventArgs e)
        {
            utb.FillCarModel(CModel);
        }

        private void CModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CColor.Items.Clear();
            utb.FillCarQuantity(CColor, CModel.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cqi = utb.CarQuantityId(CModel.Text, CColor.Text);
            if (utb.UpdateCarQuantity(Convert.ToInt32(CQuantity.Text), cqi))
            {
                MessageBox.Show("Product Update sucessfuly");
                CQuantity.Text = "";
                CColor.Items.Clear();
            }
            else { MessageBox.Show("Product can't be Update"); }
        }

        private void CColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CQuantity.Text = utb.CarQuantityNumber(utb.CarQuantityId(CModel.Text, CColor.Text));
        }
    }
}
