using UnityEngine;
using UnityEngine.InputSystem;
using RealMethod;

public class ControllInputService : MonoBehaviour
{
    public InputActionAsset asset;
    [Button]
    private void AddInputService()
    {
        Game.AddService<MyInputService>(this);
    }
    [Button]
    private void RemoveInputService()
    {
        Game.RemoveService<MyInputService>(this);
    }
}


public class MyInputService : InputService
{
    protected override void OnAcquireInputAsset(InputActionAsset asset)
    {
        throw new System.NotImplementedException();
    }

    protected override void OnDisposeInputAsset(InputActionAsset asset)
    {
        throw new System.NotImplementedException();
    }
}