using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehavior
{
    public float lifeTime = 10f;

    void Update()
    {
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if(lifeTime < 0)
            {
                DestroyObject();
            }
        }

        if(this.gameObject.postion.y <= -10)
        {
            DestroyObject();
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "destroyer")
        {
            DestroyObject();
        }
    }

    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
