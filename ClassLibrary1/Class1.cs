using System.Data;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace ClassLibraryPP1
{
    public class programMethods
    {
        public static bool oddTester()
        {
            int input;
            const string ask = "Inserta un nombre per comprobar si es senar";

            Console.WriteLine(ask);
            input = Convert.ToInt32(Console.ReadLine());
            if (input%2 == 0)
            {
                Console.WriteLine("No es un nombre senar");
                return false;
            }
            Console.WriteLine("Es un nombre senar");
            return true;
        }
        
        public static void powMaker()
        {
            int basse;
            int exponent;
            int result = 1;
            const string baseAsk = "Introdueix la base";
            const string expAsk = "Introdueix l'exponent";

            Console.WriteLine(baseAsk);
            basse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(expAsk);
            exponent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < exponent; i++) 
            {
                result = result * basse;
            }
            Console.WriteLine($"El resultat de la potencia es {result}");
        }

        public static int randomGenerator()
        {
            Random RNG = new Random();
            return RNG.Next();
        }

        public static void vowelConsonantCounter()
        {
            Console.WriteLine("Introdueix un text");
            int consonantCount = 0;
            int vowelCount = 0;
            string stringInput = " ";
            stringInput = Console.ReadLine();
            stringInput = stringInput.ToLower();

            foreach (char letter in stringInput)
            {
                char actualLetter = letter;
                if (actualLetter != ' ')
                {
                    if (actualLetter == 'a' || actualLetter == 'e' || actualLetter == 'i' || actualLetter == 'o' || actualLetter == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine($"Vocals: {vowelCount}. Consonants: {consonantCount}");
        }
    }
}