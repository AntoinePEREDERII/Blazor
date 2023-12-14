using System;
using TP1.Components;
using TP1.Models;

namespace TP1.Services
{
    public interface IDataService
    {
        Task Add(ItemModel model);

        Task<int> Count();

        Task<List<Item>> List(int currentPage, int pageSize);

        Task<Item> GetById(int id);

        Task Update(int id, ItemModel model);

        Task Delete(int id);

        Task<List<CraftingRecipe>> GetRecipes();
    }
}