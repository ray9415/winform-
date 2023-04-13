using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_訂單專題
{
    public class GlblData
    {
        internal static short orderCount = 1;
        internal static List<OrderDetail> ordersList = new List<OrderDetail>();
        internal static string Tbl = "";
        internal static bool logon = false;
    }
}
