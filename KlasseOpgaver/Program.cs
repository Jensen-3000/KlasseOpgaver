using KlasseOpgaver;


// Opgave 3
Person person1 = new Person() { Fornavn = "Abraham", Efternavn = "Lincoln" };
Person person2 = new Person() { Fornavn = "Gilbert", Efternavn = "Skysovs" };
Person person3 = new Person() { Fornavn = "Flomme" };
Person person4 = new Person() { Fornavn = "Blomme" };
Person person5 = new Person() { Fornavn = "Alexandre" };

// Opgave 4
person1.Adresse = "Vej 1";
person1.Tlfnr = 11;

person2.Adresse = "Vej 2";
person2.Tlfnr = 22;

person3.Efternavn = "Fræk";
person3.Adresse = "Vej 3";
person3.Tlfnr = 33;

person4.Efternavn = "Super";
person4.Adresse = "Vej 4";
person4.Tlfnr = 44;

person5.Efternavn = "Great";
person5.Adresse = "Vej 5";
person5.Tlfnr = 55;


// Opgave 8 - Se constructor i Produkt.cs
Console.WriteLine("Opgave 8");

Produkt produkt = new Produkt(100);
new Produkt(150);
new Produkt(10.95M);
new Produkt(75);

Console.WriteLine(new string('=', 30));
Console.WriteLine();



// Opgave 9
Person john = new Person();

void OpretPerson()
{
    john.Fornavn = "John";
    john.Efternavn = "Johnson";
    john.Adresse = "Rolighedsvej";
    john.Tlfnr = 12345678;
}

void UdskrivPerson()
{
    Console.WriteLine($"\nFornavn: {john.Fornavn} \nEfternavn: {john.Efternavn} \nAdresse: {john.Adresse} \nTlfnr: {john.Tlfnr} ");
}


OpretPerson();

UdskrivPerson();

Console.ReadLine();



// Opgave 12
