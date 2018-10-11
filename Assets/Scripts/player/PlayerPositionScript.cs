using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionScript : MonoBehaviour {

    //dit script houd de speler positie bij het help bij het erugzetten van de enemy
    public GameObject playerPoint;

    private float timer = 0.5f;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            UpdatePosition();
            timer = 0.5f;
        }
    }

    void UpdatePosition()
    {
      
        playerPoint.transform.position = transform.position;
    }
}
