using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Intractibel : MonoBehaviour
{
    
    public Varibale_Game.Obj Type;
    public UnityEvent Dowork;



    


    private void OnTriggerEnter(Collider other)
    {
        if (other !=null  &&  other.tag == "Player")
        {
            Manager_Base.Instance.E_MessageT(true);
            Manager_Base.Instance.SetIntractible(Type , this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other !=null  &&  other.tag == "Player")
        {
            Manager_Base.Instance.E_MessageT(false);
            Manager_Base.Instance.IntractibleFalse();
        }
    }

    public void DoWork()
    {
        Dowork.Invoke();
    }




}
