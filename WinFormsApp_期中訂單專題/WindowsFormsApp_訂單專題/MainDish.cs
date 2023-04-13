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
    public partial class MainDish : Form
    {
        SqlConnectionStringBuilder scsb;
        OrderDetail od;
        string imagedir ;//圖片檔案位址
        string imgname;
        public MainDish()
        {
            InitializeComponent();
        }

        internal void MainDish_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ".";
            scsb.InitialCatalog = "mid_proj";
            scsb.IntegratedSecurity = true;

            // 找出圖檔位址
            imagedir = Application.ExecutablePath;
            for (short i = 0; i < 5; i++)
                imagedir = System.IO.Directory.GetParent(imagedir).ToString() ;
            imagedir += @"\IMGsource\";
            Console.WriteLine(imagedir);

            LoadMain();
            LoadSide();
        }

        private void listBox_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選擇主食，顯示圖片，並啟用radioButton
            if (listBox_Main.SelectedIndex> -1)
            {
                imgname = GetImg( listBox_Main.SelectedItem.ToString() );
            }
            
            try
            {
                picBox_main.Image = Image.FromFile(imagedir + imgname);
            }
            catch ( Exception ex) 
            { 
                picBox_main.Image = null;
            }

            lbl_price.Text = GetMainPrice(listBox_Main.SelectedItem.ToString()).ToString();
            if ( radioBtn_set.Checked )
            {
                lbl_price.Text = (Convert.ToInt16(lbl_price.Text) +100).ToString();
            }

            groupBox1.Enabled = true;
        }

        private void listBox_Side_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選擇甜點飲料，顯示圖片，並檢查選取情況
            if (listBox_Side.SelectedIndex> -1)
            {
                imgname = GetImg( listBox_Side.SelectedItem.ToString() );
            }
            
            try
            {
                picBox_main.Image = Image.FromFile(imagedir + imgname);
            }
            catch ( Exception ex)
            {
                picBox_main.Image = null;
            }

            if ( listBox_Side.SelectedItems.Count == 2 &&( GetType(listBox_Side.SelectedItems[0].ToString()) == GetType(listBox_Side.SelectedItems[1].ToString() ) ))
            {
                MessageBox.Show("同種類不可複選");
                listBox_Side.SetSelected(listBox_Side.SelectedIndex, false);
            }
            if ( listBox_Side.SelectedItems.Count >2 )
            {
                MessageBox.Show("不可選擇超過2項");
                listBox_Side.SetSelected( listBox_Side.SelectedIndex , false);
            }
        }

        private void radioBtn_neither_CheckedChanged(object sender, EventArgs e)
        {
            //去除飲料甜點資料
            listBox_Side.SelectedIndex = -1;
            listBox_Side.Enabled = false;
            lbl_price.Text = GetMainPrice( listBox_Main.SelectedItem.ToString() ).ToString();
        }

        private void radioBtn_set_CheckedChanged(object sender, EventArgs e)
        {
            //啟用飲料甜點list
            listBox_Side.Enabled= true;
            listBox_Side.SelectionMode = SelectionMode.MultiSimple;
            lbl_price.Text = ( GetMainPrice( listBox_Main.SelectedItem.ToString() ) + 100 ).ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //將所選加入至訂單 並返回訂單
            //主食只能一項
            if ( radioBtn_neither.Checked || listBox_Side.SelectedItems.Count ==2)
            {
                od = new OrderDetail();
                od.ID = GlblData.orderCount;
                od.strMain = listBox_Main.SelectedItem.ToString();
                od.qtyMain = 1;
                od.mealSet = radioBtn_set.Checked;
                if (od.mealSet)
                {
                    foreach (object i in listBox_Side.SelectedItems)
                    {
                        if ( GetType(i.ToString()) == "beverage" )
                        {
                            od.strBeverage= i.ToString();
                            od.qtyBeverage = 1;
                        }
                        if ( GetType(i.ToString()) =="sweet" )
                        {
                            od.strSweet= i.ToString();
                            od.qtySweet = 1;
                        }
                    }
                }
                od.total = Convert.ToInt16( lbl_price.Text ) ;

                GlblData.ordersList.Add( od );
                GlblData.orderCount++;

                this.Close();

            }
            else
                MessageBox.Show("套餐請選一樣飲品及一樣甜點");
            
        }

        //============自訂函式==============

        void LoadMain()//讀入主食資料
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_Name  FROM Product WHERE P_type = @s  ";
            SqlCommand cmd= new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s" , "main");
            SqlDataReader rd = cmd.ExecuteReader();

            while ( rd.Read())
            {
                listBox_Main.Items.Add(rd["P_Name"].ToString());
            }
            rd.Close();
            conn.Close();
        }
        int GetMainPrice(string s)//回傳主食單價
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
        void LoadSide()//讀入甜點飲料資料
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_Name  FROM Product WHERE P_type = @s OR P_type = @t ";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s", "beverage");
            cmd.Parameters.AddWithValue("@t" ,"sweet");
            SqlDataReader rd = cmd.ExecuteReader();

            while ( rd.Read())
            {
                listBox_Side.Items.Add(rd["P_Name"].ToString());
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

        string GetType(string s)//取得商品類型
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string strSQL = "SELECT P_type  FROM Product WHERE P_Name = @s  ";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@s", s);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
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
