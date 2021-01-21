using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(" Eklenen Müşteri : "+ " ID : " +customer.Id+ " -İsmi : " +customer.CustomerName+ " -Soyismi : " +customer.CustomerSurname);
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Silinen Müşteri : " + " ID : " + customer.Id + " -İsmi : " + customer.CustomerName + " -Soyismi : " + customer.CustomerSurname);
        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Müşteri Listesi : " + Environment.NewLine + " Id : " + customer.Id+" - İsmi : "+customer.CustomerName+ " -Soyismi : " + customer.CustomerSurname);
        }
    }
}
