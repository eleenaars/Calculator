







//string probeer = "7+5+3-99-2+9+4-88+5";
//string[] cijfers = probeer.Split(['+', '-']);
//string[] operaties = probeer.Split(['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ']);


//List<string> cijfersInLijst = new List<string>();
//List<string> operatiesInLijst = new List<string>();

//foreach (string cijfer in cijfers)
//{
//    if (cijfer == "")
//    {
//        continue;
//    }
//    cijfersInLijst.Add(cijfer);
//}

//foreach (string operatie in operaties)
//{
//    if (operatie == "")
//    {
//        continue;
//    }
//    operatiesInLijst.Add(operatie);
//}


//for (int i = 0; i < cijfersInLijst.Count; i++)
//{

//    Console.WriteLine($"positie {i}: {cijfersInLijst[i]}");
//}

//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("");





//GetOperator();

//static string GetOperator()
//{
//    Console.WriteLine("");
//    Console.WriteLine("Hoe wil je berekenen?");
//    Console.WriteLine("A) Optellen");
//    Console.WriteLine("B) Aftrekken");
//    Console.WriteLine("C) Vermenigvuldigen");
//    Console.WriteLine("D) Delen");
//    Console.WriteLine("");

//    string operatie = "";
//    bool validInput = false;

//    do
//    {
//        Console.Write("Voer je keuze in: ");
//        string? input = Console.ReadLine();

//        switch (input?.ToUpper())
//        {
//            case "A":
//                Console.WriteLine("Je hebt gekozen voor optellen.");
//                operatie = "+";
//                validInput = true;
//                break;
//            case "B":
//                operatie = "-";
//                validInput = true;
//                Console.WriteLine("Je hebt gekozen voor aftrekken.");
//                break;
//            case "C":
//                operatie = "*";
//                validInput = true;
//                Console.WriteLine("Je hebt gekozen voor vermenigvuldigen.");
//                break;
//            case "D":
//                operatie = "/";
//                validInput = true;
//                Console.WriteLine("Je hebt gekozen voor delen.");
//                break;
//            case "N":
//                Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
//                Environment.Exit(0);
//                break;
//            case "":
//                Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
//                Console.WriteLine("");
//                break;
//            default:
//                Console.WriteLine($"{input} is geen geldige operator. Probeer het opnieuw.");
//                Console.WriteLine("");
//                break;
//        }
//    } while (validInput == false);
//    Console.WriteLine("");
//    return operatie;
//}






////1) kies operator
////2) waarde invoeren    
////3) ingevoerde waarde controleren
////a1) waarde toevoegen aan lijst
////b1) foutmelding
////b2) waarde opnieuw invoeren (ga naar 1)

////hoe stop je met getallen invoeren: vast aantal of een teken opgeven
////stoppen met de calculator: N









//bool validNumber = false;
////long number = 0;
//string? input = "";
//List<long> getallen = [];


//Console.WriteLine("Voer een geldig getal in: ");


//while (validNumber == false) 
//{
//    input = Console.ReadLine();
//    validNumber = ValidateInput(input);

//    if (validNumber == true)
//    {
//        getallen.Add(long.Parse(input));
//        Console.WriteLine();
//        Console.WriteLine($"Je hebt {input} ingevoerd.");
//        Console.WriteLine($"Je hebt {getallen.Count} getal(len) ingevoerd.");
//    }
//    else
//    {
//        Console.WriteLine();
//        Console.WriteLine("Voer een geldig getal in: ");
//        input = Console.ReadLine();
//    }
//} 







//static bool ValidateInput(string? input)
//{
//    bool validInput = long.TryParse(input, out long number);

//    if (validInput == true)
//    {
//        Console.WriteLine("");
//        Console.WriteLine($"{input} is een geldig getal.");
//    }
//    //else if (input?.ToUpper() == "N")
//    //{
//    //    Console.WriteLine();
//    //    Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
//    //    Environment.Exit(0);
//    //}
//    else if (input == "")
//    {
//        Console.WriteLine("");
//        Console.WriteLine("Je hebt niets ingevoerd.");
//    }
//    //else if (input == "=")
//    //{
//    //    Console.WriteLine("");
//    //    Console.WriteLine($"Je hebt een \"{input}\" ingevoerd.");
//    //}
//    else
//    {
//        Console.WriteLine("");
//        Console.WriteLine($"{input} is geen geldig getal.");
//    }

//    return validInput;
//}














//void GetBerekening(long[] getallen, string operatie)
//{
//    long resultaat = 0;
//    string berekening = "";

//    for (int i = 0; i < getallen.Length; i++)
//    {
//        berekening += getallen[i] + " ";

//        if (i != getallen.Length - 1) berekening += $"{operatie} ";

//        if (i == 0)
//        {
//            resultaat = getallen[i];
//        }
//        else if (operatie == "+")
//        {
//            resultaat += getallen[i];
//        }
//        else if (operatie == "-")
//        {
//            resultaat -= getallen[i];
//        }
//        else if (operatie == "*")
//        {
//            resultaat *= getallen[i];
//        }
//        else if (operatie == "/")
//        {
//            resultaat = resultaat / getallen[i]; //hier moet ik nog afvangen wanneer er niet kan worden gedeeld.
//        }
//    }

//    Console.WriteLine("");
//    Console.WriteLine($"Het resultaat is: {berekening} = {resultaat}");
//}








//static long GetNumber()
//{
//    long number;
//    bool validInput = false;

//    do
//    {
//        string? input = Console.ReadLine();

//        validInput = long.TryParse(input, out number);

//        if (validInput == true)
//        {
//            break;
//        }

//        else if (input == "")
//        {
//            Console.WriteLine("");
//            Console.WriteLine("Je hebt niets ingevoerd.");
//            Console.WriteLine("");
//            Console.Write("Voer een geldig getal in: ");
//        }
//        else if (input == "=")
//        {
//            Console.WriteLine("");

//        }
//        else
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"{input} is geen geldig getal.");
//            Console.WriteLine();
//            Console.Write("Voer een geldig getal in: ");
//        }

//    } while (validInput == false);

//    return number;
//}










////do
////{
////    validNumber = ValidateInput(input);

////    if (validNumber == true)
////    {
////        validNumber = long.TryParse(input, out number);
////        getallen.Add(number);
////        Console.WriteLine($"Je hebt {number} ingevoerd.");
////        Console.WriteLine($"Je hebt {getallen.Count} getallen ingevoerd.");
////    }
////    else
////    {
////        Console.WriteLine();
////        Console.Write("Voer een geldig getal in: ");
////        input = Console.ReadLine();
////    }
////} while (validNumber == false);











////do
////{
////    Console.WriteLine();
////    Console.WriteLine("Wil je een berekening doen? (J/N)");
////    string? input = Console.ReadLine();

////    switch (input?.ToUpper()) 
////    {
////        case "J":
////            long[] getallen = GetNumbers(); 
////            string operatie = GetOperator(); 
////            GetBerekening(getallen, operatie);
////            break;
////        case "N":
////            Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
////            Environment.Exit(0);
////            break;
////        case "":
////            Console.WriteLine("Je hebt niets ingevoerd. Probeer het opnieuw.");
////            Console.WriteLine("");
////            break;
////        default:
////            Console.WriteLine($"{input} is geen geldige keuze. Probeer het opnieuw.");
////            Console.WriteLine("");
////            break;
////    }
////} while (true);





















////static long GetNumber()
////{
////    long number;
////    bool validInput = false;

////    do
////    {
////        string? input = Console.ReadLine();

////        validInput = long.TryParse(input, out number);

////        if (validInput == true)
////        {
////            break;
////        }
////        else if (input?.ToUpper() == "N")
////        {
////            Console.WriteLine();
////            Console.WriteLine("Je hebt N ingevoerd. De calculator wordt afgesloten.");
////            Environment.Exit(0);
////        }
////        else if (input == "")
////        {
////            Console.WriteLine("");
////            Console.WriteLine("Je hebt niets ingevoerd.");
////            Console.WriteLine("");
////            Console.Write("Voer een geldig getal in: ");
////        }
////        else if (input == "=")
////        {
////            Console.WriteLine("");

////        }
////        else
////        {
////            Console.WriteLine("");
////            Console.WriteLine($"{input} is geen geldig getal.");
////            Console.WriteLine();
////            Console.Write("Voer een geldig getal in: ");
////        }

////    } while (validInput == false);

////    return number;
////}













////static List[long] GetNumbers()
////{
////    int i = 0;
////    int aantal = 5;

////    //long[] getallen = new long[aantal];

////    List<long> getallen = [];
////    Console.WriteLine("");

////    do
////    {
////        Console.Write($"Voer een geldig getal in of eindig de berekening met een \"=\": ");





////        getallen[i] = GetNumber();
////        i++;
////    } while (i < aantal);

////    return getallen;
////}




