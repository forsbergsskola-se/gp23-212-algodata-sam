using System;
using System.Collections.Generic;

namespace P1_3_Iterator.TurboCollections
{
    public static class TurboMaths2
    {
        // Returns all Even Numbers until the given number.
        public static List<int> GetEvenNumbersList(int maxNumber)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i <= maxNumber; i += 2)
            {
                evenNumbers.Add(i);
            }
            return evenNumbers;
        }

        // Returns all Even Numbers until the given number.
        public static IEnumerable<int> GetEvenNumbers(int maxNumber)
        {
            for (int i = 0; i <= maxNumber; i += 2)
            {
                yield return i;
            }
        }
    }
}