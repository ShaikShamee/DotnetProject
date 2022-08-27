using DefaultPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customers: Default,ICustomer
    {
        public int CustId;
        public string Name;
        public int CustAge;
        public string Email;
        public long PhoneNo;

        public void ShowCustomer()
        {
            Console.WriteLine("CustId:"+CustId+"\n"+ "CustName:" + Name + "\n"+ "CustAge:" + CustAge + "\n"+ "Email:" + Email + "\n"+ "PhoneNo:" + PhoneNo);
        }

        void ICustomer.GetCustomer()
        {
            Console.WriteLine("ID :"+CustId+"\n"+"Name :"+Name);
        }
    }
}
