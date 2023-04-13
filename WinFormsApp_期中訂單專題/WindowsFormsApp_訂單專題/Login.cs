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
    public partial class Login : Form
    {
        static string psd = "dmh7u3";
        static string pwd = "ad7yk5";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("店員");
            comboBox1.Items.Add("店長");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( comboBox1.Text == "店員" && textBox1.Text == psd)
            {
                GlblData.logon = true;
                this.Close();
            }
            else if (comboBox1.Text == "店長" && textBox1.Text == pwd)
            {
                GlblData.logon = true;
                this.Close();
            }
            else
                MessageBox.Show("密碼錯誤！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



    }
}
