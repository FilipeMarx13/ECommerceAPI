using Fsm.Ecommerce.Api.Models;
using Fsm.Ecommerce.Application;
using Fsm.Ecommerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fsm.Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductService _productService;

        public ProductsController(ILogger<ProductsController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductGet>> GetList()
        {
            return await _productService.Get();
            //return products;
        }

        [HttpGet("{id:guid}")]
        public async Task<ProductGetDetail> Get([FromRoute] Guid id)
        {
            await _productService.Get(id);
            //return product;
            return new ProductGetDetail();
        }

        [HttpPost()]
        public async Task<ProductPostResponseModel> Post([FromBody] ProductPostRequestModel model)
        {
            var dto = new ProductDto { Name = model.Name, Description = model.Description };

            var id = await _productService.CreateAsync(dto);

            return new ProductPostResponseModel { Id = id };

        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> PutAsync([FromRoute] Guid id, [FromBody] ProductPutRequestModel model)
        {
            var dto = new ProductDto { Name = model.Name, Description = model.Description };

            await _productService.UpdateAsync(dto);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            await _productService.DeleteAsync(id);
            return NoContent();
        }


    }
}
