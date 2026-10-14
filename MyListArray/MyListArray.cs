using System;
using System.Collections.Generic;
using System.Text;

namespace MyListArrayProject
{
    internal class MyListArray
    {
        private int[] items;
        private int count;

        public MyListArray(int size)
        {
            items = new int[size];
            count = 0;
        }
        public int Count 
        {
            get { return count; }
        }
        public void Insert(int item)
        {
            if (count == items.Length) 
            { 
                Array.Resize(ref items, count * 2);
            }
                
            items[count] = item;
            count++;
        }

        //linear search
        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }
            return -1;
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
        public int Sum()
        {
            if(count == 0)
                throw new InvalidOperationException("Cannot compute sum of an empty list.");
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += items[i];
            }
            return sum;
        }
        public int Max()
        {    if (count == 0)
                throw new InvalidOperationException("Cannot compute max of an empty list.");       
            int max = items[0];
            for (int i = 1; i < count; i++)
            {
                if (items[i] > max)
                    max = items[i];
            }
            return max;
        }
        public int Min()
        {
            if(count == 0)
                throw new InvalidOperationException("Cannot compute min of an empty list.");
            int min = items[0];
            for (int i = 1; i < count; i++)
            {
                if (items[i] < min)
                    min = items[i];
            }
            return min;
        }

    }
}
