using Fsm.Ecommerce.Application.Dtos;
using Fsm.Ecommerce.Domain.Entities;
using Fsm.Ecommerce.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Fsm.Ecommerce.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> CreateAsync(ProductDto dto)
        {
            var product = new Product();
            product.Name = product.Name;
            product.Description = product.Description;

            await _productRepository.Create(product);

            return product.Id;
        }
    
        public async Task UpdateAsync(ProductDto dto)
        {
            var product = await _productRepository.Get(dto.Id);

            product.Name = dto.Name;
            product.Name = dto.Description;

            await _productRepository.Update(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await _productRepository.Get(id);

            await _productRepository.Delete(product);
        }

        public async Task Get()
        {
            var products = await _productRepository.Get();
        }

        public async Task Get(Guid id)
        {
            var product = await _productRepository.Get(id);
            throw new NotImplementedException();
        }
    }
}
