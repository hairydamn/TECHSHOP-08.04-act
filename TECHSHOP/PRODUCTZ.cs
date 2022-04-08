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
    public partial class PRODUCTZ : Form
    {
        public PRODUCTZ()
        {
            InitializeComponent();
            ShowProd();
            ShowInfa();
        }

        void ShowInfa()
        {
            comboBox1.Items.Clear();
            foreach (PRODUCTS prod in Program.TECHSHOPBD.PRODUCTS)
            {
                string[] item = { prod.NAMEP + " ", prod.PRICEP + "Р"};
                comboBox1.Items.Add(string.Join(" ", item));
            }
        }

        public void ShowProd()
        {
            LVPROD.Items.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();
            foreach (PRODUCTS pr in Program.TECHSHOPBD.PRODUCTS)
            {
                if (pr.GROUPPROD == "Процессоры")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    pr.NAMEP, pr.PRICEP, pr.COUNTP, pr.GRADEP.ToString(),
                    pr.GROUPPROD, pr.DESCRYPTPROD
                    });
                    item.Tag = pr;
                    LVPROD.Items.Add(item);
                }
                if (pr.GROUPPROD == "Видеокарты")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    pr.NAMEP, pr.PRICEP, pr.COUNTP, pr.GRADEP.ToString(),
                    pr.GROUPPROD, pr.DESCRYPTPROD
                    });
                    item.Tag = pr;
                    listView1.Items.Add(item);
                }
                if (pr.GROUPPROD == "Ноутбуки")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    pr.NAMEP, pr.PRICEP, pr.COUNTP, pr.GRADEP.ToString(),
                    pr.GROUPPROD, pr.DESCRYPTPROD
                    });
                    item.Tag = pr;
                    listView2.Items.Add(item);
                }
            }
            LVPROD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ORDERZ o = new ORDERZ(this.comboBox1.Text, this.textBoxCount.Text);
            o.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LVPROD.Visible = true;
            listView1.Visible = false;
            listView2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LVPROD.Visible = false;
            listView1.Visible = true;
            listView2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LVPROD.Visible = false;
            listView1.Visible = false;
            listView2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminForm am = new AdminForm();
            am.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (LVPROD.SelectedItems.Count == 1)
                {
                    PRODUCTS pr = LVPROD.SelectedItems[0].Tag as PRODUCTS;
                    Program.TECHSHOPBD.PRODUCTS.Remove(pr);
                    Program.TECHSHOPBD.SaveChanges();
                    ShowProd();
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    PRODUCTS pr = listView1.SelectedItems[0].Tag as PRODUCTS;
                    Program.TECHSHOPBD.PRODUCTS.Remove(pr);
                    Program.TECHSHOPBD.SaveChanges();
                    ShowProd();
                }
                if (listView2.SelectedItems.Count == 1)
                {
                    PRODUCTS pr = listView2.SelectedItems[0].Tag as PRODUCTS;
                    Program.TECHSHOPBD.PRODUCTS.Remove(pr);
                    Program.TECHSHOPBD.SaveChanges();
                    ShowProd();
                }
            } catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PRODUCTZ_Load(object sender, EventArgs e)
        {

        }
    }
}
