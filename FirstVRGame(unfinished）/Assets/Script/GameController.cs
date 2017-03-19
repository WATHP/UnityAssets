using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool isGameOver;
    public Text ScoreText;
    public Text GameOverText;
    public Canvas GameOverCanvas;

    private int _currScore;
    private int _ScoreToWin = 30;

    void NewGame()
    {
        Reset();
    }

    public void GotOne()
    {
        _currScore++;
        ScoreText.text = "" + _currScore;
        if (_currScore >= _ScoreToWin)
        {
            GameOver(true);
        }
    }

    public void GameOver(bool didIWin)
    {
        isGameOver = true;
        GameOverText.text = (didIWin) ? "You won!" : "You are lose!";
        GameOverCanvas.enabled = true;
    }

    public void Reset()
    {
        GameOverCanvas.enabled = false;
        isGameOver = false;
        _currScore = 0;
        ScoreText.text = "---";

        //找到Tag标签为Enemy的物体
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        //找到Tag标签为NinjaStar的物体
        GameObject[] ninjaStars = GameObject.FindGameObjectsWithTag("NinjaStar");
        foreach(GameObject ninjaStar in ninjaStars)
        {
            Destroy(ninjaStar);
        }
    }

    void Start()
    {
        NewGame();
    }
}
