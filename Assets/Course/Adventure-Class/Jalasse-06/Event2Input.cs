using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event2Input : MonoBehaviour
{

    public KeyCode TypeCode;
    public UnityEvent Events;
    

    void Update()
    {
        if(Input.GetKeyDown(TypeCode)) 
        {
            Events.Invoke();
        }
    }
    




}
