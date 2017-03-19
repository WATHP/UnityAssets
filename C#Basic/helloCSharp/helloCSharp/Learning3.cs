using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp
{
    class Learning3
    {
        /*static void Main(string[] args)
        {
            string strA = "1";
            string strB = string.Empty;
            string strC = null;
            Console.WriteLine(int.Parse(strA));  //int.Parse(转换成int型),在Console.Write(...)或Console.Read(...)中使用
            Console.WriteLine(int.Parse(strB));  //false
            Console.WriteLine(strC.ToString());  //Tostring传换成字符串  //false
            Console.Read();
        }*/
        /*
         * //判断字符串是否为null或为空
         *IsNullOrEmpty等同于if(str==null||str.Equals(string.Empty))
         * isNullOrWhiteSpace等同于if(str==null||str.Equals(String.Empty)||str.Trim.Equals(string.Empty))
         * //Trim:去掉字符串前后的空格
         */
        /*static void Main(string[] args)
        {
            //string类型是引用类型，传递时无法改变引用的值，ref传递的是引用本身而不是值
            string strA = "abcde";
            Deal(ref strA);  //Deal(strA);
            Console.WriteLine(strA);
            Console.ReadLine();
        }
        static void Deal(ref string str) //static void Deal(string str)
        {
            //Substring：从第0位开始去2个字母
            str = str.Substring(0, 2);
        }*/
        /*
         * ab/abcde
        */
        /*static void Main()
        {
            StringBuilder a = new StringBuilder("Hello World!");
            //StringBuilder a = new StringBuilder("Hello World!", 25);//指定最大容量为25
            //a.Capacity = 25;//指定最大容量为25
            a.Append("What a beautiful day.");
            Console.WriteLine(a);

            int print = 25;
            a.AppendFormat("{0:C} ", print);
            Console.WriteLine(a);

            a.Insert(6, "Beautiful ");
            Console.WriteLine(a);

            a.Remove(5, 10);
            Console.WriteLine(a);

            a.Replace("!", "?");
            Console.WriteLine(a);
        }*/
    }
}
