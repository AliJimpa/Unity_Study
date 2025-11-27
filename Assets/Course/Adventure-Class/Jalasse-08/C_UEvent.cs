using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class C_UEvent : Command
{
    public UnityEvent RunEvent;
    public override void Run()
    {
        RunEvent.Invoke();
    }
}
