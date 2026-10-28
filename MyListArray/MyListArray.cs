using System;
using System.Collections.Generic;
using System.Text;

namespace MyListArrayProject
{
    internal class MyListArray
    {
        #region grupa2
        private int[] items;
        private int count;
        public MyListArray(int size)//constructor
        {
            items = new int[size];
            count = 0;
        }
        public int Count//propertie
        {
            get { return count; }
        }
        public void Insert(int item)//O(1) - constant time complexity
                                    //O(n) - linear time complexity if resizing is needed
        {
            //if (count == items.Length)
            //{
            //    Array.Resize(ref items, count * 2);
            //}

            ResizeIfRequired();

            items[count] = item;
            count++;
        }
        //linear search
        public int IndexOf(int item)//O(n) - linear time complexity
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }
            return -1;
        }
        public void Print()//O(n) - linear time complexity
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
        public int Sum()//O(n) - linear time complexity
        {
            if (count == 0)
                throw new InvalidOperationException("Cannot compute sum of an empty list.");
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += items[i];
            }
            return sum;
        }
        public int Max()//O(n) - linear time complexity
        {
            if (count == 0)
                throw new InvalidOperationException("Cannot compute max of an empty list.");
            int max = items[0];
            for (int i = 1; i < count; i++)
            {
                if (items[i] > max)
                    max = items[i];
            }
            return max;
        }
        public int Min()//O(n) - linear time complexity
        {
            if (count == 0)
                throw new InvalidOperationException("Cannot compute min of an empty list.");
            int min = items[0];
            for (int i = 1; i < count; i++)
            {
                if (items[i] < min)
                    min = items[i];
            }
            return min;
        }
        public void InsertAt(int index, int item)//O(n) - linear time complexity
        {
            if (index > count || index < 0)
            {
                throw new Exception("Index is out of range.");
            }
            if (index == count)
            {
                Insert(item);
            }
            else
            {
                //if (count == items.Length)
                //{
                //    Array.Resize(ref items, count * 2);
                //}
                ResizeIfRequired();
                for (int i = count; i > index; i--)
                {
                    items[i] = items[i - 1];
                }
                items[index] = item;
                count++;
            }
        }
        public void RemoveAt(int index)//O(n) - linear time complexity
        {
            if (index >= count || index < 0)
            {
                throw new Exception("Index is out of range.");
            }
            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
        public int GetItemAt(int index)//O(1) - constant time complexity
        {
            if (index >= count || index < 0)
            {
                throw new Exception("Index is out of range.");
            }
            return items[index];
        }//
        public void SetItemAt(int index, int item)//O(1) - constant time complexity
        {
            if (index >= count || index < 0)
            {
                throw new Exception("Index is out of range.");
            }
            items[index] = item;
        }
        public void ResizeIfRequired()//O(n) - linear time complexity if resizing is needed
        {
            if (count == items.Length)
            {
                int[] newItems = new int[items.Length * 2];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
        }
        public void ClearList()//O(1) - constant time complexity
        {
            items = new int[items.Length];
            count = 0;
        }
        public void Reverse()//O(n) - linear time complexity
        {
            int[] newRevItems = new int[count];
            for (int i = 0; i < count; i++)
            {
                newRevItems[i] = items[count - 1 - i];
            }
            items = newRevItems;
        }
        public MyListArray Intersection(MyListArray otherList)//O(n*m) - quadratic time complexity
        {
            MyListArray intersectinList = new MyListArray(count);
            for (int i = 0; i < count; i++)//O(n) - linear time complexity
            {
                if (otherList.IndexOf(items[i]) != -1)//O(m) - linear time complexity
                {
                    intersectinList.Insert(items[i]);
                }
            }
            return intersectinList;
        }

        //Union - union of two lists, returns a new
        //list containing all unique elements from both lists
        public MyListArray Union(MyListArray otherList)//O(n*m) - quadratic time complexity
        {
            MyListArray unionList = new MyListArray(count + otherList.Count);
            for (int i = 0; i < count; i++)//O(n) - linear time complexity
            {
                unionList.Insert(items[i]);
            }
            for (int i = 0; i < otherList.Count; i++)//O(m) - linear time complexity
            {
                if (unionList.IndexOf(otherList.GetItemAt(i)) == -1)//O(n) - linear time complexity
                {
                    unionList.Insert(otherList.GetItemAt(i));
                }
            }
            return unionList;
        }
        //Difference - difference of two lists, returns a new list
        //containing elements that are in the first list but not in the second list
        public MyListArray Difference(MyListArray otherList)//O(n*m) - quadratic time complexity
        {
            MyListArray differenceList = new MyListArray(count);
            for (int i = 0; i < count; i++)//O(n) - linear time complexity
            {
                if (otherList.IndexOf(items[i]) == -1)//O(m) - linear time complexity
                {
                    differenceList.Insert(items[i]);
                }
            }
            return differenceList;
        }
        #endregion

        #region grupa1
        //private int[] items;
        //private int count;

        //public MyListArray(int length)
        //{
        //    items = new int[length];
        //    count = 0;
        //}
        //public int Count// O(1) - constant time complexity
        //{
        //    get { return count; }
        //}
        //public void Insert(int item)// O(1) - constant time complexity
        //{
        //    //if (items.Length == count)
        //    //{
        //    //    Array.Resize(ref items, count * 2);// O(n) - linear time complexity
        //    //}
        //    ResizeIfRequired();
        //    items[count] = item;
        //    count++;
        //}
        //public void Print()// O(n) - linear time complexity
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.Write(items[i] + " ");
        //    }
        //    Console.WriteLine();
        //}
        ////linear search
        //public int IndexOf(int item)// O(n) - linear time complexity
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (items[i] == item)
        //            return i;
        //    }
        //    return -1;
        //}
        ////sum, min, max
        //public int Sum() // O(n) - linear time complexity
        //{
        //    if (count == 0)
        //        throw new InvalidOperationException("Cannot " +
        //            "compute sum of an empty list.");
        //    int sum = 0;
        //    for (int i = 0; i < count; i++)
        //    {
        //        sum += items[i];
        //    }
        //    return sum;
        //}
        //public int Max()// O(n) - linear time complexity
        //{
        //    if (count == 0)
        //        throw new InvalidOperationException("Cannot " +
        //            "compute max of an empty list.");
        //    int max = items[0];
        //    for (int i = 1; i < count; i++)
        //    {
        //        if (items[i] > max)
        //            max = items[i];
        //    }
        //    return max;
        //}
        //public int Min()//O(n) - linear time complexity

        //{
        //    if (count == 0)
        //        throw new InvalidOperationException("Cannot " +
        //            "compute min of an empty list.");
        //    int min = items[0];
        //    for (int i = 1; i < count; i++)
        //    {
        //        if (items[i] < min)
        //            min = items[i];
        //    }
        //    return min;
        //}
        //public void RemoveAt(int index)// O(n) - linear time complexity
        //{
        //    if (index >= count || index < 0)
        //    {
        //        throw new Exception("Index is out of range.");
        //    }
        //    // Shift elements to the left to fill the gap
        //    for (int i = index; i < count - 1; i++)
        //    {
        //        items[i] = items[i + 1];
        //    }
        //    count--;
        //}
        //public void RemoveItem(int item)// O(n) - linear time complexity
        //{
        //    int index = IndexOf(item);
        //    if (index != -1)
        //    {
        //        RemoveAt(index);
        //    }
        //    else
        //    {
        //        throw new Exception("Item not found in the list.");
        //    }
        //}
        //public void InsertAt(int index, int item)// O(n) - linear time complexity
        //{
        //    if (index > count || index < 0)
        //    {
        //        throw new Exception("Index is out of range.");
        //    }
        //    if (index == count) // Insert at the end
        //    {
        //        Insert(item);
        //    }
        //    else
        //    {
        //        //if (count == items.Length)
        //        //{
        //        //    Array.Resize(ref items, count * 2);
        //        //}
        //        ResizeIfRequired();
        //        // Shift elements to the right to make space
        //        for (int i = count; i > index; i--)
        //        {
        //            items[i] = items[i - 1];
        //        }
        //        items[index] = item;
        //        count++;
        //    }
        //}
        //public void Reverse()
        //{
        //    int[] newRevItems = new int[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        newRevItems[i] = items[count - 1 - i];
        //    }
        //    items = newRevItems;
        //}
        //public void ResizeIfRequired()
        //{
        //    if (count == items.Length)
        //    {
        //        int[] newItems = new int[items.Length * 2];
        //        for (int i = 0; i < count; i++)
        //        {
        //            newItems[i] = items[i];
        //        }
        //        items = newItems;
        //    }
        //}
        ////GetItemAt and SetItemAt methods and ClearList method 
        //public int GetItemAt(int index)// O(1) - constant time complexity
        //{
        //    if (index >= count || index < 0)
        //    {
        //        throw new Exception("Index is out of range.");
        //    }
        //    return items[index];
        //}
        //public void SetItemAt(int index, int item)// O(1) - constant time complexity
        //{
        //    if (index >= count || index < 0)
        //    {
        //        throw new Exception("Index is out of range.");
        //    }
        //    items[index] = item;
        //}
        //public void ClearList()
        //{
        //    count = 0;
        //}

        #endregion

    }
}
