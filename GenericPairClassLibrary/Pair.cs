using System;

namespace GenericPairClassLibrary
{
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }
        public void Swap ()
        {
            var temp = First;
            First = Second;
            Second = temp;
        }

        public override string ToString()
        {
            return $"This pair consists of {First} and {Second}";
        }
    }
}
