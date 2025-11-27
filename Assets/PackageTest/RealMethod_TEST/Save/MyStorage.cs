using System.Collections.Generic;
using RealMethod;
using UnityEngine;

public class MyStorage : MonoBehaviour
{
    [Header("StroatgeTest")]
    [SerializeField]
    private List<string> Tada = new List<string>();
    public StorageFile<IMyStorage, MustardSaveFile> myStorageFile;

    private void Awake()
    {
        myStorageFile.Load(this);
    }

    [Button]
    private void AddName()
    {
        Tada.Add("Halllo: " + Tada.Count);
        myStorageFile.provider.AddItem("Halllo: " + Tada.Count);
    }
    [Button]
    private void RemoveLastIndex()
    {
        Tada.RemoveAt(Tada.Count - 1);
        myStorageFile.provider.RemoveItem(Tada.Count - 1);
    }
}

public interface IMyStorage : IStorage
{
    void AddItem(string name);
    void RemoveItem(int index);
}



