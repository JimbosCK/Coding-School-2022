using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories {
    public class ProductRepo : IEntityRepo<Product> {
        //private List<Product> _products = new List<Product>() { new Product() { Cost = 5m, Description = "Kafes?", Price = 10m }, 
        //    new Product() { Cost = 3m, Description = "krouasan?", Price = 6m } };
        public async Task Create(Product entity) {
            using var context = new ApplicationContext();
            context.Products.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            using var context = new ApplicationContext();
            var foundTodo = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundTodo is null)
                return;

            context.Products.Remove(foundTodo);
            await context.SaveChangesAsync();
        }

        public List<Product> GetAll() {
            using var context = new ApplicationContext();
            return context.Products.ToList();
            //return _products;
        }

        public Product? GetById(Guid id) {
            using var context = new ApplicationContext();
            return context.Products.Where(prod => prod.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Product entity) {
            using var context = new ApplicationContext();
            var foundProduct = context.Products.SingleOrDefault(prod => prod.ID == id);
            if (foundProduct is null)
                return;

            foundProduct.Cost = entity.Cost;
            foundProduct.Code = entity.Code;
            foundProduct.Price = entity.Price;
            foundProduct.Description = entity.Description;
            foundProduct.ProductCategory = entity.ProductCategory;

            await context.SaveChangesAsync();
        }
    }
}
