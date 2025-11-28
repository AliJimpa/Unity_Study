using RealMethod;
using UnityEngine;

public class ResourceGameTEST : MonoBehaviour
{
    public StatProfile profile;
    public MyResource ali = new MyResource("aaa", 0, 50);
    [Space(5)]
    [SerializeField, ReadOnly]
    private float max;

    
    private IResource aliresource;


    void Awake()
    {
        ali.Initialize(profile);
        aliresource = ali;
        max = aliresource.MaxValue;
    }


    [Button]
    private void GetMaxValue()
    {
        max = aliresource.MaxValue;
    }
}



[System.Serializable]
public class MyResource : ResourceData<StatCategoty>
{
    public MyResource(string ReName, float val, float max) : base(ReName, val, max)
    {
    }
    protected override void OnInitiate()
    {

    }
}