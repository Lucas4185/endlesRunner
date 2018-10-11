using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour {

    float highScoreCount;
    public Text highScoreText;
    public float scoreCount;
    public Text scoreCountText;
    // Use this for initialization
    void Start()
    {
        highScoreCount = PlayerPrefs.GetFloat("highScore");
        scoreCount = PlayerPrefs.GetFloat("Score");
    }

    // Update is called once per frame
    void Update()
    {
        float hgsc = Mathf.Round(highScoreCount);
        string highScoreString = hgsc.ToString("n0");
        highScoreText.text = "High Score: \n" + highScoreString + " KM";

        float sc = Mathf.Round(scoreCount);
        string scString = sc.ToString("n0");
        scoreCountText.text = scString + " KM";
    }
}
