using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.CustomerID = 1;
            customer1.CustomerName = "Tarık";
            customer1.CustomerSurname = "Göl";
            customer1.CustomerAge = 23;

            cm.AddCustomer(customer1);

            Customer customer2 = new Customer();
            customer2.CustomerID = 2;
            customer2.CustomerName = "Ahmet";
            customer2.CustomerSurname = "Bilgin";
            customer2.CustomerAge = 34;

            cm.AddCustomer(customer2);

            Customer customer3 = new Customer();
            customer3.CustomerID = 3;
            customer3.CustomerName = "Mehmet";
            customer3.CustomerSurname = "Bozkurt";
            customer3.CustomerAge = 29;

            cm.AddCustomer(customer3);

            cm.ShowCustomers();

            cm.DeleteCustomer(customer2);

            Console.WriteLine("After deletion:");
            cm.ShowCustomers();
        }
    }
}
