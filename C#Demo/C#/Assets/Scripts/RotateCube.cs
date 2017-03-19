using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour{
    //public abstract class RotateCube : MonoBehaviour {  //abstract抽象类，只能被继承，不能实例化
    //public sealed class RotateCube : MonoBehaviour {  //sealed密封类，不可被继承
    //public class RotateCube    //没写继承类，默认继承SystemObiect类

    public float speed = 90;
	// Use this for initialization

	public virtual void Say()   //虚函数
    {
        print("I'm a Cube.");
    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
	}
}
