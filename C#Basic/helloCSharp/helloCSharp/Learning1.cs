using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp
{
    class Learning1
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello CSharp");
        }*/

        /*public static void Main()
        {
            //无符号8位整数
            byte x = 8;
            Console.WriteLine("x={0}", x); //x=8
            //无符号16位整数
            ushort y = x;
            Console.WriteLine("y={0}", y); //y=8
            y = 65535;
            Console.WriteLine("y={0}", y); //y=65535
            //32位单精度浮点数
            float z = y;
            Console.WriteLine("z={0}", z); //z=65535
        }*/

        /*static void Main()
        {
            long longValue = Int64.MaxValue;
            //转换发生溢出
            int intValue = (int)longValue;
            Console.WriteLine("(int){0}={1}", longValue, intValue);
        }*/

        /*static void Main(string[] args)
        {
            demo1();
            demo2();
            demo3();
        }

        public static void demo1()
        {
            float h1 = 1.75f;
            float h2 = 1.63f;
            bool result;
            result = h1 == h2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void demo2()
        {
            float h1 = 1.75f;
            float h2 = 1.63f;
            bool result2;
            bool result1;
            result1 = h1 != h2;
            result2 = !(h1 != h2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
        public static void demo3()
        {
            float h1 = 1.75f;
            float h2 = 1.63f;
            bool result2;
            bool result1;
            bool result3;
            bool result4;
            result1 = h1 > h2;
            result2 = h1 < h2;
            result3 = h1 >= h2;
            result4 = h1 <= h2;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadLine();
        }*/
        /*static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if (i == 6) break;
                Console.WriteLine("{0}", i++);
            }
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine("{0}", i);
            }
            Console.ReadKey();
        }*/
    }
    /*class A
    {
        public void Fun1(int i) { }
        public void Fun2() { }
        public virtual void Fun3() { }
    }
    class B : A
    {
        static void Main()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write("{0}: ", i);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2} ", i, j, i * j);
                }
                Console.Write("\n");
            }
        Console.ReadKey();
        }
    }*/
}