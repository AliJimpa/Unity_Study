using RealMethod;
using UnityEngine;

namespace RM_TEST
{
    public class Spawner : MonoBehaviour
{
    public Prefab prefabTarget;

    [Button]
    private void SpwanPrefab()
    {
        Spawn.Prefab(prefabTarget, this);
    }
    [Button]
    private void SpwanUIDoc()
    {
        Spawn.UIDoc("Hallolle", null);
    }
}

}
