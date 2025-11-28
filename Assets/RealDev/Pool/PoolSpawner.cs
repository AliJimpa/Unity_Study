using System.Collections;
using RealMethod;
using UnityEngine;

public class PoolSpawner : MonoBehaviour
{
    public PrefabPool PoolAsset;
    public int prewarm = 0;

    private void Awake()
    {
        if (prewarm > 0)
        {
            PoolAsset.Provider.Prewarm(prewarm);
        }
    }

    [Button]
    private void pullitem()
    {
        Spawn.Pool(PoolAsset);
    }
    [Button]
    private void pushitems()
    {
        Despawn.Pool(PoolAsset);
    }


    private IEnumerator MyEndOfFrameCoroutine()
    {
        Debug.Log("Before WaitForEndOfFrame");

        yield return new WaitForEndOfFrame();

        Debug.Log("After WaitForEndOfFrame (at the end of the current frame)");
    }

}
