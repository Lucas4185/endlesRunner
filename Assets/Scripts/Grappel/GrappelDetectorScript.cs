using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappelDetectorScript : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    //Dit is zodat de hook collide en de speler niet in de lucht blijft zweven
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hook")
        {
            player.GetComponent<GrappelScript>().hooked = true;
            player.GetComponent<Rigidbody>().isKinematic = false;
            enemy.GetComponent<Rigidbody>().isKinematic = false;
            //player.GetComponent<GrappelScript>().hookdeObj = other.gameObject;
        }
    }

}
