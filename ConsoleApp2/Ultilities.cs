﻿using System;
namespace Generics
{
    // where T : ICompareable
    // where T : Product
    // where T : class
    // where T : new()
    public class Ultilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

}
