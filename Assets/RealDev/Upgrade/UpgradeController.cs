using RealMethod;
using UnityEngine;

public class UpgradeController : MonoBehaviour
{
    public Upgrade myupgrade;
    public UpgradeMapConfig config;
    public IUpgradeItem MyItem;
    public string ItemName;


    private void Start()
    {
        ((IChainUpgrade)config).BindUpgrade(printer);
        GetAvailable();
    }


    [Button]
    private void IsUnlock()
    {
        Print.Log(myupgrade.IsUnlocked(MyItem).ToString());
    }
    [Button]
    private void CanUnlock()
    {
        Print.Log(myupgrade.CanUnlock(MyItem).ToString());
    }
    [Button]
    private void Unlock()
    {
        Print.Log(myupgrade.SetUnlock(MyItem).ToString());
    }
    [Button]
    private void Lock()
    {
        Print.Log(myupgrade.SetLock(MyItem).ToString());
    }
    [Button]
    private void GetAvailable()
    {
        MyItem = myupgrade.GetAvailableItem(config.Label);
        if (MyItem != null)
        {
            ItemName = MyItem.Label;
        }
        else
        {
            ItemName = string.Empty;
            Debug.Log("None");
        }
    }


    private void printer(bool status)
    {
        Debug.Log(status ? "Applt" : "Deny");
    }

}
