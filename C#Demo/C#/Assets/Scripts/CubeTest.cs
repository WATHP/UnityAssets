using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour {

	// Use this for initialization
	void Start () { 
        RotateCube a = new RotateCube();
        RotateCube b = new SuperCube();
        RotateCube c = new SuperSuperCube();

        a.Say();
        b.Say();
        c.Say();
    }

}
