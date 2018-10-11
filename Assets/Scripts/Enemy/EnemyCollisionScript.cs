using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCollisionScript : MonoBehaviour {

    public bool hit = false;


    private int now = 3;
    private int score = 0;
    public Text scoreLabel;

    private GameObject player;

    void Start()
    {

        scoreLabel.text = score.ToString();
    }

    void Update()
    {
        if (hit == false)
        {
            InvokeRepeating("AdToScore", 1, 1);
        }
    }

    void AdToScore()
    {
        if (hit == false)
        {
            if (now > 0)
            {
                score = score + 1;
                scoreLabel.text = "High Score: " + score.ToString();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        //als de enemy de speler raakt word de scene overgezet naar de Game Over scene 
        if (other.gameObject.tag == "Player")
        {
            hit = true;
            if (hit == true)
            {
                Debug.Log("hkek");
                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
