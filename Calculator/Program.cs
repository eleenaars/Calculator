// See https://aka.ms/new-console-template for more information

//opdracht 1: getallen optellen
//opdracht 2: operators zelf toevoegen
//opdracht 3: meerdere getallen tegelijk optellen (spatie of enter)
//nb. switch - case verdiepen


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine();
Console.WriteLine("Welkom bij de calculator van Eva!");
Console.WriteLine("Dit is een calculator die getallen bij elkaar optelt.");
Console.WriteLine();
Console.WriteLine("Een geldig getal is een getal van -1.000.000 tot en met 1.000.000.");
Console.WriteLine("Je kunt de calculator afsluiten door een \"X\" in te voeren.");
Console.WriteLine();
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine();

int totaal = GetSum();

Console.WriteLine();
Console.WriteLine("Oké, dankjewel.");
Console.WriteLine($"Het eindtotaal is: {totaal}");
Console.WriteLine("Tot ziens!");



static int GetSum()
{
    string? input;
    int sum = 0;

    do
    {
        Console.WriteLine("Voer een geldig getal in of sluit af met een \"X\".");
        input = Console.ReadLine();
        bool validInput = int.TryParse(input, out int number);

        switch (validInput)
        {
            case false when input == "":
                Console.WriteLine();
                Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
                break;

            case false when input?.ToLower() == "x":
                break;

            case true when number > 1000000:
                Console.WriteLine();
                Console.WriteLine($"Het getal {number} is een te hoog getal. Probeer het opnieuw.");
                break;

            case true when number < -1000000:
                Console.WriteLine();
                Console.WriteLine($"Het getal {number} is een te laag getal. Probeer het opnieuw.");
                break;

            case true:
                Console.WriteLine();
                Console.WriteLine($"Het getal is: {number}");

                sum += number;
                Console.WriteLine($"Het totaal is op dit moment: {sum}");
                Console.WriteLine();
                Console.Write("Wil je er een getal bij optellen? ");
                break;

            default:
                Console.WriteLine();
                Console.WriteLine($"{input} is geen geldig getal. Probeer het opnieuw.");
                break;
        }
    }
    while (input?.ToLower() != "x");

    return sum;
}