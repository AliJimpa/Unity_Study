using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "MyTask", menuName = "Mustard/MyTask", order = 1)]
public class MyTask : TaskBehaviour
{
    protected override void OnBegin()
    {
        Debug.Log("OnBegin  " + name);
    }

    protected override void OnEnd()
    {
        Debug.Log("OnEnd  " + name);
    }

    protected override void OnInitiate()
    {
        Debug.Log("OnInitiate  " + name);
    }

    protected override void OnPause()
    {
        Debug.Log("OnPause  " + name);
    }

    protected override void OnReset()
    {
        Debug.Log("OnReset  " + name);
    }

    protected override void OnResume()
    {
        Debug.Log("OnResume  " + name);
    }

    protected override void OnUpdate()
    {
        Debug.Log("OnUpdate  " + name);
    }
}