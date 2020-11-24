using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using WiredBrainCoffee.ExpertApp.Models;

namespace WiredBrainCoffee.ExpertApp.ViewModels
{
  public interface ICoffeesViewModel
  {
    Coffee GetPreviousCoffee(Coffee coffee);
    Coffee GetNextCoffee(Coffee coffee);
  }

  public class CoffeesViewModel : BaseViewModel, ICoffeesViewModel
  {
    public ObservableCollection<Coffee> Items { get; set; }
    public Command LoadItemsCommand { get; set; }

    public CoffeesViewModel()
    {
      Title = "Browse our coffees";
      Items = new ObservableCollection<Coffee>();
      LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
    }

    public Coffee GetPreviousCoffee(Coffee coffee)
    {
      var previousIndex = Items.IndexOf(coffee) - 1;
      if (previousIndex < 0)
      {
        // If the start is reached, continue at the end to cycle through the coffees
        previousIndex = Items.Count - 1;
      }

      return Items[previousIndex];
    }

    public Coffee GetNextCoffee(Coffee coffee)
    {
      var nextIndex = Items.IndexOf(coffee) + 1;
      if (nextIndex > Items.Count - 1)
      {
        // If the end is reached, return the first item (index zero)
        // to allow continous cyclying through the list of coffees
        nextIndex = 0;
      }

      return Items[nextIndex];
    }

    async Task ExecuteLoadItemsCommand()
    {
      IsBusy = true;

      try
      {
        Items.Clear();
        var items = await DataStore.GetItemsAsync(true);
        foreach (var item in items)
        {
          Items.Add(item);
        }
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex);
      }
      finally
      {
        IsBusy = false;
      }
    }
  }
}