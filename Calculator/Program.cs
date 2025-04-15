// See https://aka.ms/new-console-template for more information

//opdracht 3: meerdere getallen tegelijk optellen (spatie of enter)
//nb. switch - case verdiepen
//nb. functie vs method verdiepen
//delen goed afhandelen

do
{
    Console.WriteLine();
    Console.WriteLine("Wil je een berekening doen? (J/N)");
    string? input = Console.ReadLine();

    switch (input?.ToUpper()) 
    {
        case "J":
            long[] getallen = GetNumbers(); 
            string operatie = GetOperator(); 
            GetBerekening(getallen, operatie);
            break;
        case "N":
            Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
            Environment.Exit(0);
            break;
        case "":
            Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine($"{input} is geen geldige keuze. Probeer het opnieuw.");
            Console.WriteLine("");
            break;
    }
} while (true);



void GetBerekening(long[] getallen, string operatie)
{
    long resultaat = 0;
    string berekening = "";

    for (int i = 0; i < getallen.Length; i++)
    {
        berekening += getallen[i] + " ";
        
        if (i != getallen.Length - 1) berekening += $"{operatie} ";

        if (i == 0)
        {
            resultaat = getallen[i];
        }
        else if(operatie == "+")
        {
            resultaat += getallen[i];
        }
        else if (operatie == "-")
        {
            resultaat -= getallen[i];
        }
        else if (operatie == "*")
        {
            resultaat *= getallen[i];
        }
        else if (operatie == "/")
        {
            resultaat = resultaat / getallen[i]; //hier moet ik nog afvangen wanneer er niet kan worden gedeeld.
        }
    }

    Console.WriteLine("");
    Console.WriteLine($"Het resultaat is: {berekening} = {resultaat}");
}

static long GetNumber()
{
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
        else if (input?.ToUpper() == "N")
        {
            Console.WriteLine();
            Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
            Environment.Exit(0);
        }
        else if (input == "")
        {
            Console.WriteLine("");
            Console.WriteLine("Je hebt niets ingevoerd.");
            Console.WriteLine("");
            Console.Write("Voer een geldig getal in: ");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"{input} is geen geldig getal.");
            Console.WriteLine();
            Console.Write("Voer een geldig getal in: ");
        }

    } while (validInput == false);

    return number;
}

static long[] GetNumbers()
{
    int i = 0;
    int aantal = 5;

    long[] getallen = new long[aantal];

    Console.WriteLine("");
    
    do
    {
        Console.Write("Voer een geldig getal in: ");
        getallen[i] = GetNumber();
        i++;
    } while (i < aantal);
    return getallen;
}


static string GetOperator()
{
    Console.WriteLine("");
    Console.WriteLine("Hoe wil je berekenen?");
    Console.WriteLine("A) Optellen");
    Console.WriteLine("B) Aftrekken");
    Console.WriteLine("C) Vermenigvuldigen");
    Console.WriteLine("D) Delen");
    Console.WriteLine("");
    
    string operatie  = "";
    bool validInput = false;

    do
    {
        Console.Write("Voer je keuze in: ");
        string? input = Console.ReadLine();
        
        switch (input?.ToUpper())
        {
            case "A":
                Console.WriteLine("Je hebt gekozen voor optellen.");
                operatie = "+";
                validInput = true;
                break;
            case "B":
                operatie = "-";
                validInput = true;
                Console.WriteLine("Je hebt gekozen voor aftrekken.");
                break;
            case "C":
                operatie = "*";
                validInput = true;
                Console.WriteLine("Je hebt gekozen voor vermenigvuldigen.");
                break;
            case "D":
                operatie = "/";
                validInput = true;
                Console.WriteLine("Je hebt gekozen voor delen.");
                break;
            case "N":
                Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
                Environment.Exit(0);
                break;
            case "":
                Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
                Console.WriteLine("");
                break;
            default:
                Console.WriteLine($"{input} is geen geldige operator. Probeer het opnieuw.");
                Console.WriteLine("");
                break;
        }
    } while (validInput == false);

    return operatie;
}


