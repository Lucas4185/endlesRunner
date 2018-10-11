using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollisionScript : MonoBehaviour {

    public GameObject enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //zodat speler niet door de plane heen zakt
            enemy.GetComponent<Rigidbody>().isKinematic = true;
          
        }
    }


}
