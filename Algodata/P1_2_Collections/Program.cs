using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create an ArrayList to store the values true, "Forsbergs", 'a', 1000, .12f
        ArrayList arrayList = new ArrayList();
        arrayList.Add(true);
        arrayList.Add("Forsbergs");
        arrayList.Add('a');
        arrayList.Add(1000);
        arrayList.Add(0.12f);

        // Use a for-loop and the index-operator [] to print all values in the ArrayList
        Console.WriteLine("\nValues in ArrayList:");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine(arrayList[i]);
        }
    }
}