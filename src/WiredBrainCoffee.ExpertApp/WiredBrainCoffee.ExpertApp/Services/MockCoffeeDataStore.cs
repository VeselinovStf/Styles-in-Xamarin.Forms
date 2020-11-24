using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.ExpertApp.Models;

namespace WiredBrainCoffee.ExpertApp.Services
{
  public class MockCoffeeDataStore : IDataStore<Coffee>
  {
    readonly List<Coffee> _coffees;

    public MockCoffeeDataStore()
    {
      _coffees = new List<Coffee>()
      {
        new Coffee { Id = Guid.NewGuid().ToString(),
          Text = "Cappuccino", Description="Espresso with streamed milk and milk foam",
          EspressoML=40,StreamedMilkML=30,MilkFoamML=30},
        new Coffee { Id = Guid.NewGuid().ToString(),
          Text = "Doppio", Description="Double espresso",
          EspressoML=80},
        new Coffee { Id = Guid.NewGuid().ToString(),
          Text = "Espresso", Description="Pure coffee to keep you awake! :-)",
          EspressoML=40},
        new Coffee { Id = Guid.NewGuid().ToString(),
          Text = "Latte", Description="Cappuccino with more streamed milk",
          EspressoML=40,StreamedMilkML=60,MilkFoamML=30},
        new Coffee { Id = Guid.NewGuid().ToString(),
          Text = "Macchiato", Description="Espresso with milk foam",
          EspressoML=40,MilkFoamML=35},
        new Coffee { Id = Guid.NewGuid().ToString(),
          Text = "Mocha", Description="Espresso with hot chocolate and milk foam",
          EspressoML=40,MilkFoamML=30,HotChocolateML=40}
      };
    }

    public async Task<Coffee> GetItemAsync(string id)
    {
      return await Task.FromResult(_coffees.FirstOrDefault(s => s.Id == id));
    }

    public async Task<IEnumerable<Coffee>> GetItemsAsync(bool forceRefresh = false)
    {
      return await Task.FromResult(_coffees);
    }
  }
}