using Fsm.Ecommerce.Application.Dtos;
using System;
using System.Threading.Tasks;

namespace Fsm.Ecommerce.Application
{
    public interface IProductService
    {
        /// <summary>
        /// Metodo responsável pela criacao de um novo produto
        /// </summary>
        /// <param name="dto">Dto de produto</param>
        /// <returns>Identificador do produto criado</returns>
        Task<Guid> CreateAsync(ProductDto dto);
        Task UpdateAsync(ProductDto dto);
        Task DeleteAsync(Guid Id);
        Task Get();
        Task Get(Guid id);
    }
}
