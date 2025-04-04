Console.WriteLine("Welkom bij de calculator van Eva!");
Console.WriteLine("We gaan getallen bij elkaar optellen.");
Console.WriteLine("Voer een getal in:");

bool invoerwaarde1Gelukt = false;
        bool invoerwaarde2Gelukt = false;
        int getal1 = 0;
        int getal2 = 0;
        int invoerwaardeTotaal = 0;

do
{
    var invoerwaarde1 = Console.ReadLine();
        invoerwaarde1Gelukt = int.TryParse(invoerwaarde1, out getal1);

    if (invoerwaarde1Gelukt == true)
    {
        Console.WriteLine($"Je getal is: {invoerwaarde1}");
        continue;
    }
    else if (invoerwaarde1 == "")
    {
        Console.WriteLine("Je hebt niets ingevoerd.");
        Console.WriteLine($"Probeer het opnieuw.");
    }
    else
    {
    Console.WriteLine($"{invoerwaarde1} is een ongeldige invoer. Probeer het opnieuw.");
    }
}
while (invoerwaarde1Gelukt == false) ;

Console.WriteLine();
Console.WriteLine("Voer een getal in:");

do
{
    var invoerwaarde2 = Console.ReadLine();
    invoerwaarde2Gelukt = int.TryParse(invoerwaarde2, out getal2);

    if (invoerwaarde2Gelukt == true)
    {
        Console.WriteLine($"Je getal is: {invoerwaarde2}");
        continue;
    }
    else if (invoerwaarde2 == "")
    {
        Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
    }
    else
    {
        Console.WriteLine($"{invoerwaarde2} is een ongeldige invoer. Probeer het opnieuw.");
    }
}
while (invoerwaarde2Gelukt == false);

invoerwaardeTotaal = getal1 + getal2;
Console.WriteLine("De som van de getallen is: " + invoerwaardeTotaal);

Console.WriteLine();
Console.WriteLine("Wil je nog een getal erbij optellen? Voer \"J\" of \"N\" in.");

string? input;

do
{
    input = Console.ReadLine();

    if ((input == "J") || (input == "j"))
    {
        Console.WriteLine("We komen nu in een loop, dus ik laat het even hierbij :-)");
    }
    else if ((input == "N") || (input == "n"))
    {
        Console.WriteLine("Oké, dankjewel en tot ziens!");
    }
    else if (input == "")
    {
        Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
    }
    else
    {
        Console.WriteLine($"{input} is een ongeldige invoer. Probeer het opnieuw.");
    }
}
while ((input != "J") && (input != "j") && (input != "N") && (input != "n"));
