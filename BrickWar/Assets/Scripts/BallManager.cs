using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    [SerializeField]
    private float destoryTime = 8.0f;
    [SerializeField]
    private GameObject ball;
	
	// Update is called once per frame
	void Update () {
        Destroy(ball, destoryTime);
    }
}
