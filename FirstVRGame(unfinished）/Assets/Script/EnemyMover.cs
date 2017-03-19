using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {

    public float SpeedMin;
    public float SpeedMax;

    enum EnemyState { Normal, Dying };

    private EnemyState _state;
	// Use this for initialization
	void Start () {
        _state = EnemyState.Normal;
        float thisSpeed = Random.Range(SpeedMin, SpeedMax);
        this.GetComponent<Rigidbody>().velocity = transform.forward * thisSpeed;
	}
	
    public bool IsDying()
    {
        return (_state == EnemyState.Dying);
    }

    public void DieSoon()
    {
        _state = EnemyState.Dying;
        //遍历GameController对象
        GameController gameController = FindObjectOfType<GameController>();
        gameController.GotOne();
        this.GetComponent<AudioSource>().Play();
        Destroy(gameObject, 1.5f);
    }
}
