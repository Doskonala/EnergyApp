using SolarApi.Models;

namespace EnergyApp.Repositories
{
    public interface IPanelRepository
    {
        Task<List<SolarPanel>> GetAllAsync();
        Task<SolarPanel> FindAsync(int id);
        Task<SolarPanel> FindByNameAsync(string name);
        Task AddAsync(SolarPanel category);
        Task UpdateAsync(SolarPanel category);
        Task DeleteAsync(int id);
    }
}
