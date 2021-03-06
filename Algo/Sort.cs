﻿using System;

namespace Algo
{
    public abstract class Sort<T> where T:IComparable
    {
        protected static bool Less(T v, T w)
        {
            return v.CompareTo(w) < 0;
        }

        protected static void Exchange(T[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;

        }

        public abstract void Go(T[] a);

        public bool IsSorted(T[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (Less(a[i], a[i - 1])) return false;
            }
            return true;
        }

        public void Shuffle(T[] a)
        {
            var rnd = new Random();
            //Fisher-Yates algorithm
            int n = a.Length;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                var temp = a[n];
                a[n] = a[k];
                a[k] = temp;
            }
        }
    }
}
