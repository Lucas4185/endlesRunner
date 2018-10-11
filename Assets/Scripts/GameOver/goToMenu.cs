using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        //PlayerPrefs.SetFloat("highScore", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void LoadLevel()
    {
        //ga naar menu scene
        SceneManager.LoadScene("MenuScene");
    }
}
