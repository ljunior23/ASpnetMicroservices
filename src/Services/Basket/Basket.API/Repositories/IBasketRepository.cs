using Basket.API.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);

        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);

        Task DeleteBasket(string userName);
    }
}
