using System;

namespace ConsoleTester
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }


        public override string ToString()
        {
            return Name;
        }
    }


}