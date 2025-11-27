using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataTable", menuName = "EPIC/DataTable", order = 0)]
public class DataTable : ScriptableObject {
    
    public Item[] myitem = new Item[0];




}


[System.Serializable]
public class Item
{
    public string name;
    public Sprite Icon;
    public int amount;
}

