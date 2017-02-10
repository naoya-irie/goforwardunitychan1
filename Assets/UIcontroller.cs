using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour {
    private GameObject gameOverText;
    private GameObject runLengthText;
    private float len = 0;
    private float speed = 0.03f;
    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {
        this.gameOverText = GameObject.Find("gameover");
        this.runLengthText = GameObject.Find("runlength");
    }
    void Update()
    {
        if (this.isGameOver == false)
        {
            this.len += this.speed;
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }
        if (this.isGameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }

        }
    }

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}