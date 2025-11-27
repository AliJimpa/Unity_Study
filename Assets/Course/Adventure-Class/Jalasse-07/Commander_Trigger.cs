using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander_Trigger : MonoBehaviour
{
    public List<Command> Enter_Trigger = new List<Command>();
    public List<Command> Exit_Trigger = new List<Command>();

    void OnTriggerEnter(Collider other)
    {
        foreach (Command CommandTarget in Enter_Trigger)
        {
            CommandTarget.Run();
        }
    }

    void OnTriggerExit(Collider other)
    {
        foreach (Command CommandTarget2 in Exit_Trigger)
        {
            CommandTarget2.Run();
        }
    }


}
