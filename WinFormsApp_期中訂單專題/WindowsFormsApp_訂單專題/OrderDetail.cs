using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_訂單專題
{
    internal class OrderDetail// 購物車類別

    {
        internal short ID;
        internal string strMain;//主餐
        internal bool mealSet;//套餐？
        internal short qtyMain;//主餐數量
        internal bool extra;//加購?
        internal string strBeverage;//飲品
        internal short qtyBeverage;//飲品數量
        internal string strSweet;//甜點
        internal short qtySweet;//甜點數量
        internal double total;//小計
        internal OrderDetail() 
        {
            ID = 0;
            strMain = "";
            mealSet = false;
            qtyMain = 0;
            extra = false;
            strBeverage = "";
            qtyBeverage = 0;
            strSweet = "";
            qtySweet = 0;
            total = 0;
        }
    }
}
