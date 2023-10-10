namespace C_Sharp_Patterns.StructuralPatterns.Composite;

public class CompositeTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Composite pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Creates some assets
    IAsset apple = new Stock("Apple", 150);
    IAsset google = new Stock("Google", 200);
    IAsset tesla = new Stock("Tesla", 250);
    IAsset bond1 = new Bond("Bond1", 100);
    IAsset bond2 = new Bond("Bond2", 120);

    // Creates a fund that contains some stocks and bonds
    IAsset fund1 = new Fund("Fund1");
    fund1.Add(apple);
    fund1.Add(google);
    fund1.Add(bond1);

    // Creates another fund that contains some stocks and bonds
    IAsset fund2 = new Fund("Fund2");
    fund2.Add(tesla);
    fund2.Add(bond2);

    // Creates a portfolio that contains both funds
    IAsset portfolio = new Fund("Portfolio");
    portfolio.Add(fund1);
    portfolio.Add(fund2);

    // Prints the name and value of each asset in the portfolio
    Console.WriteLine($"Name: {portfolio.GetName()}, Value: {portfolio.GetValue()}");
    foreach (IAsset asset in ((Fund)portfolio).GetAssets())
    {
      Console.WriteLine($"Name: {asset.GetName()}, Value: {asset.GetValue()}");
    }

    // Removes Google stock from Fund1
    fund1.Remove(google);

    // Adds a new bond to Fund2
    IAsset bond3 = new Bond("Bond3", 140);
    fund2.Add(bond3);

    // Prints the updated value of the portfolio
    Console.WriteLine($"Name: {portfolio.GetName()}, Value: {portfolio.GetValue()}");
  }
}
