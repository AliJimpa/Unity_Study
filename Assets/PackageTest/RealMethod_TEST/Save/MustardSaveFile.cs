using System.Collections.Generic;
using RealMethod;
using UnityEngine;

[CreateAssetMenu(fileName = "MustardSaveFile", menuName = "Mustard/Save/MustardFile", order = 1)]
public class MustardSaveFile : SaveFile , IMyStorage
{
    [Header("DefaultFile")]
    public int ali;
    [Header("Storage")]
    [SerializeField]
    private List<string> MyList = new List<string>();

    public void AddItem(string name)
    {
        MyList.Add(name);
    }
    public void RemoveItem(int index)
    {
        MyList.RemoveAt(index);
    }


    protected override void OnStable(RealMethod.DataManager manager)
    {
        throw new System.NotImplementedException();
    }
    protected override void OnSaved()
    {
    }
    protected override void OnLoaded()
    {
    }
    protected override void OnDeleted()
    {
    }

    public void StorageCreated(Object author)
    {
    }

    public void StorageLoaded(Object author)
    {
    }

    public void StorageStarted(Object author)
    {
    }

    public void StorageClear()
    {
    }

    
}
