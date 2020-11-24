namespace WiredBrainCoffee.ExpertApp.Models
{
  public class Coffee
  {
    public string Id { get; set; }
    public string Text { get; set; }
    public string Description { get; set; }

    // Ingredients in milliliters (ML)
    public int MilkFoamML { get; set; }
    public int StreamedMilkML { get; set; }
    public int HotChocolateML { get; set; }
    public int EspressoML { get; set; }
  }
}