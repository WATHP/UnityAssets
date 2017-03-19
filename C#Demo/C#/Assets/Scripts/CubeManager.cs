using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    delegate void CubeMoveHDlegate();  //delegate委托机制
    CubeMoveHDlegate hDelegate;
	// Use this for initialization
	void Start () {
        SmartCube[] cubes = FindObjectsOfType(typeof(SmartCube)) as SmartCube[];
        //FindObjectsOfType(typeof(SmartCube)) 遍历场景中所有物体,获取SmartCube类型物体

        for (int i = 0; i < cubes.Length; i++)
        {
            SmartCube c = cubes[i];
            hDelegate += c.MoveHorizontal;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.LeftControl))
        {
            hDelegate();
        }
	}
}
