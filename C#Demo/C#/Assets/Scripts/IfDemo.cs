using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int score = 500;
        bool a = true;
        if (a && score > 10 && score < 100)      //好算的条件放前面，难算的条件放后面。
        {
            print("score > 10");
        }
        else if(score>100)
        {
            print("score>100");
        }
        else          //其他不明情况。if后加else为好。
        {

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
