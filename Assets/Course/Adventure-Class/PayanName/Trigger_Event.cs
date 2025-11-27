using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_Event : MonoBehaviour
{

    public UnityEvent _OnTriggerEnter;
    public UnityEvent _OnTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other !=null  &&  other.tag == "Player")
        {
            _OnTriggerEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other !=null  &&  other.tag == "Player")
        {
            _OnTriggerExit.Invoke();
        }
    }


}
