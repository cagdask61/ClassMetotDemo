using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 001;
            customer1.CustomerName = "Çağdaş";
            customer1.CustomerSurname = "Kocaman";

            Customer customer2 = new Customer();
            customer2.Id = 002;
            customer2.CustomerName = "Engin";
            customer2.CustomerSurname = "Demirog";

            Customer customer3 = new Customer();
            customer3.Id = 003;
            customer3.CustomerName = "Atakan";
            customer3.CustomerSurname = "Kocaman";

            Customer customer4 = new Customer();
            customer4.Id = 003;
            customer4.CustomerName = "Saniye";
            customer4.CustomerSurname = "Kocaman";

            Customer[] customers = new Customer[]
            {
                customer1,customer2,customer3
            };


            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerList(customer1);
            customerManager.CustomerAdd(customer4);
            customerManager.CustomerDelete(customer3);

            
            Console.WriteLine(customers[3]);




            Console.ReadKey();
        }
    }

}
