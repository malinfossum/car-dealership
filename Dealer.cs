namespace CarDealership;
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

    public List<Car> FindByYearRange(int minYear, int maxYear)
    {
        var result = new List<Car>();
        foreach (var car in Inventory)
        {
            if (minYear <= car.Year && maxYear >= car.Year)
            {
                result.Add(car);
            }
        }

        return result;
    }

    public List<Car> FindByMileage(int threshold, bool greaterThan)
    {
        var result = new List<Car>();
        foreach (var car in Inventory)
        {
            bool mileageMatches = greaterThan
                ? car.Mileage > threshold
                : car.Mileage < threshold;

            if (mileageMatches)
            {
                result.Add(car);
            }
        }
        return result;
    }

    public Car? Release(string registrationNumber)
    {
        foreach (var car in _inventory)
        {
            if (car.RegistrationNumber == registrationNumber)
            {
                _inventory.Remove(car);
                return car;
            }
        }
        return null;
    }
}
