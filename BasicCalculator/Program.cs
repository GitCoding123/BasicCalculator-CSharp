using System.Numerics;

namespace BasicCalculator
{
    class Program 
    {
        static double Addition(double num1, double num2) {
            return num1 + num2;
        }

        static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            String operation = "";
            String useAgain = "";
            double num1;
            double num2;
            double ans;
            bool running = true;

            Console.WriteLine("Welcome to the basic calculator!");

            while (running)
            {
                while (true)
                {
                    Console.WriteLine("Please choose a first number: ");
                    Console.Write("$> ");
                    try
                    {
                        num1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number! Please choose a valid number.\n");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Please choose a second number: ");
                    Console.Write("$> ");
                    try
                    {
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number! Please choose a valid number.\n");
                        continue;
                    }
                    break;
                }


                Console.WriteLine("Please choose an operation (+,-,*,/)");
                Console.Write("$> ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        ans = Addition(num1, num2);
                        break;
                    case "-":
                        ans = Subtraction(num1, num2);
                        break;
                    case "*":
                        ans = Multiplication(num1, num2);
                        break;
                    case "/":
                        ans = Division(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose a valid operation.\n");
                        continue;
                }

                Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + ans);
                
                Console.WriteLine("Continue using the basic calculator? (y/n)");
                Console.Write("$> ");
                useAgain = Console.ReadLine().ToUpper();

                if (useAgain == "Y") {
                    continue;
                }
                else if(useAgain == "N")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid option. Choose 'y' or 'n'.");

                }
            }
        }
    }
}
