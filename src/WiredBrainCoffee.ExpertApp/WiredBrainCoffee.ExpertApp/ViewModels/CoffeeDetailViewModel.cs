using System;
using System.Windows.Input;
using WiredBrainCoffee.ExpertApp.Models;
using Xamarin.Forms;

namespace WiredBrainCoffee.ExpertApp.ViewModels
{
  public class CoffeeDetailViewModel : BaseViewModel
  {
    private Coffee _coffee;

    public Coffee Coffee
    {
      get => _coffee;
      set => SetProperty(ref _coffee, value);
    }

    public CoffeeDetailViewModel(Coffee coffee, ICoffeesViewModel coffeesViewmodel = null)
    {
      Title = coffee?.Text;
      Coffee = coffee;
      PreviousCoffeeCommand = new Command(() => Coffee = coffeesViewmodel?.GetPreviousCoffee(Coffee));
      NextCoffeeCommand = new Command(() => Coffee = coffeesViewmodel?.GetNextCoffee(Coffee));
    }

    public ICommand NextCoffeeCommand { get; }
    public ICommand PreviousCoffeeCommand { get; }
  }
}
