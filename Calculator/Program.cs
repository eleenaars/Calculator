// See https://aka.ms/new-console-template for more information

//opdracht 1: getallen optellen
//opdracht 2: operators zelf toevoegen
//opdracht 3: meerdere getallen tegelijk optellen (spatie of enter)
//nb. switch - case verdiepen
//nb. github uitzoeken






Console.WriteLine("Welkom bij de calculator van Eva!");
Console.WriteLine();
GetNumber();

void GetNumber() {

    long number = 0;
    long sum = 0;
    bool validInput = false;

    do
    {
        Console.WriteLine();
        Console.WriteLine($"Voer een geldig getal in of sluit af met een \"X\".");
        var input = Console.ReadLine();
        validInput = long.TryParse(input, out number);
                

            switch (validInput)
            {
                case (false) when input == "":
                    Console.WriteLine();
                    Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
                    break;

                case (false) when input?.ToLower() == "x":
                    Console.WriteLine();
                    Console.WriteLine("Oké, dankjewel.");
                    Console.WriteLine($"Het totaal bijft: {sum}");
                    Console.WriteLine("Tot ziens!");
                    break;

                case (false):
                    Console.WriteLine();
                    Console.WriteLine($"{input} is geen geldig getal. Probeer het opnieuw.");
                    break;

                case (true):
                    Console.WriteLine();
                    Console.WriteLine($"Het getal is: {number}");

                    sum += number;
                    Console.WriteLine();
                    Console.WriteLine($"Het totaal is op dit moment: {sum}");
                    Console.WriteLine();
                    Console.WriteLine("Wil je er een getal bij optellen? Voer een geldig getal in of sluit af met een \"X\".");
                    break ;                
                
                default:
                    Console.WriteLine();
                    Console.WriteLine("Test 1 2 3");
                    break;
            }
        }





        //geen geldig getal             validValue = false
        //geen waarde                   validValue = false  value = ""  
        //juiste waarde : een getal     validValue = true   string/naar int
        //x                             validValue = false  value = x



        



    while (validInput == false);
}










//        if (value == "")
//        {
//            Console.WriteLine();
//            Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
//        }
//        else if (validValue == false)
//        {
//            Console.WriteLine();
//            Console.WriteLine($"{value} is geen geldig getal. Probeer het opnieuw.");
//        }
//        else
//        {
//            Console.WriteLine();
//            Console.WriteLine($"Het getal is: {number}");

//            sum += number;
//            Console.WriteLine();
//            Console.WriteLine($"Het totaal is op dit moment: {sum}");
//        }
//    }
//    while (validValue == false);
//}

//void GetExtraNumber()
//{
//    Console.WriteLine();
//    Console.WriteLine("Wil je er een getal bij optellen? Voer een geldig getal in of sluit af met een \"X\".");

//    string? input = "";

//    while (input?.ToLower() != "x")
//    {
//        {
//            input = Console.ReadLine();

//            if (input == "")
//            {
//                Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
//            }
//            else if (input?.ToLower() == "x")
//            {
//                Console.WriteLine();
//                Console.WriteLine("Oké, dankjewel.");
//                Console.WriteLine($"Het totaal bijft: {sum}");
//                Console.WriteLine("Tot ziens!");
//                break;
//            }




//            else if (input?.ToLower() == "j")
//            {
//                GetNumber();

//                Console.WriteLine();
//                Console.WriteLine("Wil je nog een getal erbij optellen? Voer \"J\" of \"N\" in.");
//            }

//            else
//            {
//                Console.WriteLine();
//                Console.WriteLine($"{input} is geen geldige invoer.");
//                Console.WriteLine();
//                Console.WriteLine("Wil je er een getal bij optellen? Voer een geldig getal in of sluit af met een \"X\".");
//            }
//        }
//    }
//}
            