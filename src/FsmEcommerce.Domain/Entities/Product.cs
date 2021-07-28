using System;

namespace Fsm.Ecommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
