using System;

namespace Calculator
{
    class Program
    {
        public static double Operation(double number1, double number2, string value)
        {
            double result = double.NaN; // definir la valeur par defaut de result qui n'est pas un nombre 

            switch (value)
            {
                case "a":
                    // Console.WriteLine($"votre resultat : {number1} + {number2} = {number1 + number2}");
                    result = number1 + number2;
                    break;
                case "s":
                    //Console.WriteLine($"votre resultat : {number1} - {number2} = {number1 - number2}");
                    result = number1 - number2;
                    break;
                case "p":
                    //Console.WriteLine($"votre resultat : {number1} * {number2} = {number1 * number2}");
                    result = number1 * number2;
                    break;
                case "d":
                    while (number2 == 0)
                    {
                        Console.WriteLine("entrer un numbre different de zero");
                        number2 = Convert.ToDouble(Console.ReadLine());

                    }
                    //Console.WriteLine($"votre resultat : {number1} / {number2} = {number1 / number2}");
                    result = (number1 / number2);
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenue sur notre calculateur");
            Console.WriteLine("**********************************");
            Console.WriteLine("\n");

            string numberInput1 = "";
            string numberInput2 = "";
            double resultat = 0;

            Console.WriteLine("enter your first number");
            numberInput1 = Console.ReadLine();

            double outNumber1 = 0;
            //on a ici une sorte de validateur pour savoir si la valeur saisi est un double
            //empêche aux users de saisir du texte qui devais faire planter notre appli
            while (!double.TryParse(numberInput1, out outNumber1))
            {
                Console.Write("Ce n'est pas une entrée valide. Veuillez saisir une valeur entière: ");
                numberInput1 = Console.ReadLine();
            }

            Console.WriteLine("enter your second number");
            numberInput2 = Console.ReadLine();

            double outNumber2 = 0;
            while (!double.TryParse(numberInput2, out outNumber2))
            {
                Console.Write("Ce n'est pas une entrée valide. Veuillez saisir une valeur entière: ");
                numberInput2 = Console.ReadLine();
            }

            Console.WriteLine("choisir une option dans la liste suivante \n");
 
            Console.WriteLine("*** \t a \t - Addition **** ");
            Console.WriteLine("*** \t s \t - Soustration *** ");
            Console.WriteLine("*** \t p \t - Multiplication *** ");
            Console.WriteLine("*** \t d \t - Division **** ");
            Console.WriteLine(" \t ton option ?");

            string value = Console.ReadLine();

            try
            {
                resultat = Operation(outNumber1, outNumber2, value);
                if (double.IsNaN(resultat))
                {
                    Console.WriteLine("Cette opération entraînera une erreur mathématique.\n");
                }
                else Console.WriteLine("votre resultat: {0:0.##}\n", resultat);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! exception eror: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

            //Console.Write("appuyer une touche du clavier pour fermer la console calculator app...");
            Console.ReadKey();


        }
    }
}
