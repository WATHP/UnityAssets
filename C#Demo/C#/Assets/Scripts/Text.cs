using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour {

    // Use this for initialization      //变量名手写字母只能为字母或下划线

    //var classname;                    //上下文关键字“var”只能出现在局部变量声明或脚本代码中
    string className ="Unity\" Class";   //字符串 \为转义字符，令“为名的一部分。
    int studentNum = 30;            //整数。
    int studentNum2 = (int)30.5f;      //取整，为30。   studentNum=(int)30.5f;
    float avgScore = 80.5f;          //浮点数,没f的小数为double类型。
    bool a = true;          //布尔值
    void Start () {
        print(className);
        /*
        //variable 变量
        var name = "YCL";
        var age = 20;
        //var children = { "None" };  //不能用var声明数组，不明确。
        print(name +" is "+age+" years old new");
        */

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
