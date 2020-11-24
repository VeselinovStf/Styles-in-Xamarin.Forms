using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WiredBrainCoffee.ExpertApp.ViewModels
{
  public class AboutViewModel : BaseViewModel
  {
    public AboutViewModel()
    {
      Title = "About";
      OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.thomasclaudiushuber.com"));
    }

    public ICommand OpenWebCommand { get; }
  }
}