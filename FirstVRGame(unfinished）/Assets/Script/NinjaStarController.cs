using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarController : MonoBehaviour {

    float StarSpeed = 9.0f;
    float RotationSpeed = 8.0f;
	// Use this for initialization
	void Start () {

        //Rigidbody"刚体",velocity"速度",transfoem.up"世界坐标的y轴"
        GetComponent<Rigidbody>().velocity = transform.up * StarSpeed;
        //angularVelocity角速度,transform.forwarf"世界坐标的z轴"
        GetComponent<Rigidbody>().angularVelocity = transform.forward * RotationSpeed;
	}

    /// <summary>
    /// 碰撞方法
    /// </summary>
    /// <param name="collision">碰撞对象</param>
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Enemy")
        {
            collision.collider.GetComponent<EnemyMover>().DieSoon();
            Destroy(gameObject);
        }
    }
}
