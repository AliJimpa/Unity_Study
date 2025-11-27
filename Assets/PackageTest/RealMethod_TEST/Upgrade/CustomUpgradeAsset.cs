using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeSaveFile", menuName = "Mustard/Upgrade/upgradeAsset", order = 1)]
public class CustomUpgradeAsset : UpgradeAsset
{
    protected override void Apply()
    {
    }

    protected override bool CheckDependency(IUpgradeItem[] dependedItems)
    {
        throw new System.NotImplementedException();
    }

    protected override bool CheckPayment()
    {
        throw new System.NotImplementedException();
    }

    protected override void Deny()
    {
        throw new System.NotImplementedException();
    }

    protected override void Initiate()
    {
        throw new System.NotImplementedException();
    }

    protected override void Loaded()
    {
        throw new System.NotImplementedException();
    }

    protected override void PayCost()
    {
        throw new System.NotImplementedException();
    }
}
