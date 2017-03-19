using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCSharp
{
    //internal class Learning5{} 指定为只能内部声明的内部类，但类默认是内部声明的

    //基类的访问性要比派生类高
    #region
    //public class a{}
    //internal class b:a{}  true

    //internal class b{}
    //public class a:b{}  false
    #endregion

    //析构函数
    /*class a
    {
        public a() { Console.WriteLine("构造类a"); }
        ~a() { Console.WriteLine("a的析构函数被调用"); }
    }
    class b
    {
        public b() { Console.WriteLine("构造类b"); }
        ~b() { Console.WriteLine("b的析构函数被调用"); }
    }

    class MainClass
    {
        static void Main()
        {
            a aa=new a();
            b bb=new b();
        }
    }*/

    //嵌套类默认为私有，可设置为公有。
    //嵌套类可访问外部类所有成员，不管共有私有保护还是内部
    //而外部类访问嵌套类就要遵循共有私有保护还是内部的限制

    //构造函数的重载及this的应用
    /*public class Learning5
    {
        int petalCount = 0;
        String s = "null";

        Learning5(int petals)
        {
            petalCount = petals;
            Console.WriteLine("Constructor w/int arg only, petalCount = " + petalCount);
        }
        Learning5(String s,int petals):this(petals)  //调用构造函数Car(int petals)并把参数传过去
        {
            this.s = s;
            Console.WriteLine("String & int args, s =" + s);
        }
        Learning5() : this("hi", 47)  //调用构造函数Car(String s,int petals)并把参数传过去
        {
            Console.WriteLine("default constructor");
        }

        public static void Main()
        {
            Learning5 x = new Learning5();
            Console.Read();
        }
    }*/

    //属性：专门用来访问私有字段
    /*public class Learning5_A
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return (_name == null) ? string.Empty : _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if ((value > 0) && (value < 150))
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Not a real age");
                }
            }
        }
    }
    public class Learning5_B
    {
        public static void Main(string[] args)
        {
            Learning5_A a = new Learning5_A();
            a.Name = "Anytao";   //触发set访问器
            Console.WriteLine(a.Name);
            a.Age = 66;
            Console.WriteLine(a.Age.ToString());
            a.Age = 160;   ////触发set访问器，抛出异常
            Console.ReadLine();
        }
    }*/
}
