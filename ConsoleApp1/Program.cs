using System;
using System.Collections.Generic;

namespace MyGenSpace
{
    class MyGen<T>
    {
        List<T> list;

        void add<T>()
        {

        }
        void Displist()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var typeInt = typeof(MyGen<int>);
            var typeString = typeof(MyGen<string>);
            var members = typeInt.GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine(member.Name);
            }
            Console.WriteLine();
        }
    }
}
