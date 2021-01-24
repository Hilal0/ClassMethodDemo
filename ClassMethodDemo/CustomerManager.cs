using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer Added : " + customer.Name + " " + customer.Surname);
            customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.Name + " " + customer.Surname);
            customers.Remove(customer);
        }

        public void ListCustomers()
        {
            foreach (Customer customer in customers)
            {

                Console.WriteLine(customer.Name+" "+ customer.Surname);
            }
        }
    }
}