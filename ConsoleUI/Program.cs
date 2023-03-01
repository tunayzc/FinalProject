// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    class program
    {
        static void Main(String[] args) 

        { 

            ProductManager productManager= new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }

    }

}
