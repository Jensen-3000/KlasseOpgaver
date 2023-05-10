namespace KlasseOpgaver;

// Opgave 6
internal class Produkt
{
    // Opgave 7
    public decimal Price { get; set; }
    public double Kg { get; set; }
    public double Size { get; set; }

    // Opgave 8
    public Produkt(decimal price)
    {
        Price = price;
        Console.WriteLine($"Moms af {Price}kr er: {Moms(Price):N2}kr"); // N:2 sætter decimal til 2. Så 1 = 1.00
    }

    public decimal Moms(decimal price)
    {
        return (price / 100) * 20;
    }
}
