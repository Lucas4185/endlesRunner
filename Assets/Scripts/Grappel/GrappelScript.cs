using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappelScript : MonoBehaviour {

    public GameObject hook;
    public GameObject hookHolder;

    public float hookTravelSpeed;
    public float playerTravelSpeed;
    public int grappelCounter;

    public Vector3 grappelScale;
    

    private bool fired;
    private bool hookedPos = true;
    public bool hooked;
    private bool hookInactive = false;
    public GameObject hookdeObj;

    public float maxDistance;
    private float currentDistance;


    public void Start()
    {
        grappelScale = new Vector3(0.2f, 0.2f, 1.0f);
    }
    private void Update()
    {


        if(Input.GetMouseButtonDown(0) && fired == false)
        {
            fired = true;
        }
        if (fired == true && hooked == false)
        {
            //laat de hook naar voren bewegen
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            //als de hhok na een bepaalde afstand niks raakt reset hook
            if(currentDistance >= maxDistance)
            {
                ReturnHook();
            }
        }

        if (hooked == true)
        {

            //als de hook met het juiste object collide verplaats speler naar de hook
            hook.transform.parent = hookdeObj.transform;
            transform.position = Vector3.MoveTowards(transform.position, hook.transform.position, Time.deltaTime * playerTravelSpeed);
            float distanceToHook = Vector3.Distance(transform.position, hook.transform.position);
                
            //this.GetComponent<Rigidbody>().useGravity = false;


            //als de afstand van de hook naar de speler klein is reset hook
            if (distanceToHook < 1)
            {
                ReturnHook();
            }
            
        } else {
            // zorgt ervoor dat de hook gewoon weer goed terug komt dus net dat hij op de verkeerde plek zit of de verkeerde groote is
            hook.transform.parent = hookHolder.transform;
            hook.transform.localScale = grappelScale;
            if(hookedPos == true)
            {
                hook.transform.position = hookHolder.transform.position;
                hookedPos = false;
            }
        }

        //en timer voor het weer active zetten van de hook
        if(hookInactive == true)
        {
            grappelCounter++;
        }
        if (grappelCounter == 70)
        {
            hookHolder.SetActive(true);

            grappelCounter = 0;
        }
    }


    //het reset de hook en zorgt ervoor dat de player naar beneden valt
    void ReturnHook()
    {
        hookHolder.SetActive(false);
        hookInactive = true;
        this.GetComponent<Rigidbody>().useGravity = true;
        hook.transform.rotation = hookHolder.transform.rotation;
        hook.transform.position = hookHolder.transform.position;
        hook.transform.localScale = grappelScale;
        fired = false;
        hooked = false;
        hookedPos = true;
    }
}
