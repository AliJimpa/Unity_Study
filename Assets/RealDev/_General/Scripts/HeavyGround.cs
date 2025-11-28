using RealMethod;
using UnityEngine;

public class HeavyGround : MonoBehaviour
{
    public float Slope = 10;
    public float Size = 5;
    [Space]
    public Transform Forward;
    public Transform Left;
    public Transform Right;
    public Transform Back;

    private void OnValidate()
    {
        Refresh();
    }

    [Button]
    public void Refresh()
    {
        transform.localScale = Vector3.one * (Size / 5);
        Forward.position = transform.position + (Vector3.forward * Size);
        Forward.rotation = Quaternion.Euler(Vector3.left * Slope);
        Left.position = transform.position + (Vector3.left * Size);
        Left.rotation = Quaternion.Euler(Vector3.back * Slope);
        Right.position = transform.position + (Vector3.right * Size);
        Right.rotation = Quaternion.Euler(Vector3.forward * Slope);
        Back.position = transform.position + (Vector3.back * Size);
        Back.rotation = Quaternion.Euler(Vector3.right * Slope);
    }
}
