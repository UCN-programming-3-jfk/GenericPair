using GenericPairClassLibrary;
using System;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<Person> couple = new Pair<Person>(new Person() { Name = "Anna"}, new Person() {Name = "Bob" });
            Console.WriteLine(couple);
            Console.WriteLine("Swap");
            couple.Swap();
            Console.WriteLine(couple);

            Console.WriteLine();

            ComparablePair<Person> comparePair = new ComparablePair<Person>(new Person() { Name = "Clara" }, new Person() { Name = "Dilbert" });
            Console.WriteLine(comparePair);
            Console.WriteLine("Swap");
            comparePair.Swap();
            Console.WriteLine(comparePair);
            Console.WriteLine("Sort");
            comparePair.Sort();
            Console.WriteLine(comparePair);

        }
    }
}
