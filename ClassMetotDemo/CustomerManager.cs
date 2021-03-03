using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine("Customer is added successfully.");
            Console.WriteLine();
        }

        public void ShowCustomers()
        {
            Console.WriteLine("Here is all customers' information: ");
            foreach (Customer customer in customerList)
            {
                Console.WriteLine("Customer ID: " + customer.CustomerID);
                Console.WriteLine("Customer Name: " + customer.CustomerName);
                Console.WriteLine("Customer Surname: " + customer.CustomerSurname);
                Console.WriteLine("Customer Age: " + customer.CustomerAge);
                Console.WriteLine();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer " + customer.CustomerName + " " + customer.CustomerSurname + " is deleted successfully.");
            customerList.Remove(customer);
            Console.WriteLine();
        }
    }
}
