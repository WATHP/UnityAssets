using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float maxZSpawn;
    public float minZSpawn;
    public float xSpawn;
    public float RangeMinTime;
    public float RangeMaxTime;
    public GameObject EnemyPrefabs;

    private float _nextTime;
    private float _ySpawn = 0.4f;
    private Quaternion _Rotation;
    private GameController _gameController;

	// Use this for initialization
	void Start () {

        SetNext();

        _gameController = this.GetComponent<GameController>();
        _Rotation = Quaternion.Euler(new Vector3(0.0f, -90f, 0.0f));
	}
	
    void SetNext()
    {
        float Interval = Random.Range(RangeMinTime, RangeMaxTime);
        _nextTime = Time.time + Interval;
    }
	// Update is called once per frame
	void Update () {

        if (Time.time > _nextTime && !_gameController.isGameOver)  {
            Vector3 Position = new Vector3(xSpawn, _ySpawn, Random.Range(minZSpawn, maxZSpawn));
            Instantiate(EnemyPrefabs, Position, _Rotation);
            SetNext();
        }
	}
}
