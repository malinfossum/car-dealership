namespace CarDealership;

// Uke 4 ParProg: a customer who can buy cars from the dealer
public class Customer
{
    private readonly List<Car> _ownedCars = new();

    public string Name { get; }
    public IReadOnlyList<Car> OwnedCars => _ownedCars;

    public Customer(string name)
    {
        Name = name;
    }

    // TODO: buy a car from the dealer — ask the dealer to Release it, then add the returned car to _ownedCars
    public bool Buy(Dealer dealer, string registrationNumber)
    {
        throw new NotImplementedException();
    }
}
