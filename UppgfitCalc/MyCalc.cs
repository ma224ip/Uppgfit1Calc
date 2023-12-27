using System;
using System.Collections.Generic;

// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
// OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
// Visa resultat
// Fråga användaren om den vill visa tidigare resultat.
// Visa tidigare resultat
// Fråga användaren om den vill avsluta eller fortsätta.

namespace UppgfitCalc
{
    public class MyCalc
    {
        public static void Main()
        {
            // Välkomnande meddelande
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to my Calculator");
            Console.WriteLine("------------------------");

            // En lista för att spara historik för räkningar
            List<double> results = new List<double>();
            
            // En while loop för att utförra räkningar tills användare säger nej
            while (true)
            {
                Console.WriteLine("Enter your first number:");
                double number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number:");
                double number2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter one of the options");
                Console.WriteLine("+ : To add");
                Console.WriteLine("- : To subtract");
                Console.WriteLine("* : To multiply");
                Console.WriteLine("/ : To divide");
                string operation = Console.ReadLine();

                double result = 0;

                // en switch sats för att utföra räkningar 
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by 0");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid number, please try again");
                        return;
                }
                // visa resultat till användare
                Console.WriteLine($"Result: {result}");
                
                // lägga till result i vår lista
                results.Add(result);
       
                
                // fråga användare om de vill visa sina resultat 
                Console.WriteLine("Do you want to see previous results?: (Yes or No)");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    Console.Clear();
                    foreach (double r in results)
                    {
                        Console.WriteLine(r);
                    }
                }
                
                // fråga användare om de utföra mer räkningar 
                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string continueInput = Console.ReadLine().ToLower();
                Console.Clear();
                // om de säger nej så brekar vi loopen 
                if (continueInput == "no")
                {
                    Console.WriteLine("Thank you for using my program, Bye!");
                    break; 
                }
            }
        }
    }
}
