using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new ()
        {
            new ()
            {
                Id = Guid.NewGuid(),
                Name = "Product 1",
                Stock = 10,
                Price = 1000
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Name = "Product 2",
                Stock = 10,
                Price = 2000
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Name = "Product 3",
                Stock = 10,
                Price = 3000
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Name = "Product 4",
                Stock = 10,
                Price = 4000
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Name = "Product 5",
                Stock = 10,
                Price = 5000
            }
        };
    }
}
