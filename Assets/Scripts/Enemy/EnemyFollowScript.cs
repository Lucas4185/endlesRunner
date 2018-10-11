using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowScript : MonoBehaviour {

    public Vector3 offset;
    GameObject player;
    public int z = -41;
  

    // dit script zorgt ervoor dat de enemy niet achter blijft als de speler naar voren beweegt door het grappelen
    // het zorgt er ook voor dat als de player grappelt de enemy weer terug gaat
    void Start()
    {
        offset = new Vector3(0, 0, z); 
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    void Update()
    {
       
        if (player.GetComponent<GrappelScript>().hooked == true)
        {
            transform.position = player.transform.position + offset;
      
        }
     

    }
}
