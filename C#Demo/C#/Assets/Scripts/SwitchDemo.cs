using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int type = 1;
        switch (type)      //有限且能列举再用switch
        {
            case 0:
            case 1:
                print("0 or 1");
                break;
            case 2:
                print(2);
                break;
            case 3:
                break;

            default:
                break;

            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
