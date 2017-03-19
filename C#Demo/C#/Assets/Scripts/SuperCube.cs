using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCube : RotateCube {

	// Use this for initialization

    public override void Say()    //需和virtual配合使用
    {
        print("I'm a SuperCube,I'm more faster.");
    }
    // Update is called once per frame
    void Update () {
        transform.Rotate(0, speed * Time.deltaTime, speed * Time.deltaTime);
	}


}
