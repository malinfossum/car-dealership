namespace CarDealership;
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
                    foreach (var car in _dealer.Inventory)
                    {
                        car.PrintInfo();
                    }
                    break;

                case "2":
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
                    Console.Write("Mileage threshold (km): ");
                    int.TryParse(Console.ReadLine(), out int threshold);

                    Console.Write("Above threshold? (y/n): ");
                    string answer = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
                    bool greaterThan = answer == "y";

                    var mileageMatches = _dealer.FindByMileage(threshold, greaterThan);
                    foreach (var car in mileageMatches)
                    {
                        car.PrintInfo();
                    }
                    break;

                case "4":
                    Console.Write("Registration number: ");
                    string regNr = Console.ReadLine()?.Trim() ?? "";

                    bool shop = _customer.Buy(_dealer, regNr);
                    if (shop)
                    {
                        Console.WriteLine($"Bought car {regNr}.");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, {regNr} is not available.");
                    }
                    break;

                case "5":
                    if (_customer.OwnedCars.Count == 0)
                    {
                        Console.WriteLine("You don't own any cars yet.");
                        break;
                    }

                    foreach (var car in _customer.OwnedCars)
                    {
                        car.PrintInfo();
                    }
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
