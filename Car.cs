namespace CarDealership;
public class Car
{
    public string Make { get; }
    public int Year { get; }
    public string RegistrationNumber { get; }
    public int Mileage { get; }

    public Car(string make, int year, string registrationNumber, int mileage)
    {
        Make = make;
        Year = year;
        RegistrationNumber = registrationNumber;
        Mileage = mileage;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Year} {Make} — reg {RegistrationNumber}, {Mileage} km");
    }
}
