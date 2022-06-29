using System;

namespace Task4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetInt();
        }

        static int GetInt()
        {
            int number = 0;
            bool isWork = true;
            Console.WriteLine("Введите число");
            bool isRightInput = true;

            while (isWork)
            {
                string userInput = Console.ReadLine();
                isRightInput = int.TryParse(userInput, out number);
                if (isRightInput == true)
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Число введено некорректно");
                }
            }

            Console.WriteLine($"Число: {number}");
            return number;
        }
    }
}
