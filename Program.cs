using System;

namespace LinkedListProject0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddLast("Joe Blow");
            list.AddFirst("Jane Doe");
            list.AddLast("Bob Bobberson");

            Console.WriteLine("First value: " + list.GetValue(0));
            Console.WriteLine("Total count: " + list.Count);
        }
    }
}
