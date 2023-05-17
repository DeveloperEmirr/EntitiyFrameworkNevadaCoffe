using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           // ProductTest();
            //ShipperManager shipperManager = new ShipperManager(new EfShipperDal());
            //foreach (var ship in shipperManager.GetAll())
            //{
            //    Console.WriteLine("{0}, {1}",ship.FirstName,ship.LastName);
            //}

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine($"{customer.ContactName} --  {customer.City}");
            }
            Console.Read();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.Getall())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
