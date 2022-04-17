using System;
using System.Collections.Generic;

namespace Obuchenie_1._0_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();

            a.AddRange(new[] { 1, 2, 3 });

            var s = "a = ";

            foreach (var i in a)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length a = " + a.Count);
            Console.WriteLine();


            List<int> b = new List<int> { 1, 2, 3, 4, 5 };

            s = "b = ";

            foreach (var i in b)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length b = " + b.Count);
            Console.WriteLine();


            List<int> c = new();
            c.AddRange(a);
            c.AddRange(b);

            s = "c = a -> b = ";

            foreach (var i in c)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length c = " + c.Count);
            Console.WriteLine();


            List<int> d = new();
            d.AddRange(a);
            d.AddRange(c);
            d.AddRange(b);

            s = "d = a -> c -> b = ";

            foreach (var i in d)
            {
                s += i + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine("Length d = " + d.Count);
            Console.WriteLine();

            /*
            int m = 3;
            int n = 5;

            var list = new List<int>();
            

            int[] a = new int[m]; //[]
                a[0] = 1;
                a[1] = 2;
                a[2] = 3;

            int[] b = new int[n] ; //{}
                b[0] = 1;
                b[1] = 2;
                b[2] = 3;
                b[3] = 4;
                b[4] = 5;

                                //.add()


            // a -> c -> b
            // writeline
            // writeline .lenght

            // github создать учетку (можно использовать от windows), посмотреть туторы в интернете по тому, как создать репозиторий и залить туда код. ссылку на репозиторий в телеграм
            list.AddRange(a);
            list.AddRange(b);

            var s = "c = ";
            
            foreach(var i in list)
            {
                s += i + ", ";             
            }
            Console.WriteLine(s);
            */
        }
    }
}
