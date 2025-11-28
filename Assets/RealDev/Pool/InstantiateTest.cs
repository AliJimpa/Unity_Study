using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class InstantiateTest : MonoBehaviour
{
    public GameObject prefab;         // Assign in Inspector
    public int count = 1000;          // Number of instances to test

    void Start()
    {
        TestInstantiateSpeed();
    }

    void TestInstantiateSpeed()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < count; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.name = "TestObject_" + i;
            obj.transform.position = new Vector3(i * 2f, 0, 0); // Spread out so you can see them
        }

        stopwatch.Stop();

        Debug.Log($"Instantiated {count} objects in {stopwatch.ElapsedMilliseconds} ms");
    }
}
