using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECHSHOP
{
    public partial class AdminForm : Form
    {
        public string num = null;
        public string pric = null;
        public string grad = null;
        public string group = null;
        public string count = null;
        public string desc = null;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRODUCTS pr = new PRODUCTS();
            pr.NAMEP = Convert.ToString(TBN.Text);
            pr.PRICEP = Convert.ToString(TBP.Text);
            pr.GRADEP = Convert.ToInt32(TBGG.Text);
            pr.GROUPPROD = Convert.ToString(TBG.Text);
            pr.COUNTP = Convert.ToString(TBC.Text);
            pr.DESCRYPTPROD = Convert.ToString(TBD.Text);
            Program.TECHSHOPBD.PRODUCTS.Add(pr);
            Program.TECHSHOPBD.SaveChanges();

            MessageBox.Show("Товар успешно сохранен!", "ОК!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = TBN.Text;
            pric = TBP.Text;
            grad = TBGG.Text;
            group = TBG.Text;
            count = TBC.Text;
            desc = TBD.Text;
        }
    }
}
