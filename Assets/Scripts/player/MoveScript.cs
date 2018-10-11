using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    // Use this for initialization
    private void Start()
    {

    }

    private float speed = 150.0f;
    private float speed2 = 200.0f;


    // Update is called once per frame
    private void Update()
    {
        WalkFunction();
    }

    private void WalkFunction()
    {
        //beweeg naar links en rechts
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        moveDirection *= speed;
        moveDirection *= Time.deltaTime;

        transform.Translate(moveDirection);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, 85, 175);
        transform.position = pos;
    }

}

