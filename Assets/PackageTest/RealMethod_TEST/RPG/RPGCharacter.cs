using RealMethod;
using UnityEngine;
using UnityEngine.UIElements;

public class RPGCharacter : MonoBehaviour
{
    public StatProfile MyStats;
    public BuffConfig MyBuff;
    public StatCategoty targetstate;



    [Button]
    private void GetTargetValue()
    {
        print(MyStats.GetStat(0).Value);
    }
    [Button]
    private void Apply()
    {
        MyStats.ApplyBuff(MyBuff);
    }
    [Button]
    private void Decline()
    {
        MyStats.DeclineBuff(MyBuff);
    }
    [Button]
    private void Store()
    {
        MyStats.StoreStats();
    }
    [Button]
    private void UpgradeStat0()
    {
        MyStats.GetStatData(0).SetUpgradeValue(10);
    }

}
