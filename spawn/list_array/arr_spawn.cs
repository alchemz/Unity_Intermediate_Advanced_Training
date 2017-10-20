using system.Collections;
using system.Collections.generic;
using unityEngine;

public class spawnPrefabs : MonoBehavior
{
    //define an Array
    public static GameObject[] myObjects;
    //I used this to keep track of the number of objects I spawned in the scene.
    public static int numSpawned = 0;

    void Start()
    {
        //Important note: place your prefabs folder(or levels or whatever) 
        //in a folder called "Resources" like this "Assets/Resources/Prefabs"
        myObjects = Resources.LoadAll<GameObject>("Prefabs");

    }



    void SpawnRandomObject()
    {
        //spawns item in array position between 0 and 100
        int whichItem = Random.Range(0, 100);


        GameObject myObj = Instantiate(myObjects[whichItem]) as GameObject;

        numSpawned++;

        myObj.transform.position = transform.position;
    }

    void Update()
    {
        if (numToSpawn > numSpawned)
        {
            //where your instantiated object spawns from
            transform.position = new Vector3(0, 0, 0);
            SpawnRandomObject();
        }
    }
}
