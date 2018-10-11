using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectScript : MonoBehaviour {

    //destory de obstacels
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }
    }

}
