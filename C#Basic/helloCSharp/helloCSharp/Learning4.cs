using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp
{
    class Learning4
    {
        /*static void Main()
        {
            int[] a_Array = new int[3];
            int[] b_Array = new int[] { 1, 2, 3 };
            int[] c_Array = { 1, 2, 3 }; //只能在声明时使用
            int[,] d_Array = new int[3, 3];  //二维数组，三行三列
            int[,,] e_Array = new int[,,] { { { 1, 1 }, { 11, 11 }, { 111, 111 } } ,
                                      { { 2, 2 }, { 22, 22 }, { 222, 222 } },
                                      { { 3, 3 }, { 33, 33 }, { 333, 333 } },
                                      { { 4, 4 }, { 44, 44 }, { 444, 444 } } };  //三维数组

            int[][] f_Array;  //锯齿数组，三行
            f_Array = new int[3][];
            f_Array[0] = new int[] { 1, 11, 111 };
            f_Array[1] = new int[] { 2, 22 };
            f_Array[2] = new int[] { 3, 33, 333, 3333 };
            for (int i = 0; i < f_Array.Length; i++)
            {
                for (int j = 0; j < f_Array[i].Length; j++)
                {
                    Console.Write("{0} ", f_Array[i][j]);
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            int[] arr = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            foreach (int number in arr) Console.Write("{0} ", number); //foreach 语句对数组arr进行遍历
            Console.Read();
        }*/

        //静态数组
        /*static void Main()
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("原始数组： ");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //逆转数组
            Array.Reverse(temp);
            Console.Write("逆转数组： ");
            foreach(int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Read();
        }*/

        //动态数组ArrayList
        /*static void Main()
        {
            //添加操作
            ArrayList a = new ArrayList();
            a.Add("One");
            a.Add("Two");
            Console.Write("添加后数组中的所有元素： ");
            foreach (string i in a) { Console.Write("{0} ", i); }
            Console.WriteLine("\n当前数组中的元素个数： " + a.Count);
            Console.WriteLine("当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //插入操作
            a.Insert(2,"Three");
            Console.Write("插入后数组中的所有元素： ");
            foreach (string i in a) { Console.Write("{0} ", i); }
            Console.WriteLine("\n当前数组中的元素个数： " + a.Count);
            Console.WriteLine("当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //数组容量不够，自动增加长度
            a.Add("Four");
            a.Add("Five");
            Console.Write("添加后数组中的所有元素： ");
            foreach (string i in a) { Console.Write("{0} ", i); }
            Console.WriteLine("\n当前数组中的元素个数： " + a.Count);
            Console.WriteLine("当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //索引
            Console.Write("数组中是否包含\"Five\": ");
            if (a.Contains("Five"))Console.Write("true");
            Console.Write("\n索引后数组中的所有元素： ");
            foreach (string i in a) { Console.Write("{0} ", i); }
            Console.WriteLine("\n当前数组中的元素个数： " + a.Count);
            Console.WriteLine("当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //移除
            a.Remove("Five");
            a.Remove("Six");
            Console.WriteLine("没有包含\"Six\"?,那么数组长度不变");
            Console.Write("移除\"Five\"和\"Six\"后数组中的所有元素： ");
            foreach (string i in a) { Console.Write("{0} ", i); }
            Console.WriteLine("\n当前数组中的元素个数： " + a.Count);
            Console.WriteLine("当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //指定移除
            a.RemoveAt(3);
            Console.Write("指定移除后数组中的所有元素： ");
            foreach (string i in a) { Console.Write("{0} ", i); }
            Console.WriteLine("\n当前数组中的元素个数： " + a.Count);
            Console.WriteLine("当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //缩减容量
            a.TrimToSize();
            Console.WriteLine("缩减容量后当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //清楚所有元素
            a.Clear();
            Console.WriteLine("清楚所有元素后当前数组中的元素个数： " + a.Count);
            Console.WriteLine("清楚所有元素后当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            //再次缩减容量
            a.TrimToSize();
            Console.WriteLine("再次缩减容量后当前数组能容纳的最大长度： " + a.Capacity);
            Console.WriteLine();

            Console.ReadLine();
        }*/

    }
}
