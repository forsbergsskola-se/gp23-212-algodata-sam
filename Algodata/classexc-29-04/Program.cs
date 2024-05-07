class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Marc");
        names.Add("Daniel");
        names.Add("René");
        names.Add("ABC");

        var iterator = names.GetEnumerator();
        
        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.Current); 
        }
    }
}

/*
 In this code snippet, the while loop keeps calling MoveNext(),
 which moves the iterator to the next item in the list.
 The loop continues until MoveNext() returns false, indicating that there are no more items to iterate over.
 Inside the loop, the current item (iterator.Current) is printed.
*/