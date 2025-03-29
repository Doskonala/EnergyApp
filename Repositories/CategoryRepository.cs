using EnergyApp.Models;
using Microsoft.EntityFrameworkCore;
using SolarApi.Models;
using System.Data.Entity;

namespace EnergyApp.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private SolarContext _solarContext;

    public CategoryRepository(SolarContext solarContext)
    {
        _solarContext = solarContext;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _solarContext.Categories.ToListAsync();
        //throw new NotImplementedException();
    }

    public async Task<Category> FindAsync(int id)
    {
        //throw new NotImplementedException();
        return await _solarContext.Categories.FindAsync(id);
    }

    public async Task<Category> FindByTitleAsync(string title)
    {
        //throw new NotImplementedException();
        return await _solarContext.Categories.FirstOrDefaultAsync(c => c.Title == title);
    }

    public async Task AddAsync(Category category)
    {
        await _solarContext.AddAsync(category);
        await _solarContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Category category)
    {
        var dbCategory = await _solarContext.Categories.FindAsync(category.Id);
        if (dbCategory == null)
        {
            throw new NullReferenceException();
        }

        dbCategory.Title = category.Title;

        await _solarContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        //throw new NotImplementedException();
        var category = await _solarContext.Categories.FindAsync(id);
        if (category == null)
        {
            throw new NullReferenceException();
        }

        _solarContext.Remove(category);

        await _solarContext.SaveChangesAsync();
    }
}