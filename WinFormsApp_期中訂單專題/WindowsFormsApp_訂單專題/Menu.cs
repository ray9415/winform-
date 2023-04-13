using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_訂單專題
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Order newOrder= new Order();
            newOrder.ShowDialog();
        }

        private void btn_productUpdate_Click(object sender, EventArgs e)
        {
            if ( GlblData.logon)
            {
                ProductUpdate newPU = new ProductUpdate();
                newPU.ShowDialog();
            }
            else
            {
                Login login = new Login();
                login.ShowDialog();
            }


        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            if( GlblData.logon)
                btn_logout.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            GlblData.logon = false;
            btn_logout.Visible = false;
        }

        private void btn_order_MouseEnter(object sender, EventArgs e)
        {
            btn_order.BackColor= Color.Firebrick;
            btn_order.ForeColor = Color.White;
        }

        private void btn_order_MouseLeave(object sender, EventArgs e)
        {
            btn_order.BackColor= SystemColors.Control;
            btn_order.ForeColor= SystemColors.ControlText;
        }
    }
}
