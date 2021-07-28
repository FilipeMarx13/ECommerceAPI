using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fsm.Ecommerce.Api.Models
{
    public class ProductGet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
