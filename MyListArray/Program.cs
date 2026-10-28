namespace MyListArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region grupa2
            MyListArray myList = new MyListArray(5);
            myList.Insert(10);
            myList.Insert(20);
            myList.Insert(30);
            myList.Insert(40);


            Console.WriteLine("\nMy list:");
            myList.Print();
            Console.WriteLine();

            Console.WriteLine("\nLinear search - index of:");
            Console.WriteLine("Index of 4: " + myList.IndexOf(4));
            Console.WriteLine("Index of 44: " + myList.IndexOf(44));
            Console.WriteLine();
            Console.WriteLine("\nSum: " + myList.Sum());
            Console.WriteLine();
            Console.WriteLine("\nMax: " + myList.Max());
            Console.WriteLine();
            Console.WriteLine("\nMin: " + myList.Min());
            Console.WriteLine();
            myList.InsertAt(2, 7);
            myList.Print();
            myList.RemoveAt(2);
            myList.Print();
            Console.WriteLine("\nElement at index 2: " + myList.GetItemAt(2));
            myList.SetItemAt(2, 99);
            myList.Print();

            MyListArray otherList = new MyListArray(3);
            otherList.Insert(20);
            otherList.Insert(30);
            otherList.Insert(50);

            Console.WriteLine("\nOther list:");
            otherList.Print();

            Console.WriteLine("\nIntersection:");
            MyListArray intersection = myList.Intersection(otherList);
            intersection.Print();

            MyListArray union = myList.Union(otherList);
            Console.WriteLine("\nUnion:");
            union.Print();

            MyListArray difference = myList.Difference(otherList);
            Console.WriteLine("\nDifference:");
            difference.Print();


            #endregion

            #region grupa1
            //MyListArray myList = new MyListArray(5);
            //myList.Insert(1);
            //myList.Insert(2);
            //myList.Insert(3);
            //myList.Insert(4);
            //myList.Insert(5);
            //myList.Insert(6);

            //Console.WriteLine("The list values: ");
            //myList.Print();

            //Console.WriteLine("Linear search - index of:");
            //Console.WriteLine("Index of 4: " + myList.IndexOf(4));
            //Console.WriteLine("Index of 44: " + myList.IndexOf(44));

            //Console.WriteLine("The sum of list elements " +
            //    "is " + myList.Sum());

            //Console.WriteLine("The maximum element in the list is " +
            //    myList.Max());
            //Console.WriteLine("The minimum element in the list is " +
            //    myList.Min());

            //myList.RemoveAt(4);
            //myList.Print();

            //myList.RemoveItem(3);
            //myList.Print();
            ////myList.RemoveItem(111);
            ////myList.Print();

            //myList.InsertAt(2, 99);
            //myList.Print();
            ////myList.InsertAt(14, 88);

            //myList.Reverse();
            //myList.Print();

            #endregion
        }
    }
}
