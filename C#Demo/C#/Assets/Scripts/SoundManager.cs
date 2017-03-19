using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private static SoundManager instance;   //static静态指只能在该文件内使用，不能用于其他文件。

    private SoundManager()
    {

    }

    public static SoundManager GetInstance()
    {
        if (instance == null)
        {
            instance = new SoundManager();
        }
        return instance;
    }

    public void Play()
    {
        Debug.Log("play");
    }
}
