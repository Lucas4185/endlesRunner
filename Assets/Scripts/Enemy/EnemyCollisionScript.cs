using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCollisionScript : MonoBehaviour {

    public bool hit = false;

    private GameObject player;

    private int now = 3;
    private int score = 0;
    private int highScore;
    public Text scoreLabel;

    public GateType gateType;

    public enum GateType
    {
        player,
        Stone,
        Brick
    }

    void Start()
    {

        scoreLabel.text = score.ToString();
    }

    void Update()
    {

        InvokeRepeating("AdToScore", 1, 1);
        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }

    }

    void AdToScore()
    {
        if (now > 0)
        {
            score = score + 1;
            scoreLabel.text = "Score: " + score.ToString();
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{

        //als de enemy de speler raakt word de scene overgezet naar de Game Over scene 
        //if (other.gameObject.tag == "Player")
        //{
            //hit = true;
            //if (hit == true)
            //{
                //Debug.Log("hkek");
                //SceneManager.LoadScene("EndScene");
            //}
        //}
    //}

    void OnTriggerEnter(Collider collider)
    {
        EnemyCollisionScript gateType = collider.GetComponent<EnemyCollisionScript>();

        if (gateType != null)
        {
            switch (gateType.gateType)
            {
                case GateType.player:
                    SceneManager.LoadScene("EndScene");
                    break;
            }
        }
    }
}
