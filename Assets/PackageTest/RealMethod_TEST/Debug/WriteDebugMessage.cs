using RealMethod;
using UnityEngine;

public class WriteDebugMessage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Print.Log("Start Game");
        Print.LogWarning("Hello");
        Print.Button("Opps", this, "Optis");
    }

    // Update is called once per frame
    void Update()
    {
        Print.Log("Update", 0.01f);
    }

    [Button]
    private void Optis()
    {
        Print.Log("Fuck");
    }
}
