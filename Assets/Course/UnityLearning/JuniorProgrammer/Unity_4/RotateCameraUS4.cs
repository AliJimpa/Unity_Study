using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraUS4 : MonoBehaviour
{
    public float Rotatespeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate( Vector3.up , Time.deltaTime * Rotatespeed * horizontal);
    }
}
