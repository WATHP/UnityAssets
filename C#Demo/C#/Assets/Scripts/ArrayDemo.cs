using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] gos = new GameObject[10];     //数组只能放同一种数据类型
        gos[0] = new GameObject();
        //gos[1] = new ArrayList();
        //gos.length拿取数组长度


        ArrayList a = new ArrayList();           //Array数组能放不同的数据类型
        a.Add(null);
        a.Add(new GameObject());
        a.Add(gos);
        //a.Count拿取数组长度
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
