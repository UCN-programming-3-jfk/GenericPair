using System;

namespace GenericPairClassLibrary
{
    public class ComparablePair<T> where T : IComparable<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public ComparablePair(T first, T second)
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

        public void Sort() 
        {
            if (First.CompareTo(Second) > 0)
            {
                Swap();
            }
        }

        public override string ToString()
        {
            return $"This pair consists of {First} and {Second}";
        }
    }
}