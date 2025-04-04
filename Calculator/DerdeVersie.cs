



//        // See https://aka.ms/new-console-template for more information

//        Console.WriteLine("Welkom bij de calculator van Eva!");

//long sum = 0;

//        Console.WriteLine();
//GetNumber();
//        Console.WriteLine();
//GetExtraNumber();


//        void GetNumber()
//        {

//            bool validValue = false;
//            long number = 0;

//            do
//            {
//                Console.WriteLine();
//                Console.WriteLine("Voer een geldig getal in:");
//                var value = Console.ReadLine();
//                validValue = long.TryParse(value, out number);

//                if (value == "")
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
//                }
//                else if (validValue == false)
//                {
//                    Console.WriteLine();
//                    Console.WriteLine($"{value} is geen geldig getal. Probeer het opnieuw.");
//                }
//                else
//                {
//                    Console.WriteLine();
//                    Console.WriteLine($"Het getal is: {number}");

//                    sum += number;
//                    Console.WriteLine();
//                    Console.WriteLine($"Het totaal is op dit moment: {sum}");
//                }
//            }
//            while (validValue == false);
//        }

//        void GetExtraNumber()
//        {
//            Console.WriteLine();
//            Console.WriteLine("Wil je er nog een getal bij optellen? Voer \"J\" of \"N\" in.");

//            string? input = "";

//            while (input?.ToLower() != "n")
//            {
//                {
//                    input = Console.ReadLine();

//                    if (input == "")
//                    {
//                        Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
//                    }
//                    else if (input?.ToLower() == "j")
//                    {
//                        GetNumber();

//                        Console.WriteLine();
//                        Console.WriteLine("Wil je nog een getal erbij optellen? Voer \"J\" of \"N\" in.");
//                    }
//                    else if (input?.ToLower() == "n")
//                    {
//                        Console.WriteLine("Oké, dankjewel.");
//                        Console.WriteLine($"Het totaal bijft: {sum}");
//                        Console.WriteLine("Tot ziens!");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine($"{input} is geen geldige invoer.");
//                        Console.WriteLine();
//                        Console.WriteLine("Wil je er nog een getal bij optellen? Voer \"J\" of \"N\" in.");
//                    }
//                }
//            }
//        }










