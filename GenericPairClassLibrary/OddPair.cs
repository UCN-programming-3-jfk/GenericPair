using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericPairClassLibrary
{
    public class OddPair<T, U> 
    {
        public T First { get; set; }
        public U Second { get; set; }

        public OddPair(T first, U second)
        {
            First = first;
            Second = second;          
        }
    }
}