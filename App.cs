namespace CarDealership;

// Uke 4 ParProg: console UI — menu loop, dispatches to dealer/customer actions
public class App
{
    private readonly Dealer _dealer;
    private readonly Customer _customer;

    public App(Dealer dealer, Customer customer)
    {
        _dealer = dealer;
        _customer = customer;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"--- {_dealer.Name} ---");
            Console.WriteLine("1) View inventory");
            Console.WriteLine("2) Filter by year range");
            Console.WriteLine("3) Filter by mileage");
            Console.WriteLine("4) Buy a car");
            Console.WriteLine("5) View my cars");
            Console.WriteLine("Q) Quit");
            Console.Write("> ");

            string choice = Console.ReadLine()?.Trim().ToUpperInvariant() ?? "";

            switch (choice)
            {
                case "1":
                    // TODO: print every car in _dealer.Inventory
                    foreach (var car in _dealer.Inventory) { car.PrintInfo(); }
                    break;
                case "2":
                    // TODO: ask the user for min and max year, then call _dealer.FindByYearRange and print the results
                    //Console.WriteLine("Choose year min:");
                    //var input = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Choose year max:");
                    //var input2 = int.Parse(Console.ReadLine());
                    //Console.ReadLine();
                    //foreach (var car in _dealer.Inventory) { _dealer.FindByYearRange(input, input2); }
                    Console.Write("Min year: ");
                    int.TryParse(Console.ReadLine(), out int minYear);
                    Console.Write("Max year: ");
                    int.TryParse(Console.ReadLine(), out int maxYear);

                    var matches = _dealer.FindByYearRange(minYear, maxYear);
                    foreach (var car in matches)
                    {
                        car.PrintInfo();
                    }
                    break;
                case "3":
                    // TODO: ask for a mileage threshold and whether to find over/under, then call _dealer.FindByMileage
                    Console.WriteLine("(TODO: filter by mileage)");
                    break;
                case "4":
                    // TODO: ask for a registration number, call _customer.Buy(_dealer, regNr), print success or failure
                    Console.WriteLine("(TODO: buy a car)");
                    break;
                case "5":
                    // TODO: print every car in _customer.OwnedCars
                    Console.WriteLine("(TODO: view my cars)");
                    break;
                case "Q":
                    return;
                default:
                    Console.WriteLine("Unknown choice — try again.");
                    break;
            }
        }
    }
}
