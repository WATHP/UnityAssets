using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 10; i++) {
            print(i);
        }

        int j = 0;
        while (j < 10)
        {
            print("while: " + j);
            j++;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
