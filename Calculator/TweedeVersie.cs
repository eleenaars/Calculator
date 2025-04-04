//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calculator
//{
//    internal class TweedeVersie
//    {
//        Console.WriteLine("Welkom bij de calculator van Eva!");

//        long sum = 0;

//        Console.WriteLine();
//        sum += GetNumber();

//        Console.WriteLine();
//        sum += GetNumber();

//        Console.WriteLine();
//        Console.WriteLine($"De som van de getallen is: {sum}");

//        GetExtraValue();


//        static long GetNumber()
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
//                    Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
//                }
//                else if (validValue == false)
//                {
//                    Console.WriteLine($"{value} is geen geldig getal. Probeer het opnieuw.");
//                }
//                else
//                {
//                    Console.WriteLine($"Het getal is: {number}");
//                }
//            }
//            while (validValue == false);
//            return number;
//        }

//        void GetExtraValue()
//        {
//            Console.WriteLine();
//            Console.WriteLine("Wil je nog een getal erbij optellen? Voer \"J\" of \"N\" in.");

//            string? input = "";

//            while (input?.ToLower() != "n")
//            {
//                input = Console.ReadLine();

//                if (input == "")
//                {
//                    Console.WriteLine("Er is niets ingevoerd. Probeer het opnieuw.");
//                }
//                else if (input?.ToLower() == "j")
//                {
//                    sum += GetNumber();

//                    Console.WriteLine();
//                    Console.WriteLine($"De som van de getallen is: {sum}");
//                    Console.WriteLine();
//                    Console.WriteLine("Wil je nog een getal erbij optellen? Voer \"J\" of \"N\" in.");
//                }
//                else if (input?.ToLower() == "n")
//                {
//                    Console.WriteLine("Oké, dankjewel.");
//                    Console.WriteLine($"Het uiteindelijk totaal is dan: {sum}");
//                    Console.WriteLine("Tot ziens!");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine($"{input} is een ongeldige invoer.");
//                    Console.WriteLine("Wil je nog een getal erbij optellen? Voer \"J\" of \"N\" in.");
//                }
//            }
//        }
//    )
//}


