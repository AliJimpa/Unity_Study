using RealMethod;
using UnityEngine;

public class PrefabTEST : MonoBehaviour
{
    public Prefab sampleprefab;
    public Prefab[] arrayprefab;
    [Space]
    public UPrefab UIPrefab;
    public UPrefab[] UIPrefabsarray;


    [Button]
    private void SpawnSample()
    {
        Spawn.Prefab(sampleprefab);
    }
    [Button]
    private void SpawnArray()
    {
        foreach (var prefab in arrayprefab)
        {
            Spawn.Prefab(prefab);
        }
    }
    [Button]
    private void SpawnUI()
    {
        Spawn.Widget(UIPrefab, "Sample");
    }
    [Button]
    private void SpawnUIArray()
    {
        foreach (var prefab in UIPrefabsarray)
        {
            Spawn.Widget(prefab, prefab.NameID);
        }
    }
}
