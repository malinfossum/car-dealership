namespace CarDealership;

// Uke 4 ParProg: the dealership — owns the inventory, can be queried, releases cars on sale
public class Dealer
{
    private readonly List<Car> _inventory = new();

    public string Name { get; }
    public IReadOnlyList<Car> Inventory => _inventory;

    public Dealer(string name)
    {
        Name = name;
    }

    public void AddCar(Car car)
    {
        _inventory.Add(car);
    }

    // TODO: return cars built within an inclusive year range
    public List<Car> FindByYearRange(int minYear, int maxYear)
    {
        throw new NotImplementedException();
    }

    // TODO: return cars with mileage above or below the threshold (controlled by greaterThan)
    public List<Car> FindByMileage(int threshold, bool greaterThan)
    {
        throw new NotImplementedException();
    }

    // TODO: remove the car with this registration number from the inventory and return it (null if not found)
    public Car? Release(string registrationNumber)
    {
        throw new NotImplementedException();
    }
}
