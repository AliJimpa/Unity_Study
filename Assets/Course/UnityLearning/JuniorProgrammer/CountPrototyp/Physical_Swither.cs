using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physical_Swither : MonoBehaviour
{
    private Rigidbody[] allbals;
    // Start is called before the first frame update
    void Start()
    {
        allbals = GetComponentsInChildren<Rigidbody>();
        physicSwitch(false);
        print(allbals.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void physicSwitch(bool physic)
    {
        foreach (var item in allbals)
        {
            item.useGravity = physic;
        }
    }



}
