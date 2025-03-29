﻿using EnergyApp.Models;

namespace EnergyApp.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> FindAsync(int id);
        Task<Category> FindByTitleAsync(string title);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}
