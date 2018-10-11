using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookScript : MonoBehaviour
{


    //zorgt ervoor dat hook naar de muis kijkt
    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.x));

        transform.LookAt(mousePos - Vector3.up * transform.position.y);
    }
}
