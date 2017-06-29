using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanCtrl : MonoBehaviour {

    private Animator _animator;
    private AnimatorStateInfo _currentStateInfo;    //当前状态
    private AnimatorStateInfo _PreStateInfo;        //上一个状态

    public float waitTime = 3f;
    public bool isRandom = true;

    public AnimationClip[] _FaceClips;      //存储动画片段
    public string[] _FaceMotionName;

    public AudioClip[] _ChanVoice;
    public string[] _ChanVoiceName;

    public AudioClip[] _HourClips;
    public string[] _HourVoiceName;

    public Canvas _canvas;
    public Text _ShowText;

    // Use this for initialization
    void Start () {
        _canvas.enabled = false;
        _animator = GetComponent<Animator>();
        _currentStateInfo = _animator.GetCurrentAnimatorStateInfo(0);       //获取第一个动画层的状态
        _PreStateInfo = _currentStateInfo;

        _FaceClips = Resources.LoadAll<AnimationClip>("FaceMotion");        //获取该目录下所有动画片段
        _FaceMotionName = new string[_FaceClips.Length];

        _ChanVoice = Resources.LoadAll<AudioClip>("ChanVoice");
        _ChanVoiceName = new string[_ChanVoice.Length];

        _HourClips = Resources.LoadAll<AudioClip>("HourClips");
        _HourVoiceName = new string[_HourClips.Length];

        for(int i = 0; i < _FaceClips.Length; i++)
        {
            _FaceMotionName[i] = _FaceClips[i].name;
        }

        StartCoroutine(RandomChangeMotion());       //启动协程
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hitInfo;
        if (Input.GetMouseButtonDown(0))    //鼠标左键点击或触屏
        {
            //从摄像机到触摸或点击位置的一个射线，Mathf.Infinity指无穷远
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hitInfo, Mathf.Infinity))
            {
                if (hitInfo.collider.tag == "face")     //判断射线碰撞到的刚体标签为face
                {
                    ChangeFace();
                }
            }
        }
        if (_animator.GetBool("Next"))
        {
            _currentStateInfo = _animator.GetCurrentAnimatorStateInfo(0);       //第一层的状态
            if (_PreStateInfo.fullPathHash != _currentStateInfo.fullPathHash)       //状态
            {
                _animator.SetBool("Next", false);
                _PreStateInfo = _currentStateInfo;
            }
        }
        if (GetComponent<AudioSource>().isPlaying)
        {
            _canvas.enabled = true;
        }
        else
        {
            _canvas.enabled = false;
        }
    }

    private void ChangeFace()
    {
        _ShowText.text = "";
        _animator.SetLayerWeight(1, 1);     //第二层权重100%
        int index = UnityEngine.Random.Range(0, _FaceMotionName.Length);        //随机数
        _animator.CrossFade(_FaceMotionName[index], 0.5f);     //运行动画，延时为0

        if (GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Stop();
        }
        int num = UnityEngine.Random.Range(0, _ChanVoiceName.Length);
        GetComponent<AudioSource>().clip = _ChanVoice[num];
        GetComponent<AudioSource>().Play();
    }

    IEnumerator RandomChangeMotion()        //协程，每一帧都会运行
    {
        while (true)
        {
            if (isRandom)
            {
                _animator.SetBool("Next", true);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }

    public void OnAskHour()
    {
        int hour = DateTime.Now.Hour;
        if (GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Stop();
        }
        GetComponent<AudioSource>().clip = _HourClips[hour];
        if(hour==2|| hour ==5|| hour ==8|| hour ==11|| hour ==14|| hour ==17|| hour ==20|| hour == 23)
        {
            _ShowText.text = hour + "時になりました(现在" + hour + "点)";
        }
        else
        {
            _ShowText.text = hour + "です(现在" + hour + "点)";
        }
        GetComponent<AudioSource>().Play();
    }
}
