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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REGA reg = new REGA();
            reg.Fname = TBFNAMER.Text;
            reg.Lname = TBLNAMER.Text;
            reg.Login = TBLOGINR.Text;
            reg.Password = TBPASSWORDR.Text;
            LOGINING aut = new LOGINING();
            aut.Login = TBLOGINR.Text;
            aut.Password = TBPASSWORDR.Text;
            Program.TECHSHOPBD.REGA.Add(reg);
            Program.TECHSHOPBD.LOGINING.Add(aut);
            Program.TECHSHOPBD.SaveChanges();
            PRODUCTZ sh = new PRODUCTZ();
            sh.Show();
        }

        private void BLOGINR_Click(object sender, EventArgs e)
        {
            AUTORIZE so = new AUTORIZE();
            so.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
