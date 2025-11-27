using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollider : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
                Destroy(this.gameObject);
        }


    }

}
