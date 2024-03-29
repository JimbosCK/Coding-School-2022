﻿using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories {
    public class ProductCategoryRepo : IEntityRepo<ProductCategory> {
        public async Task Create(ProductCategory entity) {
            using var context = new ApplicationContext();
            context.ProductCategories.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            using var context = new ApplicationContext();
            var foundProdCat = context.ProductCategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (foundProdCat is null)
                return;

            context.ProductCategories.Remove(foundProdCat);
            await context.SaveChangesAsync();
        }

        public List<ProductCategory> GetAll() {
            using var context = new ApplicationContext();
            return context.ProductCategories.ToList();
        }

        public ProductCategory? GetById(Guid id) {
            using var context = new ApplicationContext();
            return context.ProductCategories.Where(prodCat => prodCat.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, ProductCategory entity) {
            using var context = new ApplicationContext();
            var foundProductCat = context.ProductCategories.SingleOrDefault(prodCat => prodCat.ID == id);
            if (foundProductCat is null)
                return;

            foundProductCat.Code = entity.Code;
            foundProductCat.Description = entity.Description;
            foundProductCat.ProductType = entity.ProductType;

            await context.SaveChangesAsync();
        }
    }
}
