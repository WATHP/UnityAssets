using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulNine : MonoBehaviour {

	// Use this for initialization
	void Start () {                       //九九乘法表
        int i = 0, j = 0;
        string Result = "";
        for (i = 1; i < 10; i++) 
        {
            for (j = 1; j <= i; j++)  
            {
                Result += (j + " * " + i + " = " + (i * j) + "   ");
            }
            Result += "\n";
        }
        print(Result);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
