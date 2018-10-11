using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMoveScript : MonoBehaviour {



    private int z;
    private int moveFaster = 0;
    private bool faster = true;
	// Use this for initialization
	void Start () {
		z = Random.Range(-1, -3);
    }
	
	// Update is called once per frame
	void Update () {

        // zodat objecten na een tijd wat sneller bewegen
        if(faster == true)
        {
            moveFaster++;
        }
        if(moveFaster == 10000)
        {
            z--;
            moveFaster = 0;
        }
        if(z == -8)
        {
            faster = false;
        }


      //snelheid van object
        transform.Translate(0, 0, z);
    }
}
