using System;

namespace Fsm.Ecommerce.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
