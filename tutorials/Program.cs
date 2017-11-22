using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tutorials
{
    


    public class UnitConverter
    {
        int ratio;
        public UnitConverter(int unitRatio) { ratio = unitRatio; }
        public int Convert (int unit) { return unit * ratio; }
    }
    public class Panda
    {
        public string Name;
        public static int Population;

        public Panda(string n)
        {
            Name = n;
            Population = Population + 1;
        }
    }

    public struct PointStruct { public int X, Y; }
    public class PointClass { public int X, Y; }
    public class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }
    

    class Program
    {
        static int x;

        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
        static void FooRef(ref int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static void Split(string name, out string firstNames,
                           out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }
        static void Foo2(out int y)
        {
            Console.WriteLine(x);
            y = 1;
            Console.WriteLine(x);
        }
        static int Sum(params int[] ints)
        {
            int sum = 0;
            for(int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }
        static void Foo3 (int x = 23)
        {
            Console.WriteLine(x);
        }
        static void Foo4 (int x = 0, int y = 0)
        {
            Console.WriteLine(x + ", " + y);
        }
        static void NamedFoo(int x, int y)
        {
            Console.WriteLine(x + ", " + y);
        }
        static void Bar(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            Console.WriteLine("" + a + b + c + d);
        }

        static void ShowCard (int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case -1:
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                default:
                    Console.WriteLine(cardNumber);
                    break;
            }
        }

        static void TellMeTheType(object x)
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("it's an int!");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }
        static void whenTrue(object x)
        {
            switch (x)
            {
                case bool b when b == true:
                    Console.WriteLine("True!");
                    break;
                case bool b:
                    Console.WriteLine("False!");
                    break;
            }
        }


        static void Main(string[] args)
        {


            foreach (char c in "beer")
                Console.WriteLine(c);

            WriteLine("woah");











            //TellMeTheType(12);
            //TellMeTheType("hello");
            //TellMeTheType(true);

            //whenTrue(true);












            //if (2 + 2 == 5)
            //    Console.WriteLine("no");
            //else if (2 + 2 == 4)
            //    Console.WriteLine("yes");


















            //StringBuilder sb = null;
            //Console.WriteLine(sb?.ToString() ?? "nothing");

            //int? length = sb?.ToString().Length;





            //var y = 5 * (x = 2);
            //Console.WriteLine("x: " + x + " y: " + y);
            //string s1 = null;
            //Console.WriteLine(s1 ?? "nothing");


            //var x = "hello";
            //var y = new StringBuilder();
            //var z = (float)Math.PI;

            //double log = Math.Log(1);

            //Console.WriteLine(log);














            //Bar(d: 5);

            //NamedFoo(y: 4, x: 3);

            //Foo4(5);
            //Foo3(122);
            //int total = Sum(1, 2, 3, 4, 5, 6);
            //Console.WriteLine(total);

            //Foo2(out x);

            //Split("Stevie Ray Vaughan", out string a, out string b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Split("steve urkle", out string c, out _);
            //Console.WriteLine(c);








            //int p = 8;
            //FooRef(ref p);
            //Console.WriteLine(p);
            //string x = "Penn";
            //string y = "Teller";

            //Swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //StringBuilder ref1 = new StringBuilder("object1");
            //Foo(ref1);
            //Console.WriteLine(ref1);










            //int[,] matrix = new int[2, 3];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[i, j] = i * 3 + j;
            //        Console.WriteLine(matrix[i, j]);
            //    }

            //int[,] rectangularMatrix =
            //{
            //    {0,1,2},
            //    {3,4,5},
            //    {6,7,8}
            //};

            //var rectMatrix = new[,]
            //{
            //    {0,1,2},
            //    {3,4,5},
            //    {6,7,8}
            //};

            //var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };














            //PointStruct[] a = new PointStruct[1000];
            //Console.WriteLine(a[100].X);
            //PointClass[] b = new PointClass[1000];
            //for(int i = 0; i < a.Length; i++)
            //{
            //    b[i] = new PointClass();
            //    b[i].X = 1;
            //}
            //Console.WriteLine(b[100].X);



            /*
            int x = 4;
            int y = 4;
            
            String escaped = "First Line\r\nSecond Line";
            String verbatim = @"First Line
Second Line";
            Console.WriteLine("This is " + (escaped == verbatim));
            Console.WriteLine(@"He said ""hi""");
            Console.WriteLine($"A square has {x} sides");
            Console.WriteLine($"255 in hex is {byte.MaxValue:X2}");

            int z = 2;
            Console.WriteLine($@"this spans {
                z} lines");

            //char[] vowels = new char[5];
            //vowels[0] = 'a';
            //vowels[1] = 'e';
            //vowels[2] = 'i';
            //vowels[3] = 'o';
            //vowels[4] = 'u';

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            
            for(int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]);
            }
            */
            /*
            Dude d4 = null;
            if(d4 != null && d4.Name.Equals("John"))
            {
                Console.Write("print");
            }

            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2);
            Dude d3 = d1;
            Console.WriteLine(d1 == d3);


            Console.WriteLine(0.0/0.0);

            int a = 1000000;
            int b = 1000000;
            int c = a * b;


            double million = 1E06;
            Console.WriteLine(million);


            PointClass p3 = new PointClass();
            p3.X = 7;
            PointClass p4 = p3;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4.X);
            p4.X = 9;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4.X);




            PointStruct p1 = new PointStruct();
            p1.X = 7;
            PointStruct p2 = p1;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

            p1.X = 9;
            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);




            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(
                                milesToFeetConverter.Convert(1)));

            Panda panda1 = new Panda("Pan Dee");
            Panda panda2 = new Panda("Pan Dah");

            Console.WriteLine(panda1.Name);
            Console.WriteLine(panda2.Name);

            Console.WriteLine(Panda.Population);

            //int x = 12345;
            //long y = x;
            //short z = (short)x;
            */
        }

        static int FeetToInches (int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
