using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal

    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products= new List<Product>
            {
                new Product{ProductID=1, CategoryID=1, ProductName="Ekran Kartı", UnitPrice=10000, UnitsInStock=5},
                new Product{ProductID=2, CategoryID=1, ProductName="İşlemci", UnitPrice=2500, UnitsInStock=9},
                new Product{ProductID=3, CategoryID=2, ProductName="Mouse", UnitPrice=1000, UnitsInStock=20},
                new Product{ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=1500, UnitsInStock=12},
                new Product{ProductID=5, CategoryID=2, ProductName="Monitör", UnitPrice=4000, UnitsInStock=7},
            };
        }
        public void add(Product product)
        {
            _products.Add(product);
        }

        public void delete(Product product)
        {
            Product productToDelete= _products.SingleOrDefault(p => p.ProductID == product.ProductID);         

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryID== categoryId).ToList(); 
        }

        public void update(Product product)
        {
            Product productToUpdate= _products.SingleOrDefault(p=>p.ProductID== product.ProductID);

            productToUpdate.ProductName= product.ProductName;   
            productToUpdate.CategoryID=product.CategoryID;
            productToUpdate.UnitPrice=product.UnitPrice;    
            productToUpdate.UnitsInStock=product.UnitsInStock;

        }
    }

}
