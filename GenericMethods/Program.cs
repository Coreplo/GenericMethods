using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    //Generics allow the reuse of code across different types

    class Program
    {
        //this code will work ONLY for int types
        static void SwapInt (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //this code will work with MANY types
        static void SwapGeneric<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //T is the name of our generic type
        // the <> brackets are used to define a generic type

        static void Main(string[] args)
        {
            Console.WriteLine("Generic Methods! yay");

            int a = 4, b = 9;
            Console.WriteLine("{0} - {1}", a, b);
            SwapGeneric<int>(ref a, ref b);
            Console.WriteLine("{0} - {1}", a, b);

            string s1 = "hello", s2 = "world";
            Console.WriteLine("{0} - {1}", s1, s2);
            SwapGeneric<string>(ref s1, ref s2);
            Console.WriteLine("{0} - {1}", s1, s2);


            Console.ReadKey();
        }
        // without generics we would have had to overload the mthod 
        // for every type we want to use
        // multiple generic params can be used if needed
        //eg Func<T,U>

    }
}
