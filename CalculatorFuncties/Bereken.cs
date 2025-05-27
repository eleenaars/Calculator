using System.IO;
using static System.Net.Mime.MediaTypeNames;


namespace CalculatorFuncties
{
    public class Bereken
    {

        //invoer valideren
        //input splitsen in getallen en operaties
        //berekenen van het resultaat



        static string GetOperator()
//{

        private static SplitsGetallenEnOperaties()
        { 
        
        
        }





        public static string BerekenResultaat(string invoer)
        {
            string melding = "";
            int resultaat;

            try
            {
                if (string.IsNullOrWhiteSpace(invoer))
                {
                    throw new InvalidDataException("De invoer mag niet leeg zijn.");
                }
                else
                {
                    string som = invoer.Replace(" ", "");

                    string[] getallenReeks = som.Split(['+', '-']);
                    string[] operatiesReeks = som.Split(['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ']);

                    List<int> getallen = [];
                    List<char> operaties = [];

                    foreach (string getal in getallenReeks)
                    {
                        if (!string.IsNullOrEmpty(getal))
                        {
                            getallen.Add(int.Parse(getal));
                        }
                    }

                    foreach (string operatie in operatiesReeks)
                    {
                        if (!string.IsNullOrEmpty(operatie))
                        {
                            operaties.Add(char.Parse(operatie));
                        }
                    }





                    resultaat = getallen[0];

                    for (int i = 0; i < operaties.Count; i++)
                    {
                        if (operaties[i] == '+')
                        {
                            resultaat += getallen[i + 1];
                        }
                        else if (operaties[i] == '-')
                        {
                            resultaat -= getallen[i + 1];
                        }
                    }

                    return (resultaat, melding).ToString();
                }
            }
            catch (InvalidDataException ex)
            {
                melding = ex.Message;
                return melding;
            }
        }
    }
}