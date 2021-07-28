using System;

namespace Fsm.Ecommerce.Api.Models
{
    public class ProductGetDetail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
