using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_Test : MonoBehaviour
{

    
    
    RaycastHit Hitresult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hitresult, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * Hitresult.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }






    }
}
