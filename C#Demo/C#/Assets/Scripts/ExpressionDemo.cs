using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        /*
        //赋值运算符
            //1.左右两边数据类型需一致
        string str = "a";
        str = 1 + "";    //任何数据类型加上字符串就变成字符串。
            //2.左边是变量，右边是数据或表达式
            //1 + "" = str;
       //基本运算符 +-*%/
        print(9 + 2);
        print(9 - 2);
        print(9 * 2);
        print(9 / 2);//4  取整
        print(9f / 2);//4.5
        print(9 % 2);//1

        //NaN(Not a number)
        print(0.0 / 0.0);
        */


        /*
        string s = null;
        s = "9 + 2 = " + (9 + 2);
        print(s);
        int a = 3;
        s = a + "";
        print(s);
        */

        /*
        //连续运算符 += -= /= %= ++ --
        int b = 3;
        b += 4;
        b++;b--;
        */


        /*
        float a = 0;
        print(a);
        print(a++);
        print(a);
        print(++a);
        print(a);
        */


        /*
        //关系运算符><
        int a = 5;
        float b = 5f;
        print(a > b);
        print(a < b);
        print(a >= b);
        print(a <= b);
        print(a != b);
        print(a == b);
        */


        /*
        //逻辑运算符 && || ！
        bool b1 = true;
        bool b2 = false;
        print(b1 && b2);
        print(b1 || b2);
        print(!b1);
        print(!b2);
        */

        /*
        //类型转换cast

        //int float
        int a = 5;
        float c = 5.2f;
        float b;
        int d;

        b = a;
        print(b);
        d = (int)c;
        print(d);
        */


        //object GameObject
        Object o = new Object();
        GameObject go = new GameObject();
        //go = (GameObject)o;    //父类转换成子类为空
        print(o as GameObject);   //Null
        print((Object)go);     //子类可转换成父类,子类拥有父类所有功能，反之不是
    }
	
}
