using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float TopBound = 30;
    public float LowBound = -10;
    public int PoinValue = 1;
    void Update()
    {

        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
            SpawnManager manage = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
            manage.SetPointGame(PoinValue * -1);
        }
        else
        {
            if (transform.position.z < LowBound)
            {
                Destroy(gameObject);
                SpawnManager manage = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
                manage.SetPointGame(PoinValue * -1);
            }
        }

    }
}
