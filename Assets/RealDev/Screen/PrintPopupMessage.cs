using RealMethod;
using UnityEngine;

public class PrintPopupMessage : MonoBehaviour
{
    public string mes;
    public float timer = 5;
    [Button]
    private void Print()
    {
        Spawn.Message(mes , timer);
    }
}
