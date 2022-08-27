using DefaultPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Orders:Default,IOrder
    {
        public int OrderId;
        public DateTime OrderDate;
        public string OrderItems;
        public string OrderLocation;

        void IOrder.GetOrders()
        {
         Console.WriteLine("Ordertotal:"+OrderItems);
        }
    
        public void ShowOrders()
        {
            Console.WriteLine("Order Id" +OrderId +"\n " + "Date:" + OrderDate + "\n " + "Items:" + OrderItems + "\n" + "orderloc:" + OrderLocation);

        }

       
    }
}
