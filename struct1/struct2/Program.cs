using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2
{
    class Program
    {

        class MyClass
        {
            public string change;
        }

        struct MyStruct
        {
            public string change;
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "MyClass: Changed";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "MyStruct: Changed";
        }


        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.change = "MyClass: Not changed";
            MyStruct s;
            s.change = "MyStruct: Not changed";

            Console.WriteLine("Before:");
            Console.WriteLine(m.change);
            Console.WriteLine(s.change);

            Console.WriteLine("\nAfter:");
            ClassTaker(m);
            StruktTaker(s);
            Console.WriteLine(m.change);
            Console.WriteLine(s.change);


            Console.ReadLine();
        }
    }
}
