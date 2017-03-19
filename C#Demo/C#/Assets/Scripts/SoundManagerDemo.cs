using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SoundManager sm = SoundManager.GetInstance();
        sm.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
