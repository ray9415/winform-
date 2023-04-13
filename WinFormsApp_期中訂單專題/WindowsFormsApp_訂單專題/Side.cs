using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_訂單專題
{
    public partial class Side : Form
    {
        SqlConnectionStringBuilder scsb;
        OrderDetail order;
        string imgname;
        string imgdir ;//圖片檔案位址

        public Side()
        {
            InitializeComponent();
        }

        private void Side_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ".";
            scsb.InitialCatalog = "mid_proj";
            scsb.IntegratedSecurity = true;

            imgdir = Application.ExecutablePath;
            for( short i = 0; i <5; i++)
                imgdir = System.IO.Directory.GetParent(imgdir).ToString();
            imgdir += @"\IMGsource\";

            //只讀取甜點及飲料
            LoadSide();

            for ( int i = 1; i< 20; i++ )
                cbox_amount.Items.Add( i );

            cbox_amount.Text = "1";
        }

        private void btn_addToOrder_Click(object sender, EventArgs e)
        {
            if ( cbox_amount.Text !="" && listBox_Side.SelectedIndex> -1)
            {
                order = new OrderDetail();
                order.ID = GlblData.orderCount;
                order.extra = true;
                if ( GetType( listBox_Side.SelectedItem.ToString() ) == "beverage")
                {
                    order.strBeverage = listBox_Side.SelectedItem.ToString();
                    order.qtyBeverage = Convert.ToInt16( cbox_amount.Text);
                }
                if (GetType(listBox_Side.SelectedItem.ToString()) == "sweet")
                {
                    order.strSweet = listBox_Side.SelectedItem.ToString();
                    order.qtySweet = Convert.ToInt16( cbox_amount.Text);
                }
                order.total = Convert.ToInt16( lbl_price.Text);

                GlblData.ordersList.Add( order);
                GlblData.orderCount++;

                this.Close();

            }
            else
                MessageBox.Show("請選數量");
            

        }

        private void listBox_Side_SelectedIndexChanged(object sender, EventArgs e)
        {
            //顯示單價及圖片
            cbox_amount.Enabled = true;

            if ( listBox_Side.SelectedIndex > -1)
            {
                imgname = GetImg(listBox_Side.SelectedItem.ToString() );
            }

            try
            {
                picBox.Image = Image.FromFile(imgdir + imgname);
            }
            catch (Exception ex)
            {
                picBox.Image = null;
            }

            lbl_price.Text = GetPrice( listBox_Side.SelectedItem.ToString() ).ToString() ;
            if ( cbox_amount.Text !="")
            {
                lbl_price.Text = (Convert.ToInt16(lbl_price.Text) * Convert.ToInt16(cbox_amount.Text) ).ToString() ;   
            }
        }
        private void cbox_amount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( listBox_Side.SelectedIndex > -1 && cbox_amount.Text!="" )
            {
                lbl_price.Text = (GetPrice( listBox_Side.SelectedItem.ToString() ) * Convert.ToInt16(cbox_amount.Text)).ToString();
            }
        }

        //=============自訂函式=============

        void LoadSide()//讀入甜點飲料資料
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_Name  FROM Product WHERE P_type = @s OR P_type = @t ";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s", "beverage");
            cmd.Parameters.AddWithValue("@t", "sweet");
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                listBox_Side.Items.Add(rd["P_Name"].ToString());
            }
            rd.Close();
            conn.Close();
        }
        int GetPrice(string s)//回傳單價
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_price  FROM Product WHERE P_Name = @s  ";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s", s);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                return (int)rd["P_price"];
            }
            else
            {
                return 0;
            }
            rd.Close();
            conn.Close();
        }
        string GetImg(string s)//取得商品圖片檔名
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_image  FROM Product WHERE P_Name = @s  ";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s", s);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                return rd["P_image"].ToString();
            }
            else
            {
                return "";
            }
            rd.Close();
            conn.Close();
        }

        string GetType(string s)
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_type  FROM Product WHERE P_Name = @s  ";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s", s);
            SqlDataReader rd = cmd.ExecuteReader();

            if ( rd.Read())
            {
                return rd["P_type"].ToString();
            }
            else
            {
                return "";
            }

        }

    }
}
