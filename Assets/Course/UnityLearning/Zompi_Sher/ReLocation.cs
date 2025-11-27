using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReLocation : MonoBehaviour
{
    
    public bool Run;
    public float LimitY;
    private float Xp;
    private float Yp;
    private float Zp;



    // Start is called before the first frame update
    void Start()
    {
        Xp = transform.position.x;
        Yp = transform.position.y;
        Zp = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        if(Run)
        {
            if(transform.position.y<=LimitY)
            {
             transform.localPosition = new Vector3(Xp, Yp, Zp);
            }
        }
    }



}
