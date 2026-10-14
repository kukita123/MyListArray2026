namespace MyListArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyListArray myList = new MyListArray(5);

            

            Console.WriteLine("My list:");
            myList.Print();
            Console.WriteLine();

            Console.WriteLine("Linear search - index of:");
            Console.WriteLine("Index of 4: " + myList.IndexOf(4));
            Console.WriteLine("Index of 44: " + myList.IndexOf(44));
            Console.WriteLine();
            Console.WriteLine("Sum: " + myList.Sum());
            Console.WriteLine();
            Console.WriteLine("Max: " + myList.Max());
            Console.WriteLine();
            Console.WriteLine("Min: " + myList.Min());
            Console.WriteLine();
        }
    }
}
