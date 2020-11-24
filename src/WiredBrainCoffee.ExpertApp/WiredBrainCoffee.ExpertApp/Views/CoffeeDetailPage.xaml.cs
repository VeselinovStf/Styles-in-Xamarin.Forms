﻿using System;
using System.ComponentModel;
using WiredBrainCoffee.ExpertApp.Models;
using WiredBrainCoffee.ExpertApp.ViewModels;
using Xamarin.Forms;

namespace WiredBrainCoffee.ExpertApp.Views
{
  [DesignTimeVisible(false)]
  public partial class CoffeeDetailPage : ContentPage
  {
    private readonly CoffeeDetailViewModel _viewModel;

    public CoffeeDetailPage(CoffeeDetailViewModel viewModel)
    {
      InitializeComponent();

      BindingContext = _viewModel = viewModel;

      UpdateLabelProperties();
    }

    public CoffeeDetailPage()
    {
      InitializeComponent();

      var item = new Coffee
      {
        Text = "Item 1",
        Description = "This is an item description."
      };

      _viewModel = new CoffeeDetailViewModel(item);
      BindingContext = _viewModel;
    }


    private void Button_Clicked(object sender, System.EventArgs e)
    {
      UpdateLabelProperties();
    }

    bool _flag;

    private void UpdateLabelProperties()
    {
      if (_flag)
      {
        titleLabel.TextColor = ingredientsLabel.TextColor =
          Color.Gray;
        titleLabel.FontAttributes = ingredientsLabel.FontAttributes =
           FontAttributes.Bold | FontAttributes.Italic;
      }
      else
      {
        titleLabel.TextColor = ingredientsLabel.TextColor =
           Color.DimGray;
        titleLabel.FontAttributes = ingredientsLabel.FontAttributes =
           FontAttributes.Bold;
      }

      _flag = !_flag;
    }
  }
}