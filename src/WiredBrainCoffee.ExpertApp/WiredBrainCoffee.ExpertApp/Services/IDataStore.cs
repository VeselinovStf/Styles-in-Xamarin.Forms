﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace WiredBrainCoffee.ExpertApp.Services
{
  public interface IDataStore<T>
  {
    Task<T> GetItemAsync(string id);
    Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
  }
}
