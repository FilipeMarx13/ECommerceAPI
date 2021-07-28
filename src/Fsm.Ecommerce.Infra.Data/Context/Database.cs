using Fsm.Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Fsm.Ecommerce.Infra.Data.Context
{
    public class Database
    {
        private Database()
        {

        }

        private static Database _instance;
        public static List<Product> Products { get; set; } = new List<Product>();

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }

    }
}
