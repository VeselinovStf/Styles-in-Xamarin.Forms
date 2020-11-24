using WiredBrainCoffee.ExpertApp.Services;
using Xamarin.Forms;

namespace WiredBrainCoffee.ExpertApp
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      DependencyService.Register<MockCoffeeDataStore>();
      MainPage = new AppShell();
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
  }
}
