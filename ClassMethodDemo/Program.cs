using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Hilal";
            customer1.Surname = "Abadanoğlu";
            customer1.TC = "1234567890";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Toprak";
            customer2.Surname = "Kara";
            customer2.TC = "9876543210";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Emrah";
            customer3.Surname = "Koç";
            customer3.TC = "1234598760";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Ali";
            customer4.Surname = "Yılmaz";
            customer4.TC = "98765123400";

            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.Name = "Engin";
            customer5.Surname = "Yücel";
            customer5.TC = "1236547890";

            Customer customer6 = new Customer();
            customer6.Id = 6;
            customer6.Name = "Ayşe";
            customer6.Surname = "Güler";
            customer6.TC = "6547893201";

            Customer[] csm = new Customer[] {customer1,customer2,customer3 };

            customerManager.AddCustomer(customer4);
            customerManager.AddCustomer(customer5);
            customerManager.AddCustomer(customer6);
            customerManager.ListCustomers();
            customerManager.DeleteCustomer(customer1);
            customerManager.DeleteCustomer(customer5);
            customerManager.ListCustomers();

            
        }
    }
}
