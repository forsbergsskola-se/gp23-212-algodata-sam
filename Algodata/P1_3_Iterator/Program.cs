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
        }
    }
}