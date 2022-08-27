using DefaultPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Products:Default,IProduct
    {
        public int ProductId;
        public string ProductName;
        public int ProductPrice;
        public string Quality;


        public void ShowProducts()
        {
            Console.WriteLine("ProductId :"+ProductId+"\n"+"Name:"+ProductName+"\n"+"Price:"+ProductPrice+"\n"+"Quality:"+Quality);
        }

        void IProduct.GetProductPrice()
        {
            Console.WriteLine("Amount:"+ ProductPrice);
        }

        
    }
}
