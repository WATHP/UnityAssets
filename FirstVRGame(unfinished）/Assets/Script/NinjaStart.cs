using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStart : MonoBehaviour {

    public GameObject ninja;
    public NinjaStarController ninjaStar;
    public AudioSource whooshSound;

    private GameController _gameController;
    //Vector3"自身坐标"
    private Vector3 _shooterOffset;

	// Use this for initialization
	void Start () {

        //获取当前组件GameController的内容
        _gameController = this.GetComponent<GameController>();

        _shooterOffset = new Vector3(0.0f, 0.8f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") && !_gameController.isGameOver)
        {
            Vector3 mouseLoc = Input.mousePosition;
            //把物体在3d世界里的位置 转换到 显示在屏幕上的位置
            Vector3 worldMouseLoc = Camera.main.ScreenToWorldPoint(mouseLoc);
            worldMouseLoc.y = ninja.transform.position.y;
            //ninja的坐标“看着”转换好的鼠标的坐标
            ninja.transform.LookAt(worldMouseLoc);
            LaunchNinjaStarFrom(ninja, _shooterOffset);
        }
	}

    void LaunchNinjaStarFrom(GameObject origin,Vector3 shooterOffset)
    {
        //ninjaStarRotation的坐标等于origin的旋转坐标
        Vector3 ninjaStarRotation = origin.transform.rotation.eulerAngles;
        ninjaStarRotation.x = 90.0f;
        Vector3 transformedOffset = origin.transform.rotation * shooterOffset;
        //Instantiate创建一个预设物。参数一是预设物的名字，参数二是预设物的位置，参数三是旋转角度。
        //Quaternion.Euler返回一个旋转角度，绕z轴旋转z度，绕x轴旋转x度，绕y轴旋转y度。
        Instantiate(ninjaStar, origin.transform.position + transformedOffset, Quaternion.Euler(ninjaStarRotation));
    }
}
