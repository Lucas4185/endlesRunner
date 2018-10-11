using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {


    private int now = 3;
    private int score = 0;
    public Text scoreLabel;
    private bool hit = false;
    private GameObject player;

    void Start()
    {

        scoreLabel.text = score.ToString();
    }

    void Update()
    {

        InvokeRepeating("AdToScore", 1, 1);
    }

    void AdToScore()
    {
        if (now > 0)
        {
            score = score + 1;
            scoreLabel.text = "High Score: " + score.ToString();
        }
    }
}
