using system.Collections;
using System.Colections.generic;
using unityEngine;

public class spawnList : MonoBehavior
{
    //define a list
    public static List<GameObject> myListObjects = new List<GameObject>();
    //I used this to keep track of the number of objects I spawned in the scene.
    public static int numSpawned = 0;

    void Start()
    {
        //Important note: place your prefabs folder(or levels or whatever) 
        //in a folder called "Resources" like this "Assets/Resources/Prefabs"
        Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));
        //This may be sloppy (I've only been programing for a short time) 
        //It works though :) 
        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;

            myListObjects.Add(lo);
        }
        startPosition = transform.position;

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