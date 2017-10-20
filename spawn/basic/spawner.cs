using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehavior
{
    public Transform spawnerPos;
    public GameObject spawnee;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(spawnee, spawnerPos.position, spawnerPos.rotation);
        }
    }
}