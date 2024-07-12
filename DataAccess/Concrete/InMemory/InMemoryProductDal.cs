using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICategoryDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>(){
            new Product{
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Bardak",
                UnitPrice = 15,
                UnitsInStock = 15
            },
            new Product {
                ProductId = 2,
                CategoryId = 1,
                ProductName = "Kamera",
                UnitPrice = 500,
                UnitsInStock = 3},
            new Product {
                ProductId = 3,
                CategoryId = 2,
                ProductName = "Telefon",
                UnitPrice = 1500,
                UnitsInStock = 2},
            new Product {
                ProductId = 4,
                CategoryId = 2,
                ProductName = "Klavye",
                UnitPrice = 150,
                UnitsInStock = 65},
              new Product {
                ProductId = 5,
                CategoryId = 2,
                ProductName = "Fare",
                UnitPrice = 85,
                UnitsInStock = 1}
        };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            //Product ProductToDelete = null;

            //foreach (var p in _products)
            //{
            //    if (p.ProductId == ProductToDelete.ProductId)
            //    {
            //        ProductToDelete = p;
            //    }
            //} Bunların yerine LINQ kullandık
            Product ProductToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(ProductToDelete);
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            var CategoryList = _products.Where(p => p.CategoryId == categoryId).ToList();
            return CategoryList;
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;
            ProductToUpdate.CategoryId = product.CategoryId;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
