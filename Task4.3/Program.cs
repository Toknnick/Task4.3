using System;

namespace Task4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            ConvertToInt(ref  number);
            Console.WriteLine($"Число: {number}");
        }

        static void ConvertToInt(ref int number)
        {
            bool isWork = true;
            Console.WriteLine("Введите число");
            bool isRightInput = true;

            while (isWork)
            {
                string userInput = Console.ReadLine();
                isRightInput = int.TryParse(userInput, out  number);
                if (isRightInput == true)
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Число введено некорректно");
                }
            }
        }
    }
}
