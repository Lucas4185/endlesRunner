using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawnScript : MonoBehaviour {


    public List<GameObject> myList;

    public GameObject[] wallPrefab;
    public GameObject[] hookAble;
    public GameObject[] drone;
    public float spawnThreshold = 1f;
    private int RocketTime = 0;
    private int spawnInt;
    private int spawnerPositionMin = 500;
    private int spawnerPositionMax = 2000;

    private bool spawned = true;



    private float spawnTimer = 0;

    public GameObject prefab;
    public GameObject hookAblePrefab;
    public GameObject dronePrefab;


    private void Start()
    { 

    }

    private void Update()
    {
        spawnerPositionMin++;
        spawnerPositionMax++;
        if (spawned == true)
        {
            SpawnObj();
           
        }
       
        if(spawned == false)
        {
            //een timer zodat hij niet teveel objecten in een keer spawned maar gewoon even wacht
            spawnInt++;
            if(spawnInt == 750)
            {
                spawned = true;
                spawnInt = 0;
            }
        }
    }

    private void SpawnObj()
    {
        if (spawned == true)
        {
            //for(int i = 0; i < myList.Count; i++)
            //{
                //GameObject obj = myList[100];
                //Vector3 spawnPosition = new Vector3(Random.Range(80, 180), 0, Random.Range(spawnerPositionMin, spawnerPositionMax));
                //myList.Add((GameObject)Instantiate(prefab, spawnPosition, Quaternion.identity));
                //spawnTimer = 0;
            //}

            //spawned de kleine muren
            wallPrefab = new GameObject[50];
            for (int i = 0; i < wallPrefab.Length; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(80, 180), 0, Random.Range(spawnerPositionMin, spawnerPositionMax));
                GameObject clone = (GameObject)Instantiate(prefab, spawnPosition, Quaternion.identity);
                spawnTimer = 0;
                wallPrefab[i] = clone;
            }

            //spawned de rode blokken in de lucht
            hookAble = new GameObject[5];
            for (int i = 0; i < hookAble.Length; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(100, 160), 30, Random.Range(spawnerPositionMin, spawnerPositionMax));
                GameObject hookClone = (GameObject)Instantiate(hookAblePrefab, spawnPosition, Quaternion.identity);
                spawnTimer = 0;
                hookAble[i] = hookClone;
            }

            //spawned de grote blokken
            drone = new GameObject[2];
            for (int i = 0; i < drone.Length; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(80, 180), 15, Random.Range(spawnerPositionMin, spawnerPositionMax));
                GameObject droneClone = (GameObject)Instantiate(dronePrefab, spawnPosition, Quaternion.identity);
                spawnTimer = 0;
                drone[i] = droneClone;
            }
        }
      
          //  platform = new GameObject[10];
          //  for (int i = 0; i < platform.Length; i++)
          //  {
           // Vector3 spawnPosition = new Vector3(Random.Range(80, 180), 20, Random.Range(spawnerPositionMin, spawnerPositionMax));
          //  GameObject platformClone = (GameObject)Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
               // spawnTimer = 0;
               // platform[i] = platformClone;
                
           // }
        
        spawned = false;
        }
    }
   

