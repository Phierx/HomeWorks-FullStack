using System;

namespace csharpTutorial
{
    class Program
    {
          static void MyMethod()
        {
                string we = Console.ReadLine();
                int weLenght = we.Length -1;
                int res1;
                bool success = Int32.TryParse(we, out res1);
            if (Char.IsNumber(we, weLenght) == false)
            {
                Console.WriteLine("The factorial work with number not Alphabet");
                MyMethod();
            }
            else if (success)
            {
                if (res1 > 30)
                {
                    Console.WriteLine("To prevent the average machine to Crash type a number below 30");
                    MyMethod();
                }
                else
                {
                    int i, result = 1, input = res1;
                    for (i = 1; i <= input; i++)
                    {
                        result = result * i;
                    }
                    Console.WriteLine("The factorial of " + input + " is " + result);
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
                    Console.WriteLine("Factorial - APP");
                    Console.WriteLine("Please enter the desired number");
                    MyMethod();
        }
    }
}
