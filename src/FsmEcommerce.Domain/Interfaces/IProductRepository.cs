using Fsm.Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fsm.Ecommerce.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> Get(Guid id);
        Task<List<Product>> Get();
        Task Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
