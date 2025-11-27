using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeSaveFile", menuName = "Mustard/Upgrade/savefile", order = 1)]
public class UpgradeSaveFile : SaveFile, IPayment
{
    public int Coin = 10;


    protected override void OnDeleted()
    {
        throw new System.NotImplementedException();
    }

    protected override void OnLoaded()
    {
        throw new System.NotImplementedException();
    }

    protected override void OnSaved()
    {
        throw new System.NotImplementedException();
    }

     protected override void OnStable(RealMethod.DataManager manager)
    {
        throw new System.NotImplementedException();
    }

    public void Disbursement(int amount)
    {
        Coin = Coin - amount;
    }
    public int GetCapital()
    {
        return Coin;
    }

    public void AddFunds(int amount)
    {
        throw new System.NotImplementedException();
    }
}
