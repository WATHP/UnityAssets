using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSuperCube : SuperCube {

	// Use this for initialization

	public override void Say()
    {
        print("I'm a SuperSuperCube,I'm fastest.");
    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(speed * Time.deltaTime, 0, speed * Time.deltaTime);
    }
}
