using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp
{
    class Learning2
    {
        /*static void Main(string[] args)
        {
            if(args.Length>0)
            {
                for (int i = 0; i < args.Length; i++)
                    Console.WriteLine("命令行参数为：{0}",args[i]);
            }
            else
            {
                Console.WriteLine("没有获取命令行参数");
            }
            Console.Read();
        }*/
        //当字段声明包括 readonly 修饰符时，该声明引入的字段赋值只能作为声明的一部分出现，
        //或者出现在同一类的构造函数中。
        /*static Learning2()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
            }
        }
        static void Main()
        {

        }*/
    }
    /*public class ReadOnlyTest
    {
        class SampleClass
        {
            public int x;
            // Initialize a readonly field
            public readonly int y = 25;
            public readonly int z;
            public SampleClass()
            {
                // Initialize a readonly instance field
                z = 24;
            }
            public SampleClass(int p1, int p2, int p3)
            {
                x = p1;
                y = p2;
                z = p3;
            }
        }
        static void Main()
        {
            SampleClass p1 = new SampleClass(11, 21, 32);   // OK
            Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
            SampleClass p2 = new SampleClass();
            p2.x = 55;   // OK
            Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z);
        }
    }*/
    /*
     Output:
        p1: x=11, y=21, z=32
        p2: x=55, y=25, z=24
    */
}