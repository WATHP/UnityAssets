using System;
using System.IO;

namespace helloCSharp
{
    //委托机制
    /*class Delegate
    {
        public delegate int Call(int num1, int num2);
        class Calculate
        {
            public int Multiply(int num1,int num2)
            {
                return num1 * num2;
            }
            public int Divide(int num1,int num2)
            {
                return num1 / num2;
            }
        }

        class Test
        {
            static void Main(string[] args)
            {
                Call objCall1, objCall2, objCall3, objCall4;
                Calculate objMath = new Calculate();
                objCall1 = new Call(objMath.Multiply);   //参数需相同
                objCall2 = new Call(objMath.Divide);
                objCall3 = new Call(objMath.Divide);
                objCall4 = new Call(objMath.Multiply);
                objCall1 += objCall2;  //向委托增加一个方法，objCall -= objCalll向委托减去一个方法
                objCall3 += objCall4;
                int result1 = objCall1(5, 3);   //先执行Multiply再执行Divide方法
                int result2 = objCall3(5, 3);   //先执行Divide再执行Multiply方法
                Console.WriteLine("结果为{0} 和 {1}", result1, result2);
                Console.ReadKey();
            }
        }
    }*/

    //事件
    /*public class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }
        public EventTest(int n)
        {
            SetValue(n);
        }
        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }
    public class MainClass
    {
        static void Main()
        {
            EventTest e = new EventTest(5);
            e.SetValue(7);
            e.SetValue(11);
            Console.ReadLine();
        }
    }*/

    //事件实例
    //boiler类
    class Boiler
    {
        private int temp;
        private int pressure;
        public Boiler(int t,int p)
        {
            temp = t;
            pressure = p;
        }
        public int getTemp()
        {
            return temp;
        }
        public int getPressure()
        {
            return pressure;
        }
    }
    //事件发布器
    class DelegatBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);
        //基于上面的委托发布定义事件
        public event BoilerLogHandler BoilerEventLog;
        public void LogProcess()
        {
            string remarks = "OK";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }
            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temparature" + t + "\nPressure:" + p);
            OnBoilerEventLog("\nMessage: " + remarks);
        }
        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    }
    //该类保留写入日志文件的条款
    class BoilerInfoLogger
    {
        FileStream fs;    //文件读写
        StreamWriter sw;    //写入字符
        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);   //创建文件
            sw = new StreamWriter(fs);           
        }
        public void Logger(string info)
        {
            sw.WriteLine(info);
        }
        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }
    //事件订阅器
    public class RecordBoilerInfo
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }
        static void Main()
        {
            BoilerInfoLogger filelog = new BoilerInfoLogger("G:\\GitHub\\Unity\\C#Basic\\Boiler.txt");
            DelegatBoilerEvent boilerEvent = new DelegatBoilerEvent();
            boilerEvent.BoilerEventLog += new DelegatBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegatBoilerEvent.BoilerLogHandler(filelog.Logger);
            boilerEvent.LogProcess();
            Console.ReadLine();
            filelog.Close();
        }
    }
}
