using StorageAdministrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageAdministrator.Services
{
    public class ProductService
    {
        public List<Product> GetProducts() 
        {
            Product product1 = new Product {id = 1,
                name = "papa",
                price = 20, 
                amount = 5,
                description = "Verticulo, comida",
                category = new Category{ 
                    id = 1,
                    name = "Comida"
                }
            };
            Product product2 = new Product
            {
                id = 1,
                name = "pera",
                price = 10,
                amount = 10,
                description = "Fruto mediano verde, comida",
                category = new Category
                {
                    id = 1,
                    name = "Comida"
                }
            };
            return new List<Product>{ product1, product2 };
        }
    }
}
