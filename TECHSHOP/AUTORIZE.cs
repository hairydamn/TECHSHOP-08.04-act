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
    public struct User
    {
        public string Login;
        public string Password;
    }
    public partial class AUTORIZE : Form
    {
        public static User autoriz = new User();
        public AUTORIZE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBLOGINA.Text == "" && TBPASSWORDA.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool k = false;
                foreach (LOGINING user in Program.TECHSHOPBD.LOGINING)
                {
                    if (TBLOGINA.Text == user.Login && TBPASSWORDA.Text == user.Password)
                    {
                        k = true;
                        autoriz.Login = user.Login;
                        autoriz.Password = user.Password;
                    }
                }
                if (!k)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBLOGINA.Text = "";
                    TBPASSWORDA.Text = "";
                }
                else
                {
                    PRODUCTZ menu = new PRODUCTZ();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void AUTORIZE_Load(object sender, EventArgs e)
        {

        }
    }

}
