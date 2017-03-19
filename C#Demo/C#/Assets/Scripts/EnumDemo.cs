using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumDemo : MonoBehaviour {

    public enum PlayerType    //枚举Enum的使用
    {
        Soldier,Nurse,BlackSmith
    }

    public PlayerType player;

    void Say()
    {
        switch (player)
        {
            case PlayerType.Soldier:
                print("I'm a soldier.");
                break;
            case PlayerType.Nurse:
                print("I'm a Nurse.");
                break;
            case PlayerType.BlackSmith:
                print("I'm a BlackSmith.");
                break;
            default:
                break;
        }
    }
	// Use this for initialization
	void Start () {
        Say();
	}

    void Update()
    {
        Say();
    }
}
