using System;
using System.Collections.Generic;
using P1_3_Iterator.TurboCollections;

namespace P1_3_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List with 5 numbers: 1, 1, 2, 3, 5
            List<int> numbers = new List<int> { 1, 1, 2, 3, 5 };

            // Assign it to a variable of type IEnumerable
            IEnumerable<int> enumerableNumbers = numbers;

            // Use GetEnumerator() and a while-Loop to print all elements of the List-Variable
            IEnumerator<int> enumerator = enumerableNumbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            // Calculate the sum of the numbers in the list
            int sum = 0;
            foreach (var number in enumerableNumbers)
            {
                sum += number;
            }
            Console.WriteLine("Sum: " + sum);

            // Invoke GetEvenNumbers and GetEvenNumbersList with 12 as argument
            Console.WriteLine("GetEvenNumbers(12):");
            foreach (var evenNumber in TurboMaths2.GetEvenNumbers(12))
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("GetEvenNumbersList(12):");
            foreach (var evenNumber in TurboMaths2.GetEvenNumbersList(12))
            {
                Console.WriteLine(evenNumber);
            }

            // Invoke GetEvenNumbers with 1_000_000_000 as an argument
            Console.WriteLine("Invoke GetEvenNumbers with 1_000_000_000 as an argument. No Problem, right?");
            // Note: We will not print these values to avoid flooding the console

            // Invoke GetEvenNumbersList with 1_000_000_000 as an argument
            Console.WriteLine("Invoke GetEvenNumbersList with 1_000_000_000 as an argument. Observe the result.");
            // This will cause a huge memory allocation, so use with caution
            // Note: We will not print these values to avoid flooding the console
        }
    }
}
