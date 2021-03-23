using System;

namespace Chapter6_Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            MySubClass sub = new MySubClass("abc", 2);
           
        }
    }

    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedThis)
        {
            Console.WriteLine($"This is a base class: {baseClassNeedThis}");
        }
    }

    class MySubClass : MyBaseClass
    {
        public MySubClass(string baseClassNeedThis, int anotherValue) : base(baseClassNeedThis)
        {
            Console.WriteLine($"This is the subclass: {baseClassNeedThis} and {anotherValue}");
        }
    }
}
