// See https://aka.ms/new-console-template for more information

//opdracht 1: getallen optellen
//opdracht 2: operators zelf toevoegen
//opdracht 3: meerdere getallen tegelijk optellen (spatie of enter)
//nb. switch - case verdiepen





Console.WriteLine("Welkom bij de calculator van Eva!");
Console.WriteLine();
GetNumber();

void GetNumber()
{

    int number = 0;
    int sum = 0;
    bool validInput = false;
    string? input = "";

    do
    {
        Console.WriteLine();
        Console.WriteLine("Voer een geldig getal in of sluit af met een \"X\".");
        input = Console.ReadLine();
        validInput = int.TryParse(input, out number);


        switch (validInput)
        {
            case false when input == "":
                Console.WriteLine();
                Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
                break;

            case false when input?.ToLower() == "x":
                Console.WriteLine();
                Console.WriteLine("Oké, dankjewel.");
                Console.WriteLine($"Het totaal bijft: {sum}");
                Console.WriteLine("Tot ziens!");
                break;

            case true:
                Console.WriteLine();
                Console.WriteLine($"Het getal is: {number}");

                sum += number;
                Console.WriteLine();
                Console.WriteLine($"Het totaal is op dit moment: {sum}");
                Console.WriteLine();
                Console.WriteLine("Wil je er een getal bij optellen?");
                break;

            default:
                Console.WriteLine();
                Console.WriteLine($"{input} is geen geldig getal. Probeer het opnieuw.");
                break;
        }
    }
    while (input?.ToLower() != "x");
}








