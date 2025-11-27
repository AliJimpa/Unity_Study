using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_Dialog : MonoBehaviour
{

   public UnityEvent _OnTriggerEnter;
   public UnityEvent _OnTriggerExit;

   //public UI_Dialog UI_Dialog;
   //public string TextMessage;

   private void OnTriggerEnter(Collider other)
   {
       if (other !=null    &&    other.tag == "Player")
       {
           //UI_Dialog.ShowMessage(TextMessage);
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
