using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListAPI : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ArrayList a = new ArrayList();

        //增:Add Insert InsertRange
        a.Add("a");
        a.Add(1);//[a,1]
        a.Insert(1, "b");//插入到字符“1”的前面,a=[a,b,1]。

        ArrayList b = new ArrayList();
        b.Add("test");
        b.Add("dog");
        a.InsertRange(1, b);//插入第“1”个数前面,[a,test,dog,b,1]
        PrintArray(a);


        //删:Remove RemoveAt RemoveRange
        a.Remove(1);//指定删除字符“1”。[a,test,dog,b]
        a.RemoveAt(0);//删除第一个字符，[test,dog,b]

        a.RemoveRange(1, 2);//从第一个数开始删除2个，[test]


        //查：IndexOf LastIndexOf
        a.Add(1);
        a.InsertRange(1, b);      //  [test,test,dog,1]
        print(a.IndexOf("dog"));//查找dog在哪个位置是多少。2
        //a.LastIndexOf   //从后面往前找



        //其他：Reverse
        a.Reverse();       //反转数组
        PrintArray(a);     //[1,dog,test,test]

    }
    void PrintArray(ArrayList a)
    {
        string s = "[";
        for (int i= 0; i < a.Count; i++)
        {
            s += a[i].ToString();
            if (i != a.Count - 1) s += ",";
        }
        s += "]";
        print(s);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
