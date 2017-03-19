using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWar : MonoBehaviour {

    [SerializeField]
    private float force = 1000.0f;
    [SerializeField]
    private float destoryTime = 10;
    [SerializeField]
    private float cloumn;
    [SerializeField]
    private float row;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private Rigidbody ballPerfab;


    void Start()
    {
        for (int column = 0; column < 40; column+=2)
        {
            for (int row = 0; row < 20; row+=2)
            {
                Instantiate(cube, new Vector3(player.transform.position.x - 10 + column, player.transform.position.y + row, player.transform.position.z + 20), Quaternion.Euler(0, 0, 0));
            }
        }
    }

    void Update()
    {
        player.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0));
        if (Input.GetButtonDown("Fire1"))
        {
            //Quaternion.identity就是指Quaternion(0,0,0,0),就是每旋转前的初始角度,是一个确切的值
            Rigidbody ball = Instantiate(ballPerfab, player.transform.position, Quaternion.identity);
            ball.AddForce(force * player.transform.forward);
        }
    } 
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      