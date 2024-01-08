using System;
using ClassLibraryPP1;

namespace ProvaPractica
{
    class M03UF2Ex2
    {
        static void Main(string[] args)
        {
            const string mainMenu = "Selecciona una de les seguents opcions \n" +
                "a.Validar si un nombre es senar \n" +
                "b.Calcular la potencia d'un nombre \n" +
                "c.Retornar un valor aleatori\n" +
                "d.Comptar el nombre de vocals o consonants en un text\n" +
                "e.Sortir";
            const string charFail = "Carácter no valid, introdueix altre";

            string optionSelectSt;
            char optionSelect = ' ';

            while (optionSelect != 'e')
            {
                Console.WriteLine(mainMenu);
                optionSelectSt = Console.ReadLine();
                optionSelect = Convert.ToChar(optionSelectSt.ToLower());

                switch (optionSelect)
                {
                    case 'a':
                        programMethods.oddTester();
                        break;

                    case 'b':
                        programMethods.powMaker();
                        break;
                    case 'c':
                        Console.WriteLine($"Numero aleatori: {programMethods.randomGenerator()}");
                        break;
                    case 'd':
                        programMethods.vowelConsonantCounter();
                        break;
                    case 'e':
                        Console.WriteLine("Gracies per utilizar la aplicacio");
                        break;
                    default:
                        Console.WriteLine(charFail);
                        break;
                }
            }
        }          
    }
}