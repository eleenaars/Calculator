// See https://aka.ms/new-console-template for more information

//opdracht 2: operators zelf toevoegen
//opdracht 3: meerdere getallen tegelijk optellen (spatie of enter)
//nb. switch - case verdiepen
//nb. functie vs method verdiepen

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine();
Console.WriteLine("Welkom bij de calculator van Eva!");
Console.WriteLine("Dit is een calculator die getallen bij elkaar optelt.");
Console.WriteLine();
Console.WriteLine("Je kunt de calculator afsluiten door een \"Q\" in te voeren.");
Console.WriteLine();
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine();

long getal1 = GetNumber();
long getal2 = GetNumber();
string operatie = GetOperator();

GetCalculate(getal1, getal2, operatie);

static long GetNumber()
{
    Console.WriteLine("");
    Console.WriteLine("Voer een geldig getal in of sluit af met een Q:");
    long number;
    bool validInput = false;

    do
    {
        string? input = Console.ReadLine();

        validInput = long.TryParse(input, out number);

        if (validInput == true)
        {
            break;
        }
        else if (input?.ToUpper() == "Q")
        {
            Console.WriteLine();
            Console.WriteLine("Je hebt Q ingevoerd. De calculator wordt afgesloten.");
            Environment.Exit(0);
        }
        else if (input == "")
        {
            Console.WriteLine();
            Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{input} is geen geldig getal. Probeer het opnieuw.");
        }

    } while (validInput == false);

    return number;
}

static string GetOperator()
{
    Console.WriteLine("");
    Console.WriteLine("Hoe wil je berekenen? Voer in:");
    Console.WriteLine("A) Optellen");
    Console.WriteLine("B) Aftrekken");
    Console.WriteLine("C) Vermenigvuldigen");
    Console.WriteLine("D) Delen");
    Console.WriteLine("");

    string operatie  = "";
    bool validInput = false;

    do
    {
        string? input = Console.ReadLine();

        switch (input?.ToUpper())
        {
            case "A":
                operatie = "+";
                validInput = true;
                break;
            case "B":
                operatie = "-";
                validInput = true;
                break;
            case "C":
                operatie = "*";
                validInput = true;
                break;
            case "D":
                operatie = "/";
                validInput = true;
                break;
            case "Q":
                Console.WriteLine();
                Console.WriteLine("Je hebt Q ingevoerd. De calculator wordt afgesloten.");
                Environment.Exit(0);
                break;
            case "":
                Console.WriteLine();
                Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
                break;
            default:
                Console.WriteLine();
                Console.WriteLine($"{input} is geen geldige operator. Probeer het opnieuw.");
                break;
        }
    } while (validInput == false);

    return operatie;
}

void GetCalculate (long getal1, long getal2, string operatie)
{
    long resultaat = 0;

    if (operatie == "+")        resultaat = getal1 + getal2;
    else if (operatie == "-")   resultaat = getal1 - getal2;
    else if (operatie == "*")   resultaat = getal1 * getal2;
    else if (operatie == "/")   if (getal1 % getal2 == 0) resultaat = getal1 / getal2;
                                else Console.WriteLine("Je kunt niet delen door 0. Probeer het opnieuw.");
        

    Console.WriteLine("");
    Console.WriteLine($"{getal1} {operatie} {getal2} = {resultaat}");
}

