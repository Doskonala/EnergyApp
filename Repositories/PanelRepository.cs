using NuGet.Protocol.Plugins;
using SolarApi.Models;

namespace EnergyApp.Repositories;

public class PanelRepository : IPanelRepository
{
    private SolarContext _solarContext;

    public PanelRepository(SolarContext solarContext)
    {
        _solarContext = solarContext;
    }
    public async Task<List<SolarPanel>> GetAllAsync()
    {
        //var panels = await _solarContext.SolarPanels
        //    .Include(panel => panel.CategoryId)
        //    .ToListAsync();

        //return panels;
        throw new NotImplementedException();
    }

    public async Task<SolarPanel> FindAsync(int id)
    {
        //var panel = await _solarContext.SolarPanels
        //    .Include(panel => panel.CategoryId)
        //    .FirstOrDefaultAsync(panel => panel.Id == id);

        //return panel;
        throw new NotImplementedException();
    }

    public async Task<SolarPanel> FindByNameAsync(string name)
    {
        //var panel = await _solarContext.SolarPanels
        //    .Include(panel => panel.CategoryId)
        //    .FirstOrDefaultAsync(panel => panel.Name == name);

        //return panel;
        throw new NotImplementedException();
    }

    public async Task AddAsync(SolarPanel panel)
    {
        await _solarContext.SolarPanels.AddAsync(panel);
        await _solarContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(SolarPanel panel)
    {
        var dbPanel = await _solarContext.SolarPanels.FindAsync(panel);
        if (dbPanel == null)
        {
            throw new NullReferenceException();
        }

        dbPanel.Name = panel.Name;
        dbPanel.IsAvailable = panel.IsAvailable;
        dbPanel.CategoryId = panel.CategoryId;

        await _solarContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var panel = await _solarContext.SolarPanels.FindAsync(id);
        if (panel == null)
        {
            throw new NullReferenceException();
        }

        _solarContext.Remove(panel);

        await _solarContext.SaveChangesAsync();
    }
}