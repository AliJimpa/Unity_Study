using RealMethod;
using UnityEngine;

public class CommandRunner : MonoBehaviour
{
    public Command mycom;

    [Button]
    private void Run()
    {
        ((ICommand)mycom).ExecuteCommand(this);
    }
}
