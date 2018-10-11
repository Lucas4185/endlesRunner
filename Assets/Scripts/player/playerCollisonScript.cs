using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisonScript : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;
    private int destroyInt;
    public bool hit = false;

    //als een speler collide met een wall zet de enemy naar voren
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hit = true;
            enemy.GetComponent<EnemyFollowScript>().z = 15;
            enemy.transform.Translate(0, 0, 15);
         
        }
    }

}
