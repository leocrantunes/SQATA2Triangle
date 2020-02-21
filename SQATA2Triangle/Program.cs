using System;
using System.Collections.Generic;
using System.Linq;

namespace SQATA2Triangle
{
    class Program
    {
        private const int EXIT_CODE = 2;

        private static readonly Dictionary<int, string> _options = new Dictionary<int, string>()
        {
            { 1, "Enter triangle dimensions" },
            { 2, "Exit" }
        };

        static void Main(string[] args)
        {
            int optionCode;
            do
            {
                ShowListOfOptions();
                optionCode = ReadOptionCode();

                if (optionCode != EXIT_CODE)
                {
                    ExecuteAction(optionCode);
                }
            } while (optionCode != EXIT_CODE);
        }

        /// <summary>
        /// Executes the action according to the option code
        /// </summary>
        /// <param name="optionCode">target option</param>
        private static void ExecuteAction(int optionCode)
        {
            switch (optionCode)
            {
                case 1:
                    ReadTriangleValues();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Auxiliary method to show the list of possible options
        /// </summary>
        private static void ShowListOfOptions()
        {
            Console.WriteLine("Please, choose one of the following options:");
            Console.WriteLine(String.Join("\n", _options.Select(o => $"{o.Key}. {o.Value}")));
        }

        /// <summary>
        /// Auxiliary method to read option code and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static int ReadOptionCode()
        {
            bool correct = false;
            do
            {
                bool validInteger = int.TryParse(Console.ReadLine(), out int value);
                if (validInteger)
                {
                    if (_options.ContainsKey(value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Please inform a code in the list above");
                        ShowListOfOptions();
                    }
                }
                else
                {
                    Console.WriteLine("Please inform a valid integer number");
                    ShowListOfOptions();
                }
            }
            while (!correct);

            return EXIT_CODE;
        }

        private static void ReadTriangleValues()
        {
            Console.WriteLine("Please, enter the first value for the triangle");
            int firstValue = ReadValidInteger();

            Console.WriteLine("Please, enter the second value for the triangle");
            int secondValue = ReadValidInteger();

            Console.WriteLine("Please, enter the third value for the triangle");
            int thirdValue = ReadValidInteger();

            Console.WriteLine($"Values: {firstValue}, {secondValue}, {thirdValue}");
            Console.WriteLine($"Analysis: {TriangleSolver.Analyze(firstValue, secondValue, thirdValue)}");
        }

        /// <summary>
        /// Auxiliary method to read a valid integer and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static int ReadValidInteger()
        {
            bool correct = false;
            do
            {
                Console.Write("Value: ");
                bool validInteger = int.TryParse(Console.ReadLine(), out int value);
                if (validInteger)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Please inform an integer greater than 0");
                    }
                    else
                    {
                        return value;
                    }
                }
                else
                {
                    Console.WriteLine("Please inform a valid integer number");
                }
            }
            while (!correct);

            return 0;
        }
    }
}
