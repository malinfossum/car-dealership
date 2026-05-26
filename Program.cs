namespace CarDealership;

// Uke 4 ParProg: entry point — wires up dealer with seed data, customer, and the UI
public class Program
{
    public static void Main(string[] args)
    {
        var dealer = new Dealer("Hans & Malin Bilforhandel");
        dealer.AddCar(new Car("Toyota Corolla", 2018, "AB12345", 85000));
        dealer.AddCar(new Car("Volvo V60", 2021, "CD67890", 32000));
        dealer.AddCar(new Car("Tesla Model 3", 2023, "EF11122", 12000));
        dealer.AddCar(new Car("Ford Focus", 2015, "GH33445", 145000));
        dealer.AddCar(new Car("BMW 3-series", 2019, "IJ55677", 67000));
        dealer.AddCar(new Car("Skoda Octavia", 2017, "KL88990", 110000));

        var customer = new Customer("Kunde");

        new App(dealer, customer).Run();
    }
}
