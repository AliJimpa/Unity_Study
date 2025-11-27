using UnityEngine;
using RealMethod;


public enum StatCategoty
{
    Vitality,
    AttackPower,
    Defense,
}

[System.Serializable]
public class MyStatData : StatData
{
    // StatData Methods
    protected override void OnInitiate(StatProfile profile)
    {
        // Call when Stat Initialized in Profiler
    }
    protected override bool CheckModifier(IStatModifier mod)
    {
        // Use for filter some modifier
        return true;
    }
    protected override void OnLoaded()
    {
        // Call when stat data loaded
    }
}

[CreateAssetMenu(fileName = "StatProfile", menuName = "Mustard/Profile", order = 0)]
public class MyStatProfile : StatProfile<StatCategoty, MyStatData>
{

#if UNITY_EDITOR
    public override void OnEditorPlay()
    {
        base.OnEditorPlay();
    }
    private void OnValidate()
    {
        ChangeName(name);
    }
#endif

}

