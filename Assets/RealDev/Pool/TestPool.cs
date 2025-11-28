using System.Collections;
using RealMethod;
using UnityEngine;

public class TestPool : PoolAsset<Transform>, IPoolSpawner<Transform>, IPoolDespawner<Transform>
{
    [Header("Setting")]
    [SerializeField]
    private GameObject Identity;
    [SerializeField]
    private float Duration = 2;

    // Private Variable
    private byte UseCacheData = 0; //0:NoCashing 1:CashLocation 2:CashLocation&Rotation 3:Transform
    private Vector3 CachePosition = Vector3.zero;
    private Quaternion CacheRotation = Quaternion.identity;
    private Vector3 CacheScale = Vector3.one;

    // Functions
    public Transform Spawn(Vector3 location, Quaternion rotation, Vector3 scale)
    {
        UseCacheData = 3;
        CachePosition = location;
        CacheRotation = rotation;
        CacheScale = scale;
        return Spawn();
    }
    public Transform Spawn(Vector3 location, Quaternion rotation)
    {
        UseCacheData = 2;
        CachePosition = location;
        CacheRotation = rotation;
        return Spawn();
    }
    public Transform Spawn(Vector3 location)
    {
        UseCacheData = 1;
        CachePosition = location;
        return Spawn();
    }
    public Transform Spawn()
    {
        Transform result = Request();
        return result;
    }
    public void Despawn()
    {
        Provider.Return();
    }
    public void Despawn(Transform target)
    {
        Return(target);
    }


    // Base PoolAsset Methods
    protected override void OnRootInitiate(Transform Root)
    {
        Root.SetParent(Game.World.transform);
    }
    protected override void PreProcess(Transform Comp)
    {
        switch (UseCacheData)
        {
            case 1:
                Comp.transform.position = CachePosition;
                break;
            case 2:
                Comp.transform.position = CachePosition;
                Comp.transform.rotation = CacheRotation;
                break;
            case 3:
                Comp.transform.position = CachePosition;
                Comp.transform.rotation = CacheRotation;
                if (CacheScale != Vector3.one)
                {
                    Comp.transform.localScale = CacheScale;
                }
                break;
            default:
                Debug.LogWarning($"For this CashStage ({UseCacheData}) is Not implemented any Preprocessing");
                break;
        }
    }
    protected override Transform CreateObject()
    {
        throw new System.NotImplementedException();
    }
    protected override IEnumerator PostProcess(Transform Comp)
    {
        return PoolBack(Comp);
    }

#if UNITY_EDITOR
    // Base DataAsset Methods
    public override void OnEditorPlay()
    {
        base.OnEditorPlay();
        UseCacheData = 0;
    }
#endif
    // IEnumerator
    private IEnumerator PoolBack(Transform source)
    {
        // Befor Timer
        yield return new WaitForSeconds(Duration);
        // After Time
        Return(source);
        yield return null;
    }


}
