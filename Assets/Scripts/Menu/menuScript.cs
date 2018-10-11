using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

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
        // ga naar main scene
        SceneManager.LoadScene("MainScene");
    }
}
