using System.Collections.Generic;
using Database.Entities.Product;

namespace Repository.Product
{
    public interface IProductRepository
    {
        List<Item> GetAllItems();
        List<Item> GetItemsByCategory(string category);
    }
}