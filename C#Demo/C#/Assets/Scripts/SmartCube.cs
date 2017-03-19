using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartCube : MonoBehaviour {

    public float speed = 10;
	public void MoveHorizontal()
    {
        transform.Translate(Time.deltaTime * speed * Input.GetAxis("Horizontal"), Time.deltaTime * speed * Input.GetAxis("Jump"), Time.deltaTime * speed * Input.GetAxis("Vertical"));
        //Time.deltaTime 每一帧的时间
        //这是确定移动方向的，Input.GetAxis("Horizontal")是在X轴上移动，
        //Input.GetAxis("Vertical")代表在z轴上移动，
        //你可以从Edit——Project Setting——input中查看相关的设置
    }
}
