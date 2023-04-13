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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        bool is_orderSent = false;

        private void Order_Load(object sender, EventArgs e)
        {
            //桌號
            cbxTbl.Items.Add("外帶");
            for (int i = 1; i < 10; i ++ )
            {
                cbxTbl.Items.Add(i);
            }
        }

        private void btn_MainDish_Click(object sender, EventArgs e)
        {
            MainDish newMainDish = new MainDish();
            newMainDish.ShowDialog();
        }

        private void btn_side_Click(object sender, EventArgs e)
        {
            Side newSide = new Side();
            newSide.ShowDialog();
        }

        private void cbxTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_MainDish.Enabled = true;
            btn_side.Enabled = true;
            GlblData.Tbl = cbxTbl.Text;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //刪除所選item及orderslist成員
            if ( listBox1.SelectedIndex > -1)
            {
                string[] strs = listBox1.SelectedItem.ToString().Split(' ');
                for ( short i = 0; i < GlblData.ordersList.Count; i++ )
                {
                    if (GlblData.ordersList[i].ID == Convert.ToInt16( strs[0]) )
                        GlblData.ordersList.RemoveAt(i);    
                }
                loadOrdersToListbox();
                ShowTotal();
            }
        }

        private void btn_finishOrder_Click(object sender, EventArgs e)
        {
            //輸出訂單至DB
            if (cbxTbl.Text != "" && txt_tel.Text != "" && listBox1.Items.Count > 0)
            {
                if (txt_tel.Text.Trim().Length >= 6)
                {
                    SendOrders();
                    is_orderSent= true;
                    this.Close();
                }
                else
                    MessageBox.Show("電話格式錯誤!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = "" ;
                if (cbxTbl.Text == "")
                    msg += "桌號";
                if (txt_tel.Text == "")
                    msg += " 電話";
                if (listBox1.Items.Count == 0)
                    msg += " 訂單內容";

                MessageBox.Show(msg + "不可為空", "" , MessageBoxButtons.OK ,MessageBoxIcon.Information); 
            }
        }

        private void Order_Activated(object sender, EventArgs e)
        {
            loadOrdersToListbox();
            ShowTotal();
            if (listBox1.Items.Count>0)
            {
                btn_delete.Enabled = true;
                btn_finishOrder.Enabled = true;
            }
            
        }
        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_orderSent == false)
            {
                DialogResult r = MessageBox.Show("關閉會清空購物車，確定關閉？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                    e.Cancel = false;//
                else
                    e.Cancel = true;//
            }
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            //清空Orderslist
            GlblData.ordersList.Clear();
            GlblData.orderCount = 1;
        }

        //----------------自訂函式----------------
        void loadOrdersToListbox()
        {
            listBox1.Items.Clear();
            for ( int i = 0; i < GlblData.ordersList.Count; i++ )
            {
                string strItem = "";

                strItem += GlblData.ordersList[i].ID + " => ";
                if (GlblData.ordersList[i].strMain != "")
                {
                    strItem += GlblData.ordersList[i].strMain + " ";
                    strItem += GlblData.ordersList[i].qtyMain + " , ";
                }
                if (GlblData.ordersList[i].mealSet)
                {
                    strItem += "套餐 ";
                }
                if (GlblData.ordersList[i].strBeverage != "")
                {
                    strItem += GlblData.ordersList[i].strBeverage + " ";
                    strItem += GlblData.ordersList[i].qtyBeverage + " , ";
                }
                if (GlblData.ordersList[i].strSweet != "")
                {
                    strItem += GlblData.ordersList[i].strSweet + " ";
                    strItem += GlblData.ordersList[i].qtySweet + " , ";
                }

                strItem += "小計：" + GlblData.ordersList[i].total + " ";

                listBox1.Items.Add(strItem);
            }
        }

        void ShowTotal()
        {
            double tmp = 0;
            foreach( var v in GlblData.ordersList )
                tmp += v.total;
            lbl_total.Text = tmp.ToString();
        }

        string IDGen()//訂單編號產生器
        {
            Random random = new Random();
            string s = DateTime.Now.ToString("yyyyMMdd").Substring(2) + random.Next(1000,10000);

            return s;
        }
        
        
        void SendOrders()//輸出訂單至DB
        {
            SqlConnectionStringBuilder scsb= new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mid_proj";
            scsb.IntegratedSecurity = true;

            //使用LINQ
            mid_proj_DataClasses1DataContext mid_Proj_Data = new mid_proj_DataClasses1DataContext(scsb.ConnectionString);

            //step1.新增Orders資料
            Orders newOrder = new Orders();
            newOrder.O_ID = IDGen();
            newOrder.O_datetime= DateTime.Now;
            if (cbxTbl.Text == "外帶")
                newOrder.INorOUT = "外帶";
            else
                newOrder.INorOUT = "內用" + cbxTbl.Text;
            newOrder.Tel = txt_tel.Text.Trim();
            mid_Proj_Data.Orders.InsertOnSubmit(newOrder);
            mid_Proj_Data.SubmitChanges();

            //step2.新增order_detail資料
            foreach( var v in GlblData.ordersList)
            {
                order_detail od = new order_detail();
                od.O_ID = newOrder.O_ID;
                od.No = v.ID;
                od.total = Convert.ToInt32( v.total);

                if (v.strMain != "")
                {
                    od.main = v.strMain;
                    od.qty_main = 1;
                }
                od.is_mealset = v.mealSet;
                if(v.mealSet)
                {
                    od.beverage = v.strBeverage ;
                    od.qty_beverage = 1;
                    od.sweet = v.strSweet ;
                    od.qty_sweet= 1;
                }
                else
                {
                    if (v.strBeverage != "")
                    {
                        od.beverage= v.strBeverage;
                        od.qty_beverage= v.qtyBeverage;
                    }
                    if (v.strSweet != "")
                    {
                        od.sweet = v.strSweet;
                        od.qty_sweet= v.qtySweet;
                    }
                }

                mid_Proj_Data.order_detail.InsertOnSubmit(od);
                mid_Proj_Data.SubmitChanges();

            }

            MessageBox.Show("訂單新增成功\n訂單編號："+ newOrder.O_ID);

        }
    }
}
