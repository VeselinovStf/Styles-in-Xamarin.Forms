using System;
using System.ComponentModel;
using WiredBrainCoffee.ExpertApp.Models;
using WiredBrainCoffee.ExpertApp.ViewModels;
using Xamarin.Forms;

namespace WiredBrainCoffee.ExpertApp.Views
{
  [DesignTimeVisible(false)]
  public partial class CoffeesPage : ContentPage
  {
    private readonly CoffeesViewModel _viewModel;

    public CoffeesPage()
    {
      InitializeComponent();

      BindingContext = _viewModel = new CoffeesViewModel();
    }

    private async void OnItemSelected(object sender, EventArgs args)
    {
      var layout = (BindableObject)sender;
      var item = (Coffee)layout.BindingContext;
      await Navigation.PushAsync(new CoffeeDetailPage(new CoffeeDetailViewModel(item, _viewModel)));
    }

    protected override void OnAppearing()
    {
      base.OnAppearing();

      if (_viewModel.Items.Count == 0)
        _viewModel.IsBusy = true;
    }
  }
}