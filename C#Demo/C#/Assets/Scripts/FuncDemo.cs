using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {            //函数名首字母大写
        Say("HelloWorld!!");
        //this.
        int s = Sum(3, 4);
        print(s);
	}
	
    public void Say(string msg)
    {
        print(msg);
    }

    int Sum(int a,int b)
    {
        return a + b;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
