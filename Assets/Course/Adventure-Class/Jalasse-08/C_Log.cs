using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Log : Command
{
    public string Message;
    public override void Run()
    {
        Debug.Log(Message);
    }

}
