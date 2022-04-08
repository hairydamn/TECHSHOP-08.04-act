using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace TECHSHOP
{
    public partial class ORDERZ : Form
    {
        public ORDERZ(string data, string text)
        {
            InitializeComponent();
            ShowList();
            this.data = data;

        }
        string data;
        void ShowList()
        {
            LVORDERZ.Items.Clear();
            foreach(PRODUCTS prod in Program.TECHSHOPBD.PRODUCTS)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    prod.NAMEP, prod.PRICEP
            });
                
                item.Tag = prod;
                LVORDERZ.Items.Add(item);
            }
            LVORDERZ.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ORDERZ_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LABELSUMMA_Click(object sender, EventArgs e)
        {

        }

        private void LVORDERZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
