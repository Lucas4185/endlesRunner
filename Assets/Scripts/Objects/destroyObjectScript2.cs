using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectScript2 : MonoBehaviour {


    //destroy de hookable(de rode blokken) objects
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hookable")
        {
            Destroy(other.gameObject);
        }
    }

}
