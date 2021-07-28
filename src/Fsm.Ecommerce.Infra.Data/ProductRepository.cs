using Fsm.Ecommerce.Domain.Entities;
using Fsm.Ecommerce.Domain.Interfaces;
using Fsm.Ecommerce.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fsm.Ecommerce.Infra.Data
{
    public class ProductRepository : IProductRepository
    {
        public Task Create(Product entity)
        {
            Database.Products.Add(entity);

            return Task.CompletedTask;
        }

        public Task Update(Product entity)
        {
            var product = Database.Products.FirstOrDefault(x => x.Id == entity.Id);

            product.Name = entity.Name;
            product.Description = entity.Description;
            product.UpdateAt = DateTime.Now;

            return Task.CompletedTask;
        }
        public Task Delete(Product entity)
        {
            var product = Database.Products.FirstOrDefault(x => x.Id == entity.Id);

            Database.Products.Remove(product);

            return Task.CompletedTask;
        }

        public Task<Product> Get(Guid id)
        {
            return Task.FromResult(Database.Products.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Product>> Get()
        {
            return Task.FromResult(Database.Products);
        }
    }
}
