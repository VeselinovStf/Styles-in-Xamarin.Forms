using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace WiredBrainCoffee.ExpertApp.ViewModels
{
  public class ContactViewModel : BaseViewModel
  {
    public ContactViewModel()
    {
      SendCommand = new Command(async () => await SendAsync());
    }

    public ICommand SendCommand { get; }

    private async Task SendAsync()
    {
      await Application.Current.MainPage.DisplayAlert("Info",
        "Sending a message is not implemented yet!", "OK");
    }
  }
}
