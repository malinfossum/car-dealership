namespace CarDealership;
public class Customer
{
    private readonly List<Car> _ownedCars = new();

    public string Name { get; }
    public IReadOnlyList<Car> OwnedCars => _ownedCars;

    public Customer(string name)
    {
        Name = name;
    }

    public bool Buy(Dealer dealer, string registrationNumber)
    {
        Car? car = dealer.Release(registrationNumber);
        if (car == null)
        {
            return false;
        }

        _ownedCars.Add(car);
        return true;
    }
}
