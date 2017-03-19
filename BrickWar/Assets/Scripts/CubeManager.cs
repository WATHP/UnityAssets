using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    [SerializeField]
    private float cubeDestoryTime = 3;
    //1.如果想实现两个刚体物理的实际碰撞效果时候用OnCollisionEnter，Unity引擎会自动处理刚体碰撞的效果。
    //OnCollisionEnter方法必须是在两个碰撞物体都不勾选isTrigger的前提下才能进入。
    //2.如果想在两个物体碰撞后自己处理碰撞事件用OnTriggerEnter。
    //只要勾选一个isTrigger那么就能进入OnTriggerEnter方法。
    //3.OnCollisionEnter和OnTriggerEnter是冲突的不能同时存在。
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject, cubeDestoryTime);
    }
}
